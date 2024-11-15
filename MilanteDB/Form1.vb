Imports MySql.Data.MySqlClient

Public Class Form1
    ' MySQL connection details
    Dim conn As New MySqlConnection("server=your_server;userid=your_userid;password=your_password;database=matt")
    Dim COMMAND As MySqlCommand


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Check if both username and password fields are filled
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password='';database=matt"
        Dim READER As MySqlDataReader
        Try
            conn.Open()
            Dim Query As String
            Query = "select * from matt.employee where UserName = '" & TextBox1.Text & "' and PW = '" & TextBox2.Text & "' "
            COMMAND = New MySqlCommand(Query, conn)
            READER = COMMAND.ExecuteReader
            Dim count As Integer
            count = 0
            While READER.Read
                count = count + 1
            End While

            If count = 1 Then
                MessageBox.Show("Username and password are Correct")
            ElseIf count > 1 Then
                MessageBox.Show("Username and password are Duplicate")
            Else
                MessageBox.Show("Username and password are incorrect")

            End If

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        ' Code for label click, if needed
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Any initialization code when the form loads
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ' Any logic to handle text changes in TextBox1 (if needed)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password='';database=test"

        Try
            conn.Open()
            MessageBox.Show("Connection to MySQL test database was successful!!!!", "TESTING      CONNECTION TO MySQL DATABASE")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
End Class
