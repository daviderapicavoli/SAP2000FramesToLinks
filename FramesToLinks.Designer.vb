<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FramesToLinks
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbxLinkProperties = New System.Windows.Forms.ComboBox()
        Me.ButtonFrameToLink = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.cbxLinkProperties)
        Me.GroupBox2.Controls.Add(Me.ButtonFrameToLink)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(385, 98)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Convert Frames to Links"
        '
        'cbxLinkProperties
        '
        Me.cbxLinkProperties.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxLinkProperties.FormattingEnabled = True
        Me.cbxLinkProperties.Location = New System.Drawing.Point(96, 28)
        Me.cbxLinkProperties.Name = "cbxLinkProperties"
        Me.cbxLinkProperties.Size = New System.Drawing.Size(283, 21)
        Me.cbxLinkProperties.TabIndex = 2
        '
        'ButtonFrameToLink
        '
        Me.ButtonFrameToLink.Location = New System.Drawing.Point(96, 55)
        Me.ButtonFrameToLink.Name = "ButtonFrameToLink"
        Me.ButtonFrameToLink.Size = New System.Drawing.Size(283, 23)
        Me.ButtonFrameToLink.TabIndex = 1
        Me.ButtonFrameToLink.Text = "Convert Frames to Links"
        Me.ButtonFrameToLink.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Link property"
        '
        'FramesToLinks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 125)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FramesToLinks"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FramesToLinks"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
    Friend WithEvents cbxLinkProperties As Windows.Forms.ComboBox
    Friend WithEvents ButtonFrameToLink As Windows.Forms.Button
    Friend WithEvents Label1 As Windows.Forms.Label
End Class
