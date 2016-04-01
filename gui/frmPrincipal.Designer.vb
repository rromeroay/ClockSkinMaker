<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.txtCenterX = New System.Windows.Forms.NumericUpDown()
        Me.txtCenterY = New System.Windows.Forms.NumericUpDown()
        Me.picPrevio = New System.Windows.Forms.PictureBox()
        Me.dlgFileName = New System.Windows.Forms.OpenFileDialog()
        Me.cmdFileName = New System.Windows.Forms.Button()
        Me.lstToolBox = New System.Windows.Forms.ListBox()
        Me.cmdDel = New System.Windows.Forms.Button()
        Me.pnlCanvas = New System.Windows.Forms.Panel()
        Me.grpCanvas = New System.Windows.Forms.GroupBox()
        Me.lvwCanvas = New System.Windows.Forms.ListView()
        Me.colType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.imgCanvas = New System.Windows.Forms.ImageList(Me.components)
        Me.cmdUp = New System.Windows.Forms.Button()
        Me.cmdDown = New System.Windows.Forms.Button()
        Me.grpProps = New System.Windows.Forms.GroupBox()
        Me.cmdArray = New System.Windows.Forms.Button()
        Me.lblFile = New System.Windows.Forms.Label()
        Me.lblColorArray = New System.Windows.Forms.Label()
        Me.lblColorBat = New System.Windows.Forms.Label()
        Me.lblDirection = New System.Windows.Forms.Label()
        Me.lblMulRotate = New System.Windows.Forms.Label()
        Me.lblCenterX = New System.Windows.Forms.Label()
        Me.txtWidth = New System.Windows.Forms.NumericUpDown()
        Me.lblWidth = New System.Windows.Forms.Label()
        Me.txtHeight = New System.Windows.Forms.NumericUpDown()
        Me.txtAngle = New System.Windows.Forms.NumericUpDown()
        Me.txtStartAngle = New System.Windows.Forms.NumericUpDown()
        Me.txtMulRotate = New System.Windows.Forms.NumericUpDown()
        Me.cmbDirection = New System.Windows.Forms.ComboBox()
        Me.cmbColorBat = New System.Windows.Forms.ComboBox()
        Me.lblAngle = New System.Windows.Forms.Label()
        Me.cmdColorDel = New System.Windows.Forms.Button()
        Me.cmdColor2 = New System.Windows.Forms.Button()
        Me.cmdColor1 = New System.Windows.Forms.Button()
        Me.lblComma = New System.Windows.Forms.Label()
        Me.dlgColor = New System.Windows.Forms.ColorDialog()
        Me.splPrincipal = New System.Windows.Forms.SplitContainer()
        Me.tblExplorer = New System.Windows.Forms.TableLayoutPanel()
        Me.lvwExplorer = New System.Windows.Forms.ListView()
        Me.colFilename = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.toolExplorer = New System.Windows.Forms.ToolStrip()
        Me.cmdDelSkin = New System.Windows.Forms.ToolStripButton()
        Me.cmdNewSkin = New System.Windows.Forms.ToolStripButton()
        Me.cmdImport = New System.Windows.Forms.ToolStripButton()
        Me.grpMode = New System.Windows.Forms.GroupBox()
        Me.lblSteps = New System.Windows.Forms.Label()
        Me.lblHeart = New System.Windows.Forms.Label()
        Me.lblMoon = New System.Windows.Forms.Label()
        Me.lblTemperature = New System.Windows.Forms.Label()
        Me.lblBatt = New System.Windows.Forms.Label()
        Me.txtSteps = New System.Windows.Forms.NumericUpDown()
        Me.cmbMoon = New System.Windows.Forms.ComboBox()
        Me.txtTemperature = New System.Windows.Forms.NumericUpDown()
        Me.txtHeart = New System.Windows.Forms.NumericUpDown()
        Me.cmbWeather = New System.Windows.Forms.ComboBox()
        Me.txtBatt = New System.Windows.Forms.NumericUpDown()
        Me.lblWeekday = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.txtYear = New System.Windows.Forms.NumericUpDown()
        Me.txtDay = New System.Windows.Forms.NumericUpDown()
        Me.cmbWeekday = New System.Windows.Forms.ComboBox()
        Me.cmbMonth = New System.Windows.Forms.ComboBox()
        Me.txtSeconds = New System.Windows.Forms.NumericUpDown()
        Me.txtMinutes = New System.Windows.Forms.NumericUpDown()
        Me.txtHour = New System.Windows.Forms.NumericUpDown()
        Me.grpToolBox = New System.Windows.Forms.GroupBox()
        Me.chkNow = New System.Windows.Forms.CheckBox()
        Me.optModeTest = New System.Windows.Forms.RadioButton()
        Me.optModeEdit = New System.Windows.Forms.RadioButton()
        Me.pnlToolBox = New System.Windows.Forms.Panel()
        Me.toolToolBox = New System.Windows.Forms.ToolStrip()
        Me.cmdSave = New System.Windows.Forms.ToolStripButton()
        Me.txtName = New System.Windows.Forms.ToolStripTextBox()
        Me.cmdLoad = New System.Windows.Forms.ToolStripButton()
        Me.cmdXml = New System.Windows.Forms.ToolStripButton()
        Me.cmdFileExplorer = New System.Windows.Forms.ToolStripButton()
        Me.sep2 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblX = New System.Windows.Forms.ToolStripLabel()
        Me.lblY = New System.Windows.Forms.ToolStripLabel()
        Me.cmdClear = New System.Windows.Forms.ToolStripButton()
        Me.staBar = New System.Windows.Forms.StatusStrip()
        Me.dlgFont = New System.Windows.Forms.FontDialog()
        Me.mnuPrincipal = New System.Windows.Forms.ToolStrip()
        Me.mnuPrincFile = New System.Windows.Forms.ToolStripDropDownButton()
        Me.mnuPrincExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrincHelp = New System.Windows.Forms.ToolStripSplitButton()
        Me.mnuPrincAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.dirWatcher = New System.IO.FileSystemWatcher()
        CType(Me.txtCenterX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCenterY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPrevio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCanvas.SuspendLayout()
        Me.grpProps.SuspendLayout()
        CType(Me.txtWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAngle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStartAngle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMulRotate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.splPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splPrincipal.Panel1.SuspendLayout()
        Me.splPrincipal.Panel2.SuspendLayout()
        Me.splPrincipal.SuspendLayout()
        Me.tblExplorer.SuspendLayout()
        Me.toolExplorer.SuspendLayout()
        Me.grpMode.SuspendLayout()
        CType(Me.txtSteps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTemperature, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHeart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBatt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtYear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSeconds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMinutes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHour, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpToolBox.SuspendLayout()
        Me.pnlToolBox.SuspendLayout()
        Me.toolToolBox.SuspendLayout()
        Me.mnuPrincipal.SuspendLayout()
        CType(Me.dirWatcher, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCenterX
        '
        Me.txtCenterX.Location = New System.Drawing.Point(112, 36)
        Me.txtCenterX.Maximum = New Decimal(New Integer() {1024, 0, 0, 0})
        Me.txtCenterX.Minimum = New Decimal(New Integer() {1024, 0, 0, -2147483648})
        Me.txtCenterX.Name = "txtCenterX"
        Me.txtCenterX.Size = New System.Drawing.Size(61, 20)
        Me.txtCenterX.TabIndex = 4
        Me.txtCenterX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCenterY
        '
        Me.txtCenterY.Location = New System.Drawing.Point(181, 36)
        Me.txtCenterY.Maximum = New Decimal(New Integer() {1024, 0, 0, 0})
        Me.txtCenterY.Minimum = New Decimal(New Integer() {1024, 0, 0, -2147483648})
        Me.txtCenterY.Name = "txtCenterY"
        Me.txtCenterY.Size = New System.Drawing.Size(61, 20)
        Me.txtCenterY.TabIndex = 5
        Me.txtCenterY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'picPrevio
        '
        Me.picPrevio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPrevio.Location = New System.Drawing.Point(3, 3)
        Me.picPrevio.Name = "picPrevio"
        Me.picPrevio.Size = New System.Drawing.Size(130, 130)
        Me.picPrevio.TabIndex = 11
        Me.picPrevio.TabStop = False
        '
        'dlgFileName
        '
        Me.dlgFileName.RestoreDirectory = True
        '
        'cmdFileName
        '
        Me.cmdFileName.Location = New System.Drawing.Point(112, 11)
        Me.cmdFileName.Name = "cmdFileName"
        Me.cmdFileName.Size = New System.Drawing.Size(61, 23)
        Me.cmdFileName.TabIndex = 1
        Me.cmdFileName.Text = "..."
        Me.cmdFileName.UseVisualStyleBackColor = True
        '
        'lstToolBox
        '
        Me.lstToolBox.BackColor = System.Drawing.Color.White
        Me.lstToolBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstToolBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstToolBox.Location = New System.Drawing.Point(1, 13)
        Me.lstToolBox.Name = "lstToolBox"
        Me.lstToolBox.Size = New System.Drawing.Size(126, 450)
        Me.lstToolBox.TabIndex = 0
        '
        'cmdDel
        '
        Me.cmdDel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdDel.BackgroundImage = CType(resources.GetObject("cmdDel.BackgroundImage"), System.Drawing.Image)
        Me.cmdDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdDel.FlatAppearance.BorderSize = 0
        Me.cmdDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDel.Location = New System.Drawing.Point(246, 38)
        Me.cmdDel.Name = "cmdDel"
        Me.cmdDel.Size = New System.Drawing.Size(20, 20)
        Me.cmdDel.TabIndex = 1
        Me.cmdDel.UseVisualStyleBackColor = True
        '
        'pnlCanvas
        '
        Me.pnlCanvas.Location = New System.Drawing.Point(139, 50)
        Me.pnlCanvas.Name = "pnlCanvas"
        Me.pnlCanvas.Size = New System.Drawing.Size(400, 400)
        Me.pnlCanvas.TabIndex = 1
        '
        'grpCanvas
        '
        Me.grpCanvas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpCanvas.Controls.Add(Me.lvwCanvas)
        Me.grpCanvas.Controls.Add(Me.cmdDel)
        Me.grpCanvas.Controls.Add(Me.cmdUp)
        Me.grpCanvas.Controls.Add(Me.cmdDown)
        Me.grpCanvas.Location = New System.Drawing.Point(545, 50)
        Me.grpCanvas.Margin = New System.Windows.Forms.Padding(0)
        Me.grpCanvas.Name = "grpCanvas"
        Me.grpCanvas.Padding = New System.Windows.Forms.Padding(1, 0, 0, 1)
        Me.grpCanvas.Size = New System.Drawing.Size(269, 350)
        Me.grpCanvas.TabIndex = 0
        Me.grpCanvas.TabStop = False
        Me.grpCanvas.Text = "Layers"
        '
        'lvwCanvas
        '
        Me.lvwCanvas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwCanvas.BackColor = System.Drawing.Color.White
        Me.lvwCanvas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvwCanvas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colType, Me.colName})
        Me.lvwCanvas.FullRowSelect = True
        Me.lvwCanvas.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvwCanvas.HideSelection = False
        Me.lvwCanvas.Location = New System.Drawing.Point(3, 12)
        Me.lvwCanvas.MultiSelect = False
        Me.lvwCanvas.Name = "lvwCanvas"
        Me.lvwCanvas.ShowGroups = False
        Me.lvwCanvas.ShowItemToolTips = True
        Me.lvwCanvas.Size = New System.Drawing.Size(236, 335)
        Me.lvwCanvas.SmallImageList = Me.imgCanvas
        Me.lvwCanvas.TabIndex = 0
        Me.lvwCanvas.UseCompatibleStateImageBehavior = False
        Me.lvwCanvas.View = System.Windows.Forms.View.Details
        '
        'colType
        '
        Me.colType.Text = "Type"
        Me.colType.Width = 133
        '
        'colName
        '
        Me.colName.Text = "Name"
        Me.colName.Width = 120
        '
        'imgCanvas
        '
        Me.imgCanvas.ImageStream = CType(resources.GetObject("imgCanvas.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgCanvas.TransparentColor = System.Drawing.Color.Transparent
        Me.imgCanvas.Images.SetKeyName(0, "new")
        Me.imgCanvas.Images.SetKeyName(1, "warning")
        '
        'cmdUp
        '
        Me.cmdUp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdUp.BackgroundImage = CType(resources.GetObject("cmdUp.BackgroundImage"), System.Drawing.Image)
        Me.cmdUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdUp.FlatAppearance.BorderSize = 0
        Me.cmdUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdUp.Location = New System.Drawing.Point(246, 300)
        Me.cmdUp.Name = "cmdUp"
        Me.cmdUp.Size = New System.Drawing.Size(20, 20)
        Me.cmdUp.TabIndex = 2
        Me.cmdUp.UseVisualStyleBackColor = True
        '
        'cmdDown
        '
        Me.cmdDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdDown.BackgroundImage = CType(resources.GetObject("cmdDown.BackgroundImage"), System.Drawing.Image)
        Me.cmdDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdDown.FlatAppearance.BorderSize = 0
        Me.cmdDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDown.Location = New System.Drawing.Point(246, 326)
        Me.cmdDown.Name = "cmdDown"
        Me.cmdDown.Size = New System.Drawing.Size(20, 20)
        Me.cmdDown.TabIndex = 3
        Me.cmdDown.UseVisualStyleBackColor = True
        '
        'grpProps
        '
        Me.grpProps.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpProps.Controls.Add(Me.cmdArray)
        Me.grpProps.Controls.Add(Me.lblFile)
        Me.grpProps.Controls.Add(Me.lblColorArray)
        Me.grpProps.Controls.Add(Me.lblColorBat)
        Me.grpProps.Controls.Add(Me.lblDirection)
        Me.grpProps.Controls.Add(Me.lblMulRotate)
        Me.grpProps.Controls.Add(Me.lblCenterX)
        Me.grpProps.Controls.Add(Me.txtWidth)
        Me.grpProps.Controls.Add(Me.cmdFileName)
        Me.grpProps.Controls.Add(Me.lblWidth)
        Me.grpProps.Controls.Add(Me.txtHeight)
        Me.grpProps.Controls.Add(Me.txtAngle)
        Me.grpProps.Controls.Add(Me.txtStartAngle)
        Me.grpProps.Controls.Add(Me.txtMulRotate)
        Me.grpProps.Controls.Add(Me.cmbDirection)
        Me.grpProps.Controls.Add(Me.cmbColorBat)
        Me.grpProps.Controls.Add(Me.txtCenterY)
        Me.grpProps.Controls.Add(Me.lblAngle)
        Me.grpProps.Controls.Add(Me.cmdColorDel)
        Me.grpProps.Controls.Add(Me.txtCenterX)
        Me.grpProps.Controls.Add(Me.cmdColor2)
        Me.grpProps.Controls.Add(Me.cmdColor1)
        Me.grpProps.Controls.Add(Me.lblComma)
        Me.grpProps.Location = New System.Drawing.Point(545, 400)
        Me.grpProps.Margin = New System.Windows.Forms.Padding(0)
        Me.grpProps.Name = "grpProps"
        Me.grpProps.Size = New System.Drawing.Size(269, 198)
        Me.grpProps.TabIndex = 1
        Me.grpProps.TabStop = False
        Me.grpProps.Text = "Properties"
        '
        'cmdArray
        '
        Me.cmdArray.Location = New System.Drawing.Point(181, 11)
        Me.cmdArray.Name = "cmdArray"
        Me.cmdArray.Size = New System.Drawing.Size(61, 23)
        Me.cmdArray.TabIndex = 2
        Me.cmdArray.Text = "Create"
        Me.cmdArray.UseVisualStyleBackColor = True
        '
        'lblFile
        '
        Me.lblFile.AutoSize = True
        Me.lblFile.Location = New System.Drawing.Point(51, 16)
        Me.lblFile.Name = "lblFile"
        Me.lblFile.Size = New System.Drawing.Size(55, 13)
        Me.lblFile.TabIndex = 0
        Me.lblFile.Text = "Filename"
        '
        'lblColorArray
        '
        Me.lblColorArray.AutoSize = True
        Me.lblColorArray.Location = New System.Drawing.Point(33, 174)
        Me.lblColorArray.Name = "lblColorArray"
        Me.lblColorArray.Size = New System.Drawing.Size(73, 13)
        Me.lblColorArray.TabIndex = 18
        Me.lblColorArray.Text = "Color array"
        '
        'lblColorBat
        '
        Me.lblColorBat.AutoSize = True
        Me.lblColorBat.Location = New System.Drawing.Point(39, 151)
        Me.lblColorBat.Name = "lblColorBat"
        Me.lblColorBat.Size = New System.Drawing.Size(67, 13)
        Me.lblColorBat.TabIndex = 16
        Me.lblColorBat.Text = "Batt color"
        '
        'lblDirection
        '
        Me.lblDirection.AutoSize = True
        Me.lblDirection.Location = New System.Drawing.Point(45, 128)
        Me.lblDirection.Name = "lblDirection"
        Me.lblDirection.Size = New System.Drawing.Size(61, 13)
        Me.lblDirection.TabIndex = 14
        Me.lblDirection.Text = "Direction"
        '
        'lblMulRotate
        '
        Me.lblMulRotate.AutoSize = True
        Me.lblMulRotate.Location = New System.Drawing.Point(45, 84)
        Me.lblMulRotate.Name = "lblMulRotate"
        Me.lblMulRotate.Size = New System.Drawing.Size(61, 13)
        Me.lblMulRotate.TabIndex = 9
        Me.lblMulRotate.Text = "Mulrotate"
        '
        'lblCenterX
        '
        Me.lblCenterX.AutoSize = True
        Me.lblCenterX.Location = New System.Drawing.Point(45, 40)
        Me.lblCenterX.Name = "lblCenterX"
        Me.lblCenterX.Size = New System.Drawing.Size(61, 13)
        Me.lblCenterX.TabIndex = 3
        Me.lblCenterX.Text = "CenterX/Y"
        '
        'txtWidth
        '
        Me.txtWidth.Location = New System.Drawing.Point(112, 58)
        Me.txtWidth.Maximum = New Decimal(New Integer() {1024, 0, 0, 0})
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(61, 20)
        Me.txtWidth.TabIndex = 7
        Me.txtWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblWidth
        '
        Me.lblWidth.AutoSize = True
        Me.lblWidth.Location = New System.Drawing.Point(27, 62)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(79, 13)
        Me.lblWidth.TabIndex = 6
        Me.lblWidth.Text = "Width/Height"
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(181, 58)
        Me.txtHeight.Maximum = New Decimal(New Integer() {1024, 0, 0, 0})
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(61, 20)
        Me.txtHeight.TabIndex = 8
        Me.txtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAngle
        '
        Me.txtAngle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAngle.Location = New System.Drawing.Point(112, 102)
        Me.txtAngle.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.txtAngle.Minimum = New Decimal(New Integer() {360, 0, 0, -2147483648})
        Me.txtAngle.Name = "txtAngle"
        Me.txtAngle.Size = New System.Drawing.Size(61, 20)
        Me.txtAngle.TabIndex = 12
        Me.txtAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtStartAngle
        '
        Me.txtStartAngle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtStartAngle.Location = New System.Drawing.Point(181, 102)
        Me.txtStartAngle.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.txtStartAngle.Minimum = New Decimal(New Integer() {360, 0, 0, -2147483648})
        Me.txtStartAngle.Name = "txtStartAngle"
        Me.txtStartAngle.Size = New System.Drawing.Size(61, 20)
        Me.txtStartAngle.TabIndex = 13
        Me.txtStartAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMulRotate
        '
        Me.txtMulRotate.Location = New System.Drawing.Point(112, 80)
        Me.txtMulRotate.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.txtMulRotate.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
        Me.txtMulRotate.Name = "txtMulRotate"
        Me.txtMulRotate.Size = New System.Drawing.Size(61, 20)
        Me.txtMulRotate.TabIndex = 10
        Me.txtMulRotate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmbDirection
        '
        Me.cmbDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDirection.FormattingEnabled = True
        Me.cmbDirection.Location = New System.Drawing.Point(112, 124)
        Me.cmbDirection.Name = "cmbDirection"
        Me.cmbDirection.Size = New System.Drawing.Size(61, 21)
        Me.cmbDirection.TabIndex = 15
        '
        'cmbColorBat
        '
        Me.cmbColorBat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbColorBat.FormattingEnabled = True
        Me.cmbColorBat.Location = New System.Drawing.Point(112, 147)
        Me.cmbColorBat.Name = "cmbColorBat"
        Me.cmbColorBat.Size = New System.Drawing.Size(61, 21)
        Me.cmbColorBat.TabIndex = 17
        '
        'lblAngle
        '
        Me.lblAngle.AutoSize = True
        Me.lblAngle.Location = New System.Drawing.Point(3, 106)
        Me.lblAngle.Name = "lblAngle"
        Me.lblAngle.Size = New System.Drawing.Size(103, 13)
        Me.lblAngle.TabIndex = 11
        Me.lblAngle.Text = "Angle/StartAngle"
        '
        'cmdColorDel
        '
        Me.cmdColorDel.BackgroundImage = CType(resources.GetObject("cmdColorDel.BackgroundImage"), System.Drawing.Image)
        Me.cmdColorDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdColorDel.FlatAppearance.BorderSize = 0
        Me.cmdColorDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdColorDel.Location = New System.Drawing.Point(246, 172)
        Me.cmdColorDel.Name = "cmdColorDel"
        Me.cmdColorDel.Size = New System.Drawing.Size(14, 17)
        Me.cmdColorDel.TabIndex = 22
        Me.cmdColorDel.UseVisualStyleBackColor = True
        '
        'cmdColor2
        '
        Me.cmdColor2.Location = New System.Drawing.Point(181, 170)
        Me.cmdColor2.Name = "cmdColor2"
        Me.cmdColor2.Size = New System.Drawing.Size(61, 21)
        Me.cmdColor2.TabIndex = 21
        Me.cmdColor2.Text = "Transp"
        Me.cmdColor2.UseVisualStyleBackColor = True
        '
        'cmdColor1
        '
        Me.cmdColor1.Location = New System.Drawing.Point(112, 170)
        Me.cmdColor1.Name = "cmdColor1"
        Me.cmdColor1.Size = New System.Drawing.Size(61, 21)
        Me.cmdColor1.TabIndex = 19
        Me.cmdColor1.Text = "Transp"
        Me.cmdColor1.UseVisualStyleBackColor = True
        '
        'lblComma
        '
        Me.lblComma.AutoSize = True
        Me.lblComma.Location = New System.Drawing.Point(171, 174)
        Me.lblComma.Name = "lblComma"
        Me.lblComma.Size = New System.Drawing.Size(13, 13)
        Me.lblComma.TabIndex = 20
        Me.lblComma.Text = ","
        '
        'splPrincipal
        '
        Me.splPrincipal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.splPrincipal.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.splPrincipal.Location = New System.Drawing.Point(0, 27)
        Me.splPrincipal.Name = "splPrincipal"
        '
        'splPrincipal.Panel1
        '
        Me.splPrincipal.Panel1.Controls.Add(Me.tblExplorer)
        Me.splPrincipal.Panel1MinSize = 150
        '
        'splPrincipal.Panel2
        '
        Me.splPrincipal.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.splPrincipal.Panel2.Controls.Add(Me.grpProps)
        Me.splPrincipal.Panel2.Controls.Add(Me.grpCanvas)
        Me.splPrincipal.Panel2.Controls.Add(Me.grpMode)
        Me.splPrincipal.Panel2.Controls.Add(Me.grpToolBox)
        Me.splPrincipal.Panel2.Controls.Add(Me.chkNow)
        Me.splPrincipal.Panel2.Controls.Add(Me.optModeTest)
        Me.splPrincipal.Panel2.Controls.Add(Me.optModeEdit)
        Me.splPrincipal.Panel2.Controls.Add(Me.pnlToolBox)
        Me.splPrincipal.Panel2.Controls.Add(Me.picPrevio)
        Me.splPrincipal.Panel2.Controls.Add(Me.pnlCanvas)
        Me.splPrincipal.Panel2MinSize = 800
        Me.splPrincipal.Size = New System.Drawing.Size(1008, 601)
        Me.splPrincipal.SplitterDistance = 187
        Me.splPrincipal.TabIndex = 1
        Me.splPrincipal.TabStop = False
        '
        'tblExplorer
        '
        Me.tblExplorer.ColumnCount = 1
        Me.tblExplorer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblExplorer.Controls.Add(Me.lvwExplorer, 0, 1)
        Me.tblExplorer.Controls.Add(Me.toolExplorer, 0, 0)
        Me.tblExplorer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblExplorer.Location = New System.Drawing.Point(0, 0)
        Me.tblExplorer.Name = "tblExplorer"
        Me.tblExplorer.RowCount = 2
        Me.tblExplorer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tblExplorer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblExplorer.Size = New System.Drawing.Size(187, 601)
        Me.tblExplorer.TabIndex = 0
        '
        'lvwExplorer
        '
        Me.lvwExplorer.BackColor = System.Drawing.Color.White
        Me.lvwExplorer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvwExplorer.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colFilename})
        Me.lvwExplorer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvwExplorer.FullRowSelect = True
        Me.lvwExplorer.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lvwExplorer.HideSelection = False
        Me.lvwExplorer.Location = New System.Drawing.Point(3, 35)
        Me.lvwExplorer.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.lvwExplorer.MultiSelect = False
        Me.lvwExplorer.Name = "lvwExplorer"
        Me.lvwExplorer.ShowGroups = False
        Me.lvwExplorer.ShowItemToolTips = True
        Me.lvwExplorer.Size = New System.Drawing.Size(181, 563)
        Me.lvwExplorer.TabIndex = 1
        Me.lvwExplorer.UseCompatibleStateImageBehavior = False
        Me.lvwExplorer.View = System.Windows.Forms.View.Details
        '
        'colFilename
        '
        Me.colFilename.Text = "ClockSkin"
        Me.colFilename.Width = 100
        '
        'toolExplorer
        '
        Me.toolExplorer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolExplorer.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdDelSkin, Me.cmdNewSkin, Me.cmdImport})
        Me.toolExplorer.Location = New System.Drawing.Point(3, 3)
        Me.toolExplorer.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.toolExplorer.Name = "toolExplorer"
        Me.toolExplorer.Size = New System.Drawing.Size(181, 32)
        Me.toolExplorer.TabIndex = 0
        Me.toolExplorer.Text = "ClockSkin actions"
        '
        'cmdDelSkin
        '
        Me.cmdDelSkin.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.cmdDelSkin.AutoSize = False
        Me.cmdDelSkin.BackColor = System.Drawing.Color.Transparent
        Me.cmdDelSkin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdDelSkin.Image = CType(resources.GetObject("cmdDelSkin.Image"), System.Drawing.Image)
        Me.cmdDelSkin.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdDelSkin.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdDelSkin.Name = "cmdDelSkin"
        Me.cmdDelSkin.Size = New System.Drawing.Size(30, 30)
        Me.cmdDelSkin.Text = "Delete"
        Me.cmdDelSkin.ToolTipText = "Delete skin"
        '
        'cmdNewSkin
        '
        Me.cmdNewSkin.AutoSize = False
        Me.cmdNewSkin.BackColor = System.Drawing.Color.Transparent
        Me.cmdNewSkin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdNewSkin.Image = CType(resources.GetObject("cmdNewSkin.Image"), System.Drawing.Image)
        Me.cmdNewSkin.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdNewSkin.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdNewSkin.Name = "cmdNewSkin"
        Me.cmdNewSkin.Size = New System.Drawing.Size(30, 30)
        Me.cmdNewSkin.Text = "New"
        Me.cmdNewSkin.ToolTipText = "Add skin"
        '
        'cmdImport
        '
        Me.cmdImport.AutoSize = False
        Me.cmdImport.BackColor = System.Drawing.Color.Transparent
        Me.cmdImport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdImport.Image = CType(resources.GetObject("cmdImport.Image"), System.Drawing.Image)
        Me.cmdImport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdImport.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdImport.Name = "cmdImport"
        Me.cmdImport.Size = New System.Drawing.Size(30, 30)
        Me.cmdImport.Text = "Import"
        Me.cmdImport.ToolTipText = "Import .watch images"
        '
        'grpMode
        '
        Me.grpMode.Controls.Add(Me.lblSteps)
        Me.grpMode.Controls.Add(Me.lblHeart)
        Me.grpMode.Controls.Add(Me.lblMoon)
        Me.grpMode.Controls.Add(Me.lblTemperature)
        Me.grpMode.Controls.Add(Me.lblBatt)
        Me.grpMode.Controls.Add(Me.txtSteps)
        Me.grpMode.Controls.Add(Me.cmbMoon)
        Me.grpMode.Controls.Add(Me.txtTemperature)
        Me.grpMode.Controls.Add(Me.txtHeart)
        Me.grpMode.Controls.Add(Me.cmbWeather)
        Me.grpMode.Controls.Add(Me.txtBatt)
        Me.grpMode.Controls.Add(Me.lblWeekday)
        Me.grpMode.Controls.Add(Me.lblDate)
        Me.grpMode.Controls.Add(Me.lblTime)
        Me.grpMode.Controls.Add(Me.txtYear)
        Me.grpMode.Controls.Add(Me.txtDay)
        Me.grpMode.Controls.Add(Me.cmbWeekday)
        Me.grpMode.Controls.Add(Me.cmbMonth)
        Me.grpMode.Controls.Add(Me.txtSeconds)
        Me.grpMode.Controls.Add(Me.txtMinutes)
        Me.grpMode.Controls.Add(Me.txtHour)
        Me.grpMode.Location = New System.Drawing.Point(139, 467)
        Me.grpMode.Margin = New System.Windows.Forms.Padding(0)
        Me.grpMode.Name = "grpMode"
        Me.grpMode.Padding = New System.Windows.Forms.Padding(0)
        Me.grpMode.Size = New System.Drawing.Size(400, 122)
        Me.grpMode.TabIndex = 5
        Me.grpMode.TabStop = False
        Me.grpMode.Visible = False
        '
        'lblSteps
        '
        Me.lblSteps.AutoSize = True
        Me.lblSteps.Location = New System.Drawing.Point(131, 102)
        Me.lblSteps.Name = "lblSteps"
        Me.lblSteps.Size = New System.Drawing.Size(37, 13)
        Me.lblSteps.TabIndex = 19
        Me.lblSteps.Text = "Steps"
        '
        'lblHeart
        '
        Me.lblHeart.AutoSize = True
        Me.lblHeart.Location = New System.Drawing.Point(31, 102)
        Me.lblHeart.Name = "lblHeart"
        Me.lblHeart.Size = New System.Drawing.Size(43, 13)
        Me.lblHeart.TabIndex = 17
        Me.lblHeart.Text = "Heart "
        '
        'lblMoon
        '
        Me.lblMoon.AutoSize = True
        Me.lblMoon.Location = New System.Drawing.Point(255, 80)
        Me.lblMoon.Name = "lblMoon"
        Me.lblMoon.Size = New System.Drawing.Size(31, 13)
        Me.lblMoon.TabIndex = 15
        Me.lblMoon.Text = "Moon"
        '
        'lblTemperature
        '
        Me.lblTemperature.AutoSize = True
        Me.lblTemperature.Location = New System.Drawing.Point(1, 80)
        Me.lblTemperature.Name = "lblTemperature"
        Me.lblTemperature.Size = New System.Drawing.Size(73, 13)
        Me.lblTemperature.TabIndex = 12
        Me.lblTemperature.Text = "Temperature"
        '
        'lblBatt
        '
        Me.lblBatt.AutoSize = True
        Me.lblBatt.Location = New System.Drawing.Point(25, 58)
        Me.lblBatt.Name = "lblBatt"
        Me.lblBatt.Size = New System.Drawing.Size(49, 13)
        Me.lblBatt.TabIndex = 10
        Me.lblBatt.Text = "Battery"
        '
        'txtSteps
        '
        Me.txtSteps.Enabled = False
        Me.txtSteps.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.txtSteps.Location = New System.Drawing.Point(174, 98)
        Me.txtSteps.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.txtSteps.Name = "txtSteps"
        Me.txtSteps.Size = New System.Drawing.Size(60, 20)
        Me.txtSteps.TabIndex = 20
        Me.txtSteps.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmbMoon
        '
        Me.cmbMoon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMoon.Enabled = False
        Me.cmbMoon.FormattingEnabled = True
        Me.cmbMoon.Location = New System.Drawing.Point(289, 76)
        Me.cmbMoon.Name = "cmbMoon"
        Me.cmbMoon.Size = New System.Drawing.Size(103, 21)
        Me.cmbMoon.TabIndex = 16
        '
        'txtTemperature
        '
        Me.txtTemperature.Enabled = False
        Me.txtTemperature.Location = New System.Drawing.Point(77, 76)
        Me.txtTemperature.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.txtTemperature.Minimum = New Decimal(New Integer() {99, 0, 0, -2147483648})
        Me.txtTemperature.Name = "txtTemperature"
        Me.txtTemperature.Size = New System.Drawing.Size(48, 20)
        Me.txtTemperature.TabIndex = 13
        Me.txtTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtHeart
        '
        Me.txtHeart.Enabled = False
        Me.txtHeart.Location = New System.Drawing.Point(77, 98)
        Me.txtHeart.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.txtHeart.Name = "txtHeart"
        Me.txtHeart.Size = New System.Drawing.Size(48, 20)
        Me.txtHeart.TabIndex = 18
        Me.txtHeart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmbWeather
        '
        Me.cmbWeather.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbWeather.Enabled = False
        Me.cmbWeather.FormattingEnabled = True
        Me.cmbWeather.Location = New System.Drawing.Point(131, 76)
        Me.cmbWeather.Name = "cmbWeather"
        Me.cmbWeather.Size = New System.Drawing.Size(103, 21)
        Me.cmbWeather.TabIndex = 14
        '
        'txtBatt
        '
        Me.txtBatt.Enabled = False
        Me.txtBatt.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.txtBatt.Location = New System.Drawing.Point(77, 54)
        Me.txtBatt.Name = "txtBatt"
        Me.txtBatt.Size = New System.Drawing.Size(48, 20)
        Me.txtBatt.TabIndex = 11
        Me.txtBatt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblWeekday
        '
        Me.lblWeekday.AutoSize = True
        Me.lblWeekday.Location = New System.Drawing.Point(237, 34)
        Me.lblWeekday.Name = "lblWeekday"
        Me.lblWeekday.Size = New System.Drawing.Size(49, 13)
        Me.lblWeekday.TabIndex = 8
        Me.lblWeekday.Text = "Weekday"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(7, 36)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(67, 13)
        Me.lblDate.TabIndex = 4
        Me.lblDate.Text = "dd-mm-yyyy"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(19, 14)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(55, 13)
        Me.lblTime.TabIndex = 0
        Me.lblTime.Text = "hh:mm:ss"
        '
        'txtYear
        '
        Me.txtYear.Enabled = False
        Me.txtYear.Location = New System.Drawing.Point(186, 32)
        Me.txtYear.Maximum = New Decimal(New Integer() {2999, 0, 0, 0})
        Me.txtYear.Minimum = New Decimal(New Integer() {1900, 0, 0, 0})
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(48, 20)
        Me.txtYear.TabIndex = 7
        Me.txtYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtYear.Value = New Decimal(New Integer() {1900, 0, 0, 0})
        '
        'txtDay
        '
        Me.txtDay.Enabled = False
        Me.txtDay.Location = New System.Drawing.Point(77, 32)
        Me.txtDay.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
        Me.txtDay.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtDay.Name = "txtDay"
        Me.txtDay.Size = New System.Drawing.Size(48, 20)
        Me.txtDay.TabIndex = 5
        Me.txtDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtDay.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'cmbWeekday
        '
        Me.cmbWeekday.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbWeekday.Enabled = False
        Me.cmbWeekday.FormattingEnabled = True
        Me.cmbWeekday.Location = New System.Drawing.Point(289, 31)
        Me.cmbWeekday.Name = "cmbWeekday"
        Me.cmbWeekday.Size = New System.Drawing.Size(48, 21)
        Me.cmbWeekday.TabIndex = 9
        '
        'cmbMonth
        '
        Me.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMonth.Enabled = False
        Me.cmbMonth.FormattingEnabled = True
        Me.cmbMonth.Location = New System.Drawing.Point(131, 32)
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.Size = New System.Drawing.Size(48, 21)
        Me.cmbMonth.TabIndex = 6
        '
        'txtSeconds
        '
        Me.txtSeconds.Enabled = False
        Me.txtSeconds.Location = New System.Drawing.Point(186, 10)
        Me.txtSeconds.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.txtSeconds.Name = "txtSeconds"
        Me.txtSeconds.Size = New System.Drawing.Size(48, 20)
        Me.txtSeconds.TabIndex = 3
        Me.txtSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMinutes
        '
        Me.txtMinutes.Enabled = False
        Me.txtMinutes.Location = New System.Drawing.Point(131, 10)
        Me.txtMinutes.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.txtMinutes.Name = "txtMinutes"
        Me.txtMinutes.Size = New System.Drawing.Size(48, 20)
        Me.txtMinutes.TabIndex = 2
        Me.txtMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtHour
        '
        Me.txtHour.Enabled = False
        Me.txtHour.Location = New System.Drawing.Point(77, 10)
        Me.txtHour.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.txtHour.Name = "txtHour"
        Me.txtHour.Size = New System.Drawing.Size(48, 20)
        Me.txtHour.TabIndex = 1
        Me.txtHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'grpToolBox
        '
        Me.grpToolBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpToolBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.grpToolBox.Controls.Add(Me.lstToolBox)
        Me.grpToolBox.Location = New System.Drawing.Point(3, 133)
        Me.grpToolBox.Name = "grpToolBox"
        Me.grpToolBox.Padding = New System.Windows.Forms.Padding(1, 0, 3, 2)
        Me.grpToolBox.Size = New System.Drawing.Size(130, 465)
        Me.grpToolBox.TabIndex = 0
        Me.grpToolBox.TabStop = False
        Me.grpToolBox.Text = "Toolbox"
        '
        'chkNow
        '
        Me.chkNow.AutoSize = True
        Me.chkNow.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkNow.Enabled = False
        Me.chkNow.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNow.Location = New System.Drawing.Point(495, 452)
        Me.chkNow.Name = "chkNow"
        Me.chkNow.Size = New System.Drawing.Size(44, 17)
        Me.chkNow.TabIndex = 4
        Me.chkNow.Text = "Now"
        Me.chkNow.UseVisualStyleBackColor = True
        '
        'optModeTest
        '
        Me.optModeTest.AutoSize = True
        Me.optModeTest.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optModeTest.Location = New System.Drawing.Point(192, 452)
        Me.optModeTest.Name = "optModeTest"
        Me.optModeTest.Size = New System.Drawing.Size(265, 17)
        Me.optModeTest.TabIndex = 3
        Me.optModeTest.Text = "Simulation (can differ from real engine)"
        Me.optModeTest.UseVisualStyleBackColor = True
        '
        'optModeEdit
        '
        Me.optModeEdit.AutoSize = True
        Me.optModeEdit.Checked = True
        Me.optModeEdit.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optModeEdit.Location = New System.Drawing.Point(139, 452)
        Me.optModeEdit.Name = "optModeEdit"
        Me.optModeEdit.Size = New System.Drawing.Size(49, 17)
        Me.optModeEdit.TabIndex = 2
        Me.optModeEdit.TabStop = True
        Me.optModeEdit.Text = "Edit"
        Me.optModeEdit.UseVisualStyleBackColor = True
        '
        'pnlToolBox
        '
        Me.pnlToolBox.Controls.Add(Me.toolToolBox)
        Me.pnlToolBox.Location = New System.Drawing.Point(139, 3)
        Me.pnlToolBox.Name = "pnlToolBox"
        Me.pnlToolBox.Size = New System.Drawing.Size(400, 41)
        Me.pnlToolBox.TabIndex = 40
        '
        'toolToolBox
        '
        Me.toolToolBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolToolBox.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdSave, Me.txtName, Me.cmdLoad, Me.cmdXml, Me.cmdFileExplorer, Me.sep2, Me.lblX, Me.lblY, Me.cmdClear})
        Me.toolToolBox.Location = New System.Drawing.Point(0, 0)
        Me.toolToolBox.Name = "toolToolBox"
        Me.toolToolBox.Size = New System.Drawing.Size(400, 41)
        Me.toolToolBox.TabIndex = 0
        Me.toolToolBox.Text = "ToolStrip1"
        '
        'cmdSave
        '
        Me.cmdSave.AutoSize = False
        Me.cmdSave.BackColor = System.Drawing.Color.Transparent
        Me.cmdSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSave.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(30, 30)
        Me.cmdSave.Text = "Save"
        '
        'txtName
        '
        Me.txtName.AutoSize = False
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(120, 29)
        '
        'cmdLoad
        '
        Me.cmdLoad.AutoSize = False
        Me.cmdLoad.BackColor = System.Drawing.Color.Transparent
        Me.cmdLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdLoad.Image = CType(resources.GetObject("cmdLoad.Image"), System.Drawing.Image)
        Me.cmdLoad.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdLoad.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdLoad.Name = "cmdLoad"
        Me.cmdLoad.Size = New System.Drawing.Size(30, 30)
        Me.cmdLoad.Text = "Load"
        Me.cmdLoad.ToolTipText = "Load skin"
        '
        'cmdXml
        '
        Me.cmdXml.AutoSize = False
        Me.cmdXml.BackColor = System.Drawing.Color.Transparent
        Me.cmdXml.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdXml.Image = CType(resources.GetObject("cmdXml.Image"), System.Drawing.Image)
        Me.cmdXml.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdXml.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdXml.Name = "cmdXml"
        Me.cmdXml.Size = New System.Drawing.Size(30, 30)
        Me.cmdXml.Text = "XML"
        '
        'cmdFileExplorer
        '
        Me.cmdFileExplorer.AutoSize = False
        Me.cmdFileExplorer.BackColor = System.Drawing.Color.Transparent
        Me.cmdFileExplorer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdFileExplorer.Image = CType(resources.GetObject("cmdFileExplorer.Image"), System.Drawing.Image)
        Me.cmdFileExplorer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdFileExplorer.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdFileExplorer.Name = "cmdFileExplorer"
        Me.cmdFileExplorer.Size = New System.Drawing.Size(30, 30)
        Me.cmdFileExplorer.Text = "File explorer"
        '
        'sep2
        '
        Me.sep2.Name = "sep2"
        Me.sep2.Size = New System.Drawing.Size(6, 41)
        '
        'lblX
        '
        Me.lblX.AutoSize = False
        Me.lblX.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.lblX.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(42, 38)
        Me.lblX.Text = "X:0"
        Me.lblX.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblY
        '
        Me.lblY.AutoSize = False
        Me.lblY.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.lblY.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblY.Name = "lblY"
        Me.lblY.Size = New System.Drawing.Size(42, 38)
        Me.lblY.Text = "Y:0"
        Me.lblY.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'cmdClear
        '
        Me.cmdClear.AutoSize = False
        Me.cmdClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdClear.Image = CType(resources.GetObject("cmdClear.Image"), System.Drawing.Image)
        Me.cmdClear.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(30, 30)
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.ToolTipText = "Clear skin"
        '
        'staBar
        '
        Me.staBar.Location = New System.Drawing.Point(0, 631)
        Me.staBar.Name = "staBar"
        Me.staBar.Size = New System.Drawing.Size(1016, 22)
        Me.staBar.TabIndex = 1
        '
        'mnuPrincipal
        '
        Me.mnuPrincipal.AutoSize = False
        Me.mnuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrincFile, Me.mnuPrincHelp})
        Me.mnuPrincipal.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.mnuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.mnuPrincipal.Name = "mnuPrincipal"
        Me.mnuPrincipal.Size = New System.Drawing.Size(1016, 26)
        Me.mnuPrincipal.TabIndex = 0
        Me.mnuPrincipal.Text = "Main menu"
        '
        'mnuPrincFile
        '
        Me.mnuPrincFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuPrincFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrincExit})
        Me.mnuPrincFile.Image = CType(resources.GetObject("mnuPrincFile.Image"), System.Drawing.Image)
        Me.mnuPrincFile.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuPrincFile.Name = "mnuPrincFile"
        Me.mnuPrincFile.Size = New System.Drawing.Size(36, 23)
        Me.mnuPrincFile.Text = "&File"
        '
        'mnuPrincExit
        '
        Me.mnuPrincExit.Name = "mnuPrincExit"
        Me.mnuPrincExit.Size = New System.Drawing.Size(92, 22)
        Me.mnuPrincExit.Text = "E&xit"
        '
        'mnuPrincHelp
        '
        Me.mnuPrincHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.mnuPrincHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuPrincHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrincAbout})
        Me.mnuPrincHelp.Image = CType(resources.GetObject("mnuPrincHelp.Image"), System.Drawing.Image)
        Me.mnuPrincHelp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuPrincHelp.Name = "mnuPrincHelp"
        Me.mnuPrincHelp.Size = New System.Drawing.Size(44, 23)
        Me.mnuPrincHelp.Text = "&Help"
        '
        'mnuPrincAbout
        '
        Me.mnuPrincAbout.Name = "mnuPrincAbout"
        Me.mnuPrincAbout.Size = New System.Drawing.Size(115, 22)
        Me.mnuPrincAbout.Text = "&About..."
        '
        'dirWatcher
        '
        Me.dirWatcher.EnableRaisingEvents = True
        Me.dirWatcher.SynchronizingObject = Me
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1016, 653)
        Me.Controls.Add(Me.mnuPrincipal)
        Me.Controls.Add(Me.splPrincipal)
        Me.Controls.Add(Me.staBar)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1024, 680)
        Me.Name = "frmPrincipal"
        Me.Text = "ClockSkinMaker"
        CType(Me.txtCenterX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCenterY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPrevio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCanvas.ResumeLayout(False)
        Me.grpProps.ResumeLayout(False)
        Me.grpProps.PerformLayout()
        CType(Me.txtWidth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAngle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStartAngle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMulRotate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splPrincipal.Panel1.ResumeLayout(False)
        Me.splPrincipal.Panel2.ResumeLayout(False)
        Me.splPrincipal.Panel2.PerformLayout()
        CType(Me.splPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splPrincipal.ResumeLayout(False)
        Me.tblExplorer.ResumeLayout(False)
        Me.tblExplorer.PerformLayout()
        Me.toolExplorer.ResumeLayout(False)
        Me.toolExplorer.PerformLayout()
        Me.grpMode.ResumeLayout(False)
        Me.grpMode.PerformLayout()
        CType(Me.txtSteps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTemperature, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHeart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBatt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtYear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSeconds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMinutes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHour, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpToolBox.ResumeLayout(False)
        Me.pnlToolBox.ResumeLayout(False)
        Me.pnlToolBox.PerformLayout()
        Me.toolToolBox.ResumeLayout(False)
        Me.toolToolBox.PerformLayout()
        Me.mnuPrincipal.ResumeLayout(False)
        Me.mnuPrincipal.PerformLayout()
        CType(Me.dirWatcher, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCenterX As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtCenterY As System.Windows.Forms.NumericUpDown
    Friend WithEvents picPrevio As System.Windows.Forms.PictureBox
    Friend WithEvents dlgFileName As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cmdFileName As System.Windows.Forms.Button
    Friend WithEvents lstToolBox As System.Windows.Forms.ListBox
    Friend WithEvents cmdDel As System.Windows.Forms.Button
    Friend WithEvents pnlCanvas As System.Windows.Forms.Panel
    Friend WithEvents cmdUp As System.Windows.Forms.Button
    Friend WithEvents cmdDown As System.Windows.Forms.Button
    Friend WithEvents txtHeight As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtWidth As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtAngle As NumericUpDown
    Friend WithEvents txtStartAngle As NumericUpDown
    Friend WithEvents txtMulRotate As NumericUpDown
    Friend WithEvents cmbDirection As ComboBox
    Friend WithEvents cmbColorBat As ComboBox
    Friend WithEvents lblAngle As Label
    Friend WithEvents cmdColor1 As Button
    Friend WithEvents cmdColor2 As Button
    Friend WithEvents cmdColorDel As Button
    Friend WithEvents dlgColor As ColorDialog
    Friend WithEvents tblExplorer As TableLayoutPanel
    Friend WithEvents splPrincipal As SplitContainer
    Friend WithEvents lvwExplorer As ListView
    Friend WithEvents colFilename As ColumnHeader
    Friend WithEvents toolExplorer As ToolStrip
    Friend WithEvents cmdDelSkin As ToolStripButton
    Friend WithEvents cmdNewSkin As ToolStripButton
    Friend WithEvents cmdImport As ToolStripButton
    Friend WithEvents pnlToolBox As Panel
    Friend WithEvents toolToolBox As ToolStrip
    Friend WithEvents txtName As ToolStripTextBox
    Friend WithEvents cmdSave As ToolStripButton
    Friend WithEvents cmdXml As ToolStripButton
    Friend WithEvents lblY As ToolStripLabel
    Friend WithEvents lblX As ToolStripLabel
    Friend WithEvents sep2 As ToolStripSeparator
    Friend WithEvents lvwCanvas As ListView
    Friend WithEvents colType As ColumnHeader
    Friend WithEvents colName As ColumnHeader
    Friend WithEvents imgCanvas As ImageList
    Friend WithEvents grpProps As GroupBox
    Friend WithEvents lblFile As Label
    Friend WithEvents lblColorArray As Label
    Friend WithEvents lblColorBat As Label
    Friend WithEvents lblDirection As Label
    Friend WithEvents lblMulRotate As Label
    Friend WithEvents lblCenterX As Label
    Friend WithEvents lblWidth As Label
    Friend WithEvents lblComma As Label
    Friend WithEvents grpCanvas As GroupBox
    Friend WithEvents staBar As StatusStrip
    Friend WithEvents cmdLoad As ToolStripButton
    Friend WithEvents grpToolBox As GroupBox
    Friend WithEvents cmdClear As ToolStripButton
    Friend WithEvents dlgFont As FontDialog
    Friend WithEvents cmdArray As Button
    Friend WithEvents mnuPrincipal As ToolStrip
    Friend WithEvents mnuPrincFile As ToolStripDropDownButton
    Friend WithEvents mnuPrincExit As ToolStripMenuItem
    Friend WithEvents dirWatcher As IO.FileSystemWatcher
    Friend WithEvents optModeTest As RadioButton
    Friend WithEvents optModeEdit As RadioButton
    Friend WithEvents chkNow As CheckBox
    Friend WithEvents lblSteps As Label
    Friend WithEvents lblHeart As Label
    Friend WithEvents lblMoon As Label
    Friend WithEvents lblTemperature As Label
    Friend WithEvents lblBatt As Label
    Friend WithEvents lblWeekday As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents txtHour As NumericUpDown
    Friend WithEvents txtMinutes As NumericUpDown
    Friend WithEvents txtSeconds As NumericUpDown
    Friend WithEvents cmbMonth As ComboBox
    Friend WithEvents cmbWeekday As ComboBox
    Friend WithEvents txtDay As NumericUpDown
    Friend WithEvents txtYear As NumericUpDown
    Friend WithEvents lblTime As Label
    Friend WithEvents txtBatt As NumericUpDown
    Friend WithEvents cmbWeather As ComboBox
    Friend WithEvents txtHeart As NumericUpDown
    Friend WithEvents txtTemperature As NumericUpDown
    Friend WithEvents cmbMoon As ComboBox
    Friend WithEvents txtSteps As NumericUpDown
    Friend WithEvents grpMode As GroupBox
    Friend WithEvents cmdFileExplorer As ToolStripButton
    Friend WithEvents mnuPrincAbout As ToolStripMenuItem
    Friend WithEvents mnuPrincHelp As ToolStripSplitButton
End Class
