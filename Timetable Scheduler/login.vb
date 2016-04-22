Imports System.Data
Imports MySql.Data
Imports MySql.Data.MySqlClient


Public Class login
    Public conn As MySqlConnection
    Public query As String
    Dim cmd As MySqlCommand
    Dim rd As MySqlDataReader
    Private Sub BaWGUITextBox1_TextChanged(sender As Object, e As EventArgs) Handles username.TextChanged

    End Sub
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show()
        Try
            conn = New MySqlConnection("server=localhost; database=timetable; user id=root; password=mathmoon;")
            'conn.Open()
            'MessageBox.Show("Connected")
        Catch ex As Exception
            MessageBox.Show("Error")
        End Try
    End Sub
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        On Error GoTo err

        conn.Open()
        query = "select * from users where Username='" & username.Text.Trim & "' and Password='" & password.Text.Trim & "'"
        cmd = New MySqlCommand(query, conn)
        rd = cmd.ExecuteReader()
        rd.Read()

        If username.Text <> rd(1) And password.Text <> rd(2) Then
            GoTo err 'MessageBox.Show("Invalid Credentials")
        Else
            Form1.Show()
            Me.Hide()
        End If
        Exit Sub

err:
        MessageBox.Show("Invalid Credentials")
        'txtMon1.Text = rd(0) & vbNewLine & rd(1) 'randarray(1).ToString()
        conn.Close()
    End Sub

    Private Sub password_TextChanged(sender As Object, e As EventArgs) Handles password.TextChanged

    End Sub

    Private Sub BaWGUIThemeContainer1_Click(sender As Object, e As EventArgs) Handles BaWGUIThemeContainer1.Click

    End Sub
End Class