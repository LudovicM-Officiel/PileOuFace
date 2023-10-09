Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim pof As Integer = CInt(Int((8 * Rnd()) + 0))
        Label2.Text = pof
        If Label2.Text = 0 Then
            PictureBox1.Image = My.Resources.pile
        End If
        If Label2.Text = 1 Then
            PictureBox1.Image = My.Resources.pile
        End If
        If Label2.Text = 2 Then
            PictureBox1.Image = My.Resources.pile
        End If
        If Label2.Text = 3 Then
            PictureBox1.Image = My.Resources.pile
        End If
        If Label2.Text = 4 Then
            PictureBox1.Image = My.Resources.face
        End If
        If Label2.Text = 5 Then
            PictureBox1.Image = My.Resources.face
        End If
        If Label2.Text = 6 Then
            PictureBox1.Image = My.Resources.face
        End If
        If Label2.Text = 7 Then
            PictureBox1.Image = My.Resources.face
        End If
        If Label2.Text = 0 Then
            Label4.Text = "Pile !"
        End If
        If Label2.Text = 1 Then
            Label4.Text = "Pile !"
        End If
        If Label2.Text = 2 Then
            Label4.Text = "Pile !"
        End If
        If Label2.Text = 3 Then
            Label4.Text = "Pile !"
        End If
        If Label2.Text = 4 Then
            Label4.Text = "Face !"
        End If
        If Label2.Text = 5 Then
            Label4.Text = "Face !"
        End If
        If Label2.Text = 6 Then
            Label4.Text = "Face !"
        End If
        If Label2.Text = 7 Then
            Label4.Text = "Face !"
        End If
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
