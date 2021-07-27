<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InvoiceMenuForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InvoiceMenuForm))
        Me.TopSliderPanel = New System.Windows.Forms.Panel()
        Me.HeadingLabel = New System.Windows.Forms.Label()
        Me.MinimizeButton = New System.Windows.Forms.Button()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.SaveInvoiceButton = New System.Windows.Forms.Button()
        Me.TopPanel = New System.Windows.Forms.Panel()
        Me.TopPanelExpand = New System.Windows.Forms.Panel()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.BottomPanelExpand = New System.Windows.Forms.Panel()
        Me.InvoiceRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.PrintInvoiceButton = New System.Windows.Forms.Button()
        Me.BottomPanel = New System.Windows.Forms.Panel()
        Me.MidPanel = New System.Windows.Forms.Panel()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.GoBackButton = New System.Windows.Forms.Button()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TopPanel.SuspendLayout()
        Me.TopPanelExpand.SuspendLayout()
        Me.BottomPanelExpand.SuspendLayout()
        Me.BottomPanel.SuspendLayout()
        Me.MidPanel.SuspendLayout()
        Me.SuspendLayout()
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
        'SaveInvoiceButton
        '
        Me.SaveInvoiceButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.SaveInvoiceButton.FlatAppearance.BorderSize = 0
        Me.SaveInvoiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveInvoiceButton.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SaveInvoiceButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.SaveInvoiceButton.Location = New System.Drawing.Point(14, 330)
        Me.SaveInvoiceButton.Name = "SaveInvoiceButton"
        Me.SaveInvoiceButton.Size = New System.Drawing.Size(168, 34)
        Me.SaveInvoiceButton.TabIndex = 15
        Me.SaveInvoiceButton.Text = "Save Invoice"
        Me.SaveInvoiceButton.UseVisualStyleBackColor = False
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
        'BottomPanelExpand
        '
        Me.BottomPanelExpand.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.BottomPanelExpand.Controls.Add(Me.GoBackButton)
        Me.BottomPanelExpand.Controls.Add(Me.InvoiceRichTextBox)
        Me.BottomPanelExpand.Controls.Add(Me.PrintInvoiceButton)
        Me.BottomPanelExpand.Controls.Add(Me.SaveInvoiceButton)
        Me.BottomPanelExpand.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BottomPanelExpand.Location = New System.Drawing.Point(0, 0)
        Me.BottomPanelExpand.Name = "BottomPanelExpand"
        Me.BottomPanelExpand.Size = New System.Drawing.Size(377, 420)
        Me.BottomPanelExpand.TabIndex = 0
        '
        'InvoiceRichTextBox
        '
        Me.InvoiceRichTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.InvoiceRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.InvoiceRichTextBox.Location = New System.Drawing.Point(14, 6)
        Me.InvoiceRichTextBox.Name = "InvoiceRichTextBox"
        Me.InvoiceRichTextBox.Size = New System.Drawing.Size(349, 309)
        Me.InvoiceRichTextBox.TabIndex = 17
        Me.InvoiceRichTextBox.Text = "*********************************************************" & Global.Microsoft.VisualBasic.ChrW(10) & "***********************" &
    "**********************************"
        '
        'PrintInvoiceButton
        '
        Me.PrintInvoiceButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.PrintInvoiceButton.FlatAppearance.BorderSize = 0
        Me.PrintInvoiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PrintInvoiceButton.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PrintInvoiceButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.PrintInvoiceButton.Location = New System.Drawing.Point(195, 330)
        Me.PrintInvoiceButton.Name = "PrintInvoiceButton"
        Me.PrintInvoiceButton.Size = New System.Drawing.Size(168, 34)
        Me.PrintInvoiceButton.TabIndex = 16
        Me.PrintInvoiceButton.Text = "Print Invoice"
        Me.PrintInvoiceButton.UseVisualStyleBackColor = False
        '
        'BottomPanel
        '
        Me.BottomPanel.Controls.Add(Me.BottomPanelExpand)
        Me.BottomPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BottomPanel.Location = New System.Drawing.Point(0, 176)
        Me.BottomPanel.Name = "BottomPanel"
        Me.BottomPanel.Size = New System.Drawing.Size(377, 420)
        Me.BottomPanel.TabIndex = 1
        '
        'MidPanel
        '
        Me.MidPanel.Controls.Add(Me.BottomPanel)
        Me.MidPanel.Controls.Add(Me.TopPanel)
        Me.MidPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MidPanel.Location = New System.Drawing.Point(0, 0)
        Me.MidPanel.Name = "MidPanel"
        Me.MidPanel.Size = New System.Drawing.Size(377, 596)
        Me.MidPanel.TabIndex = 4
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'GoBackButton
        '
        Me.GoBackButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.GoBackButton.FlatAppearance.BorderSize = 0
        Me.GoBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GoBackButton.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GoBackButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.GoBackButton.Location = New System.Drawing.Point(14, 374)
        Me.GoBackButton.Name = "GoBackButton"
        Me.GoBackButton.Size = New System.Drawing.Size(349, 34)
        Me.GoBackButton.TabIndex = 18
        Me.GoBackButton.Text = "Go Back"
        Me.GoBackButton.UseVisualStyleBackColor = False
        '
        'InvoiceMenuForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(377, 596)
        Me.Controls.Add(Me.MidPanel)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "InvoiceMenuForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Boat Solutions"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TopPanel.ResumeLayout(False)
        Me.TopPanelExpand.ResumeLayout(False)
        Me.TopPanelExpand.PerformLayout()
        Me.BottomPanelExpand.ResumeLayout(False)
        Me.BottomPanel.ResumeLayout(False)
        Me.MidPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TopSliderPanel As Panel
    Friend WithEvents HeadingLabel As Label
    Friend WithEvents MinimizeButton As Button
    Friend WithEvents LogoPictureBox As PictureBox
    Friend WithEvents SaveInvoiceButton As Button
    Friend WithEvents TopPanel As Panel
    Friend WithEvents TopPanelExpand As Panel
    Friend WithEvents ExitButton As Button
    Friend WithEvents BottomPanelExpand As Panel
    Friend WithEvents InvoiceRichTextBox As RichTextBox
    Friend WithEvents PrintInvoiceButton As Button
    Friend WithEvents BottomPanel As Panel
    Friend WithEvents MidPanel As Panel
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents GoBackButton As Button
End Class
