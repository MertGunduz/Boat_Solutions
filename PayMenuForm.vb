Public Class PayMenuForm

    Dim firstCardOctet As String
    Dim secondCardOctet As String
    Dim thirdCardOctet As String
    Dim fourthCardOctet As String

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Application.Exit()
    End Sub

    Private Sub MinimizeButton_Click(sender As Object, e As EventArgs) Handles MinimizeButton.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PayMenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TotalAmountPaidForServicesTextBox.Text = "$" + BoatResultsForm.totalPrice.ToString()
    End Sub

    Private Sub CardNumberTextBox_TextChanged(sender As Object, e As EventArgs) Handles CardNumberTextBox.TextChanged
        If CardNumberTextBox.Text.Length = 16 Then
            Dim i As Integer
            For i = 0 To CardNumberTextBox.Text.Length - 1
                If i <= 3 Then
                    firstCardOctet = firstCardOctet + CardNumberTextBox.Text.Chars(i)
                ElseIf i <= 7 Then
                    secondCardOctet = secondCardOctet + CardNumberTextBox.Text.Chars(i)
                ElseIf i <= 11 Then
                    thirdCardOctet = thirdCardOctet + CardNumberTextBox.Text.Chars(i)
                ElseIf i <= 15 Then
                    fourthCardOctet = fourthCardOctet + CardNumberTextBox.Text.Chars(i)
                End If
            Next
            CardNumberTextBox.Text = firstCardOctet + " " + secondCardOctet + " " + thirdCardOctet + " " + fourthCardOctet
        End If
        If CardNumberTextBox.Text.Length = 0 Then
            firstCardOctet = ""
            secondCardOctet = ""
            thirdCardOctet = ""
            fourthCardOctet = ""
        End If
    End Sub

    Private Sub ConfirmPaymentButton_Click(sender As Object, e As EventArgs) Handles ConfirmPaymentButton.Click
        If CardNumberTextBox.Text IsNot "" And ExpirationDateOfCardTextBox.Text IsNot "" And CVVTextBox.Text IsNot "" Then
            Me.Hide()
            InvoiceMenuForm.Show()
        End If
    End Sub
End Class