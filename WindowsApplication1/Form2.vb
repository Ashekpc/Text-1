﻿Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("再怎么试也是一样的")
        Me.Hide()
        Form1.Show()
    End Sub
End Class