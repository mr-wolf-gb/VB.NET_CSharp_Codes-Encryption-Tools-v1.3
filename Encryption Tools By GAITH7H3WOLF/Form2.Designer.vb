<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.GhostTheme1 = New Encryption_Tools_By_GAITH7H3WOLF.GhostTheme()
        Me.GhostControlBox1 = New Encryption_Tools_By_GAITH7H3WOLF.GhostControlBox()
        Me.GhostButton1 = New Encryption_Tools_By_GAITH7H3WOLF.GhostButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New Encryption_Tools_By_GAITH7H3WOLF.GhostTextBox()
        Me.GhostTheme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GhostTheme1
        '
        Me.GhostTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.GhostTheme1.Colors = New Encryption_Tools_By_GAITH7H3WOLF.Bloom(-1) {}
        Me.GhostTheme1.Controls.Add(Me.GhostControlBox1)
        Me.GhostTheme1.Controls.Add(Me.GhostButton1)
        Me.GhostTheme1.Controls.Add(Me.Label1)
        Me.GhostTheme1.Controls.Add(Me.TextBox1)
        Me.GhostTheme1.Customization = ""
        Me.GhostTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GhostTheme1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.GhostTheme1.Image = Nothing
        Me.GhostTheme1.Location = New System.Drawing.Point(0, 0)
        Me.GhostTheme1.Movable = True
        Me.GhostTheme1.Name = "GhostTheme1"
        Me.GhostTheme1.NoRounding = False
        Me.GhostTheme1.ShowIcon = True
        Me.GhostTheme1.Sizable = False
        Me.GhostTheme1.Size = New System.Drawing.Size(616, 78)
        Me.GhostTheme1.SmartBounds = True
        Me.GhostTheme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.GhostTheme1.TabIndex = 0
        Me.GhostTheme1.Text = "Function Call"
        Me.GhostTheme1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.GhostTheme1.Transparent = False
        '
        'GhostControlBox1
        '
        Me.GhostControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GhostControlBox1.Customization = "QEBA/wAAAP9aWlr/"
        Me.GhostControlBox1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.GhostControlBox1.Image = Nothing
        Me.GhostControlBox1.Location = New System.Drawing.Point(544, 0)
        Me.GhostControlBox1.Name = "GhostControlBox1"
        Me.GhostControlBox1.NoRounding = False
        Me.GhostControlBox1.Size = New System.Drawing.Size(72, 19)
        Me.GhostControlBox1.TabIndex = 3
        Me.GhostControlBox1.Text = "GhostControlBox1"
        Me.GhostControlBox1.Transparent = False
        '
        'GhostButton1
        '
        Me.GhostButton1.Color = System.Drawing.Color.Empty
        Me.GhostButton1.Colors = New Encryption_Tools_By_GAITH7H3WOLF.Bloom(-1) {}
        Me.GhostButton1.Customization = ""
        Me.GhostButton1.EnableGlass = True
        Me.GhostButton1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.GhostButton1.Image = Nothing
        Me.GhostButton1.Location = New System.Drawing.Point(529, 35)
        Me.GhostButton1.Name = "GhostButton1"
        Me.GhostButton1.NoRounding = False
        Me.GhostButton1.Size = New System.Drawing.Size(75, 23)
        Me.GhostButton1.TabIndex = 2
        Me.GhostButton1.Text = "Copy"
        Me.GhostButton1.Transparent = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(15, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Call :"
        '
        'TextBox1
        '
        Me.TextBox1.Customization = "/////wAAAP8AAAD/Wlpa/w=="
        Me.TextBox1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.TextBox1.Image = Nothing
        Me.TextBox1.Location = New System.Drawing.Point(59, 34)
        Me.TextBox1.MaxLength = 32767
        Me.TextBox1.Multiline = False
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.NoRounding = False
        Me.TextBox1.ReadOnly = False
        Me.TextBox1.Size = New System.Drawing.Size(464, 24)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TextBox1.Transparent = False
        Me.TextBox1.UseSystemPasswordChar = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 78)
        Me.Controls.Add(Me.GhostTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.GhostTheme1.ResumeLayout(False)
        Me.GhostTheme1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GhostTheme1 As Encryption_Tools_By_GAITH7H3WOLF.GhostTheme
    Friend WithEvents GhostButton1 As Encryption_Tools_By_GAITH7H3WOLF.GhostButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As Encryption_Tools_By_GAITH7H3WOLF.GhostTextBox
    Friend WithEvents GhostControlBox1 As Encryption_Tools_By_GAITH7H3WOLF.GhostControlBox
End Class
