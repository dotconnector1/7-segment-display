Public Class Form1

    Dim count As Integer

    Private Sub SplitContainer1_Panel1_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub setNum_TextChanged(sender As Object, e As EventArgs) Handles setNum.TextChanged
        If setNum.Text = "1" Then
            Me.Button1.Visible = False
            Me.Button2.Visible = False
            Me.Button3.Visible = False
            Me.Button4.Visible = False
            Me.Button5.Visible = False
            Me.Button6.Visible = False
            Me.Button7.Visible = False

            Me.Button6.Visible = True
            Me.Button7.Visible = True
        ElseIf setNum.Text = "2" Then
            Me.Button1.Visible = False
            Me.Button2.Visible = False
            Me.Button3.Visible = False
            Me.Button4.Visible = False
            Me.Button5.Visible = False
            Me.Button6.Visible = False
            Me.Button7.Visible = False

            Me.Button1.Visible = True
            Me.Button7.Visible = True
            Me.Button3.Visible = True
            Me.Button4.Visible = True
            Me.Button5.Visible = True
        ElseIf setNum.Text = "3" Then
            Me.Button1.Visible = False
            Me.Button2.Visible = False
            Me.Button3.Visible = False
            Me.Button4.Visible = False
            Me.Button5.Visible = False
            Me.Button6.Visible = False
            Me.Button7.Visible = False

            Me.Button1.Visible = True
            Me.Button7.Visible = True
            Me.Button3.Visible = True
            Me.Button6.Visible = True
            Me.Button5.Visible = True
        ElseIf setNum.Text = "4" Then
            Me.Button1.Visible = False
            Me.Button2.Visible = False
            Me.Button3.Visible = False
            Me.Button4.Visible = False
            Me.Button5.Visible = False
            Me.Button6.Visible = False
            Me.Button7.Visible = False

            Me.Button2.Visible = True
            Me.Button6.Visible = True
            Me.Button3.Visible = True
            Me.Button7.Visible = True

        ElseIf setNum.Text = "5" Then
            Me.Button1.Visible = False
            Me.Button2.Visible = False
            Me.Button3.Visible = False
            Me.Button4.Visible = False
            Me.Button5.Visible = False
            Me.Button6.Visible = False
            Me.Button7.Visible = False

            Me.Button1.Visible = True
            Me.Button2.Visible = True
            Me.Button3.Visible = True
            Me.Button6.Visible = True
            Me.Button5.Visible = True
        ElseIf setNum.Text = "6" Then
            Me.Button1.Visible = False
            Me.Button2.Visible = False
            Me.Button3.Visible = False
            Me.Button4.Visible = False
            Me.Button5.Visible = False
            Me.Button6.Visible = False
            Me.Button7.Visible = False

            Me.Button1.Visible = True
            Me.Button2.Visible = True
            Me.Button3.Visible = True
            Me.Button6.Visible = True
            Me.Button5.Visible = True
            Me.Button4.Visible = True
        ElseIf setNum.Text = "7" Then
            Me.Button1.Visible = False
            Me.Button2.Visible = False
            Me.Button3.Visible = False
            Me.Button4.Visible = False
            Me.Button5.Visible = False
            Me.Button6.Visible = False
            Me.Button7.Visible = False

            Me.Button1.Visible = True
            Me.Button7.Visible = True
            Me.Button6.Visible = True

        ElseIf setNum.Text = "8" Then
            Me.Button1.Visible = True
            Me.Button2.Visible = True
            Me.Button3.Visible = True
            Me.Button4.Visible = True
            Me.Button5.Visible = True
            Me.Button6.Visible = True
            Me.Button7.Visible = True

        ElseIf setNum.Text = "9" Then
            Me.Button1.Visible = False
            Me.Button2.Visible = False
            Me.Button3.Visible = False
            Me.Button4.Visible = False
            Me.Button5.Visible = False
            Me.Button6.Visible = False
            Me.Button7.Visible = False

            Me.Button1.Visible = True
            Me.Button2.Visible = True
            Me.Button3.Visible = True

            Me.Button5.Visible = True
            Me.Button6.Visible = True
            Me.Button7.Visible = True
        ElseIf setNum.Text = "0" Then
            Me.Button1.Visible = False
            Me.Button2.Visible = False
            Me.Button3.Visible = False
            Me.Button4.Visible = False
            Me.Button5.Visible = False
            Me.Button6.Visible = False
            Me.Button7.Visible = False

            Me.Button1.Visible = True
            Me.Button2.Visible = True

            Me.Button4.Visible = True
            Me.Button5.Visible = True
            Me.Button6.Visible = True
            Me.Button7.Visible = True
        ElseIf setNum.Text = "" Then
            Me.Button1.Visible = False
            Me.Button2.Visible = False
            Me.Button3.Visible = False
            Me.Button4.Visible = False
            Me.Button5.Visible = False
            Me.Button6.Visible = False
            Me.Button7.Visible = False
        End If
    End Sub

    Private Sub Start_Click(sender As Object, e As EventArgs) Handles Start.Click
        Timer1.Interval = 1000
        Timer1.Start()
        If setNum.Text IsNot "" Then
            count = CInt(setNum.Text)
        End If
        setNum.Enabled = False

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        count = count + 1
        If count Mod 10 = 1 Then
            Me.Button1.Visible = False
            Me.Button2.Visible = False
            Me.Button3.Visible = False
            Me.Button4.Visible = False
            Me.Button5.Visible = False
            Me.Button6.Visible = False
            Me.Button7.Visible = False

            Me.Button6.Visible = True
            Me.Button7.Visible = True
        ElseIf count Mod 10 = 2 Then
            Me.Button1.Visible = False
            Me.Button2.Visible = False
            Me.Button3.Visible = False
            Me.Button4.Visible = False
            Me.Button5.Visible = False
            Me.Button6.Visible = False
            Me.Button7.Visible = False

            Me.Button1.Visible = True
            Me.Button7.Visible = True
            Me.Button3.Visible = True
            Me.Button4.Visible = True
            Me.Button5.Visible = True
        ElseIf count Mod 10 = 3 Then
            Me.Button1.Visible = False
            Me.Button2.Visible = False
            Me.Button3.Visible = False
            Me.Button4.Visible = False
            Me.Button5.Visible = False
            Me.Button6.Visible = False
            Me.Button7.Visible = False

            Me.Button1.Visible = True
            Me.Button7.Visible = True
            Me.Button3.Visible = True
            Me.Button6.Visible = True
            Me.Button5.Visible = True
        ElseIf count Mod 10 = 4 Then
            Me.Button1.Visible = False
            Me.Button2.Visible = False
            Me.Button3.Visible = False
            Me.Button4.Visible = False
            Me.Button5.Visible = False
            Me.Button6.Visible = False
            Me.Button7.Visible = False

            Me.Button2.Visible = True
            Me.Button6.Visible = True
            Me.Button3.Visible = True
            Me.Button7.Visible = True

        ElseIf count Mod 10 = 5 Then
            Me.Button1.Visible = False
            Me.Button2.Visible = False
            Me.Button3.Visible = False
            Me.Button4.Visible = False
            Me.Button5.Visible = False
            Me.Button6.Visible = False
            Me.Button7.Visible = False

            Me.Button1.Visible = True
            Me.Button2.Visible = True
            Me.Button3.Visible = True
            Me.Button6.Visible = True
            Me.Button5.Visible = True
        ElseIf count Mod 10 = 6 Then
            Me.Button1.Visible = False
            Me.Button2.Visible = False
            Me.Button3.Visible = False
            Me.Button4.Visible = False
            Me.Button5.Visible = False
            Me.Button6.Visible = False
            Me.Button7.Visible = False

            Me.Button1.Visible = True
            Me.Button2.Visible = True
            Me.Button3.Visible = True
            Me.Button6.Visible = True
            Me.Button5.Visible = True
            Me.Button4.Visible = True
        ElseIf count Mod 10 = 7 Then
            Me.Button1.Visible = False
            Me.Button2.Visible = False
            Me.Button3.Visible = False
            Me.Button4.Visible = False
            Me.Button5.Visible = False
            Me.Button6.Visible = False
            Me.Button7.Visible = False

            Me.Button1.Visible = True
            Me.Button7.Visible = True
            Me.Button6.Visible = True

        ElseIf count Mod 10 = 8 Then
            Me.Button1.Visible = True
            Me.Button2.Visible = True
            Me.Button3.Visible = True
            Me.Button4.Visible = True
            Me.Button5.Visible = True
            Me.Button6.Visible = True
            Me.Button7.Visible = True

        ElseIf count Mod 10 = 9 Then
            Me.Button1.Visible = False
            Me.Button2.Visible = False
            Me.Button3.Visible = False
            Me.Button4.Visible = False
            Me.Button5.Visible = False
            Me.Button6.Visible = False
            Me.Button7.Visible = False

            Me.Button1.Visible = True
            Me.Button2.Visible = True
            Me.Button3.Visible = True

            Me.Button5.Visible = True
            Me.Button6.Visible = True
            Me.Button7.Visible = True
        ElseIf count Mod 10 = 0 Then
            Me.Button1.Visible = False
            Me.Button2.Visible = False
            Me.Button3.Visible = False
            Me.Button4.Visible = False
            Me.Button5.Visible = False
            Me.Button6.Visible = False
            Me.Button7.Visible = False

            Me.Button1.Visible = True
            Me.Button2.Visible = True

            Me.Button4.Visible = True
            Me.Button5.Visible = True
            Me.Button6.Visible = True
            Me.Button7.Visible = True
        End If
    End Sub

    Private Sub stap_Click(sender As Object, e As EventArgs) Handles stap.Click
        Timer1.Stop()
        setNum.Enabled = True


    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        count = 0
        Me.Button1.Visible = False
        Me.Button2.Visible = False
        Me.Button3.Visible = False
        Me.Button4.Visible = False
        Me.Button5.Visible = False
        Me.Button6.Visible = False
        Me.Button7.Visible = False

        Me.Button1.Visible = True
        Me.Button2.Visible = True

        Me.Button4.Visible = True
        Me.Button5.Visible = True
        Me.Button6.Visible = True
        Me.Button7.Visible = True
    End Sub



End Class
