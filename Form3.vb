﻿Imports System.Reflection.Emit

Public Class Form3


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
            Label4.Text = "Pile"
        End If
        If Label2.Text = 2 Then
            Label4.Text = "Face"
        End If

        If ComboBox1.Text = Label4.Text Then
            Label1.Text = Label1.Text + 1
        Else
            Label7.Text = Label7.Text + 1
        End If
        Label12.Text = Label12.Text + 1
        Label15.Text = Label1.Text * 100 / Label12.Text
        Dim dblTranspo As Double
        dblTranspo = Label15.Text
        Label15.Text = Format(dblTranspo, "#,##0.00")
        Me.Label15.Text = Me.Label15.Text
        Label16.Text = Label7.Text * 100 / Label12.Text
        Dim dblTranspo2 As Double
        dblTranspo2 = Label16.Text
        Label16.Text = Format(dblTranspo2, "#,##0.00")
        Me.Label16.Text = Me.Label16.Text
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Label7.Text = "0"
        Label1.Text = "0"
        Label15.Text = "0"
        Label16.Text = "0"
        Label12.Text = "0"
        Label23.Text = "0"
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Visible = True
        Label21.Visible = True
        Button1.PerformClick()
        TextBox1.ReadOnly = True
        ProgressBar1.Value = (Label12.Text / TextBox1.Text) * 100
        Label21.Text = "" & ProgressBar1.Value & " %"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Or TextBox1.Text = "0" Or TextBox1.Text = "00" Or TextBox1.Text = "000" Or TextBox1.Text = "0000" Or TextBox1.Text = "00000" Or TextBox1.Text = "000000" Or TextBox1.Text = "0000000" Then
            MsgBox("La valeur ne peut être 0 ou vide!", vbExclamation + vbDefaultButton2, "Pile ou face ? 1.4")
        Else
            Timer1.Enabled = True
            Timer2.Enabled = True
            Timer3.Enabled = True
            Button3.Enabled = False
            Label7.Text = "0"
            Label1.Text = "0"
            Label15.Text = "0"
            Label23.Text = "0"
            Label16.Text = "0"
            Label12.Text = "0"
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If TextBox1.Text = Label12.Text Then
            Timer1.Enabled = False
            Timer2.Enabled = False
            Timer3.Enabled = False
            Button3.Enabled = True
            TextBox1.ReadOnly = False
            ProgressBar1.Value = 0
            ProgressBar1.Visible = False
            Label21.Visible = False
            MsgBox("Parti automatique fini !", vbExclamation + vbDefaultButton2, "Pile ou face ?")
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Label23.Text = Label23.Text + 1
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Timer1.Enabled = False
        Timer2.Enabled = False
        Timer3.Enabled = False
        TextBox1.ReadOnly = False
        ProgressBar1.Value = 0
        ProgressBar1.Visible = False
        Label21.Visible = False
        Timer2.Enabled = False
        Label23.Text = "0"
        Button3.Enabled = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form1.Show()
        Me.Close()

    End Sub
End Class