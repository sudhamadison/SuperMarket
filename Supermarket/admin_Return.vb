Imports System.Data
Imports System.Data.SqlClient

Public Class admin_Return
    Dim con As New SqlConnection

    Private Sub admin_Return_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            TextBox6.Text = rd1.GetString(2)

        End While
        con.Close()
    End Sub



    Private Sub TextBox3_Click(sender As Object, e As EventArgs) Handles TextBox3.Click
        Dim a As Integer
        a = Val(TextBox2.Text) - Val(TextBox5.Text)
        TextBox3.Text = a
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con.Open()
        Dim qry2 As String
        qry2 = "update product set stocks=" & TextBox3.Text & "where prd_id=" & ComboBox1.Text
        Dim cmd2 As New SqlCommand(qry2, con)
        If cmd2.ExecuteNonQuery Then
            gridview.Show()
            Me.Hide()
        End If
        con.Close()

        con.Open()
        Dim qry3 As String
        qry3 = "insert into pur_return values(" & ComboBox1.Text & ",'" & TextBox1.Text & "'," & TextBox2.Text & ",'" & TextBox6.Text & "','" & TextBox4.Text & "'," & TextBox5.Text & ",'" & DateTimePicker1.Value & "'," & TextBox3.Text & ")"
        Dim cmd3 As New SqlCommand(qry3, con)
        If cmd3.ExecuteNonQuery Then
            MsgBox("Information saved successfully")


        End If
        con.Close()
    End Sub


End Class