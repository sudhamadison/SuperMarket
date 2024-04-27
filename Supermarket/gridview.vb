Imports System.Data
Imports System.Data.SqlClient

Public Class gridview
    Dim con As New SqlConnection

    Private Sub gridview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=.\SQLEXPRESS;Initial Catalog=super_market;Integrated Security=True"
        con.Open()
        Dim qry As String
        qry = "select * from product"

        Dim adapt As New SqlDataAdapter(qry, con)
        Dim ds As New DataSet()

        adapt.Fill(ds, "product")
        DataGridView1.DataSource = ds.Tables(0)

        DataGridView1.Visible = True
        con.Close()

    End Sub


End Class