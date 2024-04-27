Imports System.Data
Imports System.Data.SqlClient

Public Class Customers
    Dim con As New SqlConnection

    Private Sub Customers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        con.ConnectionString = "Data Source=.\SQLEXPRESS;Initial Catalog=super_market;Integrated Security=True;MultipleActiveResultSets=true;"

        ComboBox1.Items.Add("Male")
        ComboBox1.Items.Add("Female")
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        TextBox5.Enabled = True
        TextBox6.Enabled = True
        TextBox7.Enabled = True
        TextBox8.Enabled = True
        Button2.Enabled = True
        Button1.Enabled = False

        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""


        con.Open()
        Dim qry As String
        qry = "select customerid from custom"
        Dim cmd As New SqlCommand(qry, con)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader

        While rd.Read
            If rd.GetInt32(0) > 0 Then
                TextBox1.Text = 1 + rd.GetInt32(0)
            Else
                TextBox1.Text = 1
            End If

        End While
        con.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Button1.Enabled = True
        Button2.Enabled = False
        Dim str As String
        con.Open()
        str = "insert into custom values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & ComboBox1.Text & "','" & DateTimePicker1.Value & "')"
        Dim cd As New SqlCommand(str, con)
        If cd.ExecuteNonQuery Then
            MsgBox("customer information added")
        End If
        con.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


        Dim st As String
        con.Open()
        st = "Select * from custom where customerid=" & TextBox1.Text

        If TextBox1.Text = "" Then
            MsgBox("ID Missing")
        Else
            Dim com As New SqlCommand(st, con)
            Dim rad As SqlDataReader
            rad = com.ExecuteReader

            If rad.Read Then
                TextBox1.Text = rad.GetInt32(0)
                TextBox2.Text = rad.GetString(1)
                TextBox3.Text = rad.GetString(2)
                TextBox4.Text = rad.GetString(3)
                TextBox5.Text = rad.GetString(4)
                TextBox6.Text = rad.GetInt32(5)
                TextBox7.Text = rad.GetString(6)
                TextBox8.Text = rad.GetString(7)
                ComboBox1.Text = rad.GetString(8)
                DateTimePicker1.Value = rad.GetDateTime(9)

            End If

        End If

        con.Close()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        ComboBox1.Text = " "


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        con.Open()

        Dim stri As String
        stri = "update custom Set gender ='" & ComboBox1.Text & "',dob ='" & DateTimePicker1.Value & "',customername ='" & TextBox2.Text & "' ,addr ='" & TextBox3.Text & "' , city ='" & TextBox4.Text & "' ,c_state ='" & TextBox5.Text & "' ,pincode =" & TextBox6.Text & " ,ph_no ='" & TextBox7.Text & "' ,email_id ='" & TextBox8.Text & "' where customerid = " & TextBox1.Text
        If TextBox1.Text = "" Then
            MsgBox("ID missing")
        Else

            Dim cd As New SqlCommand(stri, con)
            If cd.ExecuteNonQuery Then
                MsgBox("Customer information updated")
            End If
        End If


        con.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        con.Open()
        Dim st As String
        st = "delete from custom where customerid =" & TextBox1.Text
        Dim comm As New SqlCommand(st, con)
        If comm.ExecuteNonQuery Then
            MsgBox("Customer information deleted")
        End If
        con.Close()
    End Sub



    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        If TextBox1.Text = "" Then
            ErrorProvider1.SetError(TextBox1, "Please Enter value")
        Else
            ErrorProvider1.SetError(TextBox1, "")
        End If

    End Sub


    Private Sub TextBox2_LostFocus(sender As Object, e As EventArgs) Handles TextBox2.LostFocus
        If TextBox2.Text = "" Then
            ErrorProvider1.SetError(TextBox2, "Please Enter value")
        Else
            ErrorProvider1.SetError(TextBox2, "")
        End If
    End Sub

    Private Sub TextBox3_LostFocus(sender As Object, e As EventArgs) Handles TextBox3.LostFocus
        If TextBox3.Text = "" Then
            ErrorProvider1.SetError(TextBox3, "Please Enter value")
        Else
            ErrorProvider1.SetError(TextBox3, "")
        End If
    End Sub


    Private Sub TextBox4_LostFocus(sender As Object, e As EventArgs) Handles TextBox4.LostFocus
        If TextBox4.Text = "" Then
            ErrorProvider1.SetError(TextBox4, "Please Enter value")
        Else
            ErrorProvider1.SetError(TextBox4, "")
        End If
    End Sub


    Private Sub TextBox5_LostFocus(sender As Object, e As EventArgs) Handles TextBox5.LostFocus
        If TextBox5.Text = "" Then
            ErrorProvider1.SetError(TextBox5, "Please Enter value")
        Else
            ErrorProvider1.SetError(TextBox5, "")
        End If
    End Sub



    Private Sub TextBox6_LostFocus(sender As Object, e As EventArgs) Handles TextBox6.LostFocus
        If TextBox6.TextLength > 6 Or TextBox6.TextLength < 6 Then
            ErrorProvider1.SetError(TextBox6, "Please Enter 6 digit only")
        Else
            ErrorProvider1.SetError(TextBox6, "")
        End If
    End Sub


    Private Sub TextBox7_LostFocus(sender As Object, e As EventArgs) Handles TextBox7.LostFocus
        If TextBox7.TextLength > 10 Or TextBox7.TextLength < 10 Then
            ErrorProvider1.SetError(TextBox7, "Please Enter 10 digit only")
        Else
            ErrorProvider1.SetError(TextBox7, "")
        End If
    End Sub



    Private Sub TextBox8_LostFocus(sender As Object, e As EventArgs) Handles TextBox8.LostFocus
        If TextBox8.Text = "" Then
            ErrorProvider1.SetError(TextBox8, "Please Enter value")
        Else
            ErrorProvider1.SetError(TextBox8, "")
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class