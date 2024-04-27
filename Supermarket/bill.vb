Imports System.Data
Imports System.Data.SqlClient

Public Class bill
    Dim con As New SqlConnection

    Private Sub bill_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button3.Visible = False
        Button4.Visible = False
        TextBox1.Visible = False

        con.ConnectionString = "Data Source=.\SQLEXPRESS;Initial Catalog=super_market;Integrated Security=True;MultipleActiveResultSets=True;"
        Call view()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button3.Visible = True
        Button4.Visible = True
        TextBox1.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim sql As String
        sql = "delete from sales_temp where pro_name='" & ListBox1.SelectedItem & "'"
        con.Open()
        Dim cmd As New SqlCommand(sql, con)
        If cmd.ExecuteNonQuery Then
            MsgBox("Item Removed")
            ListBox1.Items.Clear()

            ListBox2.Items.Clear()

            ListBox3.Items.Clear()


            Call view()
        End If
        con.Close()
    End Sub

    Sub view()
        con.Open()
        Dim qry4 As String
        qry4 = "select sno from sales_temp"
        Dim cmd4 As New SqlCommand(qry4, con)
        Dim rd4 As SqlDataReader
        rd4 = cmd4.ExecuteReader
        ListBox4.Items.Clear()
        While rd4.Read
            ListBox4.Items.Add(rd4.GetInt32(0))
        End While
        con.Close()

        con.Open()
        Dim qry As String
        qry = "select pro_name from sales_temp"
        Dim cmd As New SqlCommand(qry, con)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader
        ListBox1.Items.Clear()
        While rd.Read
            ListBox1.Items.Add(rd.GetString(0))
        End While
        con.Close()



        con.Open()
        Dim qry2 As String
        qry2 = "select quantity from sales_temp"
        Dim cmd2 As New SqlCommand(qry2, con)
        Dim rd2 As SqlDataReader
        rd2 = cmd2.ExecuteReader
        ListBox2.Items.Clear()
        While rd2.Read
            ListBox2.Items.Add(rd2.GetInt32(0))
        End While
        con.Close()

        con.Open()
        Dim qry3 As String
        qry3 = "select total from sales_temp"
        Dim cmd3 As New SqlCommand(qry3, con)
        Dim rd3 As SqlDataReader
        rd3 = cmd3.ExecuteReader
        ListBox3.Items.Clear()
        While rd3.Read
            ListBox3.Items.Add(rd3.GetDouble(0))
        End While
        con.Close()

        rd.Close()
        rd.Close()
        rd2.Close()
        rd3.Close()
        rd4.Close()
        'rd5.Close()


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Sales_product.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        con.Open()
        Dim q1 As String
        Dim newpr As Integer
        q1 = "select sell_price from product where prd_name='" & ListBox1.SelectedItem & "'"
        Dim cd As New SqlCommand(q1, con)
        Dim rd As SqlDataReader
        rd = cd.ExecuteReader
        If rd.Read = True Then
            Dim pr As Integer
            pr = rd.GetDouble(0)
            newpr = Val(TextBox1.Text) * pr
        End If
        rd.Close()
        cd.Dispose()
        con.Close()

        con.Open()
        Dim qry4 As String
        qry4 = "update sales_temp set quantity=" & TextBox1.Text & ", total=" & newpr & "where sno =" & ListBox4.SelectedItem
        Dim cd1 As New SqlCommand(qry4, con)
        Dim rd1 As SqlDataReader
        rd1 = cd1.ExecuteReader
        If rd1.Read Then
            MsgBox("Updated successfully")
            ListBox1.Items.Clear()

            ListBox2.Items.Clear()

            ListBox3.Items.Clear()
            Call view()
        End If
        rd1.Close()
        cd1.Dispose()
        con.Close()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con.Open()
        Dim query As String
        query = "SELECT * FROM sales_temp"
        Dim comd As New SqlCommand(query, con)
        Dim red As SqlDataReader
        red = comd.ExecuteReader
        While red.Read
            Dim qrry As String
            qrry = "INSERT INTO sales VALUES(" & red.GetInt32(1) & ", '" & red.GetString(2) & "' , " & red.GetInt32(3) & " , '" & red.GetString(4) & "' , " & red.GetDouble(5) & " , " & red.GetInt32(6) & ", " & red.GetDouble(7) & " , " & red.GetDouble(8) & ")"
            Dim comdd As New SqlCommand(qrry, con)
            comdd.ExecuteNonQuery()

            'MsgBox("test")

        End While

        Dim dq As String
        dq = "delete from sales_temp"
        Dim cod As New SqlCommand(dq, con)
        If cod.ExecuteNonQuery() Then

        End If
        red.Close()
        con.Close()
    End Sub
End Class