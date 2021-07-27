Imports System.IO
Imports System.Drawing

Public Class InvoiceMenuForm
    Private Sub InvoiceMenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InvoiceRichTextBox.Text = $"*********************************************************" & vbCrLf & "INVOICE" & vbCrLf & "*********************************************************" & vbCrLf & $"Buyer: {BoatSearchingForm.firstName} {BoatSearchingForm.secondName}" & vbCrLf & $"Price: {BoatResultsForm.totalPrice}" & vbCrLf & $"How Many Hours: {BoatResultsForm.numberOfHours}" & vbCrLf & $"Boat Type: {BoatSearchingForm.boatTypeString}" & vbCrLf & $"Location: {BoatSearchingForm.locationOrCityString}" & vbCrLf & $"Payment Date: {DateTime.Now}" & vbCrLf & "*********************************************************"
    End Sub

    Private Sub SaveInvoiceButton_Click(sender As Object, e As EventArgs) Handles SaveInvoiceButton.Click
        Dim fileWriter As StreamWriter
        Dim results As DialogResult
        SaveFileDialog1.DefaultExt = ".txt"
        SaveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*"
        results = SaveFileDialog1.ShowDialog()

        If results = DialogResult.OK Then
            fileWriter = New StreamWriter(SaveFileDialog1.FileName, False)
            fileWriter.Write(InvoiceRichTextBox.Text)
            fileWriter.Close()
        End If
    End Sub

    Private Sub PrintInvoiceButton_Click(sender As Object, e As EventArgs) Handles PrintInvoiceButton.Click
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font As New Font("Century Gothic", 12, FontStyle.Bold)
        e.Graphics.DrawString(InvoiceRichTextBox.Text, font, Brushes.Black, 100, 100)
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Application.Exit()
    End Sub

    Private Sub MinimizeButton_Click(sender As Object, e As EventArgs) Handles MinimizeButton.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub GoBackButton_Click(sender As Object, e As EventArgs) Handles GoBackButton.Click
        Me.Hide()
        BoatSearchingForm.Show()
    End Sub
End Class