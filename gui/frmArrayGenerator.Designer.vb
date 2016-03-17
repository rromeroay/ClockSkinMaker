<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmArrayGenerator
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmArrayGenerator))
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.dlgOpenDir = New System.Windows.Forms.FolderBrowserDialog()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.grpArray = New System.Windows.Forms.GroupBox()
        Me.lblShadow = New System.Windows.Forms.Label()
        Me.txtShadowY = New System.Windows.Forms.NumericUpDown()
        Me.txtShadowX = New System.Windows.Forms.NumericUpDown()
        Me.cmdShadowColor = New System.Windows.Forms.Button()
        Me.chkAutoscale = New System.Windows.Forms.CheckBox()
        Me.cmdView = New System.Windows.Forms.Button()
        Me.lblForeBackColor = New System.Windows.Forms.Label()
        Me.lblFont = New System.Windows.Forms.Label()
        Me.lblArrayName = New System.Windows.Forms.Label()
        Me.txtArrayFileName = New System.Windows.Forms.TextBox()
        Me.cmdArrayColorDel = New System.Windows.Forms.Button()
        Me.cmdArrayFont = New System.Windows.Forms.Button()
        Me.cmdArrayBack = New System.Windows.Forms.Button()
        Me.cmdArrayFore = New System.Windows.Forms.Button()
        Me.grpContents = New System.Windows.Forms.GroupBox()
        Me.tblContents = New System.Windows.Forms.TableLayoutPanel()
        Me.cmdForeColor12 = New System.Windows.Forms.Button()
        Me.cmdForeColor11 = New System.Windows.Forms.Button()
        Me.cmdForeColor10 = New System.Windows.Forms.Button()
        Me.cmdForeColor9 = New System.Windows.Forms.Button()
        Me.cmdForeColor8 = New System.Windows.Forms.Button()
        Me.cmdForeColor7 = New System.Windows.Forms.Button()
        Me.cmdForeColor6 = New System.Windows.Forms.Button()
        Me.cmdForeColor5 = New System.Windows.Forms.Button()
        Me.cmdForeColor4 = New System.Windows.Forms.Button()
        Me.cmdForeColor3 = New System.Windows.Forms.Button()
        Me.cmdForeColor2 = New System.Windows.Forms.Button()
        Me.cmdForeColor1 = New System.Windows.Forms.Button()
        Me.txtContent12 = New System.Windows.Forms.TextBox()
        Me.lblContent12 = New System.Windows.Forms.Label()
        Me.lblContent2 = New System.Windows.Forms.Label()
        Me.lblContent1 = New System.Windows.Forms.Label()
        Me.lblContent0 = New System.Windows.Forms.Label()
        Me.txtContent0 = New System.Windows.Forms.TextBox()
        Me.lblContent3 = New System.Windows.Forms.Label()
        Me.lblContent4 = New System.Windows.Forms.Label()
        Me.lblContent5 = New System.Windows.Forms.Label()
        Me.lblContent6 = New System.Windows.Forms.Label()
        Me.lblContent7 = New System.Windows.Forms.Label()
        Me.lblContent8 = New System.Windows.Forms.Label()
        Me.lblContent9 = New System.Windows.Forms.Label()
        Me.lblContent10 = New System.Windows.Forms.Label()
        Me.lblContent11 = New System.Windows.Forms.Label()
        Me.txtContent1 = New System.Windows.Forms.TextBox()
        Me.txtContent2 = New System.Windows.Forms.TextBox()
        Me.txtContent3 = New System.Windows.Forms.TextBox()
        Me.txtContent4 = New System.Windows.Forms.TextBox()
        Me.txtContent5 = New System.Windows.Forms.TextBox()
        Me.txtContent6 = New System.Windows.Forms.TextBox()
        Me.txtContent7 = New System.Windows.Forms.TextBox()
        Me.txtContent8 = New System.Windows.Forms.TextBox()
        Me.txtContent9 = New System.Windows.Forms.TextBox()
        Me.txtContent10 = New System.Windows.Forms.TextBox()
        Me.txtContent11 = New System.Windows.Forms.TextBox()
        Me.cmdForeColor0 = New System.Windows.Forms.Button()
        Me.cmdContentsColorDel = New System.Windows.Forms.Button()
        Me.dlgFont = New System.Windows.Forms.FontDialog()
        Me.dlgColor = New System.Windows.Forms.ColorDialog()
        Me.grpArray.SuspendLayout()
        CType(Me.txtShadowY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtShadowX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpContents.SuspendLayout()
        Me.tblContents.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdClose.Location = New System.Drawing.Point(167, 498)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 23)
        Me.cmdClose.TabIndex = 3
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'dlgOpenDir
        '
        Me.dlgOpenDir.ShowNewFolderButton = False
        '
        'cmdOk
        '
        Me.cmdOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdOk.Location = New System.Drawing.Point(86, 498)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(75, 23)
        Me.cmdOk.TabIndex = 2
        Me.cmdOk.Text = "Apply"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'grpArray
        '
        Me.grpArray.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpArray.Controls.Add(Me.lblShadow)
        Me.grpArray.Controls.Add(Me.txtShadowY)
        Me.grpArray.Controls.Add(Me.txtShadowX)
        Me.grpArray.Controls.Add(Me.cmdShadowColor)
        Me.grpArray.Controls.Add(Me.chkAutoscale)
        Me.grpArray.Controls.Add(Me.cmdView)
        Me.grpArray.Controls.Add(Me.lblForeBackColor)
        Me.grpArray.Controls.Add(Me.lblFont)
        Me.grpArray.Controls.Add(Me.lblArrayName)
        Me.grpArray.Controls.Add(Me.txtArrayFileName)
        Me.grpArray.Controls.Add(Me.cmdArrayColorDel)
        Me.grpArray.Controls.Add(Me.cmdArrayFont)
        Me.grpArray.Controls.Add(Me.cmdArrayBack)
        Me.grpArray.Controls.Add(Me.cmdArrayFore)
        Me.grpArray.Location = New System.Drawing.Point(3, 0)
        Me.grpArray.Margin = New System.Windows.Forms.Padding(0)
        Me.grpArray.Name = "grpArray"
        Me.grpArray.Size = New System.Drawing.Size(273, 129)
        Me.grpArray.TabIndex = 0
        Me.grpArray.TabStop = False
        Me.grpArray.Text = "Array Generator"
        '
        'lblShadow
        '
        Me.lblShadow.AutoSize = True
        Me.lblShadow.Location = New System.Drawing.Point(31, 107)
        Me.lblShadow.Name = "lblShadow"
        Me.lblShadow.Size = New System.Drawing.Size(67, 13)
        Me.lblShadow.TabIndex = 10
        Me.lblShadow.Text = "Shadow X/Y"
        '
        'txtShadowY
        '
        Me.txtShadowY.Location = New System.Drawing.Point(141, 103)
        Me.txtShadowY.Maximum = New Decimal(New Integer() {24, 0, 0, 0})
        Me.txtShadowY.Minimum = New Decimal(New Integer() {24, 0, 0, -2147483648})
        Me.txtShadowY.Name = "txtShadowY"
        Me.txtShadowY.Size = New System.Drawing.Size(41, 20)
        Me.txtShadowY.TabIndex = 12
        Me.txtShadowY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtShadowX
        '
        Me.txtShadowX.Location = New System.Drawing.Point(99, 103)
        Me.txtShadowX.Maximum = New Decimal(New Integer() {24, 0, 0, 0})
        Me.txtShadowX.Minimum = New Decimal(New Integer() {24, 0, 0, -2147483648})
        Me.txtShadowX.Name = "txtShadowX"
        Me.txtShadowX.Size = New System.Drawing.Size(41, 20)
        Me.txtShadowX.TabIndex = 11
        Me.txtShadowX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdShadowColor
        '
        Me.cmdShadowColor.BackColor = System.Drawing.Color.Gray
        Me.cmdShadowColor.Location = New System.Drawing.Point(183, 103)
        Me.cmdShadowColor.Name = "cmdShadowColor"
        Me.cmdShadowColor.Size = New System.Drawing.Size(51, 21)
        Me.cmdShadowColor.TabIndex = 13
        Me.cmdShadowColor.Text = "808080"
        Me.cmdShadowColor.UseVisualStyleBackColor = False
        '
        'chkAutoscale
        '
        Me.chkAutoscale.AutoSize = True
        Me.chkAutoscale.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkAutoscale.Location = New System.Drawing.Point(148, 61)
        Me.chkAutoscale.Name = "chkAutoscale"
        Me.chkAutoscale.Size = New System.Drawing.Size(80, 17)
        Me.chkAutoscale.TabIndex = 5
        Me.chkAutoscale.Text = "Autoscale"
        Me.chkAutoscale.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkAutoscale.UseVisualStyleBackColor = True
        '
        'cmdView
        '
        Me.cmdView.BackgroundImage = CType(resources.GetObject("cmdView.BackgroundImage"), System.Drawing.Image)
        Me.cmdView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdView.FlatAppearance.BorderSize = 0
        Me.cmdView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdView.Location = New System.Drawing.Point(238, 17)
        Me.cmdView.Name = "cmdView"
        Me.cmdView.Size = New System.Drawing.Size(14, 17)
        Me.cmdView.TabIndex = 2
        Me.cmdView.UseVisualStyleBackColor = True
        '
        'lblForeBackColor
        '
        Me.lblForeBackColor.AutoSize = True
        Me.lblForeBackColor.Location = New System.Drawing.Point(1, 84)
        Me.lblForeBackColor.Name = "lblForeBackColor"
        Me.lblForeBackColor.Size = New System.Drawing.Size(97, 13)
        Me.lblForeBackColor.TabIndex = 6
        Me.lblForeBackColor.Text = "Fore/Back Color"
        '
        'lblFont
        '
        Me.lblFont.AutoSize = True
        Me.lblFont.Location = New System.Drawing.Point(67, 42)
        Me.lblFont.Name = "lblFont"
        Me.lblFont.Size = New System.Drawing.Size(31, 13)
        Me.lblFont.TabIndex = 3
        Me.lblFont.Text = "Font"
        '
        'lblArrayName
        '
        Me.lblArrayName.AutoSize = True
        Me.lblArrayName.Location = New System.Drawing.Point(67, 19)
        Me.lblArrayName.Name = "lblArrayName"
        Me.lblArrayName.Size = New System.Drawing.Size(31, 13)
        Me.lblArrayName.TabIndex = 0
        Me.lblArrayName.Text = "Name"
        '
        'txtArrayFileName
        '
        Me.txtArrayFileName.BackColor = System.Drawing.Color.White
        Me.txtArrayFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtArrayFileName.Location = New System.Drawing.Point(99, 15)
        Me.txtArrayFileName.Name = "txtArrayFileName"
        Me.txtArrayFileName.Size = New System.Drawing.Size(135, 20)
        Me.txtArrayFileName.TabIndex = 1
        '
        'cmdArrayColorDel
        '
        Me.cmdArrayColorDel.BackgroundImage = CType(resources.GetObject("cmdArrayColorDel.BackgroundImage"), System.Drawing.Image)
        Me.cmdArrayColorDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdArrayColorDel.FlatAppearance.BorderSize = 0
        Me.cmdArrayColorDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdArrayColorDel.Location = New System.Drawing.Point(238, 82)
        Me.cmdArrayColorDel.Name = "cmdArrayColorDel"
        Me.cmdArrayColorDel.Size = New System.Drawing.Size(14, 17)
        Me.cmdArrayColorDel.TabIndex = 9
        Me.cmdArrayColorDel.UseVisualStyleBackColor = True
        '
        'cmdArrayFont
        '
        Me.cmdArrayFont.Location = New System.Drawing.Point(99, 38)
        Me.cmdArrayFont.Name = "cmdArrayFont"
        Me.cmdArrayFont.Size = New System.Drawing.Size(135, 21)
        Me.cmdArrayFont.TabIndex = 4
        Me.cmdArrayFont.UseVisualStyleBackColor = True
        '
        'cmdArrayBack
        '
        Me.cmdArrayBack.Location = New System.Drawing.Point(169, 80)
        Me.cmdArrayBack.Name = "cmdArrayBack"
        Me.cmdArrayBack.Size = New System.Drawing.Size(65, 21)
        Me.cmdArrayBack.TabIndex = 8
        Me.cmdArrayBack.Text = "Transp"
        Me.cmdArrayBack.UseVisualStyleBackColor = True
        '
        'cmdArrayFore
        '
        Me.cmdArrayFore.BackColor = System.Drawing.Color.Black
        Me.cmdArrayFore.Location = New System.Drawing.Point(99, 80)
        Me.cmdArrayFore.Name = "cmdArrayFore"
        Me.cmdArrayFore.Size = New System.Drawing.Size(65, 21)
        Me.cmdArrayFore.TabIndex = 7
        Me.cmdArrayFore.Text = "000000"
        Me.cmdArrayFore.UseVisualStyleBackColor = False
        '
        'grpContents
        '
        Me.grpContents.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpContents.Controls.Add(Me.tblContents)
        Me.grpContents.Location = New System.Drawing.Point(3, 128)
        Me.grpContents.Margin = New System.Windows.Forms.Padding(0)
        Me.grpContents.Name = "grpContents"
        Me.grpContents.Size = New System.Drawing.Size(273, 362)
        Me.grpContents.TabIndex = 1
        Me.grpContents.TabStop = False
        Me.grpContents.Text = "Contents"
        '
        'tblContents
        '
        Me.tblContents.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tblContents.ColumnCount = 3
        Me.tblContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.tblContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblContents.Controls.Add(Me.cmdForeColor12, 2, 13)
        Me.tblContents.Controls.Add(Me.cmdForeColor11, 2, 12)
        Me.tblContents.Controls.Add(Me.cmdForeColor10, 2, 11)
        Me.tblContents.Controls.Add(Me.cmdForeColor9, 2, 10)
        Me.tblContents.Controls.Add(Me.cmdForeColor8, 2, 9)
        Me.tblContents.Controls.Add(Me.cmdForeColor7, 2, 8)
        Me.tblContents.Controls.Add(Me.cmdForeColor6, 2, 7)
        Me.tblContents.Controls.Add(Me.cmdForeColor5, 2, 6)
        Me.tblContents.Controls.Add(Me.cmdForeColor4, 2, 5)
        Me.tblContents.Controls.Add(Me.cmdForeColor3, 2, 4)
        Me.tblContents.Controls.Add(Me.cmdForeColor2, 2, 3)
        Me.tblContents.Controls.Add(Me.cmdForeColor1, 2, 2)
        Me.tblContents.Controls.Add(Me.txtContent12, 1, 13)
        Me.tblContents.Controls.Add(Me.lblContent12, 0, 13)
        Me.tblContents.Controls.Add(Me.lblContent2, 0, 3)
        Me.tblContents.Controls.Add(Me.lblContent1, 0, 2)
        Me.tblContents.Controls.Add(Me.lblContent0, 0, 1)
        Me.tblContents.Controls.Add(Me.txtContent0, 1, 1)
        Me.tblContents.Controls.Add(Me.lblContent3, 0, 4)
        Me.tblContents.Controls.Add(Me.lblContent4, 0, 5)
        Me.tblContents.Controls.Add(Me.lblContent5, 0, 6)
        Me.tblContents.Controls.Add(Me.lblContent6, 0, 7)
        Me.tblContents.Controls.Add(Me.lblContent7, 0, 8)
        Me.tblContents.Controls.Add(Me.lblContent8, 0, 9)
        Me.tblContents.Controls.Add(Me.lblContent9, 0, 10)
        Me.tblContents.Controls.Add(Me.lblContent10, 0, 11)
        Me.tblContents.Controls.Add(Me.lblContent11, 0, 12)
        Me.tblContents.Controls.Add(Me.txtContent1, 1, 2)
        Me.tblContents.Controls.Add(Me.txtContent2, 1, 3)
        Me.tblContents.Controls.Add(Me.txtContent3, 1, 4)
        Me.tblContents.Controls.Add(Me.txtContent4, 1, 5)
        Me.tblContents.Controls.Add(Me.txtContent5, 1, 6)
        Me.tblContents.Controls.Add(Me.txtContent6, 1, 7)
        Me.tblContents.Controls.Add(Me.txtContent7, 1, 8)
        Me.tblContents.Controls.Add(Me.txtContent8, 1, 9)
        Me.tblContents.Controls.Add(Me.txtContent9, 1, 10)
        Me.tblContents.Controls.Add(Me.txtContent10, 1, 11)
        Me.tblContents.Controls.Add(Me.txtContent11, 1, 12)
        Me.tblContents.Controls.Add(Me.cmdForeColor0, 2, 1)
        Me.tblContents.Controls.Add(Me.cmdContentsColorDel, 2, 0)
        Me.tblContents.Location = New System.Drawing.Point(38, 12)
        Me.tblContents.Name = "tblContents"
        Me.tblContents.RowCount = 15
        Me.tblContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tblContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tblContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tblContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tblContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tblContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tblContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tblContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tblContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tblContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tblContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tblContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tblContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tblContents.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblContents.Size = New System.Drawing.Size(196, 347)
        Me.tblContents.TabIndex = 0
        '
        'cmdForeColor12
        '
        Me.cmdForeColor12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdForeColor12.Enabled = False
        Me.cmdForeColor12.Location = New System.Drawing.Point(179, 323)
        Me.cmdForeColor12.Name = "cmdForeColor12"
        Me.cmdForeColor12.Size = New System.Drawing.Size(14, 19)
        Me.cmdForeColor12.TabIndex = 39
        Me.cmdForeColor12.UseVisualStyleBackColor = True
        '
        'cmdForeColor11
        '
        Me.cmdForeColor11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdForeColor11.Enabled = False
        Me.cmdForeColor11.Location = New System.Drawing.Point(179, 298)
        Me.cmdForeColor11.Name = "cmdForeColor11"
        Me.cmdForeColor11.Size = New System.Drawing.Size(14, 19)
        Me.cmdForeColor11.TabIndex = 36
        Me.cmdForeColor11.UseVisualStyleBackColor = True
        '
        'cmdForeColor10
        '
        Me.cmdForeColor10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdForeColor10.Enabled = False
        Me.cmdForeColor10.Location = New System.Drawing.Point(179, 273)
        Me.cmdForeColor10.Name = "cmdForeColor10"
        Me.cmdForeColor10.Size = New System.Drawing.Size(14, 19)
        Me.cmdForeColor10.TabIndex = 33
        Me.cmdForeColor10.UseVisualStyleBackColor = True
        '
        'cmdForeColor9
        '
        Me.cmdForeColor9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdForeColor9.Enabled = False
        Me.cmdForeColor9.Location = New System.Drawing.Point(179, 248)
        Me.cmdForeColor9.Name = "cmdForeColor9"
        Me.cmdForeColor9.Size = New System.Drawing.Size(14, 19)
        Me.cmdForeColor9.TabIndex = 30
        Me.cmdForeColor9.UseVisualStyleBackColor = True
        '
        'cmdForeColor8
        '
        Me.cmdForeColor8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdForeColor8.Enabled = False
        Me.cmdForeColor8.Location = New System.Drawing.Point(179, 223)
        Me.cmdForeColor8.Name = "cmdForeColor8"
        Me.cmdForeColor8.Size = New System.Drawing.Size(14, 19)
        Me.cmdForeColor8.TabIndex = 27
        Me.cmdForeColor8.UseVisualStyleBackColor = True
        '
        'cmdForeColor7
        '
        Me.cmdForeColor7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdForeColor7.Enabled = False
        Me.cmdForeColor7.Location = New System.Drawing.Point(179, 198)
        Me.cmdForeColor7.Name = "cmdForeColor7"
        Me.cmdForeColor7.Size = New System.Drawing.Size(14, 19)
        Me.cmdForeColor7.TabIndex = 24
        Me.cmdForeColor7.UseVisualStyleBackColor = True
        '
        'cmdForeColor6
        '
        Me.cmdForeColor6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdForeColor6.Enabled = False
        Me.cmdForeColor6.Location = New System.Drawing.Point(179, 173)
        Me.cmdForeColor6.Name = "cmdForeColor6"
        Me.cmdForeColor6.Size = New System.Drawing.Size(14, 19)
        Me.cmdForeColor6.TabIndex = 21
        Me.cmdForeColor6.UseVisualStyleBackColor = True
        '
        'cmdForeColor5
        '
        Me.cmdForeColor5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdForeColor5.Enabled = False
        Me.cmdForeColor5.Location = New System.Drawing.Point(179, 148)
        Me.cmdForeColor5.Name = "cmdForeColor5"
        Me.cmdForeColor5.Size = New System.Drawing.Size(14, 19)
        Me.cmdForeColor5.TabIndex = 18
        Me.cmdForeColor5.UseVisualStyleBackColor = True
        '
        'cmdForeColor4
        '
        Me.cmdForeColor4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdForeColor4.Enabled = False
        Me.cmdForeColor4.Location = New System.Drawing.Point(179, 123)
        Me.cmdForeColor4.Name = "cmdForeColor4"
        Me.cmdForeColor4.Size = New System.Drawing.Size(14, 19)
        Me.cmdForeColor4.TabIndex = 15
        Me.cmdForeColor4.UseVisualStyleBackColor = True
        '
        'cmdForeColor3
        '
        Me.cmdForeColor3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdForeColor3.Enabled = False
        Me.cmdForeColor3.Location = New System.Drawing.Point(179, 98)
        Me.cmdForeColor3.Name = "cmdForeColor3"
        Me.cmdForeColor3.Size = New System.Drawing.Size(14, 19)
        Me.cmdForeColor3.TabIndex = 12
        Me.cmdForeColor3.UseVisualStyleBackColor = True
        '
        'cmdForeColor2
        '
        Me.cmdForeColor2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdForeColor2.Enabled = False
        Me.cmdForeColor2.Location = New System.Drawing.Point(179, 73)
        Me.cmdForeColor2.Name = "cmdForeColor2"
        Me.cmdForeColor2.Size = New System.Drawing.Size(14, 19)
        Me.cmdForeColor2.TabIndex = 9
        Me.cmdForeColor2.UseVisualStyleBackColor = True
        '
        'cmdForeColor1
        '
        Me.cmdForeColor1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdForeColor1.Enabled = False
        Me.cmdForeColor1.Location = New System.Drawing.Point(179, 48)
        Me.cmdForeColor1.Name = "cmdForeColor1"
        Me.cmdForeColor1.Size = New System.Drawing.Size(14, 19)
        Me.cmdForeColor1.TabIndex = 6
        Me.cmdForeColor1.UseVisualStyleBackColor = True
        '
        'txtContent12
        '
        Me.txtContent12.BackColor = System.Drawing.Color.White
        Me.txtContent12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContent12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtContent12.Enabled = False
        Me.txtContent12.Location = New System.Drawing.Point(109, 323)
        Me.txtContent12.MaxLength = 20
        Me.txtContent12.Name = "txtContent12"
        Me.txtContent12.Size = New System.Drawing.Size(64, 20)
        Me.txtContent12.TabIndex = 38
        '
        'lblContent12
        '
        Me.lblContent12.AutoSize = True
        Me.lblContent12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblContent12.Location = New System.Drawing.Point(3, 320)
        Me.lblContent12.Name = "lblContent12"
        Me.lblContent12.Size = New System.Drawing.Size(100, 25)
        Me.lblContent12.TabIndex = 37
        Me.lblContent12.Text = "NOT USED"
        Me.lblContent12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblContent2
        '
        Me.lblContent2.AutoSize = True
        Me.lblContent2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblContent2.Location = New System.Drawing.Point(3, 70)
        Me.lblContent2.Name = "lblContent2"
        Me.lblContent2.Size = New System.Drawing.Size(100, 25)
        Me.lblContent2.TabIndex = 7
        Me.lblContent2.Text = "NOT USED"
        Me.lblContent2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblContent1
        '
        Me.lblContent1.AutoSize = True
        Me.lblContent1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblContent1.Location = New System.Drawing.Point(3, 45)
        Me.lblContent1.Name = "lblContent1"
        Me.lblContent1.Size = New System.Drawing.Size(100, 25)
        Me.lblContent1.TabIndex = 4
        Me.lblContent1.Text = "NOT USED"
        Me.lblContent1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblContent0
        '
        Me.lblContent0.AutoSize = True
        Me.lblContent0.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblContent0.Location = New System.Drawing.Point(3, 20)
        Me.lblContent0.Name = "lblContent0"
        Me.lblContent0.Size = New System.Drawing.Size(100, 25)
        Me.lblContent0.TabIndex = 1
        Me.lblContent0.Text = "NOT USED"
        Me.lblContent0.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtContent0
        '
        Me.txtContent0.BackColor = System.Drawing.Color.White
        Me.txtContent0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContent0.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtContent0.Enabled = False
        Me.txtContent0.Location = New System.Drawing.Point(109, 23)
        Me.txtContent0.MaxLength = 20
        Me.txtContent0.Name = "txtContent0"
        Me.txtContent0.Size = New System.Drawing.Size(64, 20)
        Me.txtContent0.TabIndex = 2
        '
        'lblContent3
        '
        Me.lblContent3.AutoSize = True
        Me.lblContent3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblContent3.Location = New System.Drawing.Point(3, 95)
        Me.lblContent3.Name = "lblContent3"
        Me.lblContent3.Size = New System.Drawing.Size(100, 25)
        Me.lblContent3.TabIndex = 10
        Me.lblContent3.Text = "NOT USED"
        Me.lblContent3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblContent4
        '
        Me.lblContent4.AutoSize = True
        Me.lblContent4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblContent4.Location = New System.Drawing.Point(3, 120)
        Me.lblContent4.Name = "lblContent4"
        Me.lblContent4.Size = New System.Drawing.Size(100, 25)
        Me.lblContent4.TabIndex = 13
        Me.lblContent4.Text = "NOT USED"
        Me.lblContent4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblContent5
        '
        Me.lblContent5.AutoSize = True
        Me.lblContent5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblContent5.Location = New System.Drawing.Point(3, 145)
        Me.lblContent5.Name = "lblContent5"
        Me.lblContent5.Size = New System.Drawing.Size(100, 25)
        Me.lblContent5.TabIndex = 16
        Me.lblContent5.Text = "NOT USED"
        Me.lblContent5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblContent6
        '
        Me.lblContent6.AutoSize = True
        Me.lblContent6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblContent6.Location = New System.Drawing.Point(3, 170)
        Me.lblContent6.Name = "lblContent6"
        Me.lblContent6.Size = New System.Drawing.Size(100, 25)
        Me.lblContent6.TabIndex = 19
        Me.lblContent6.Text = "NOT USED"
        Me.lblContent6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblContent7
        '
        Me.lblContent7.AutoSize = True
        Me.lblContent7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblContent7.Location = New System.Drawing.Point(3, 195)
        Me.lblContent7.Name = "lblContent7"
        Me.lblContent7.Size = New System.Drawing.Size(100, 25)
        Me.lblContent7.TabIndex = 22
        Me.lblContent7.Text = "NOT USED"
        Me.lblContent7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblContent8
        '
        Me.lblContent8.AutoSize = True
        Me.lblContent8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblContent8.Location = New System.Drawing.Point(3, 220)
        Me.lblContent8.Name = "lblContent8"
        Me.lblContent8.Size = New System.Drawing.Size(100, 25)
        Me.lblContent8.TabIndex = 25
        Me.lblContent8.Text = "NOT USED"
        Me.lblContent8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblContent9
        '
        Me.lblContent9.AutoSize = True
        Me.lblContent9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblContent9.Location = New System.Drawing.Point(3, 245)
        Me.lblContent9.Name = "lblContent9"
        Me.lblContent9.Size = New System.Drawing.Size(100, 25)
        Me.lblContent9.TabIndex = 28
        Me.lblContent9.Text = "NOT USED"
        Me.lblContent9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblContent10
        '
        Me.lblContent10.AutoSize = True
        Me.lblContent10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblContent10.Location = New System.Drawing.Point(3, 270)
        Me.lblContent10.Name = "lblContent10"
        Me.lblContent10.Size = New System.Drawing.Size(100, 25)
        Me.lblContent10.TabIndex = 31
        Me.lblContent10.Text = "NOT USED"
        Me.lblContent10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblContent11
        '
        Me.lblContent11.AutoSize = True
        Me.lblContent11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblContent11.Location = New System.Drawing.Point(3, 295)
        Me.lblContent11.Name = "lblContent11"
        Me.lblContent11.Size = New System.Drawing.Size(100, 25)
        Me.lblContent11.TabIndex = 34
        Me.lblContent11.Text = "NOT USED"
        Me.lblContent11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtContent1
        '
        Me.txtContent1.BackColor = System.Drawing.Color.White
        Me.txtContent1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContent1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtContent1.Enabled = False
        Me.txtContent1.Location = New System.Drawing.Point(109, 48)
        Me.txtContent1.MaxLength = 20
        Me.txtContent1.Name = "txtContent1"
        Me.txtContent1.Size = New System.Drawing.Size(64, 20)
        Me.txtContent1.TabIndex = 5
        '
        'txtContent2
        '
        Me.txtContent2.BackColor = System.Drawing.Color.White
        Me.txtContent2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContent2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtContent2.Enabled = False
        Me.txtContent2.Location = New System.Drawing.Point(109, 73)
        Me.txtContent2.MaxLength = 20
        Me.txtContent2.Name = "txtContent2"
        Me.txtContent2.Size = New System.Drawing.Size(64, 20)
        Me.txtContent2.TabIndex = 8
        '
        'txtContent3
        '
        Me.txtContent3.BackColor = System.Drawing.Color.White
        Me.txtContent3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContent3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtContent3.Enabled = False
        Me.txtContent3.Location = New System.Drawing.Point(109, 98)
        Me.txtContent3.MaxLength = 20
        Me.txtContent3.Name = "txtContent3"
        Me.txtContent3.Size = New System.Drawing.Size(64, 20)
        Me.txtContent3.TabIndex = 11
        '
        'txtContent4
        '
        Me.txtContent4.BackColor = System.Drawing.Color.White
        Me.txtContent4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContent4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtContent4.Enabled = False
        Me.txtContent4.Location = New System.Drawing.Point(109, 123)
        Me.txtContent4.MaxLength = 20
        Me.txtContent4.Name = "txtContent4"
        Me.txtContent4.Size = New System.Drawing.Size(64, 20)
        Me.txtContent4.TabIndex = 14
        '
        'txtContent5
        '
        Me.txtContent5.BackColor = System.Drawing.Color.White
        Me.txtContent5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContent5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtContent5.Enabled = False
        Me.txtContent5.Location = New System.Drawing.Point(109, 148)
        Me.txtContent5.MaxLength = 20
        Me.txtContent5.Name = "txtContent5"
        Me.txtContent5.Size = New System.Drawing.Size(64, 20)
        Me.txtContent5.TabIndex = 17
        '
        'txtContent6
        '
        Me.txtContent6.BackColor = System.Drawing.Color.White
        Me.txtContent6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContent6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtContent6.Enabled = False
        Me.txtContent6.Location = New System.Drawing.Point(109, 173)
        Me.txtContent6.MaxLength = 20
        Me.txtContent6.Name = "txtContent6"
        Me.txtContent6.Size = New System.Drawing.Size(64, 20)
        Me.txtContent6.TabIndex = 20
        '
        'txtContent7
        '
        Me.txtContent7.BackColor = System.Drawing.Color.White
        Me.txtContent7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContent7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtContent7.Enabled = False
        Me.txtContent7.Location = New System.Drawing.Point(109, 198)
        Me.txtContent7.MaxLength = 20
        Me.txtContent7.Name = "txtContent7"
        Me.txtContent7.Size = New System.Drawing.Size(64, 20)
        Me.txtContent7.TabIndex = 23
        '
        'txtContent8
        '
        Me.txtContent8.BackColor = System.Drawing.Color.White
        Me.txtContent8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContent8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtContent8.Enabled = False
        Me.txtContent8.Location = New System.Drawing.Point(109, 223)
        Me.txtContent8.MaxLength = 20
        Me.txtContent8.Name = "txtContent8"
        Me.txtContent8.Size = New System.Drawing.Size(64, 20)
        Me.txtContent8.TabIndex = 26
        '
        'txtContent9
        '
        Me.txtContent9.BackColor = System.Drawing.Color.White
        Me.txtContent9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContent9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtContent9.Enabled = False
        Me.txtContent9.Location = New System.Drawing.Point(109, 248)
        Me.txtContent9.MaxLength = 20
        Me.txtContent9.Name = "txtContent9"
        Me.txtContent9.Size = New System.Drawing.Size(64, 20)
        Me.txtContent9.TabIndex = 29
        '
        'txtContent10
        '
        Me.txtContent10.BackColor = System.Drawing.Color.White
        Me.txtContent10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContent10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtContent10.Enabled = False
        Me.txtContent10.Location = New System.Drawing.Point(109, 273)
        Me.txtContent10.MaxLength = 20
        Me.txtContent10.Name = "txtContent10"
        Me.txtContent10.Size = New System.Drawing.Size(64, 20)
        Me.txtContent10.TabIndex = 32
        '
        'txtContent11
        '
        Me.txtContent11.BackColor = System.Drawing.Color.White
        Me.txtContent11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContent11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtContent11.Enabled = False
        Me.txtContent11.Location = New System.Drawing.Point(109, 298)
        Me.txtContent11.MaxLength = 20
        Me.txtContent11.Name = "txtContent11"
        Me.txtContent11.Size = New System.Drawing.Size(64, 20)
        Me.txtContent11.TabIndex = 35
        '
        'cmdForeColor0
        '
        Me.cmdForeColor0.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdForeColor0.Enabled = False
        Me.cmdForeColor0.Location = New System.Drawing.Point(179, 23)
        Me.cmdForeColor0.Name = "cmdForeColor0"
        Me.cmdForeColor0.Size = New System.Drawing.Size(14, 19)
        Me.cmdForeColor0.TabIndex = 3
        Me.cmdForeColor0.UseVisualStyleBackColor = True
        '
        'cmdContentsColorDel
        '
        Me.cmdContentsColorDel.BackgroundImage = CType(resources.GetObject("cmdContentsColorDel.BackgroundImage"), System.Drawing.Image)
        Me.cmdContentsColorDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdContentsColorDel.FlatAppearance.BorderSize = 0
        Me.cmdContentsColorDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdContentsColorDel.Location = New System.Drawing.Point(179, 3)
        Me.cmdContentsColorDel.Name = "cmdContentsColorDel"
        Me.cmdContentsColorDel.Size = New System.Drawing.Size(14, 14)
        Me.cmdContentsColorDel.TabIndex = 0
        Me.cmdContentsColorDel.UseVisualStyleBackColor = True
        '
        'frmArrayGenerator
        '
        Me.AcceptButton = Me.cmdOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CancelButton = Me.cmdClose
        Me.ClientSize = New System.Drawing.Size(287, 546)
        Me.Controls.Add(Me.grpContents)
        Me.Controls.Add(Me.grpArray)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.cmdClose)
        Me.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(295, 570)
        Me.Name = "frmArrayGenerator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Generate..."
        Me.TopMost = True
        Me.grpArray.ResumeLayout(False)
        Me.grpArray.PerformLayout()
        CType(Me.txtShadowY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtShadowX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpContents.ResumeLayout(False)
        Me.tblContents.ResumeLayout(False)
        Me.tblContents.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents dlgOpenDir As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents cmdOk As Button
    Friend WithEvents grpArray As GroupBox
    Friend WithEvents lblForeBackColor As Label
    Friend WithEvents lblFont As Label
    Friend WithEvents lblArrayName As Label
    Friend WithEvents txtArrayFileName As TextBox
    Friend WithEvents cmdArrayColorDel As Button
    Friend WithEvents cmdArrayFont As Button
    Friend WithEvents cmdArrayBack As Button
    Friend WithEvents cmdArrayFore As Button
    Friend WithEvents grpContents As GroupBox
    Friend WithEvents lblContent0 As Label
    Friend WithEvents txtContent0 As TextBox
    Friend WithEvents tblContents As TableLayoutPanel
    Friend WithEvents lblContent2 As Label
    Friend WithEvents lblContent1 As Label
    Friend WithEvents lblContent3 As Label
    Friend WithEvents lblContent4 As Label
    Friend WithEvents lblContent5 As Label
    Friend WithEvents lblContent6 As Label
    Friend WithEvents lblContent7 As Label
    Friend WithEvents lblContent8 As Label
    Friend WithEvents lblContent9 As Label
    Friend WithEvents lblContent10 As Label
    Friend WithEvents lblContent11 As Label
    Friend WithEvents txtContent1 As TextBox
    Friend WithEvents txtContent2 As TextBox
    Friend WithEvents txtContent3 As TextBox
    Friend WithEvents txtContent4 As TextBox
    Friend WithEvents txtContent5 As TextBox
    Friend WithEvents txtContent6 As TextBox
    Friend WithEvents txtContent7 As TextBox
    Friend WithEvents txtContent8 As TextBox
    Friend WithEvents txtContent9 As TextBox
    Friend WithEvents txtContent10 As TextBox
    Friend WithEvents txtContent11 As TextBox
    Friend WithEvents dlgFont As FontDialog
    Friend WithEvents dlgColor As ColorDialog
    Friend WithEvents txtContent12 As TextBox
    Friend WithEvents lblContent12 As Label
    Friend WithEvents cmdView As Button
    Friend WithEvents chkAutoscale As CheckBox
    Friend WithEvents cmdForeColor12 As Button
    Friend WithEvents cmdForeColor11 As Button
    Friend WithEvents cmdForeColor10 As Button
    Friend WithEvents cmdForeColor9 As Button
    Friend WithEvents cmdForeColor8 As Button
    Friend WithEvents cmdForeColor7 As Button
    Friend WithEvents cmdForeColor6 As Button
    Friend WithEvents cmdForeColor5 As Button
    Friend WithEvents cmdForeColor4 As Button
    Friend WithEvents cmdForeColor3 As Button
    Friend WithEvents cmdForeColor2 As Button
    Friend WithEvents cmdForeColor1 As Button
    Friend WithEvents cmdForeColor0 As Button
    Friend WithEvents cmdContentsColorDel As Button
    Friend WithEvents cmdShadowColor As Button
    Friend WithEvents lblShadow As Label
    Friend WithEvents txtShadowY As NumericUpDown
    Friend WithEvents txtShadowX As NumericUpDown
End Class
