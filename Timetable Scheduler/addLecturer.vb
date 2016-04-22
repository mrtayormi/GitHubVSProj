Imports System.Data
Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class addLecturer
    Dim conn As MySqlConnection = New MySqlConnection("server=localhost; user id=root; password=mathmoon; database=timetable")
    'Public conn As MySqlConnection
    Public query As String
    Dim cmd As New MySqlCommand
    Dim rd As MySqlDataReader
    Dim adapter As New MySqlDataAdapter
    Dim result As Integer
    Dim sqlQuery As String
    Private Sub addLecturer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Me.Show()
        'Try
        '[conn = New MySqlConnection("server=localhost; database=timetable; user id=root; password=mathmoon;")
        'conn.Open()
        ' MessageBox.Show("Connected")
        'Catch ex As Exception
        'MessageBox.Show("Error")
        'End Try
    End Sub
    Private Sub register(ByVal sqlQuery As String)
        Try
            'OPENING THE CONNECTION
            conn.Open()
            'HOLDS THE DATA TO BE EXECUTED
            With cmd
                .Connection = conn
                .CommandText = sqlQuery
            End With
            'EXECUTE THE DATA
            result = cmd.ExecuteNonQuery
            'CHECKING IF THE DATA HAS EXECUTED OR NOT
            If result > 0 Then
                MsgBox("Yay! Lecturer has been succesfully registered", MsgBoxStyle.Information, "Registration")
            Else
                MsgBox("Oops! We failed to register the user.", MsgBoxStyle.Information, "Registration")
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BaWGUIThemeContainer1_Click(sender As Object, e As EventArgs) Handles BaWGUIThemeContainer1.Click

    End Sub

    Private Sub BaWGUITextBox2_TextChanged(sender As Object, e As EventArgs) Handles lnametb.TextChanged

    End Sub

    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click
        sqlQuery = "INSERT INTO lecturer ( `firstName`, `lastName`, `staffID`)" & _
                    "VALUES ('" & fnametb.Text & "','" & lnametb.Text & "','" & staffidtb.Text & "')"
        register(sqlQuery)
        ' MessageBox.Show("Lecturer details saved sucessfully")
    End Sub
End Class