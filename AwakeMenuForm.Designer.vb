<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AwakeMenuForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AwakeMenuForm))
        Me.MidPanel = New System.Windows.Forms.Panel()
        Me.MainLogoPicture = New System.Windows.Forms.PictureBox()
        Me.AwakeTimer = New System.Windows.Forms.Timer(Me.components)
        Me.MidPanel.SuspendLayout()
        CType(Me.MainLogoPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MidPanel
        '
        Me.MidPanel.Controls.Add(Me.MainLogoPicture)
        Me.MidPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MidPanel.Location = New System.Drawing.Point(0, 0)
        Me.MidPanel.Name = "MidPanel"
        Me.MidPanel.Size = New System.Drawing.Size(1025, 450)
        Me.MidPanel.TabIndex = 0
        '
        'MainLogoPicture
        '
        Me.MainLogoPicture.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainLogoPicture.Image = CType(resources.GetObject("MainLogoPicture.Image"), System.Drawing.Image)
        Me.MainLogoPicture.Location = New System.Drawing.Point(0, 0)
        Me.MainLogoPicture.Name = "MainLogoPicture"
        Me.MainLogoPicture.Size = New System.Drawing.Size(1025, 450)
        Me.MainLogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MainLogoPicture.TabIndex = 0
        Me.MainLogoPicture.TabStop = False
        '
        'AwakeTimer
        '
        Me.AwakeTimer.Interval = 10
        '
        'AwakeMenuForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1025, 450)
        Me.Controls.Add(Me.MidPanel)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AwakeMenuForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Boat Solutions"
        Me.MidPanel.ResumeLayout(False)
        CType(Me.MainLogoPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MidPanel As Panel
    Friend WithEvents MainLogoPicture As PictureBox
    Friend WithEvents AwakeTimer As Timer
End Class
