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

Imports System.Xml
Imports ClockSkinMaker.core

Public Class frmSearchArray
    Private _ruta_act As String = ""
    Private _fichero_act As String = ""
    Private _filename As String = ""
    Private Drawables As New List(Of String)

    Public ReadOnly Property FileName As String
        Get
            Return _filename
        End Get
    End Property

    Public Sub New(ruta As String, fichero As String)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        _ruta_act = ruta
        _fichero_act = fichero
    End Sub

    Private Sub frmSearchImage_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        InitForm(_ruta_act, _fichero_act)
    End Sub

    Public Sub InitForm(ruta As String, file As String)
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        _fichero_act = file
        _ruta_act = ruta
        lblLinkDir.Text = _ruta_act

        Dim di As IO.DirectoryInfo = New IO.DirectoryInfo(_ruta_act)
        If Not di.Exists Then Return

        tblImages.SuspendLayout()
        tblImages.Controls.Clear()

        cmbXML.Items.Clear()
        Dim selected_file As Object = Nothing
        For Each fichero As IO.FileInfo In di.GetFiles("*.xml")
            If fichero.Name.ToLower = "clock_skin.xml" Then Continue For
            cmbXML.Items.Add(fichero)

            If IO.Path.GetFileName(_fichero_act).ToLower = fichero.Name.ToLower Then selected_file = cmbXML.Items(cmbXML.Items.Count - 1)
        Next
        tblImages.ResumeLayout()

        If Not selected_file Is Nothing Then cmbXML.SelectedItem = selected_file
    End Sub

    Private Sub cmdOK_Click(sender As System.Object, e As System.EventArgs) Handles cmdOk.Click
        If cmbXML.SelectedIndex = -1 Then Return
        Me._filename = cmbXML.SelectedItem.fullname
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub lblLinkDir_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblLinkDir.LinkClicked
        dlgOpenDir.SelectedPath = IIf(My.Computer.FileSystem.DirectoryExists(_ruta_act), _ruta_act, PATH_SKINS)
        If dlgOpenDir.ShowDialog() <> System.Windows.Forms.DialogResult.OK Then Return
        InitForm(dlgOpenDir.SelectedPath, _fichero_act)
    End Sub

    Private Sub cmbXML_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbXML.SelectedIndexChanged
        If cmbXML.SelectedIndex = -1 Then Return
        LoadDrawables(cmbXML.SelectedItem.fullname)
    End Sub

    Private Sub LoadDrawables(fichero As String)
        Dim reader As New XmlDocument()

        Try
            Drawables.Clear()

            reader.Load(fichero)
            For Each drawable As XmlNode In reader.SelectNodes("/drawables/image")
                Drawables.Add(String.Format("{0}\{1}", IO.Path.GetDirectoryName(fichero), drawable.InnerText.Trim))
            Next
        Catch ex As Exception
            MB(TIPO_DBG.ERR, String.Format("Xml {0} cannot be loaded.", fichero), True)
        End Try

        tblImages.SuspendLayout()
        tblImages.Controls.Clear()
        For Each drawable As String In Drawables
            Dim img As New Button
            img.BackColor = Color.WhiteSmoke
            img.FlatStyle = FlatStyle.Flat
            img.BackgroundImageLayout = ImageLayout.Stretch

            tip.SetToolTip(img, IO.Path.GetFileName(drawable))

            Try
                Using fs As New System.IO.FileStream(drawable, IO.FileMode.Open, IO.FileAccess.Read)
                    img.BackgroundImage = System.Drawing.Image.FromStream(fs)
                    fs.Close()
                End Using
            Catch ex As Exception
                img.BackgroundImage = My.Resources.warning
                MB(TIPO_DBG.ERR, String.Format("Image {0} cannot be loaded.", drawable), True)
            End Try

            img.Size = New Size(img.BackgroundImage.Size.Width * 1.5, img.BackgroundImage.Height * 1.5)
            tblImages.Controls.Add(img)
        Next
        tblImages.ResumeLayout()
    End Sub

    Private Sub cmdXML_Click(sender As Object, e As EventArgs) Handles cmdXML.Click
        If cmbXML.SelectedIndex = -1 Then Return
        Try
            If IO.File.Exists(cmbXML.SelectedItem.fullname) Then Process.Start(cmbXML.SelectedItem.fullname)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdFileExplorer_Click(sender As Object, e As EventArgs) Handles cmdFileExplorer.Click
        Try
            Dim ruta As String = IIf(IO.Directory.Exists(_ruta_act), _ruta_act, PATH_SKINS)
            If IO.Directory.Exists(ruta) Then Process.Start("explorer.exe", ruta)
        Catch ex As Exception
        End Try
    End Sub
End Class