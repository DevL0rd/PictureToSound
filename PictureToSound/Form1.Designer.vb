<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SpeedLabel = New System.Windows.Forms.Label()
        Me.Speed_Modifier = New System.Windows.Forms.TrackBar()
        Me.FreqModLabel = New System.Windows.Forms.Label()
        Me.Frequency_Modifier = New System.Windows.Forms.TrackBar()
        Me.PlayButton = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Output = New System.Windows.Forms.TextBox()
        Me.MenuView = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundSync = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextColorSync = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Speed_Modifier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Frequency_Modifier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(12, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1024, 483)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.SpeedLabel)
        Me.Panel1.Controls.Add(Me.Speed_Modifier)
        Me.Panel1.Controls.Add(Me.FreqModLabel)
        Me.Panel1.Controls.Add(Me.Frequency_Modifier)
        Me.Panel1.Location = New System.Drawing.Point(1063, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(189, 483)
        Me.Panel1.TabIndex = 1
        '
        'SpeedLabel
        '
        Me.SpeedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpeedLabel.ForeColor = System.Drawing.Color.White
        Me.SpeedLabel.Location = New System.Drawing.Point(3, 0)
        Me.SpeedLabel.Name = "SpeedLabel"
        Me.SpeedLabel.Size = New System.Drawing.Size(183, 23)
        Me.SpeedLabel.TabIndex = 3
        Me.SpeedLabel.Text = "Speed Modifier (100)"
        Me.SpeedLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Speed_Modifier
        '
        Me.Speed_Modifier.Location = New System.Drawing.Point(3, 19)
        Me.Speed_Modifier.Maximum = 400
        Me.Speed_Modifier.Minimum = 1
        Me.Speed_Modifier.Name = "Speed_Modifier"
        Me.Speed_Modifier.Size = New System.Drawing.Size(183, 45)
        Me.Speed_Modifier.TabIndex = 2
        Me.Speed_Modifier.TickFrequency = 25
        Me.Speed_Modifier.Value = 100
        '
        'FreqModLabel
        '
        Me.FreqModLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FreqModLabel.ForeColor = System.Drawing.Color.White
        Me.FreqModLabel.Location = New System.Drawing.Point(3, 67)
        Me.FreqModLabel.Name = "FreqModLabel"
        Me.FreqModLabel.Size = New System.Drawing.Size(183, 23)
        Me.FreqModLabel.TabIndex = 1
        Me.FreqModLabel.Text = "Frequency Modifier (2)"
        Me.FreqModLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Frequency_Modifier
        '
        Me.Frequency_Modifier.Location = New System.Drawing.Point(3, 86)
        Me.Frequency_Modifier.Maximum = 5
        Me.Frequency_Modifier.Minimum = 1
        Me.Frequency_Modifier.Name = "Frequency_Modifier"
        Me.Frequency_Modifier.Size = New System.Drawing.Size(183, 45)
        Me.Frequency_Modifier.TabIndex = 0
        Me.Frequency_Modifier.Value = 2
        '
        'PlayButton
        '
        Me.PlayButton.BackColor = System.Drawing.Color.RoyalBlue
        Me.PlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.PlayButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.PlayButton.Location = New System.Drawing.Point(485, 235)
        Me.PlayButton.Name = "PlayButton"
        Me.PlayButton.Size = New System.Drawing.Size(78, 84)
        Me.PlayButton.TabIndex = 3
        Me.PlayButton.Text = "▶"
        Me.PlayButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.PlayButton.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuFile, Me.MenuView})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1264, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuFile
        '
        Me.MenuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem})
        Me.MenuFile.ForeColor = System.Drawing.Color.White
        Me.MenuFile.Name = "MenuFile"
        Me.MenuFile.Size = New System.Drawing.Size(37, 20)
        Me.MenuFile.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'Output
        '
        Me.Output.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Output.Location = New System.Drawing.Point(12, 534)
        Me.Output.Multiline = True
        Me.Output.Name = "Output"
        Me.Output.ReadOnly = True
        Me.Output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Output.Size = New System.Drawing.Size(1237, 132)
        Me.Output.TabIndex = 4
        '
        'MenuView
        '
        Me.MenuView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackgroundSync, Me.TextColorSync})
        Me.MenuView.ForeColor = System.Drawing.Color.White
        Me.MenuView.Name = "MenuView"
        Me.MenuView.Size = New System.Drawing.Size(44, 20)
        Me.MenuView.Text = "View"
        '
        'BackgroundSync
        '
        Me.BackgroundSync.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundSync.ForeColor = System.Drawing.Color.White
        Me.BackgroundSync.Name = "BackgroundSync"
        Me.BackgroundSync.Size = New System.Drawing.Size(227, 22)
        Me.BackgroundSync.Text = "Background Color Sync (ON)"
        '
        'TextColorSync
        '
        Me.TextColorSync.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextColorSync.ForeColor = System.Drawing.Color.White
        Me.TextColorSync.Name = "TextColorSync"
        Me.TextColorSync.Size = New System.Drawing.Size(227, 22)
        Me.TextColorSync.Text = "Text Color Sync (ON)"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1264, 682)
        Me.Controls.Add(Me.PlayButton)
        Me.Controls.Add(Me.Output)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(1280, 720)
        Me.Name = "Form1"
        Me.Text = "Picture To Sound ~Dustin Harris"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Speed_Modifier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Frequency_Modifier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Frequency_Modifier As TrackBar
    Friend WithEvents SpeedLabel As Label
    Friend WithEvents Speed_Modifier As TrackBar
    Friend WithEvents FreqModLabel As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuFile As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PlayButton As Button
    Friend WithEvents Output As TextBox
    Friend WithEvents MenuView As ToolStripMenuItem
    Friend WithEvents BackgroundSync As ToolStripMenuItem
    Friend WithEvents TextColorSync As ToolStripMenuItem
End Class
