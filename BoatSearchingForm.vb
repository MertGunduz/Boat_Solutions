Imports System.IO

Public Class BoatSearchingForm

    'All Datas
    Private dateTime As DateTime = DateTime.Now
    Private dateTimeString As String
    Private boatType As String
    Private numberOfPassengers As String
    Private locationOrCity As String
    Private timeChecker As Integer
    Private correctLine As String
    Private substringedCorrectFormat As String
    Private finalPrice As String
    Private isBoatFound As Boolean
    Private isDollarSignCome As Boolean
    Private boatPriceString As String
    Public Shared boatPrice As Integer
    Public Shared firstName As String
    Public Shared secondName As String
    Public Shared boatTypeString As String
    Public Shared locationOrCityString As String

    Private Sub BoatSearchingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Application.Exit()
    End Sub

    Private Sub MinimizeButton_Click(sender As Object, e As EventArgs) Handles MinimizeButton.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        Try
            dateTimeString = DatePicker.Value.ToString()
            boatType = BoatTypeComboBox.Text.ToString()
            numberOfPassengers = NumberOfPassengersTextBox.Text
            locationOrCity = CityAndLocationComboBox.Text.ToString()

            Dim rawCSV As String() = File.ReadAllLines("C:\BoatSolutionsValues.csv")

            Dim i As Integer
            For i = 0 To rawCSV.Length
                timeChecker = timeChecker + 1

                If rawCSV(i).Contains(boatType) And rawCSV(i).Contains(numberOfPassengers) And rawCSV(i).Contains(locationOrCity) Then
                    locationOrCityString = CityAndLocationComboBox.Text
                    boatTypeString = BoatTypeComboBox.Text
                    firstName = FirstNameTextBox.Text
                    secondName = LastNameTextBox.Text
                    correctLine = rawCSV(i).ToString()
                    isBoatFound = True
                    Exit For
                End If

                If timeChecker = rawCSV.Length Then
                    If Not rawCSV(i).Contains(boatType) And Not rawCSV(i).Contains(numberOfPassengers) And Not rawCSV(i).Contains(locationOrCity) Then
                        MessageBox.Show("No Records Found!\n\nPlease Try An Other Search!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        DatePicker.Value = dateTime
                        BoatTypeComboBox.Text = "  Select The Boat Type"
                        NumberOfPassengersTextBox.Clear()
                        FirstNameTextBox.Clear()
                        LastNameTextBox.Clear()
                        CityAndLocationComboBox.Text = "  Select The Location"
                    End If
                    timeChecker = 0
                End If

            Next

            If isBoatFound = True Then
                If correctLine.Contains("$") Then
                    Dim indexer As Integer
                    For indexer = 0 To correctLine.Length - 1
                        If (correctLine.Chars(indexer) = "$") Then
                            isDollarSignCome = True
                        End If
                        If isDollarSignCome = True Then
                            boatPriceString = boatPriceString + correctLine.Chars(indexer)
                        End If
                    Next
                End If
                substringedCorrectFormat = boatPriceString.Substring(1)

                Dim ae As Integer
                For ae = 0 To substringedCorrectFormat.Length - 1
                    If substringedCorrectFormat.Chars(ae) = "1" Or substringedCorrectFormat.Chars(ae) = "2" Or substringedCorrectFormat.Chars(ae) = "3" Or substringedCorrectFormat.Chars(ae) = "4" Or substringedCorrectFormat.Chars(ae) = "5" Or substringedCorrectFormat.Chars(ae) = "6" Or substringedCorrectFormat.Chars(ae) = "7" Or substringedCorrectFormat.Chars(ae) = "8" Or substringedCorrectFormat.Chars(ae) = "9" Or substringedCorrectFormat.Chars(ae) = "0" Then
                        finalPrice = finalPrice + substringedCorrectFormat.Chars(ae)
                    End If
                Next
                boatPrice = Convert.ToInt32(finalPrice)
                Me.Hide()
                BoatResultsForm.Show()
            End If
        Catch ex As Exception
            MessageBox.Show("No Records Found!" & vbCrLf & vbCrLf & "Please Try An Other Search!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ClearFieldsButton_Click(sender As Object, e As EventArgs) Handles ClearFieldsButton.Click
        DatePicker.Value = dateTime
        BoatTypeComboBox.Text = "  Select The Boat Type"
        NumberOfPassengersTextBox.Clear()
        FirstNameTextBox.Clear()
        LastNameTextBox.Clear()
        CityAndLocationComboBox.Text = "  Select The Location"
    End Sub
End Class