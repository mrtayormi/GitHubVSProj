Imports System.Data
Imports MySql.Data.MySqlClient
Public Class addLectureHall
    Dim conn As MySqlConnection = New MySqlConnection("server=localhost; user id=root; password=mathmoon; database=timetable")
    Public query As String
    Dim cmd As New MySqlCommand
    Dim rd As MySqlDataReader
    Dim adapter As New MySqlDataAdapter
    Dim result As Integer
    Dim sqlQuery As String

    Private Sub AddLectureHall(ByVal sqlQuery As String)
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
                MsgBox("Lecture hall has been succesfully added", MsgBoxStyle.Exclamation, "Registration")
            Else
                MsgBox("Oops! We failed to Add the Lecture Hall. Please try again", MsgBoxStyle.RetryCancel, "Registration")
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BaWGUIButton1_Click(sender As Object, e As EventArgs) Handles BaWGUIButton1.Click
        sqlQuery = "INSERT INTO lecturehall ( `blockName`, `Room`)" & _
                    "VALUES ('" & blktb.Text & "','" & rmtb.Text & "')"
        AddLectureHall(sqlQuery)
    End Sub
End Class