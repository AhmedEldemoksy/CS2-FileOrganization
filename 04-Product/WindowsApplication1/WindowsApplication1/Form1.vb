Imports System.Data.SqlClient

Public Class Form1
    Dim conn As SqlConnection
    Dim da As SqlDataAdapter
    Dim ds As DataSet

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strconnection As String = "data source= DESKTOP-LMOVISH;initial catalog=product1;integrated security=true"
        conn = New SqlConnection(strconnection)
        conn.Open()

        da = New SqlDataAdapter("select * from pro", conn)
        Dim cb As New SqlCommandBuilder(da)
        ds = New DataSet()
        da.Fill(ds, "pro")
        DataGridView1.DataBindings.Add("datasource", ds, "pro")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim r As DataRow = ds.Tables("pro").NewRow()
        r("id") = Val(TextBox1.Text)
        r("name") = TextBox2.Text
        r("quantity") = Val(TextBox3.Text)
        ds.Tables("pro").Rows.Add(r)
        da.Update(ds, "pro")
    End Sub
End Class
