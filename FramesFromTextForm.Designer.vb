<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FramesFromTextForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CreateStructureButton = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonFrameToLink = New System.Windows.Forms.Button()
        Me.cbxLinkProperties = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CreateStructureButton)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(5, -1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(385, 144)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'CreateStructureButton
        '
        Me.CreateStructureButton.Location = New System.Drawing.Point(52, 111)
        Me.CreateStructureButton.Name = "CreateStructureButton"
        Me.CreateStructureButton.Size = New System.Drawing.Size(327, 23)
        Me.CreateStructureButton.TabIndex = 2
        Me.CreateStructureButton.Text = "Create Structure from Text Above"
        Me.CreateStructureButton.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(52, 16)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(327, 89)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "Hello CSI"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Text:"
        '
        'ButtonFrameToLink
        '
        Me.ButtonFrameToLink.Location = New System.Drawing.Point(52, 55)
        Me.ButtonFrameToLink.Name = "ButtonFrameToLink"
        Me.ButtonFrameToLink.Size = New System.Drawing.Size(327, 23)
        Me.ButtonFrameToLink.TabIndex = 1
        Me.ButtonFrameToLink.Text = "Convert Frames to Links"
        Me.ButtonFrameToLink.UseVisualStyleBackColor = True
        '
        'cbxLinkProperties
        '
        Me.cbxLinkProperties.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxLinkProperties.FormattingEnabled = True
        Me.cbxLinkProperties.Location = New System.Drawing.Point(52, 28)
        Me.cbxLinkProperties.Name = "cbxLinkProperties"
        Me.cbxLinkProperties.Size = New System.Drawing.Size(327, 21)
        Me.cbxLinkProperties.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbxLinkProperties)
        Me.GroupBox2.Controls.Add(Me.ButtonFrameToLink)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 149)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(385, 98)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Convert Frames to Links"
        '
        'FramesFromTextForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 255)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FramesFromTextForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frames From Text Plug-in"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CreateStructureButton As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonFrameToLink As Windows.Forms.Button
    Friend WithEvents cbxLinkProperties As Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
End Class
