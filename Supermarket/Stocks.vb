Imports System.Data
Imports System.Data.SqlClient

Public Class Stocks
    Dim con As New SqlConnection

    Private Sub Stocks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=.\SQLEXPRESS;Initial Catalog=super_market;Integrated Security=True;MultipleActiveResultSets=True"
        con.Open()
        Dim qry As String
        qry = "select prd_id from product"
        Dim cmd As New SqlCommand(qry, con)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader
        While rd.Read
            ComboBox1.Items.Add(rd.GetInt32(0))
        End While



        con.Close()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        con.Open()
        Dim qry1 As String
        qry1 = "select prd_name, stocks,dealer_name from product where prd_id=" & ComboBox1.Text
        Dim cmd1 As New SqlCommand(qry1, con)
        Dim rd1 As SqlDataReader
        rd1 = cmd1.ExecuteReader
        While rd1.Read
            TextBox1.Text = rd1.GetString(0)
            TextBox2.Text = rd1.GetInt32(1)
            TextBox3.Text = rd1.GetString(2)

        End While
        con.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con.Open()
        Dim a As Integer
        a = Val(TextBox2.Text) + Val(TextBox4.Text)
        Dim qry2 As String
        qry2 = "update product set stocks=" & a & "where prd_id=" & ComboBox1.Text
        Dim cmd2 As New SqlCommand(qry2, con)
        If cmd2.ExecuteNonQuery Then
            MsgBox("Stocks updated successfully")

        End If
        con.Close()

        con.Open()
        Dim qry4 As String
        qry4 = "insert into stocks values(" & ComboBox1.Text & ",'" & TextBox1.Text & "'," & TextBox2.Text & ",'" & TextBox3.Text & "'," & TextBox4.Text & ",'" & DateTimePicker1.Value & "')"
        Dim cmd4 As New SqlCommand(qry4, con)
        If cmd4.ExecuteNonQuery Then
            MsgBox("Information saved successfully")
        End If
        con.Close()
    End Sub
End Class