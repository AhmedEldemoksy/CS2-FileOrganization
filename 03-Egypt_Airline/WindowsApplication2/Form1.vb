Imports System.IO
Imports System.IO.IOException
Imports System.Windows.Forms.Control
Public Structure hagz
    Dim trip_no As Integer
    Dim trip_date As String
    Dim trip_time As String
    Dim arrive As String
    Dim city As String
    Dim city1 As String
    <VBFixedArray(55)> Dim korsi_no() As Integer
    <VBFixedArray(55)> Dim passenger() As String
    <VBFixedArray(55)> Dim phone() As String
    <VBFixedArray(55)> Dim address() As String
End Structure

Public Class Form1

    Public prec As hagz
    Dim button(55) As Button
    Dim i, j, x, z, s, position As Integer


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FileOpen(1, "d:\air.txt", OpenMode.Random, , , Len(prec))
        prec.korsi_no = New Integer(55) {}
        prec.passenger = New String(55) {}
        prec.phone = New String(55) {}
        prec.address = New String(55) {}
        Label11.Text = Now()
        For i = 1 To 56
            button(i - 1) = Me.Controls("button" & i)
            AddHandler button(i - 1).Click, AddressOf korsi
        Next
    End Sub
    Private Sub korsi(sender As Object, e As EventArgs)
        FileGet(1, prec, Val(TextBox1.Text))

        For i = 0 To 55
            If button(i) Is sender Then
                j = i
                Exit For
            End If
        Next
        z = prec.korsi_no(j)
        If z <> 0 Then
            TextBox7.Text = prec.passenger(j)
            TextBox8.Text = prec.phone(j)
            TextBox9.Text = prec.address(j)
        End If
        If j <= 8 Then
            Label10.Text = "first class"
        Else
            Label10.Text = "second class"
        End If
    End Sub
    Sub view()
        FileGet(1, prec, Val(TextBox1.Text))
        If prec.trip_no <> Val(TextBox1.Text) Then
            MsgBox("no trip under this number !!")
            Exit Sub
        End If
        TextBox2.Text = prec.trip_date
        TextBox3.Text = prec.trip_time
        TextBox4.Text = prec.arrive
        TextBox5.Text = prec.city
        TextBox6.Text = prec.city1

        For i = 0 To 55
            If prec.korsi_no(i) = 1 Then
                button(i).BackColor = Color.Orange
            ElseIf prec.korsi_no(i) = 2 Then
                button(i).BackColor = Color.Red
            Else
                button(i).BackColor = Color.Lime
            End If
        Next
    End Sub

    Private Sub Button61_Click(sender As Object, e As EventArgs)


    End Sub
    Sub clear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox6.Clear()
        TextBox5.Clear()

    End Sub
    Sub textbox1_textchange(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            view()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button57_Click(sender As Object, e As EventArgs) Handles Button57.Click
        End
    End Sub

    Private Sub Button60_Click(sender As Object, e As EventArgs) Handles Button60.Click
        view()
        x = MsgBox("do you want to book this chair ?!", MsgBoxStyle.OkCancel)
        If x = 1 Then
            button(j).BackColor = Color.Orange
            z = 1
            FileGet(1, prec, Val(TextBox1.Text))
            prec.korsi_no(j) = z
            prec.passenger(j) = TextBox7.Text
            prec.phone(j) = TextBox8.Text
            prec.address(j) = TextBox9.Text
            s = Val(TextBox1.Text)
            FilePut(1, prec, s)
            clear2()
        ElseIf x = 2 Then
            button(j).BackColor = Color.Lime
            Exit Sub
        End If

    End Sub
    Sub clear2()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        Label10.Text = ""


    End Sub

    Private Sub Button59_Click(sender As Object, e As EventArgs) Handles Button59.Click
        view()
        If z = 0 Then
            MsgBox("you can't confirm this chair !!")
        ElseIf z = 1 Then
            x = MsgBox("do you want to confirm this chair !?", MsgBoxStyle.OkCancel)
            If x = 1 Then
                button(j).BackColor = Color.Red
                z = 2
                FileGet(1, prec, Val(TextBox1.Text))
                prec.korsi_no(j) = z
                s = Val(TextBox1.Text)
                FilePut(1, prec, s)
                clear2()
            ElseIf x = 2 Then
                button(j).BackColor = Color.Orange

            End If

        End If

    End Sub

    Private Sub Button58_Click(sender As Object, e As EventArgs) Handles Button58.Click
        view()
        If z = 2 Then
            MsgBox("you can't delete this chair")
        ElseIf z = 1 Then
            x = MsgBox("do you want to clear this chair", MsgBoxStyle.OkCancel)
            If x = 1 Then
                button(j).BackColor = Color.Lime
                z = 0
                prec.korsi_no(j) = 0
                prec.passenger(j) = ""
                prec.phone(j) = ""
                prec.address(j) = ""
            ElseIf x = 2 Then
                button(j).BackColor = Color.Orange

            End If
        End If
    End Sub


    Private Sub Button62_Click(sender As Object, e As EventArgs) Handles Button62.Click
        position = Loc(1)
        s = Val(TextBox1.Text)
        Seek(1, s)

        prec.trip_no = Val(TextBox1.Text)
        prec.trip_date = TextBox2.Text
        prec.trip_time = TextBox3.Text
        prec.arrive = TextBox4.Text
        prec.city = TextBox5.Text
        prec.city1 = TextBox6.Text

        For i = 0 To 55
            prec.korsi_no(i) = 0
            prec.passenger(i) = ""
            prec.phone(i) = ""
            prec.address(i) = ""

        Next
        s = TextBox1.Text
        FilePut(1, prec, s)
        MsgBox("data saved !")
        clear()
    End Sub
End Class
