<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMaster
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMaster))
        Me.AxAcroPDF1 = New AxAcroPDFLib.AxAcroPDF()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.btnMaximize = New System.Windows.Forms.Button()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlToolbar = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboSize = New System.Windows.Forms.ComboBox()
        Me.ofdFile = New System.Windows.Forms.OpenFileDialog()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPage = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnOpenFile = New System.Windows.Forms.Button()
        Me.btnSizePlus = New System.Windows.Forms.Button()
        Me.btnSizeMinus = New System.Windows.Forms.Button()
        Me.btnNextPage = New System.Windows.Forms.Button()
        Me.btnPreviousPage = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        Me.pnlToolbar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxAcroPDF1
        '
        Me.AxAcroPDF1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AxAcroPDF1.Enabled = True
        Me.AxAcroPDF1.Location = New System.Drawing.Point(0, 50)
        Me.AxAcroPDF1.Name = "AxAcroPDF1"
        Me.AxAcroPDF1.OcxState = CType(resources.GetObject("AxAcroPDF1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDF1.Size = New System.Drawing.Size(800, 650)
        Me.AxAcroPDF1.TabIndex = 0
        '
        'pnlHeader
        '
        Me.pnlHeader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlHeader.BackColor = System.Drawing.Color.DimGray
        Me.pnlHeader.Controls.Add(Me.PictureBox1)
        Me.pnlHeader.Controls.Add(Me.btnMaximize)
        Me.pnlHeader.Controls.Add(Me.btnMinimize)
        Me.pnlHeader.Controls.Add(Me.btnClose)
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(800, 50)
        Me.pnlHeader.TabIndex = 2
        '
        'btnMaximize
        '
        Me.btnMaximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximize.FlatAppearance.BorderSize = 0
        Me.btnMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximize.Font = New System.Drawing.Font("Wingdings", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnMaximize.Location = New System.Drawing.Point(718, 5)
        Me.btnMaximize.Name = "btnMaximize"
        Me.btnMaximize.Size = New System.Drawing.Size(40, 40)
        Me.btnMaximize.TabIndex = 3
        Me.btnMaximize.Text = "o"
        Me.btnMaximize.UseVisualStyleBackColor = True
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Font = New System.Drawing.Font("Lucida Console", 26.0!, System.Drawing.FontStyle.Bold)
        Me.btnMinimize.Location = New System.Drawing.Point(678, 5)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(40, 40)
        Me.btnMinimize.TabIndex = 2
        Me.btnMinimize.Text = "-"
        Me.btnMinimize.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Lucida Console", 26.0!, System.Drawing.FontStyle.Bold)
        Me.btnClose.Location = New System.Drawing.Point(757, 5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(40, 40)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "X"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblTitle.Location = New System.Drawing.Point(47, 16)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(160, 20)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Simple PDF reader"
        '
        'pnlToolbar
        '
        Me.pnlToolbar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlToolbar.Controls.Add(Me.Label3)
        Me.pnlToolbar.Controls.Add(Me.btnSizePlus)
        Me.pnlToolbar.Controls.Add(Me.btnSizeMinus)
        Me.pnlToolbar.Controls.Add(Me.txtPage)
        Me.pnlToolbar.Controls.Add(Me.Label2)
        Me.pnlToolbar.Controls.Add(Me.Label1)
        Me.pnlToolbar.Controls.Add(Me.btnNextPage)
        Me.pnlToolbar.Controls.Add(Me.btnPreviousPage)
        Me.pnlToolbar.Controls.Add(Me.btnPrint)
        Me.pnlToolbar.Controls.Add(Me.cboSize)
        Me.pnlToolbar.Location = New System.Drawing.Point(0, 50)
        Me.pnlToolbar.Name = "pnlToolbar"
        Me.pnlToolbar.Size = New System.Drawing.Size(800, 38)
        Me.pnlToolbar.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(50, -3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 41)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "|"
        '
        'cboSize
        '
        Me.cboSize.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.cboSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboSize.FormattingEnabled = True
        Me.cboSize.Items.AddRange(New Object() {"10%", "25%", "50%", "75%", "100%", "125%", "150%", "200%", "400%", "800%", "1600%"})
        Me.cboSize.Location = New System.Drawing.Point(369, 8)
        Me.cboSize.Name = "cboSize"
        Me.cboSize.Size = New System.Drawing.Size(80, 21)
        Me.cboSize.TabIndex = 0
        '
        'ofdFile
        '
        Me.ofdFile.FileName = "OpenFileDialog1"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(113, -3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 41)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "|"
        '
        'txtPage
        '
        Me.txtPage.BackColor = System.Drawing.SystemColors.Menu
        Me.txtPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPage.Location = New System.Drawing.Point(224, 1)
        Me.txtPage.Multiline = True
        Me.txtPage.Name = "txtPage"
        Me.txtPage.Size = New System.Drawing.Size(70, 35)
        Me.txtPage.TabIndex = 9
        Me.txtPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPage.WordWrap = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(300, -10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 48)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "|"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnOpenFile
        '
        Me.btnOpenFile.BackgroundImage = Global.SimplePDFReader.My.Resources.Resources.icons8_pdf_50
        Me.btnOpenFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnOpenFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Wheat
        Me.btnOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpenFile.Location = New System.Drawing.Point(13, 51)
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(35, 35)
        Me.btnOpenFile.TabIndex = 3
        Me.btnOpenFile.UseVisualStyleBackColor = True
        '
        'btnSizePlus
        '
        Me.btnSizePlus.BackgroundImage = Global.SimplePDFReader.My.Resources.Resources.icons8_plus_50
        Me.btnSizePlus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSizePlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSizePlus.Location = New System.Drawing.Point(455, 1)
        Me.btnSizePlus.Name = "btnSizePlus"
        Me.btnSizePlus.Size = New System.Drawing.Size(35, 35)
        Me.btnSizePlus.TabIndex = 11
        Me.btnSizePlus.UseVisualStyleBackColor = True
        '
        'btnSizeMinus
        '
        Me.btnSizeMinus.BackgroundImage = Global.SimplePDFReader.My.Resources.Resources.icons8_minus_50
        Me.btnSizeMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSizeMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSizeMinus.Location = New System.Drawing.Point(328, 1)
        Me.btnSizeMinus.Name = "btnSizeMinus"
        Me.btnSizeMinus.Size = New System.Drawing.Size(35, 35)
        Me.btnSizeMinus.TabIndex = 10
        Me.btnSizeMinus.UseVisualStyleBackColor = True
        '
        'btnNextPage
        '
        Me.btnNextPage.BackgroundImage = Global.SimplePDFReader.My.Resources.Resources.icons8_scroll_down_50
        Me.btnNextPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNextPage.Location = New System.Drawing.Point(182, 1)
        Me.btnNextPage.Name = "btnNextPage"
        Me.btnNextPage.Size = New System.Drawing.Size(35, 35)
        Me.btnNextPage.TabIndex = 6
        Me.btnNextPage.UseVisualStyleBackColor = True
        '
        'btnPreviousPage
        '
        Me.btnPreviousPage.BackgroundImage = Global.SimplePDFReader.My.Resources.Resources.icons8_scroll_up_50
        Me.btnPreviousPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPreviousPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPreviousPage.Location = New System.Drawing.Point(141, 1)
        Me.btnPreviousPage.Name = "btnPreviousPage"
        Me.btnPreviousPage.Size = New System.Drawing.Size(35, 35)
        Me.btnPreviousPage.TabIndex = 5
        Me.btnPreviousPage.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.BackgroundImage = Global.SimplePDFReader.My.Resources.Resources.icons8_print_50
        Me.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Location = New System.Drawing.Point(72, 1)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(35, 35)
        Me.btnPrint.TabIndex = 4
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SimplePDFReader.My.Resources.Resources.Logo
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(0, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'frmMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 700)
        Me.Controls.Add(Me.btnOpenFile)
        Me.Controls.Add(Me.pnlToolbar)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.AxAcroPDF1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMaster"
        Me.Text = "Form1"
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlToolbar.ResumeLayout(False)
        Me.pnlToolbar.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents btnMaximize As Button
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlToolbar As Panel
    Friend WithEvents ofdFile As OpenFileDialog
    Friend WithEvents btnOpenFile As Button
    Friend WithEvents cboSize As ComboBox
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnPreviousPage As Button
    Friend WithEvents btnNextPage As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtPage As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSizePlus As Button
    Friend WithEvents btnSizeMinus As Button
End Class
