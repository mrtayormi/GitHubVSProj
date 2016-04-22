Imports System.Data
Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class addCourse
    Dim conn As MySqlConnection = New MySqlConnection("server=localhost; user id=root; password=mathmoon; database=timetable")
    'Public conn As MySqlConnection
    Public query As String
    Dim cmd As New MySqlCommand
    Dim rd As MySqlDataReader
    Dim adapter As New MySqlDataAdapter
    Dim result As Integer
    Dim sqlQuery As String


    Private Sub addCourse_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Try
        'conn = New MySqlConnection("server=localhost; database=timetable; user id=root; password=mathmoon; port=3306;")
        conn.Open()
        'MessageBox.Show("Connected")
        query = "select * from lecturer "
        cmd = New MySqlCommand(query, conn)
        rd = cmd.ExecuteReader()
        Dim ds As New DataSet()
        adapter.SelectCommand = cmd
        conn.Close()
        adapter.Fill(ds)
        adapter.Dispose()
        'conn.Close()
        lecturercb.DataSource = ds.Tables(0)
        lecturercb.ValueMember = "lastName"
        'lecturercb.ValueMember = "firstName"
        lecturercb.DisplayMember = "firstName"
        'Catch ex As Exception
        'MessageBox.Show("Not Connected")
        ' End Try
    End Sub
    Private Sub saveCourse(ByVal sqlQuery As String)
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
                MsgBox("Yay! Course has been succesfully added.", MsgBoxStyle.Information, "Save Course")
            Else
                MsgBox("Oops! We failed to save the course.", MsgBoxStyle.Information, "Save Course")
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BaWGUIComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lecturercb.SelectedIndexChanged

    End Sub

    Private Sub BaWGUIThemeContainer1_Click(sender As Object, e As EventArgs) Handles BaWGUIThemeContainer1.Click

    End Sub

    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click
        sqlQuery = "INSERT INTO courses ( `courseTitle`, `CourseCode`, `creditUnit`, `LevelID`, `hours`, `lecturer`)" & _
                    "VALUES ('" & ctitletb.Text & "','" & ccodetb.Text & "','" & cunittb.Text & "', '" & levelcb.Text & "', '" & hourscb.Text & "', '" & lecturercb.Text & "')"
        saveCourse(sqlQuery)
    End Sub

    Private Sub BaWGUIButton2_Click(sender As Object, e As EventArgs) Handles BaWGUIButton2.Click

    End Sub
End Class