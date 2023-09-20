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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PromptTextBox = New System.Windows.Forms.TextBox()
        Me.AspectRetioComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StyleComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NegativePromptTextBox = New System.Windows.Forms.TextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(710, 17)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 28)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "generate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 62)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1105, 384)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(805, 17)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 28)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PromptTextBox
        '
        Me.PromptTextBox.Location = New System.Drawing.Point(66, 17)
        Me.PromptTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PromptTextBox.Name = "PromptTextBox"
        Me.PromptTextBox.Size = New System.Drawing.Size(369, 22)
        Me.PromptTextBox.TabIndex = 3
        '
        'AspectRetioComboBox
        '
        Me.AspectRetioComboBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AspectRetioComboBox.FormattingEnabled = True
        Me.AspectRetioComboBox.Items.AddRange(New Object() {"SQUARE", "TALL", "WIDE"})
        Me.AspectRetioComboBox.Location = New System.Drawing.Point(993, 17)
        Me.AspectRetioComboBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AspectRetioComboBox.Name = "AspectRetioComboBox"
        Me.AspectRetioComboBox.Size = New System.Drawing.Size(89, 24)
        Me.AspectRetioComboBox.TabIndex = 4
        Me.AspectRetioComboBox.Text = "Aspect"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "prompt"
        '
        'StyleComboBox
        '
        Me.StyleComboBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StyleComboBox.FormattingEnabled = True
        Me.StyleComboBox.Items.AddRange(New Object() {"No Style", "Anime", "Comic Book", "Enhance", "Photographic", "Digital art", "Fantasy art", "Analog film", "Neon punk", "Isometric", "Low poly", "Origami", "Line art", "Craft clay", "Cinematic", "3D model", "Pixel art"})
        Me.StyleComboBox.Location = New System.Drawing.Point(899, 17)
        Me.StyleComboBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.StyleComboBox.Name = "StyleComboBox"
        Me.StyleComboBox.Size = New System.Drawing.Size(89, 24)
        Me.StyleComboBox.TabIndex = 6
        Me.StyleComboBox.Text = "Style"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(443, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "negative prompt"
        '
        'NegativePromptTextBox
        '
        Me.NegativePromptTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.NegativePromptTextBox.Location = New System.Drawing.Point(549, 17)
        Me.NegativePromptTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NegativePromptTextBox.Name = "NegativePromptTextBox"
        Me.NegativePromptTextBox.Size = New System.Drawing.Size(147, 22)
        Me.NegativePromptTextBox.TabIndex = 7
        Me.NegativePromptTextBox.Text = "blurry image, watermark, messy"
        '
        'BackgroundWorker1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1105, 496)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NegativePromptTextBox)
        Me.Controls.Add(Me.StyleComboBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AspectRetioComboBox)
        Me.Controls.Add(Me.PromptTextBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "AI Image Generator"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents PromptTextBox As TextBox
    Friend WithEvents AspectRetioComboBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents StyleComboBox As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents NegativePromptTextBox As TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
