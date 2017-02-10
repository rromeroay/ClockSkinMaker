<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSearchArray
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearchArray))
        Me.tblImages = New System.Windows.Forms.FlowLayoutPanel()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.lblLinkDir = New System.Windows.Forms.LinkLabel()
        Me.dlgOpenDir = New System.Windows.Forms.FolderBrowserDialog()
        Me.cmbXML = New System.Windows.Forms.ComboBox()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.cmdXML = New System.Windows.Forms.Button()
        Me.tip = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdFileExplorer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tblImages
        '
        Me.tblImages.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tblImages.AutoScroll = True
        Me.tblImages.BackColor = System.Drawing.Color.White
        Me.tblImages.Location = New System.Drawing.Point(2, 55)
        Me.tblImages.Name = "tblImages"
        Me.tblImages.Size = New System.Drawing.Size(787, 307)
        Me.tblImages.TabIndex = 4
        '
        'cmdCancel
        '
        Me.cmdCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Location = New System.Drawing.Point(688, 368)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 6
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'lblLinkDir
        '
        Me.lblLinkDir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLinkDir.AutoEllipsis = True
        Me.lblLinkDir.Location = New System.Drawing.Point(2, 3)
        Me.lblLinkDir.Name = "lblLinkDir"
        Me.lblLinkDir.Size = New System.Drawing.Size(761, 22)
        Me.lblLinkDir.TabIndex = 0
        Me.lblLinkDir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dlgOpenDir
        '
        Me.dlgOpenDir.ShowNewFolderButton = False
        '
        'cmbXML
        '
        Me.cmbXML.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbXML.DisplayMember = "Name"
        Me.cmbXML.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbXML.FormattingEnabled = True
        Me.cmbXML.Location = New System.Drawing.Point(2, 29)
        Me.cmbXML.Name = "cmbXML"
        Me.cmbXML.Size = New System.Drawing.Size(579, 21)
        Me.cmbXML.TabIndex = 2
        '
        'cmdOk
        '
        Me.cmdOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdOk.Location = New System.Drawing.Point(607, 368)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(75, 23)
        Me.cmdOk.TabIndex = 5
        Me.cmdOk.Text = "OK"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'cmdXML
        '
        Me.cmdXML.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdXML.BackColor = System.Drawing.Color.Transparent
        Me.cmdXML.BackgroundImage = CType(resources.GetObject("cmdXML.BackgroundImage"), System.Drawing.Image)
        Me.cmdXML.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdXML.FlatAppearance.BorderSize = 0
        Me.cmdXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdXML.Location = New System.Drawing.Point(587, 30)
        Me.cmdXML.Name = "cmdXML"
        Me.cmdXML.Size = New System.Drawing.Size(21, 21)
        Me.cmdXML.TabIndex = 3
        Me.cmdXML.UseVisualStyleBackColor = False
        '
        'cmdFileExplorer
        '
        Me.cmdFileExplorer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdFileExplorer.BackColor = System.Drawing.Color.Transparent
        Me.cmdFileExplorer.BackgroundImage = CType(resources.GetObject("cmdFileExplorer.BackgroundImage"), System.Drawing.Image)
        Me.cmdFileExplorer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdFileExplorer.FlatAppearance.BorderSize = 0
        Me.cmdFileExplorer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdFileExplorer.Location = New System.Drawing.Point(768, 4)
        Me.cmdFileExplorer.Name = "cmdFileExplorer"
        Me.cmdFileExplorer.Size = New System.Drawing.Size(21, 21)
        Me.cmdFileExplorer.TabIndex = 1
        Me.cmdFileExplorer.UseVisualStyleBackColor = False
        '
        'frmSearchArray
        '
        Me.AcceptButton = Me.cmdOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(792, 396)
        Me.Controls.Add(Me.cmdFileExplorer)
        Me.Controls.Add(Me.cmdXML)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.cmbXML)
        Me.Controls.Add(Me.lblLinkDir)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.tblImages)
        Me.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(350, 300)
        Me.Name = "frmSearchArray"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Search..."
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tblImages As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents lblLinkDir As System.Windows.Forms.LinkLabel
    Friend WithEvents dlgOpenDir As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents cmbXML As ComboBox
    Friend WithEvents cmdOk As Button
    Friend WithEvents cmdXML As Button
    Friend WithEvents tip As ToolTip
    Friend WithEvents cmdFileExplorer As Button
End Class
