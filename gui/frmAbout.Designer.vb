<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    Friend WithEvents TableLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents LabelProductName As System.Windows.Forms.Label
    Friend WithEvents LabelVersion As System.Windows.Forms.Label
    Friend WithEvents OKButton As System.Windows.Forms.Button
    Friend WithEvents LabelCopyright As System.Windows.Forms.Label

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
        Me.TableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelProductName = New System.Windows.Forms.Label()
        Me.LabelVersion = New System.Windows.Forms.Label()
        Me.LabelCopyright = New System.Windows.Forms.Label()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.splLicenseCredits = New System.Windows.Forms.SplitContainer()
        Me.TextBoxLicense = New System.Windows.Forms.TextBox()
        Me.TextBoxCredits = New System.Windows.Forms.TextBox()
        Me.lblCreditsLicense = New System.Windows.Forms.LinkLabel()
        Me.PictureBoxLicense = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel.SuspendLayout()
        CType(Me.splLicenseCredits, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splLicenseCredits.Panel1.SuspendLayout()
        Me.splLicenseCredits.Panel2.SuspendLayout()
        Me.splLicenseCredits.SuspendLayout()
        CType(Me.PictureBoxLicense, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel
        '
        Me.TableLayoutPanel.ColumnCount = 3
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel.Controls.Add(Me.LabelProductName, 0, 0)
        Me.TableLayoutPanel.Controls.Add(Me.LabelVersion, 0, 1)
        Me.TableLayoutPanel.Controls.Add(Me.LabelCopyright, 0, 2)
        Me.TableLayoutPanel.Controls.Add(Me.OKButton, 2, 5)
        Me.TableLayoutPanel.Controls.Add(Me.splLicenseCredits, 0, 3)
        Me.TableLayoutPanel.Controls.Add(Me.lblCreditsLicense, 1, 5)
        Me.TableLayoutPanel.Controls.Add(Me.PictureBoxLicense, 0, 5)
        Me.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel.Location = New System.Drawing.Point(9, 9)
        Me.TableLayoutPanel.Name = "TableLayoutPanel"
        Me.TableLayoutPanel.RowCount = 6
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel.Size = New System.Drawing.Size(453, 272)
        Me.TableLayoutPanel.TabIndex = 0
        '
        'LabelProductName
        '
        Me.TableLayoutPanel.SetColumnSpan(Me.LabelProductName, 3)
        Me.LabelProductName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelProductName.Location = New System.Drawing.Point(6, 0)
        Me.LabelProductName.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.LabelProductName.MaximumSize = New System.Drawing.Size(0, 17)
        Me.LabelProductName.Name = "LabelProductName"
        Me.LabelProductName.Size = New System.Drawing.Size(444, 17)
        Me.LabelProductName.TabIndex = 0
        Me.LabelProductName.Text = "Nombre de producto"
        Me.LabelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelVersion
        '
        Me.TableLayoutPanel.SetColumnSpan(Me.LabelVersion, 3)
        Me.LabelVersion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelVersion.Location = New System.Drawing.Point(6, 20)
        Me.LabelVersion.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.LabelVersion.MaximumSize = New System.Drawing.Size(0, 17)
        Me.LabelVersion.Name = "LabelVersion"
        Me.LabelVersion.Size = New System.Drawing.Size(444, 17)
        Me.LabelVersion.TabIndex = 1
        Me.LabelVersion.Text = "Versión"
        Me.LabelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelCopyright
        '
        Me.TableLayoutPanel.SetColumnSpan(Me.LabelCopyright, 3)
        Me.LabelCopyright.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelCopyright.Location = New System.Drawing.Point(6, 40)
        Me.LabelCopyright.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.LabelCopyright.MaximumSize = New System.Drawing.Size(0, 17)
        Me.LabelCopyright.Name = "LabelCopyright"
        Me.LabelCopyright.Size = New System.Drawing.Size(444, 17)
        Me.LabelCopyright.TabIndex = 2
        Me.LabelCopyright.Text = "Copyright"
        Me.LabelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'OKButton
        '
        Me.OKButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.OKButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OKButton.Location = New System.Drawing.Point(362, 245)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(88, 24)
        Me.OKButton.TabIndex = 5
        Me.OKButton.Text = "&Aceptar"
        '
        'splLicenseCredits
        '
        Me.TableLayoutPanel.SetColumnSpan(Me.splLicenseCredits, 2)
        Me.splLicenseCredits.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splLicenseCredits.IsSplitterFixed = True
        Me.splLicenseCredits.Location = New System.Drawing.Point(3, 63)
        Me.splLicenseCredits.Name = "splLicenseCredits"
        Me.splLicenseCredits.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splLicenseCredits.Panel1
        '
        Me.splLicenseCredits.Panel1.Controls.Add(Me.TextBoxLicense)
        '
        'splLicenseCredits.Panel2
        '
        Me.splLicenseCredits.Panel2.Controls.Add(Me.TextBoxCredits)
        Me.TableLayoutPanel.SetRowSpan(Me.splLicenseCredits, 2)
        Me.splLicenseCredits.Size = New System.Drawing.Size(353, 176)
        Me.splLicenseCredits.SplitterDistance = 88
        Me.splLicenseCredits.TabIndex = 8
        '
        'TextBoxLicense
        '
        Me.TextBoxLicense.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBoxLicense.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxLicense.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxLicense.Location = New System.Drawing.Point(0, 0)
        Me.TextBoxLicense.Multiline = True
        Me.TextBoxLicense.Name = "TextBoxLicense"
        Me.TextBoxLicense.ReadOnly = True
        Me.TextBoxLicense.Size = New System.Drawing.Size(353, 88)
        Me.TextBoxLicense.TabIndex = 4
        Me.TextBoxLicense.Text = "ClockSkinMaker is distributed under the GNU General Public License GPLv3 or highe" &
    "r. Please see LICENSE.TXT for details or visit http://www.gnu.org/licenses/."
        '
        'TextBoxCredits
        '
        Me.TextBoxCredits.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBoxCredits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxCredits.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxCredits.Location = New System.Drawing.Point(0, 0)
        Me.TextBoxCredits.Multiline = True
        Me.TextBoxCredits.Name = "TextBoxCredits"
        Me.TextBoxCredits.ReadOnly = True
        Me.TextBoxCredits.Size = New System.Drawing.Size(353, 84)
        Me.TextBoxCredits.TabIndex = 5
        Me.TextBoxCredits.Text = resources.GetString("TextBoxCredits.Text")
        '
        'lblCreditsLicense
        '
        Me.lblCreditsLicense.AutoSize = True
        Me.lblCreditsLicense.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblCreditsLicense.Location = New System.Drawing.Point(307, 242)
        Me.lblCreditsLicense.Name = "lblCreditsLicense"
        Me.lblCreditsLicense.Size = New System.Drawing.Size(49, 30)
        Me.lblCreditsLicense.TabIndex = 7
        Me.lblCreditsLicense.TabStop = True
        Me.lblCreditsLicense.Text = "Credits"
        Me.lblCreditsLicense.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBoxLicense
        '
        Me.PictureBoxLicense.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxLicense.Image = CType(resources.GetObject("PictureBoxLicense.Image"), System.Drawing.Image)
        Me.PictureBoxLicense.Location = New System.Drawing.Point(3, 242)
        Me.PictureBoxLicense.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.PictureBoxLicense.Name = "PictureBoxLicense"
        Me.PictureBoxLicense.Size = New System.Drawing.Size(88, 27)
        Me.PictureBoxLicense.TabIndex = 2
        Me.PictureBoxLicense.TabStop = False
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CancelButton = Me.OKButton
        Me.ClientSize = New System.Drawing.Size(471, 290)
        Me.Controls.Add(Me.TableLayoutPanel)
        Me.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAbout"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmAbout"
        Me.TableLayoutPanel.ResumeLayout(False)
        Me.TableLayoutPanel.PerformLayout()
        Me.splLicenseCredits.Panel1.ResumeLayout(False)
        Me.splLicenseCredits.Panel1.PerformLayout()
        Me.splLicenseCredits.Panel2.ResumeLayout(False)
        Me.splLicenseCredits.Panel2.PerformLayout()
        CType(Me.splLicenseCredits, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splLicenseCredits.ResumeLayout(False)
        CType(Me.PictureBoxLicense, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBoxLicense As PictureBox
    Friend WithEvents TextBoxLicense As TextBox
    Friend WithEvents lblCreditsLicense As LinkLabel
    Friend WithEvents splLicenseCredits As SplitContainer
    Friend WithEvents TextBoxCredits As TextBox
End Class
