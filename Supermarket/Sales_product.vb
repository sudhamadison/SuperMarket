Imports System.Data
Imports System.Data.SqlClient

Public Class Sales_product
    Dim con As New SqlConnection
    Private Sub Sales_product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=.\SQLEXPRESS;Initial Catalog=super_market;Integrated Security=True"
        con.Open()
        Dim qry2 As String
        qry2 = "select customerid from custom"
        Dim cmd2 As New SqlCommand(qry2, con)
        Dim rd2 As SqlDataReader
        rd2 = cmd2.ExecuteReader
        While rd2.Read
            ComboBox1.Items.Add(rd2.GetInt32(0))
        End While
        con.Close()

        con.Open()
        Dim qry3 As String
        qry3 = "select prd_id from product"
        Dim cmd3 As New SqlCommand(qry3, con)
        Dim rd3 As SqlDataReader
        rd3 = cmd3.ExecuteReader
        While rd3.Read
            ComboBox2.Items.Add(rd3.GetInt32(0))
        End While
        con.Close()
        Label4.Text = Now

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        con.Open()
        Dim qry As String
        qry = "select customername from custom where customerid= " & ComboBox1.Text
        Dim cmd As New SqlCommand(qry, con)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader
        If rd.Read Then
            TextBox1.Text = rd.GetString(0)

        End If


        con.close()

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        con.Open()
        Dim qry1 As String
        qry1 = "select prd_name,sell_price from product where prd_id= " & ComboBox2.Text
        Dim cmd1 As New SqlCommand(qry1, con)
        Dim rd1 As SqlDataReader
        rd1 = cmd1.ExecuteReader
        If rd1.Read Then
            TextBox2.Text = rd1.GetString(0)
            TextBox3.Text = rd1.GetDouble(1)
        End If


        con.Close()

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub TextBox6_GotFocus(sender As Object, e As EventArgs) Handles TextBox6.GotFocus
        Dim tot As Integer
        Dim dis As Integer

        tot = Val(TextBox3.Text) * Val(TextBox4.Text)
        dis = Val(TextBox5.Text) * tot / 100
        TextBox6.Text = tot - dis
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con.Open()
        Dim qry3 As String
        qry3 = "insert into sales_temp values(" & ComboBox1.Text & ",'" & TextBox1.Text & "'," & ComboBox2.Text & ",'" & TextBox2.Text & "'," & TextBox3.Text & "," & TextBox4.Text & "," & TextBox5.Text & "," & TextBox6.Text & ")"
        Dim cmd3 As New SqlCommand(qry3, con)
        If cmd3.ExecuteNonQuery Then
            Dim qry4 As String
            qry4 = "select * from sales_temp"

            Dim adapt As New SqlDataAdapter(qry4, con)
            Dim ds As New DataSet()

            adapt.Fill(ds, "sales_temp")
            DataGridView1.DataSource = ds.Tables(0)

            DataGridView1.Visible = True
        End If

        con.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class