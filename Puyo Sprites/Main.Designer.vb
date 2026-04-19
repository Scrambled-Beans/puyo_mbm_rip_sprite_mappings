<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Form))
        Me.Menu_Strip = New System.Windows.Forms.MenuStrip()
        Me.File_Menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.File_Open = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.About_Tool = New System.Windows.Forms.ToolStripMenuItem()
        Me.Open_File = New System.Windows.Forms.OpenFileDialog()
        Me.ROM_Offset = New System.Windows.Forms.TextBox()
        Me.Number_Frames = New System.Windows.Forms.TextBox()
        Me.Label_Name = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Save_Text_Dialog = New System.Windows.Forms.SaveFileDialog()
        Me.Text_Output = New System.Windows.Forms.RichTextBox()
        Me.Menu_Strip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Menu_Strip
        '
        Me.Menu_Strip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Menu_Strip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.File_Menu, Me.About_Tool})
        Me.Menu_Strip.Location = New System.Drawing.Point(0, 0)
        Me.Menu_Strip.Name = "Menu_Strip"
        Me.Menu_Strip.Size = New System.Drawing.Size(1105, 28)
        Me.Menu_Strip.TabIndex = 1
        Me.Menu_Strip.Text = "MenuStrip1"
        '
        'File_Menu
        '
        Me.File_Menu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.File_Open, Me.SaveToolStripMenuItem})
        Me.File_Menu.Name = "File_Menu"
        Me.File_Menu.Size = New System.Drawing.Size(46, 24)
        Me.File_Menu.Text = "File"
        '
        'File_Open
        '
        Me.File_Open.Name = "File_Open"
        Me.File_Open.Size = New System.Drawing.Size(128, 26)
        Me.File_Open.Text = "Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(128, 26)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'About_Tool
        '
        Me.About_Tool.Name = "About_Tool"
        Me.About_Tool.Size = New System.Drawing.Size(64, 24)
        Me.About_Tool.Text = "About"
        '
        'Open_File
        '
        Me.Open_File.FileName = "Open_File"
        Me.Open_File.Filter = "BIN|*.bin|MD|*.md"
        '
        'ROM_Offset
        '
        Me.ROM_Offset.Font = New System.Drawing.Font("Consolas", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ROM_Offset.Location = New System.Drawing.Point(409, 37)
        Me.ROM_Offset.MaxLength = 6
        Me.ROM_Offset.Name = "ROM_Offset"
        Me.ROM_Offset.Size = New System.Drawing.Size(193, 39)
        Me.ROM_Offset.TabIndex = 5
        Me.ROM_Offset.Text = "14F9C"
        Me.ROM_Offset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Number_Frames
        '
        Me.Number_Frames.Font = New System.Drawing.Font("Consolas", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Number_Frames.Location = New System.Drawing.Point(409, 82)
        Me.Number_Frames.MaxLength = 2
        Me.Number_Frames.Name = "Number_Frames"
        Me.Number_Frames.Size = New System.Drawing.Size(83, 39)
        Me.Number_Frames.TabIndex = 8
        Me.Number_Frames.Text = "9"
        Me.Number_Frames.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_Name
        '
        Me.Label_Name.Font = New System.Drawing.Font("Consolas", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Name.Location = New System.Drawing.Point(409, 130)
        Me.Label_Name.MaxLength = 30
        Me.Label_Name.Name = "Label_Name"
        Me.Label_Name.Size = New System.Drawing.Size(681, 39)
        Me.Label_Name.TabIndex = 10
        Me.Label_Name.Text = "Sprite_Puyo_Red"
        Me.Label_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 37)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(389, 39)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Offset:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 80)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(389, 39)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Number of Frames:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 130)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(389, 39)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Label Name:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Save_Text_Dialog
        '
        Me.Save_Text_Dialog.Filter = "ASM | *.asm"
        '
        'Text_Output
        '
        Me.Text_Output.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_Output.Location = New System.Drawing.Point(12, 177)
        Me.Text_Output.Margin = New System.Windows.Forms.Padding(4)
        Me.Text_Output.Name = "Text_Output"
        Me.Text_Output.ReadOnly = True
        Me.Text_Output.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.Text_Output.Size = New System.Drawing.Size(1078, 592)
        Me.Text_Output.TabIndex = 4
        Me.Text_Output.Text = ""
        Me.Text_Output.WordWrap = False
        '
        'Main_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1105, 782)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label_Name)
        Me.Controls.Add(Me.Number_Frames)
        Me.Controls.Add(Me.ROM_Offset)
        Me.Controls.Add(Me.Text_Output)
        Me.Controls.Add(Me.Menu_Strip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Main_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Puyo Puyo 1 / Mean Bean Machine - Extract Sprite Mappings (V1.3)"
        Me.Menu_Strip.ResumeLayout(False)
        Me.Menu_Strip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Menu_Strip As MenuStrip
    Friend WithEvents File_Menu As ToolStripMenuItem
    Friend WithEvents File_Open As ToolStripMenuItem
    Friend WithEvents About_Tool As ToolStripMenuItem
    Friend WithEvents Open_File As OpenFileDialog
    Friend WithEvents ROM_Offset As TextBox
    Friend WithEvents Number_Frames As TextBox
    Friend WithEvents Label_Name As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Save_Text_Dialog As SaveFileDialog
    Friend WithEvents Text_Output As RichTextBox
End Class
