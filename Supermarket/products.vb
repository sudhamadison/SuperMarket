Imports System.Data
Imports System.Data.SqlClient

Public Class products
    Dim con As New SqlConnection

    Private Sub products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=.\SQLEXPRESS;Initial Catalog=super_market;Integrated Security=True"

        con.Open()
        Dim qry As String
        qry = "select prd_id from product"
        Dim cmd As New SqlCommand(qry, con)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader
        TextBox1.Text = 1
        While rd.Read
            If rd.GetInt32(0) = 0 Then
                TextBox1.Text = 1
            Else
                TextBox1.Text = rd.GetInt32(0) + 1
            End If

        End While


        con.Close()


        con.Open()
        Dim qry1 As String
        qry1 = "select dealerid from dealer"
        Dim cmd1 As New SqlCommand(qry1, con)
        Dim rd1 As SqlDataReader
        rd1 = cmd1.ExecuteReader
        While rd1.Read
            ComboBox1.Items.Add(rd1.GetInt32(0))

        End While

        con.Close()
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        con.Open()
        Dim qry3 As String
        qry3 = "select dealername from dealer where dealerid = " & ComboBox1.Text
        Dim cmd3 As New SqlCommand(qry3, con)
        Dim rd3 As SqlDataReader
        rd3 = cmd3.ExecuteReader
        If rd3.Read Then
            TextBox5.Text = rd3.GetString(0)
        End If

        con.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        con.Open()
        Dim qry2 As String
        qry2 = "insert into product values(" & TextBox1.Text & ",'" & TextBox2.Text & "'," & TextBox3.Text & "," & TextBox4.Text & "," & ComboBox1.Text & ",'" & TextBox5.Text & "','" & DateTimePicker1.Value & "','" & DateTimePicker2.Value & "'," & TextBox6.Text & ")"

        Dim cmd2 As New SqlCommand(qry2, con)
        If cmd2.ExecuteNonQuery Then
            MsgBox("Information added successfully")
        End If
        con.Close()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        ComboBox1.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'con.Open()
        'Dim qry3 As String
        'qry3 = "select * from product where prd_id = " & TextBox1.Text
        'Dim cmd3 As New SqlCommand(qry3, con)
        'Dim rd3 As SqlDataReader
        'rd3 = cmd3.ExecuteReader
        'If rd3.Read Then
        'TextBox1.Text = rd3.GetInt32(0)
        'TextBox2.Text = rd3.GetString(1)
        'TextBox3.Text = rd3.GetDouble(2)
        'TextBox4.Text = rd3.GetDouble(3)
        'ComboBox1.Text = rd3.GetInt32(4)
        'TextBox5.Text = rd3.GetString(5)
        'DateTimePicker1.Value = rd3.GetDateTime(6)
        'DateTimePicker2.Value = rd3.GetDateTime(7)

        'End If
        gridview.Show()
        Me.Hide()
        'con.Close()
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub
End Class