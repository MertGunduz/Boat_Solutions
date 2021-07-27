Public Class BoatResultsForm

    Private hourlyRate As Double = BoatSearchingForm.boatPrice
    Public Shared numberOfHours As Double
    Private salesTax As Double
    Public Shared totalPrice As Double

    Private Sub BoatResultsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HourlyRateTextBox.Text = BoatSearchingForm.boatPrice
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Application.Exit()
    End Sub

    Private Sub MinimizeButton_Click(sender As Object, e As EventArgs) Handles MinimizeButton.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub CalculatePriceButton_Click(sender As Object, e As EventArgs) Handles CalculatePriceButton.Click
        PayButton.Enabled = True
        numberOfHours = Convert.ToDouble(NumberOfHoursTextBox.Text)
        salesTax = Convert.ToDouble(SalesTaxTextBox.Text)
        totalPrice = numberOfHours * hourlyRate
        totalPrice = totalPrice + (totalPrice * (salesTax / 100))
        PriceTextBox.Text = "$" + totalPrice.ToString()
    End Sub

    Private Sub NumberOfHoursTextBox_MouseClick(sender As Object, e As MouseEventArgs) Handles NumberOfHoursTextBox.MouseClick
        If (NumberOfHoursTextBox.Text = "  Enter Number of Hours: ") Then
            NumberOfHoursTextBox.Clear()
        End If
    End Sub

    Private Sub SalesTaxTextBox_MouseClick(sender As Object, e As MouseEventArgs) Handles SalesTaxTextBox.MouseClick
        If (SalesTaxTextBox.Text = "  Enter Tax Percentage Value:") Then
            SalesTaxTextBox.Clear()
        End If
    End Sub

    Private Sub GoBackButton_Click(sender As Object, e As EventArgs) Handles GoBackButton.Click
        Me.Hide()
        BoatSearchingForm.Show()
    End Sub

    Private Sub PayButton_Click(sender As Object, e As EventArgs) Handles PayButton.Click
        Me.Hide()
        PayMenuForm.Show()
    End Sub
End Class