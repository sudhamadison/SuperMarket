Imports System.Data
Imports System.Data.SqlClient

Public Class Admin
    Dim con As New SqlConnection
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=.\SQLEXPRESS;Initial Catalog=super_market;Integrated Security=True"


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con.Open()
        Dim qry As String
        qry = "select pword from adminlog where username='" & TextBox1.Text & "'"
        Dim cmd As New SqlCommand(qry, con)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader
        ' rd.Read = rd.GetString(0)
        If rd.Read = True Then
            If (rd.GetString(0) = TextBox2.Text) Then
                Dim st As String
                st = "Update adminlog set pword='" & TextBox3.Text & "' where username='" & TextBox1.Text & "' and pword='" & rd.GetString(0) & "' "
                rd.Close()
                Dim cd As New SqlCommand(st, con)
                If cd.ExecuteNonQuery() Then
                    MsgBox("Password changed successfully")

                End If
            Else
                MsgBox("Current password mismatch")
            End If
        End If
        con.Close()
    End Sub
End Class
