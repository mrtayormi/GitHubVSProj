Imports System.Data
Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class timetable
    Dim conn As MySqlConnection = New MySqlConnection("server=localhost; user id=root; password=mathmoon; database=timetable")
    Public query As String
    Dim cmd As New MySqlCommand
    Dim rd As MySqlDataReader
    Dim adapter As New MySqlDataAdapter
    Dim result As Integer
    Dim sqlQuery As String
    Private Sub Monday()
        'Using a shuffling algorith to arrange the course into appropiate time
        Dim x, mix, temp As Integer
        Dim num As Integer = 10
        Dim randarray(num) As Integer
        Dim randnum As Random = New Random()

        For x = 1 To num
            randarray(x) = x
        Next

        For x = num To 1 Step -1
            mix = randnum.Next(1, x)
            temp = randarray(mix)
            randarray(mix) = randarray(x)
            randarray(x) = temp
        Next

        conn.Open()
        query = "select CourseCode from courses where CourseID=" & randarray(1)
        cmd = New MySqlCommand(query, conn)
        rd = cmd.ExecuteReader()
        rd.Read()
        txtMon1.Text = rd(0) ' & vbNewLine & rd(1) 'randarray(1).ToString()
        conn.Close()

        conn.Open()
        query = "select CourseCode from courses where CourseID=" & randarray(2)
        cmd = New MySqlCommand(query, conn)
        rd = cmd.ExecuteReader()
        rd.Read()
        txtMon2.Text = rd(0) ' & vbNewLine & rd(1) 'randarray(2).ToString()
        conn.Close()

        conn.Open()
        query = "select CourseCode from courses where CourseID=" & randarray(3)
        cmd = New MySqlCommand(query, conn)
        rd = cmd.ExecuteReader()
        rd.Read()
        txtMon3.Text = rd(0) ' & vbNewLine & rd(1) 'randarray(3).ToString()
        conn.Close()

        conn.Open()
        query = "select CourseCode from courses where CourseID=" & randarray(4)
        cmd = New MySqlCommand(query, conn)
        rd = cmd.ExecuteReader()
        rd.Read()
        txtMon4.Text = rd(0) ' & vbNewLine & rd(1) 'randarray(4).ToString()
        conn.Close()

        conn.Open()
        query = "select CourseCode from courses where CourseID=" & randarray(5)
        cmd = New MySqlCommand(query, conn)
        rd = cmd.ExecuteReader()
        rd.Read()
        txtMon5.Text = rd(0) ' & vbNewLine & rd(1) 'randarray(6).ToString()
        conn.Close()

        conn.Open()
        query = "select CourseCode from courses where CourseID=" & randarray(6)
        cmd = New MySqlCommand(query, conn)
        rd = cmd.ExecuteReader()
        rd.Read()
        txtMon6.Text = rd(0) ' & vbNewLine & rd(1) 'randarray(6).ToString()
        conn.Close()
    End Sub
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub BaWGUIThemeContainer1_Click(sender As Object, e As EventArgs) Handles BaWGUIThemeContainer1.Click

    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip1.Popup

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '  tip = "help!!!"

    End Sub
    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        ToolTip1.SetToolTip(Button1, "Print the timetable")
    End Sub
    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles Button2.MouseHover
        ToolTip2.SetToolTip(Button2, "Save the timetable")
    End Sub
    Private Sub Button3_MouseHover(sender As Object, e As EventArgs) Handles Button3.MouseHover
        ToolTip2.SetToolTip(Button3, "Auto Generate Timetable")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Monday()
    End Sub

    Private Sub txtMon1_Click(sender As Object, e As EventArgs) Handles txtMon1.Click

    End Sub
End Class