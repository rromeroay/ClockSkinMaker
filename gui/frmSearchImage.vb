''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
' Copyright(c) 2016 Ricardo Romero <rromeroa@hotmail.com>
'
' This file is part of ClockSinMaker
'
' ClockSinMaker is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' ClockSinMaker is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY Or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License
' along with ClockSkinMaker. If not, see <http://www.gnu.org/licenses/>.
'
' Author: richi, rromeroa@hotmail.com
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

Imports ClockSkinMaker.core
Public Class frmSearchImage
    Private _ruta_act As String = ""
    Private _filename As String = ""
    Public ReadOnly Property FileName As String
        Get
            Return _filename
        End Get
    End Property

    Public Sub New(ruta As String)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        _ruta_act = ruta
    End Sub

    Private Sub frmSearchImage_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        InitForm(_ruta_act)
    End Sub

    Public Sub InitForm(path As String)
        _ruta_act = path
        lblLinkDir.Text = path
        Dim di As IO.DirectoryInfo = New IO.DirectoryInfo(_ruta_act)
        If Not di.Exists Then Return

        tblImages.SuspendLayout()
        tblImages.Controls.Clear()

        For Each fichero As IO.FileInfo In di.GetFiles("*.png")
            Dim img As New Button
            img.BackColor = Color.WhiteSmoke
            img.FlatStyle = FlatStyle.Flat
            img.BackgroundImageLayout = ImageLayout.Stretch

            tip.SetToolTip(img, fichero.Name)

            img.Tag = fichero.FullName
            Try
                Using fs As New System.IO.FileStream(fichero.FullName, IO.FileMode.Open, IO.FileAccess.Read)
                    img.BackgroundImage = System.Drawing.Image.FromStream(fs)
                    fs.Close()
                End Using

                AddHandler img.Click, AddressOf cmdImage_Click
            Catch ex As Exception
                img.BackgroundImage = My.Resources.warning
                MB(TIPO_DBG.ERR, String.Format("Image {0} cannot be loaded.", fichero.FullName), True)
            End Try

            img.Size = New Size(img.BackgroundImage.Size.Width * 0.5, img.BackgroundImage.Height * 0.5)
            tblImages.Controls.Add(img)
        Next

        tblImages.ResumeLayout()
    End Sub

    Private Sub cmdImage_Click(sender As System.Object, e As System.EventArgs)
        Me._filename = sender.Tag
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub lblLinkDir_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblLinkDir.LinkClicked
        dlgOpenDir.SelectedPath = IIf(IO.Directory.Exists(_ruta_act), _ruta_act, PATH_SKINS)
        If dlgOpenDir.ShowDialog() <> System.Windows.Forms.DialogResult.OK Then Return
        InitForm(dlgOpenDir.SelectedPath)
    End Sub

    Private Sub cmdFileExplorer_Click(sender As Object, e As EventArgs) Handles cmdFileExplorer.Click
        Try
            Dim ruta As String = IIf(IO.Directory.Exists(_ruta_act), _ruta_act, PATH_SKINS)
            If IO.Directory.Exists(ruta) Then Process.Start("explorer.exe", ruta)
        Catch ex As Exception
        End Try
    End Sub
End Class