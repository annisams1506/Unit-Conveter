<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UNITCONVERTERS
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.APLIKASIToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABOUTToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.KELUARToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Elephant", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumAquamarine
        Me.Label1.Location = New System.Drawing.Point(280, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(557, 62)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "UNIT CONVERTER"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MediumSpringGreen
        Me.Label2.Location = New System.Drawing.Point(444, 394)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Let's Enjoy The Converter"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.APLIKASIToolStripMenuItem1, Me.ABOUTToolStripMenuItem1, Me.KELUARToolStripMenuItem1})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(1084, 24)
        Me.MenuStrip2.TabIndex = 3
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'APLIKASIToolStripMenuItem1
        '
        Me.APLIKASIToolStripMenuItem1.Name = "APLIKASIToolStripMenuItem1"
        Me.APLIKASIToolStripMenuItem1.Size = New System.Drawing.Size(67, 20)
        Me.APLIKASIToolStripMenuItem1.Text = "AP&LIKASI"
        '
        'ABOUTToolStripMenuItem1
        '
        Me.ABOUTToolStripMenuItem1.Name = "ABOUTToolStripMenuItem1"
        Me.ABOUTToolStripMenuItem1.Size = New System.Drawing.Size(58, 20)
        Me.ABOUTToolStripMenuItem1.Text = "&ABOUT"
        '
        'KELUARToolStripMenuItem1
        '
        Me.KELUARToolStripMenuItem1.Name = "KELUARToolStripMenuItem1"
        Me.KELUARToolStripMenuItem1.Size = New System.Drawing.Size(61, 20)
        Me.KELUARToolStripMenuItem1.Text = "&KELUAR"
        '
        'UNITCONVERTERS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BackgroundImage = Global.KP_KERJA_PROJEK.My.Resources.Resources._59809
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1084, 530)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "UNITCONVERTERS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UNIT CONVERTER"
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents APLIKASIToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABOUTToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KELUARToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

End Class
