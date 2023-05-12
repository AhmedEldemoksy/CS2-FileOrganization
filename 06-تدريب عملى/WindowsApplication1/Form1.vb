Imports System.Data.SqlClient
Public Class Form1
    Dim conn As SqlConnection
    Dim da As SqlDataAdapter
    Dim ds As DataSet = New DataSet()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strconnection As String = "data source=DESKTOP-HDDD7SC; initial catalog=db; integrated security=true"
        conn = New SqlConnection(strconnection)
        conn.Open()
        da = New SqlDataAdapter("select * from student", conn)
        Dim x As New SqlCommandBuilder(da)
        da.Fill(ds, "student")
        DataGridView1.DataBindings.Add("datasource", ds, "student")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim r As DataRow = ds.Tables("student").NewRow()
        r("id") = Val(TextBox1.Text)
        r("name") = TextBox2.Text
        r("city") = TextBox3.Text
        ds.Tables("student").Rows.Add(r)
        da.Update(ds, "student")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim r As DataRow
        For Each r In ds.Tables("student").Rows
            If r("id") = Val(TextBox1.Text) Then
                TextBox2.Text = r("name")
                TextBox3.Text = r("city")
            End If
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim r As DataRow
        Dim x As Integer
        For Each r In ds.Tables("student").Rows
            If r("id") = Val(TextBox1.Text) Then
                x = MsgBox("Are you Sure to edit student", MsgBoxStyle.OkCancel)
                If x = 1 Then
                    r("name") = TextBox2.Text
                    r("city") = TextBox3.Text
                    da.Update(ds, "student")
                End If
            End If

        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim r As DataRow
        Dim x As Integer
        For Each r In ds.Tables("student").Rows
            If r("id") = Val(TextBox1.Text) Then
                x = MsgBox("Are you Sure to delete student", MsgBoxStyle.OkCancel)
                If x = 1 Then
                    r.Delete()
                End If
            End If
        Next
        da.Update(ds, "student")
    End Sub
End Class
