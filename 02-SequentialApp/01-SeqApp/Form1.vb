Public Class Form1

    Dim position As Integer

    Dim num As Integer
    Dim nam As String
    Dim unit As Integer
    Dim money_now As Integer
    Dim sale_price As Integer
    Dim total_price As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FileOpen(1, "d:\a.txt", OpenMode.Append)
        num = Val(TextBox1.Text)
        nam = TextBox2.Text
        unit = Val(TextBox3.Text)
        money_now = Val(TextBox4.Text)
        sale_price = Val(TextBox5.Text)
        total_price = Val(TextBox6.Text)
        WriteLine(1, num, nam, unit, money_now, sale_price, total_price)
        FileClose(1)
        MsgBox("Data Added")
        clear()
    End Sub
    Sub clear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox1.Focus()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FileOpen(1, "d:\a.txt", OpenMode.Input)
        FileOpen(2, "d:\b.txt", OpenMode.Append)
        Do While Not EOF(1)
            Input(1, num)
            Input(1, nam)
            Input(1, unit)
            Input(1, money_now)
            Input(1, sale_price)
            Input(1, total_price)
            If num = Val(TextBox1.Text) Then
                position = Loc(1)
                nam = TextBox2.Text
                unit = Val(TextBox3.Text)
                money_now = Val(TextBox4.Text)
                sale_price = Val(TextBox5.Text)
                total_price = Val(TextBox6.Text)
                WriteLine(2, num, nam, unit, money_now, sale_price, total_price)
            End If
            If num <> Val(TextBox1.Text) Then
                position = Loc(1)
                WriteLine(2, num, nam, unit, money_now, sale_price, total_price)
            End If
        Loop
        FileClose(2)
        FileClose(1)
        Kill("d:\a.txt")
        Rename("d:\b.txt", "d:\a.txt")
        clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        view()
    End Sub

    Sub view()
        Dim count As Integer
        FileOpen(1, "d:\a.txt", OpenMode.Input)
        count = 1
        ListBox1.Height = (ListBox1.ItemHeight + 3) * 12
        ListBox1.Items.Clear()
        ListBox1.Items.Add("")
        ListBox1.Items.Add("|" + "رقم الصنف")
        ListBox1.Items.Add("|" + "------------------")
        ListBox1.Items.Add("|" + "اسم الصنف")
        ListBox1.Items.Add("|" + "------------------")
        ListBox1.Items.Add("|" + "الوحدة")
        ListBox1.Items.Add("|" + "------------------")
        ListBox1.Items.Add("|" + "الرصيد")
        ListBox1.Items.Add("|" + "------------------")
        ListBox1.Items.Add("|" + "السعر")
        ListBox1.Items.Add("|" + "------------------")
        ListBox1.Items.Add("|" + "السعر الكلي")
        Do While Not EOF(1)
            Input(1, num)
            Input(1, nam)
            Input(1, unit)
            Input(1, money_now)
            Input(1, sale_price)
            Input(1, total_price)
            ListBox1.Items.Add("")
            ListBox1.Items.Add("|" + Str(num))
            ListBox1.Items.Add("|" + "------------------")
            ListBox1.Items.Add("|" + nam)
            ListBox1.Items.Add("|" + "------------------")
            ListBox1.Items.Add("|" + Str(unit))
            ListBox1.Items.Add("|" + "------------------")
            ListBox1.Items.Add("|" + Str(money_now))
            ListBox1.Items.Add("|" + "------------------")
            ListBox1.Items.Add("|" + Str(sale_price))
            ListBox1.Items.Add("|" + "------------------")
            ListBox1.Items.Add("|" + Str(total_price))

            If num = Val(TextBox1.Text) Then
                TextBox2.Text = nam
                TextBox3.Text = unit
                TextBox4.Text = money_now
                TextBox5.Text = sale_price
                TextBox6.Text = total_price
            End If
            count += 1
        Loop
        FileClose(1)
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FileOpen(1, "d:\a.txt", OpenMode.Input)
        FileOpen(2, "d:\b.txt", OpenMode.Append)
        Do While Not EOF(1)
            Input(1, num)
            Input(1, nam)
            Input(1, unit)
            Input(1, money_now)
            Input(1, sale_price)
            Input(1, total_price)
            If num <> Val(TextBox1.Text) Then
                position = Loc(1)
                WriteLine(2, num, nam, unit, money_now, sale_price, total_price)
            End If
        Loop
        FileClose(2)
        FileClose(1)
        Kill("d:\a.txt")
        Rename("d:\b.txt", "d:\a.txt")
        clear()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        End
    End Sub
    Private Sub Button1_MouseUp(sender As Object, e As MouseEventArgs) Handles Button1.MouseUp
        view()
    End Sub
    Private Sub Button3_MouseUp(sender As Object, e As MouseEventArgs) Handles Button3.MouseUp
        view()
    End Sub
    Private Sub Button4_MouseUp(sender As Object, e As MouseEventArgs) Handles Button4.MouseUp
        view()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
