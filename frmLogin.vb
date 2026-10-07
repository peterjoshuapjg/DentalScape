Imports System.Data

Public Class frmLogin

    Private Const MaxAttempts As Integer = 3     ' wrong passwords allowed before the account is locked
    Private Const LockMinutes As Integer = 15    ' how long a locked account stays locked (admin can unlock sooner)

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.AcceptButton = btnLogin          ' Enter key signs in
    End Sub

    ''' <summary>Called by frmMain after "Sign Out" to bring the sign-in screen back.</summary>
    Public Sub ShowAgain()
        txtUsername.Clear()
        txtPassword.Clear()
        Me.Show()
        txtUsername.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim user As String = txtUsername.Text.Trim()
        Dim pass As String = txtPassword.Text
        If user.Length = 0 OrElse pass.Length = 0 Then
            Ui.Warn("Enter your username and password.")
            Return
        End If

        Try
            Dim table As DataTable = Db.Query("
                SELECT u.UserID, u.PasswordHash, u.IsActive, r.RoleName, s.Status AS StaffStatus,
                       CONCAT(s.FirstName, ' ', s.LastName) AS FullName, u.FailedAttempts,
                       IFNULL(CEIL(TIMESTAMPDIFF(SECOND, NOW(), u.LockedUntil) / 60), 0) AS LockMins
                FROM tblUsers u
                INNER JOIN tblRoles r ON r.RoleID = u.RoleID
                INNER JOIN tblStaff s ON s.StaffID = u.StaffID
                WHERE u.Username = @u", ("@u", user))

            If table.Rows.Count = 0 Then
                Fail(user)
                Return
            End If

            Dim row As DataRow = table.Rows(0)
            Dim userId As Integer = Convert.ToInt32(row("UserID"))
            Dim hash As String = row("PasswordHash").ToString()

            If Not Convert.ToBoolean(row("IsActive")) OrElse row("StaffStatus").ToString() <> "Active" Then
                Ui.Warn("This account is disabled. Please contact the administrator.")
                Return
            End If

            Dim failed As Integer = Convert.ToInt32(row("FailedAttempts"))
            Dim lockMins As Integer = Convert.ToInt32(row("LockMins"))
            If lockMins > 0 Then
                Audit.Log("Login Failed", "tblUsers", Nothing, Nothing, user & " (account locked)")
                Ui.Warn($"This account is locked after {MaxAttempts} wrong passwords." & vbCrLf &
                        $"Try again in about {lockMins} minute(s), or ask the administrator to unlock it.")
                txtPassword.Clear()
                Return
            End If
            If failed >= MaxAttempts Then failed = 0      ' the lock has expired: start counting again

            If hash = Pwd.FirstRunHash Then
                ' The SQL script ships a placeholder: the first sign-in chooses the real password.
                Dim chosen As String = Ui.AskPassword("First sign-in for '" & user & "'." & vbCrLf & "Choose a password for this account.")
                If chosen Is Nothing Then Return
                hash = Pwd.Hash(chosen)
                Db.Exec("UPDATE tblUsers SET PasswordHash = @h WHERE UserID = @id", ("@h", hash), ("@id", userId))
            ElseIf Not Pwd.Verify(pass, hash) Then
                Fail(user, userId, failed)
                Return
            End If

            Session.UserId = userId
            Session.Username = user
            Session.FullName = row("FullName").ToString()
            Session.Role = row("RoleName").ToString()

            Db.Exec("UPDATE tblUsers SET LastLogin = NOW(), FailedAttempts = 0, LockedUntil = NULL WHERE UserID = @id", ("@id", userId))
            Audit.Log("Login", "tblUsers", userId)

            ' One window only: hide the sign-in screen and show the main form (all pages are panels in it).
            txtPassword.Clear()
            Me.Hide()
            frmMain.Show()
        Catch ex As Exception
            Ui.Error(ex)
        End Try
    End Sub

    ''' <summary>Wrong username or password. For a real account, counts the attempt and locks it after MaxAttempts.</summary>
    Private Sub Fail(user As String, Optional userId As Integer = 0, Optional failedBefore As Integer = 0)
        Audit.Log("Login Failed", "tblUsers", Nothing, Nothing, user)
        txtPassword.Clear()
        txtPassword.Focus()

        If userId = 0 Then
            Ui.Warn("Incorrect username or password.")
            Return
        End If

        Dim failed As Integer = failedBefore + 1
        If failed >= MaxAttempts Then
            Db.Exec("UPDATE tblUsers SET FailedAttempts = @f, LockedUntil = DATE_ADD(NOW(), INTERVAL " & LockMinutes & " MINUTE) WHERE UserID = @id",
                    ("@f", failed), ("@id", userId))
            Audit.Log("Account Locked", "tblUsers", userId, Nothing, user)
            Ui.Warn($"Incorrect password {MaxAttempts} times." & vbCrLf &
                    $"The account is locked for {LockMinutes} minutes. The administrator can unlock it sooner.")
        Else
            Db.Exec("UPDATE tblUsers SET FailedAttempts = @f WHERE UserID = @id", ("@f", failed), ("@id", userId))
            Ui.Warn("Incorrect username or password." & vbCrLf &
                    $"{MaxAttempts - failed} attempt(s) left before the account is locked.")
        End If
    End Sub

    Private Sub cbShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles cbShowPassword.CheckedChanged
        If cbShowPassword.Checked Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub


End Class
