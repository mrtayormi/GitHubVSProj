Imports System.Data
Imports MySql.Data
Imports MySql.Data.MySqlClient

Module modcon
    Public con As MySqlConnection
    ' Public valList As Integer

    Public Sub Connect()
        Try
            If con.State = ConnectionState.Closed Then
                con.ConnectionString = "server=localhost; database=timetable; user id=root; password=mathmoon; port=3306;"
                con.Open()
                MessageBox.Show("Connected")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Public Sub DisConnect()
        Try
            con.Close()
        Catch ex As Exception

        End Try
    End Sub
End Module
