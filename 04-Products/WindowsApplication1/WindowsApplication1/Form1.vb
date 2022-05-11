Imports System.Data.SqlClient
Public Class Form1
    Dim conn As SqlConnection
    Dim da As SqlDataAdapter
    Dim ds As DataSet

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New SqlConnection("data source=DESKTOP-5S5N8U6;" & "initial catalog=master;" & "integrated security=true")
        conn.Open()
        Try
            conn.ChangeDatabase("productsDB")
        Catch ex As Exception
            Try
                Dim command As New SqlCommand("CREATE DATABASE productsDB", conn)
                command.ExecuteNonQuery()
                command.Connection.ChangeDatabase("productsDB")
                Dim command2 As New SqlCommand("CREATE TABLE products(id int primary key,name varchar(30),quantity int,dealer_price int,unit_price int)", conn)
                command2.ExecuteNonQuery()
            Catch ex2 As Exception
                MsgBox(ex2.Message)
            End Try
        End Try
        da = New SqlDataAdapter("select * from products", conn)
        Dim cb As New SqlCommandBuilder(da)
        ds = New DataSet()
        da.Fill(ds, "products")
        dgvProducts.DataBindings.Add("datasource", ds, "products")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim r As DataRow = ds.Tables("products").NewRow()
        r("id") = Val(txtProductId.Text)
        r("name") = txtProductName.Text
        r("quantity") = Val(txtCurrentQuantity.Text)
        r("dealer_price") = Val(txtDealerPrice.Text)
        r("unit_price") = Val(txtUnitPrice.Text)
        ds.Tables("products").Rows.Add(r)
        da.Update(ds, "products")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim answer As Integer
        Dim r As DataRow = Nothing
        For Each r In ds.Tables("products").Rows
            If r("id") = Val(txtProductId.Text) Then
                txtProductName.Text = r("name")
                txtCurrentQuantity.Text = r("quantity")
                txtDealerPrice.Text = r("dealer_price")
                txtUnitPrice.Text = r("unit_price")
                Exit For
            End If
        Next
        answer = MsgBox("You are about delete the current record?", MsgBoxStyle.OkCancel)
        If answer = 2 Then Exit Sub
        r.Delete()
        da.Update(ds, "products")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim r As DataRow
        For Each r In ds.Tables("products").Rows
            If r("id") = Val(txtProductId.Text) Then
                txtProductName.Text = r("name")
                txtCurrentQuantity.Text = r("quantity")
                txtDealerPrice.Text = r("dealer_price")
                txtUnitPrice.Text = r("unit_price")
                Exit For
            End If
        Next
        Button6.Visible = True
        txtProductName.Focus()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim sqlstatment As String
        sqlstatment = "select * from products where id=" & txtProductId.Text
        Dim command As SqlCommand = New SqlCommand(sqlstatment, conn)
        Try
            Dim reader As SqlDataReader
            reader = command.ExecuteReader()
            reader.Read()
            txtProductName.Text = reader(1)
            txtCurrentQuantity.Text = reader(2)
            txtDealerPrice.Text = reader(3)
            txtUnitPrice.Text = reader(4)
            conn.Close()
        Catch ex As Exception
            MsgBox("error")
        End Try
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        cmboQuantityType.Visible = True
        txtQuantity.Visible = True
        Dim r As DataRow
        For Each r In ds.Tables("products").Rows
            If r("id") = Val(txtProductId.Text) Then
                txtProductName.Text = r("name")
                txtCurrentQuantity.Text = r("quantity")
                txtDealerPrice.Text = r("dealer_price")
                txtUnitPrice.Text = r("unit_price")
                Exit For
            End If
        Next

    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim r As DataRow
        For Each r In ds.Tables("products").Rows
            If r("id") = Val(txtProductId.Text) Then
                r("name") = txtProductName.Text
                r("quantity") = txtCurrentQuantity.Text
                r("dealer_price") = txtDealerPrice.Text
                r("unit_price") = txtUnitPrice.Text
            End If
        Next
        da.Update(ds, "products")
        Button6.Visible = False
        cmboQuantityType.Visible = False
        txtQuantity.Visible = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        txtProductId.Text = " "
        txtProductName.Text = " "
        txtCurrentQuantity.Text = " "
        txtDealerPrice.Text = " "
        txtUnitPrice.Text = " "
    End Sub

    Private Sub cmboQuantityType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmboQuantityType.SelectedIndexChanged
        Dim r As DataRow
        For Each r In ds.Tables("products").Rows
            If r("id") = Val(txtProductId.Text) Then
                Dim newquantity As Single
                If (cmboQuantityType.SelectedIndex = 0) Then
                    newquantity = Val(r("quantity")) - Val(txtQuantity.Text)
                ElseIf (cmboQuantityType.SelectedIndex = 1) Then
                    newquantity = Val(r("quantity")) + Val(txtQuantity.Text)
                End If
                r("quantity") = newquantity
                txtCurrentQuantity.Text = r("quantity")
                Exit For
            End If
        Next
        da.Update(ds, "products")
    End Sub

   
End Class
