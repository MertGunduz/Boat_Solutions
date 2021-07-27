<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PayMenuForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PayMenuForm))
        Me.MidPanel = New System.Windows.Forms.Panel()
        Me.BottomPanel = New System.Windows.Forms.Panel()
        Me.BottomPanelExpand = New System.Windows.Forms.Panel()
        Me.ConfirmPaymentButton = New System.Windows.Forms.Button()
        Me.CardNumberTextBox = New System.Windows.Forms.TextBox()
        Me.TotalAmountPaidForServicesTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CVVTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ExpirationDateOfCardTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TopPanel = New System.Windows.Forms.Panel()
        Me.TopPanelExpand = New System.Windows.Forms.Panel()
        Me.TopSliderPanel = New System.Windows.Forms.Panel()
        Me.HeadingLabel = New System.Windows.Forms.Label()
        Me.MinimizeButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.MidPanel.SuspendLayout()
        Me.BottomPanel.SuspendLayout()
        Me.BottomPanelExpand.SuspendLayout()
        Me.TopPanel.SuspendLayout()
        Me.TopPanelExpand.SuspendLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MidPanel
        '
        Me.MidPanel.Controls.Add(Me.BottomPanel)
        Me.MidPanel.Controls.Add(Me.TopPanel)
        Me.MidPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MidPanel.Location = New System.Drawing.Point(0, 0)
        Me.MidPanel.Name = "MidPanel"
        Me.MidPanel.Size = New System.Drawing.Size(377, 558)
        Me.MidPanel.TabIndex = 3
        '
        'BottomPanel
        '
        Me.BottomPanel.Controls.Add(Me.BottomPanelExpand)
        Me.BottomPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BottomPanel.Location = New System.Drawing.Point(0, 176)
        Me.BottomPanel.Name = "BottomPanel"
        Me.BottomPanel.Size = New System.Drawing.Size(377, 382)
        Me.BottomPanel.TabIndex = 1
        '
        'BottomPanelExpand
        '
        Me.BottomPanelExpand.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.BottomPanelExpand.Controls.Add(Me.ConfirmPaymentButton)
        Me.BottomPanelExpand.Controls.Add(Me.CardNumberTextBox)
        Me.BottomPanelExpand.Controls.Add(Me.TotalAmountPaidForServicesTextBox)
        Me.BottomPanelExpand.Controls.Add(Me.Label6)
        Me.BottomPanelExpand.Controls.Add(Me.CVVTextBox)
        Me.BottomPanelExpand.Controls.Add(Me.Label5)
        Me.BottomPanelExpand.Controls.Add(Me.ExpirationDateOfCardTextBox)
        Me.BottomPanelExpand.Controls.Add(Me.Label4)
        Me.BottomPanelExpand.Controls.Add(Me.Label2)
        Me.BottomPanelExpand.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BottomPanelExpand.Location = New System.Drawing.Point(0, 0)
        Me.BottomPanelExpand.Name = "BottomPanelExpand"
        Me.BottomPanelExpand.Size = New System.Drawing.Size(377, 382)
        Me.BottomPanelExpand.TabIndex = 0
        '
        'ConfirmPaymentButton
        '
        Me.ConfirmPaymentButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ConfirmPaymentButton.FlatAppearance.BorderSize = 0
        Me.ConfirmPaymentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ConfirmPaymentButton.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ConfirmPaymentButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.ConfirmPaymentButton.Location = New System.Drawing.Point(31, 330)
        Me.ConfirmPaymentButton.Name = "ConfirmPaymentButton"
        Me.ConfirmPaymentButton.Size = New System.Drawing.Size(315, 34)
        Me.ConfirmPaymentButton.TabIndex = 15
        Me.ConfirmPaymentButton.Text = "Confirm Payment"
        Me.ConfirmPaymentButton.UseVisualStyleBackColor = False
        '
        'CardNumberTextBox
        '
        Me.CardNumberTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.CardNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CardNumberTextBox.ForeColor = System.Drawing.Color.White
        Me.CardNumberTextBox.Location = New System.Drawing.Point(31, 53)
        Me.CardNumberTextBox.Name = "CardNumberTextBox"
        Me.CardNumberTextBox.Size = New System.Drawing.Size(315, 27)
        Me.CardNumberTextBox.TabIndex = 14
        '
        'TotalAmountPaidForServicesTextBox
        '
        Me.TotalAmountPaidForServicesTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.TotalAmountPaidForServicesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalAmountPaidForServicesTextBox.Enabled = False
        Me.TotalAmountPaidForServicesTextBox.ForeColor = System.Drawing.Color.White
        Me.TotalAmountPaidForServicesTextBox.Location = New System.Drawing.Point(31, 287)
        Me.TotalAmountPaidForServicesTextBox.Name = "TotalAmountPaidForServicesTextBox"
        Me.TotalAmountPaidForServicesTextBox.Size = New System.Drawing.Size(315, 27)
        Me.TotalAmountPaidForServicesTextBox.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(67, 252)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(243, 19)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Total Amount Paid For Services"
        '
        'CVVTextBox
        '
        Me.CVVTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.CVVTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CVVTextBox.ForeColor = System.Drawing.Color.White
        Me.CVVTextBox.Location = New System.Drawing.Point(31, 209)
        Me.CVVTextBox.Name = "CVVTextBox"
        Me.CVVTextBox.Size = New System.Drawing.Size(315, 27)
        Me.CVVTextBox.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(167, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 19)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "CVV"
        '
        'ExpirationDateOfCardTextBox
        '
        Me.ExpirationDateOfCardTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ExpirationDateOfCardTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ExpirationDateOfCardTextBox.ForeColor = System.Drawing.Color.White
        Me.ExpirationDateOfCardTextBox.Location = New System.Drawing.Point(31, 131)
        Me.ExpirationDateOfCardTextBox.Name = "ExpirationDateOfCardTextBox"
        Me.ExpirationDateOfCardTextBox.Size = New System.Drawing.Size(315, 27)
        Me.ExpirationDateOfCardTextBox.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(94, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(189, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Expiration Date Of Card"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(130, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Card Number"
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
        'PayMenuForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(377, 558)
        Me.Controls.Add(Me.MidPanel)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PayMenuForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PayMenuForm"
        Me.MidPanel.ResumeLayout(False)
        Me.BottomPanel.ResumeLayout(False)
        Me.BottomPanelExpand.ResumeLayout(False)
        Me.BottomPanelExpand.PerformLayout()
        Me.TopPanel.ResumeLayout(False)
        Me.TopPanelExpand.ResumeLayout(False)
        Me.TopPanelExpand.PerformLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MidPanel As Panel
    Friend WithEvents BottomPanel As Panel
    Friend WithEvents BottomPanelExpand As Panel
    Friend WithEvents ConfirmPaymentButton As Button
    Friend WithEvents CardNumberTextBox As TextBox
    Friend WithEvents TotalAmountPaidForServicesTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CVVTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ExpirationDateOfCardTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TopPanel As Panel
    Friend WithEvents TopPanelExpand As Panel
    Friend WithEvents TopSliderPanel As Panel
    Friend WithEvents HeadingLabel As Label
    Friend WithEvents MinimizeButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents LogoPictureBox As PictureBox
End Class
