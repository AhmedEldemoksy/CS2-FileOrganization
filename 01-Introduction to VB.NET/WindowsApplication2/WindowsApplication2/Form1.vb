Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x1, x2, x3, x4, x5, x6 As String
        x1 = TextBox1.Text
        x2 = TextBox2.Text
        x3 = ComboBox1.SelectedItem
        x4 = ListBox1.SelectedItem
        If RadioButton1.Checked = True Then
            x5 = "Male"
        ElseIf RadioButton2.Checked = True Then
            x5 = "Female"
        Else
            x5 = "NotFound"
        End If
        x6 = " "
        If CheckBox1.Checked = True Then
            x6 = "Arb"
        End If

        If CheckBox2.Checked = True Then
            x6 += "Eng"
        End If

        If CheckBox3.Checked = True Then
            x6 += "Frs"
        End If
        MsgBox(x1 & " " & x2 & " " & x3 & " " & x4 & " " & x5 & " " & x6)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox1.SelectedIndex = -1
        ListBox1.SelectedIndex = -1
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Red
    End Sub

    Private Sub Form1_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
        Me.BackColor = Color.Aqua
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Me.BackColor = Color.Coral
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim img As String
        OpenFileDialog1.ShowDialog()
        img = OpenFileDialog1.FileName
        PictureBox1.Image = Image.FromFile(img)
    End Sub
End Class
