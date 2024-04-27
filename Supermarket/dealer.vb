Imports System.Data
Imports System.Data.SqlClient

Public Class dealer
    Dim con As New SqlConnection

    Private Sub dealer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=.\SQLEXPRESS;Initial Catalog=super_market;Integrated Security=True"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        Button1.Enabled = False
        Button2.Enabled = True

        con.Open()
        Dim qry As String
        qry = "select dealerid from dealer"
        Dim cmd As New SqlCommand(qry, con)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader

        While rd.Read
            If rd.GetInt32(0) = 0 Then
                TextBox1.Text = 1
            Else
                TextBox1.Text = 1 + rd.GetInt32(0)
            End If
        End While
        con.Close()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button1.Enabled = True
        Button2.Enabled = False
        Dim qry1 As String
        con.Open()
        qry1 = "insert into dealer values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "')"
        Dim cmd1 As New SqlCommand(qry1, con)
        If cmd1.ExecuteNonQuery() Then
            MsgBox("Information added successfully")
        End If
        con.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""

        Dim qry2 As String
        con.Open()
        qry2 = "select * from dealer where dealerid=" & TextBox1.Text

        If TextBox1.Text = "" Then
            MsgBox("Please enter dealer id")
        Else
            Dim cmd2 As New SqlCommand(qry2, con)
            Dim rd2 As SqlDataReader
            rd2 = cmd2.ExecuteReader

            If rd2.Read Then

                TextBox1.Text = rd2.GetInt32(0)
                TextBox2.Text = rd2.GetString(1)
                TextBox3.Text = rd2.GetString(2)
                TextBox4.Text = rd2.GetString(3)
                TextBox5.Text = rd2.GetString(4)
                TextBox6.Text = rd2.GetString(5)
                TextBox7.Text = rd2.GetString(6)

            End If
        End If

        con.Close()


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        con.Open()
        Dim qry3 As String
        qry3 = "update dealer set dealername='" & TextBox2.Text & "',addr='" & TextBox3.Text & "',city='" & TextBox4.Text & "',d_state='" & TextBox5.Text & "',pincode='" & TextBox6.Text & "',ph_no='" & TextBox7.Text & "'where dealerid = " & TextBox1.Text
        If TextBox1.Text = "" Then
            MsgBox("Please enter dealerid")
        Else
            Dim cmd3 As New SqlCommand(qry3, con)
            If cmd3.ExecuteNonQuery Then
                MsgBox("Information updated successfully")
            End If
        End If
        con.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim qry4 As String
        con.Open()
        qry4 = "delete  from dealer where dealerid = " & TextBox1.Text
        Dim cmd4 As New SqlCommand(qry4, con)
        If cmd4.ExecuteNonQuery Then
            MsgBox("Informatin deleted successfully")
        End If
        con.Close()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class