<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BoatResultsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BoatResultsForm))
        Me.MinimizeButton = New System.Windows.Forms.Button()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.PayButton = New System.Windows.Forms.Button()
        Me.CalculatePriceButton = New System.Windows.Forms.Button()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SalesTaxTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NumberOfHoursTextBox = New System.Windows.Forms.TextBox()
        Me.TopSliderPanel = New System.Windows.Forms.Panel()
        Me.HeadingLabel = New System.Windows.Forms.Label()
        Me.BottomPanel = New System.Windows.Forms.Panel()
        Me.BottomPanelExpand = New System.Windows.Forms.Panel()
        Me.GoBackButton = New System.Windows.Forms.Button()
        Me.HourlyRateTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TopPanel = New System.Windows.Forms.Panel()
        Me.TopPanelExpand = New System.Windows.Forms.Panel()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.MidPanel = New System.Windows.Forms.Panel()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BottomPanel.SuspendLayout()
        Me.BottomPanelExpand.SuspendLayout()
        Me.TopPanel.SuspendLayout()
        Me.TopPanelExpand.SuspendLayout()
        Me.MidPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MinimizeButton
        '
        Me.MinimizeButton.FlatAppearance.BorderSize = 0
        Me.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MinimizeButton.Image = CType(resources.GetObject("MinimizeButton.Image"), System.Drawing.Image)
        Me.MinimizeButton.Location = New System.Drawing.Point(309, 12)
        Me.MinimizeButton.Name = "MinimizeButton"
        Me.MinimizeButton.Size = New System.Drawing.Size(25, 25)
        Me.MinimizeButton.TabIndex = 1
        Me.MinimizeButton.UseVisualStyleBackColor = True
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(126, 16)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(125, 125)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'PayButton
        '
        Me.PayButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.PayButton.Enabled = False
        Me.PayButton.FlatAppearance.BorderSize = 0
        Me.PayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PayButton.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PayButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.PayButton.Location = New System.Drawing.Point(192, 334)
        Me.PayButton.Name = "PayButton"
        Me.PayButton.Size = New System.Drawing.Size(154, 34)
        Me.PayButton.TabIndex = 13
        Me.PayButton.Text = "Pay"
        Me.PayButton.UseVisualStyleBackColor = False
        '
        'CalculatePriceButton
        '
        Me.CalculatePriceButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.CalculatePriceButton.FlatAppearance.BorderSize = 0
        Me.CalculatePriceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CalculatePriceButton.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CalculatePriceButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.CalculatePriceButton.Location = New System.Drawing.Point(31, 334)
        Me.CalculatePriceButton.Name = "CalculatePriceButton"
        Me.CalculatePriceButton.Size = New System.Drawing.Size(154, 34)
        Me.CalculatePriceButton.TabIndex = 12
        Me.CalculatePriceButton.Text = "Calculate Price"
        Me.CalculatePriceButton.UseVisualStyleBackColor = False
        '
        'PriceTextBox
        '
        Me.PriceTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.PriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PriceTextBox.Enabled = False
        Me.PriceTextBox.ForeColor = System.Drawing.Color.White
        Me.PriceTextBox.Location = New System.Drawing.Point(31, 287)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(315, 27)
        Me.PriceTextBox.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(165, 252)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 19)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Price"
        '
        'SalesTaxTextBox
        '
        Me.SalesTaxTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.SalesTaxTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SalesTaxTextBox.ForeColor = System.Drawing.Color.White
        Me.SalesTaxTextBox.Location = New System.Drawing.Point(31, 209)
        Me.SalesTaxTextBox.Name = "SalesTaxTextBox"
        Me.SalesTaxTextBox.Size = New System.Drawing.Size(315, 27)
        Me.SalesTaxTextBox.TabIndex = 7
        Me.SalesTaxTextBox.Text = "  Enter Tax Percentage Value:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(149, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 19)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Sales Tax"
        '
        'NumberOfHoursTextBox
        '
        Me.NumberOfHoursTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.NumberOfHoursTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumberOfHoursTextBox.ForeColor = System.Drawing.Color.White
        Me.NumberOfHoursTextBox.Location = New System.Drawing.Point(31, 131)
        Me.NumberOfHoursTextBox.Name = "NumberOfHoursTextBox"
        Me.NumberOfHoursTextBox.Size = New System.Drawing.Size(315, 27)
        Me.NumberOfHoursTextBox.TabIndex = 5
        Me.NumberOfHoursTextBox.Text = "  Enter Number of Hours: "
        '
        'TopSliderPanel
        '
        Me.TopSliderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.TopSliderPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopSliderPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopSliderPanel.Name = "TopSliderPanel"
        Me.TopSliderPanel.Size = New System.Drawing.Size(377, 3)
        Me.TopSliderPanel.TabIndex = 3
        '
        'HeadingLabel
        '
        Me.HeadingLabel.AutoSize = True
        Me.HeadingLabel.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.HeadingLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.HeadingLabel.Location = New System.Drawing.Point(120, 148)
        Me.HeadingLabel.Name = "HeadingLabel"
        Me.HeadingLabel.Size = New System.Drawing.Size(137, 23)
        Me.HeadingLabel.TabIndex = 2
        Me.HeadingLabel.Text = "Boat Solutions"
        '
        'BottomPanel
        '
        Me.BottomPanel.Controls.Add(Me.BottomPanelExpand)
        Me.BottomPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BottomPanel.Location = New System.Drawing.Point(0, 176)
        Me.BottomPanel.Name = "BottomPanel"
        Me.BottomPanel.Size = New System.Drawing.Size(377, 431)
        Me.BottomPanel.TabIndex = 1
        '
        'BottomPanelExpand
        '
        Me.BottomPanelExpand.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.BottomPanelExpand.Controls.Add(Me.GoBackButton)
        Me.BottomPanelExpand.Controls.Add(Me.HourlyRateTextBox)
        Me.BottomPanelExpand.Controls.Add(Me.PayButton)
        Me.BottomPanelExpand.Controls.Add(Me.CalculatePriceButton)
        Me.BottomPanelExpand.Controls.Add(Me.PriceTextBox)
        Me.BottomPanelExpand.Controls.Add(Me.Label6)
        Me.BottomPanelExpand.Controls.Add(Me.SalesTaxTextBox)
        Me.BottomPanelExpand.Controls.Add(Me.Label5)
        Me.BottomPanelExpand.Controls.Add(Me.NumberOfHoursTextBox)
        Me.BottomPanelExpand.Controls.Add(Me.Label4)
        Me.BottomPanelExpand.Controls.Add(Me.Label2)
        Me.BottomPanelExpand.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BottomPanelExpand.Location = New System.Drawing.Point(0, 0)
        Me.BottomPanelExpand.Name = "BottomPanelExpand"
        Me.BottomPanelExpand.Size = New System.Drawing.Size(377, 431)
        Me.BottomPanelExpand.TabIndex = 0
        '
        'GoBackButton
        '
        Me.GoBackButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.GoBackButton.FlatAppearance.BorderSize = 0
        Me.GoBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GoBackButton.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GoBackButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.GoBackButton.Location = New System.Drawing.Point(31, 383)
        Me.GoBackButton.Name = "GoBackButton"
        Me.GoBackButton.Size = New System.Drawing.Size(315, 34)
        Me.GoBackButton.TabIndex = 15
        Me.GoBackButton.Text = "Go Back"
        Me.GoBackButton.UseVisualStyleBackColor = False
        '
        'HourlyRateTextBox
        '
        Me.HourlyRateTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.HourlyRateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HourlyRateTextBox.ForeColor = System.Drawing.Color.White
        Me.HourlyRateTextBox.Location = New System.Drawing.Point(31, 53)
        Me.HourlyRateTextBox.Name = "HourlyRateTextBox"
        Me.HourlyRateTextBox.Size = New System.Drawing.Size(315, 27)
        Me.HourlyRateTextBox.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(120, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Number of Hours"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(140, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Hourly Rate"
        '
        'TopPanel
        '
        Me.TopPanel.Controls.Add(Me.TopPanelExpand)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(377, 176)
        Me.TopPanel.TabIndex = 0
        '
        'TopPanelExpand
        '
        Me.TopPanelExpand.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.TopPanelExpand.Controls.Add(Me.TopSliderPanel)
        Me.TopPanelExpand.Controls.Add(Me.HeadingLabel)
        Me.TopPanelExpand.Controls.Add(Me.MinimizeButton)
        Me.TopPanelExpand.Controls.Add(Me.ExitButton)
        Me.TopPanelExpand.Controls.Add(Me.LogoPictureBox)
        Me.TopPanelExpand.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TopPanelExpand.Location = New System.Drawing.Point(0, 0)
        Me.TopPanelExpand.Name = "TopPanelExpand"
        Me.TopPanelExpand.Size = New System.Drawing.Size(377, 176)
        Me.TopPanelExpand.TabIndex = 0
        '
        'ExitButton
        '
        Me.ExitButton.FlatAppearance.BorderSize = 0
        Me.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitButton.Image = CType(resources.GetObject("ExitButton.Image"), System.Drawing.Image)
        Me.ExitButton.Location = New System.Drawing.Point(340, 12)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(25, 25)
        Me.ExitButton.TabIndex = 0
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'MidPanel
        '
        Me.MidPanel.Controls.Add(Me.BottomPanel)
        Me.MidPanel.Controls.Add(Me.TopPanel)
        Me.MidPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MidPanel.Location = New System.Drawing.Point(0, 0)
        Me.MidPanel.Name = "MidPanel"
        Me.MidPanel.Size = New System.Drawing.Size(377, 607)
        Me.MidPanel.TabIndex = 2
        '
        'BoatResultsForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(377, 607)
        Me.Controls.Add(Me.MidPanel)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BoatResultsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Boat Solutions"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BottomPanel.ResumeLayout(False)
        Me.BottomPanelExpand.ResumeLayout(False)
        Me.BottomPanelExpand.PerformLayout()
        Me.TopPanel.ResumeLayout(False)
        Me.TopPanelExpand.ResumeLayout(False)
        Me.TopPanelExpand.PerformLayout()
        Me.MidPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MinimizeButton As Button
    Friend WithEvents LogoPictureBox As PictureBox
    Friend WithEvents PayButton As Button
    Friend WithEvents CalculatePriceButton As Button
    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents SalesTaxTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents NumberOfHoursTextBox As TextBox
    Friend WithEvents TopSliderPanel As Panel
    Friend WithEvents HeadingLabel As Label
    Friend WithEvents BottomPanel As Panel
    Friend WithEvents BottomPanelExpand As Panel
    Friend WithEvents GoBackButton As Button
    Friend WithEvents HourlyRateTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TopPanel As Panel
    Friend WithEvents TopPanelExpand As Panel
    Friend WithEvents ExitButton As Button
    Friend WithEvents MidPanel As Panel
End Class
