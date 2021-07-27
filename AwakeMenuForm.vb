Public Class AwakeMenuForm
    Private Sub AwakeMenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AwakeTimer.Start()
    End Sub

    Dim awakeInt As Integer = 0

    Private Sub AwakeTimer_Tick(sender As Object, e As EventArgs) Handles AwakeTimer.Tick
        awakeInt = awakeInt + 1
        If (awakeInt = 99) Then
            AwakeTimer.Stop()
            Me.Hide()
            BoatSearchingForm.Show()
        End If
    End Sub
End Class