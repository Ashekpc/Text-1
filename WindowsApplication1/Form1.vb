Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim a As Integer
        a = 0
        Label2.Text = Val(a)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "喜欢" Then
            Me.Hide()
            Form2.Show()
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label2.Text = 0
        Me.Hide()
        Form2.Show()
    End Sub
    Private Sub Button1_MouseMove(sender As Object, e As MouseEventArgs) Handles Button1.MouseMove
        If Val(Label2.Text) = 0 Then
            Label1.Text = "小心别点错咯"
            Button1.Text = "喜欢"
            Label2.Text = Val(Label2.Text) + 1
        End If
        If Val(Label2.Text) = 2 Then
            Label1.Text = "哎呀不用那么执着的"
            Timer1.Interval = 20
            Timer1.Enabled = True
            ' Button1.Left = 10
            ' Button2.Left = 360
            'Label2.Text = Val(Label2.Text) + 1
        End If
        If Val(Label2.Text) = 2 And Val(Button1.Left) < 300 Then
            Label2.Text = Val(Label2.Text) + 1
        End If
        If Val(Label2.Text) = 3 And Val(Button1.Top) = 230 And Val(Button1.Left) = 360 Then
            Label2.Text = Val(Label2.Text) + 1
        End If
        If Val(Label2.Text) = 4 And Val(Button1.Top) < 130 And Val(Button1.Left) = 360 Then
            Label1.Text = "这样真的好吗？"
            Label2.Text = Val(Label2.Text) + 1
        End If
        If Val(Label2.Text) = 5 And Val(Button1.Top) = 230 And Val(Button1.Left) = 360 Then
            Label2.Text = Val(Label2.Text) + 1
            Label1.Text = "不给你点"
            Button1.Enabled = False
        End If

        If Val(Label2.Text) = 6 Then
            'Button1.Top = 230
            Label2.Text = Val(Label2.Text) + 1
        End If
    End Sub
    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If Val(Label2.Text) = 1 Then
            Button1.Text = "不喜欢"
            Label2.Text = Val(Label2.Text) + 1
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Val(Label2.Text) = 2 Then
            If Val(Button1.Left) < 19 Then
                Exit Sub
            ElseIf Val(Button1.Left) <= 360 Then
                Button1.Left = Val(Button1.Left) - 10
            End If
            If Val(Button2.Left) > 360 Then
                Exit Sub
            ElseIf Val(Button1.Left) >= 10 Then
                Button2.Left = Val(Button2.Left) + 10
            End If
        End If
        If Val(Label2.Text) = 3 Then
            If Val(Button2.Left) < 19 Then
                Exit Sub
            ElseIf Val(Button2.Left) <= 360 Then
                Button2.Left = Val(Button2.Left) - 10
            End If
            If Val(Button1.Left) > 360 Then
                Exit Sub
            ElseIf Val(Button1.Left) >= 10 Then
                Button1.Left = Val(Button1.Left) + 10
            End If
        End If
        If Val(Label2.Text) = 4 Then
            If Val(Button1.Top) <= 120 Then
                Exit Sub
            ElseIf Val(Button1.Top) <= 230 Then
                Button1.Top = Val(Button1.Top) - 10
            End If
        End If
        If Val(Label2.Text) = 5 Then
            If Val(Button1.Top) >= 230 Then
                Exit Sub
            ElseIf Val(Button1.Top) > 110 Then
                Button1.Top = Val(Button1.Top) + 10
            End If
        End If
    End Sub
End Class
