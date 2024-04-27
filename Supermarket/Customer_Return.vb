Imports System.Data
Imports System.Data.SqlClient

Public Class Customer_Return
    Dim Con As New SqlConnection

    Private Sub Customer_Return_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Con.ConnectionString = "Data Source=.\SQLEXPRESS;Initial Catalog=super_market;Integrated Security=True;MultipleActiveResultSets=True;"
        Con.Open()
        Dim qry As String
        qry = "select customerid from custom"
        Dim cmd As New SqlCommand(qry, Con)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader
        While rd.Read
            ComboBox1.Items.Add(rd.GetInt32(0))
        End While


        Dim qry0 As String
        qry0 = "select prd_id from product"
        Dim cmd0 As New SqlCommand(qry0, Con)
        Dim rd0 As SqlDataReader
        rd0 = cmd0.ExecuteReader
        While rd0.Read
            ComboBox2.Items.Add(rd0.GetInt32(0))
        End While

        Con.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Con.Open()
        Dim qry1 As String
        qry1 = "select customername from custom where customerid=" & ComboBox1.Text
        Dim cmd1 As New SqlCommand(qry1, Con)
        Dim rd1 As SqlDataReader
        rd1 = cmd1.ExecuteReader
        While rd1.Read
            TextBox1.Text = rd1.GetString(0)
        End While
        Con.Close()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Con.Open()
        Dim qry2 As String
        qry2 = "select prd_name,stocks from product where prd_id=" & ComboBox2.Text
        Dim cmd2 As New SqlCommand(qry2, Con)
        Dim rd2 As SqlDataReader
        rd2 = cmd2.ExecuteReader
        While rd2.Read
            TextBox6.Text = rd2.GetString(0)
            TextBox2.Text = rd2.GetInt32(1)
        End While
        Con.Close()
    End Sub

    Private Sub TextBox3_Click(sender As Object, e As EventArgs) Handles TextBox3.Click
        Dim a As Integer
        a = Val(TextBox2.Text) + Val(TextBox5.Text)
        TextBox3.Text = a
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Con.Open()
        Dim qry3 As String
        qry3 = "update product set stocks=" & TextBox3.Text & "where prd_id=" & ComboBox2.Text
        Dim cmd3 As New SqlCommand(qry3, Con)
        If cmd3.ExecuteNonQuery Then
            gridview.Show()
            Me.Hide()
        End If
        Con.Close()

        Con.Open()
        Dim qry4 As String
        qry4 = "insert into sales_return values(" & ComboBox1.Text & ",'" & TextBox1.Text & "'," & ComboBox2.Text & ",'" & TextBox6.Text & "'," & TextBox2.Text & ",'" & TextBox4.Text & "'," & TextBox5.Text & ",'" & DateTimePicker1.Value & "'," & TextBox3.Text & ")"
        Dim cmd4 As New SqlCommand(qry4, Con)
        If cmd4.ExecuteNonQuery Then
            MsgBox("Information saved successfully")
        End If
        Con.Close()
    End Sub
End Class