Imports System.Data
Imports System.Data.SqlClient

Public Class adminlogin
    Dim con As New SqlConnection
    Private Sub adminlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=.\SQLEXPRESS;Initial Catalog=super_market;Integrated Security=True"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con.Open()
        Dim qry As String
        qry = "SELECT * FROM adminlog WHERE username='" & TextBox1.Text & "' and pword='" & TextBox2.Text & "'"
        Dim cmd As New SqlCommand(qry, con)

        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader

        If rd.Read = True Then
            MDIParent1.Show()
            Me.Hide()
        Else
            MsgBox("Incorrect username or password")
        End If
        con.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Admin.Show()
        TextBox1.Text = ""
        TextBox2.Text = ""

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class