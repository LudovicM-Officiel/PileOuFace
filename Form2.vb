Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim pof As Integer = CInt(Int((2 * Rnd()) + 1))
        Label2.Text = pof
        If Label2.Text = 1 Then
            PictureBox1.Image = My.Resources.pile
        End If
        If Label2.Text = 2 Then
            PictureBox1.Image = My.Resources.face
        End If

        If Label2.Text = 1 Then
            Label4.Text = "Pile !"
        End If
        If Label2.Text = 2 Then
            Label4.Text = "Face !"
        End If

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Close()
    End Sub
End Class
