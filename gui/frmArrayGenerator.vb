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

Public Class frmArrayGenerator
    Private _full_path As String = ""
    Private element As CSkinPanel = Nothing
    Private arrayformat As CArrayFormat = Nothing

    Private LABELS() As Label
    Private TEXTS() As TextBox
    Private COLORS() As Button

    Public Event OnOk(sender As CSkinPanel)
    Public Sub New(_element As CSkinPanel, ruta As String)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        LABELS = New Label() {lblContent0, lblContent1, lblContent2, lblContent3, lblContent4, lblContent5, lblContent6, lblContent7, lblContent8, lblContent9, lblContent10, lblContent11, lblContent12}
        TEXTS = New TextBox() {txtContent0, txtContent1, txtContent2, txtContent3, txtContent4, txtContent5, txtContent6, txtContent7, txtContent8, txtContent9, txtContent10, txtContent11, txtContent12}
        COLORS = New Button() {cmdForeColor0, cmdForeColor1, cmdForeColor2, cmdForeColor3, cmdForeColor4, cmdForeColor5, cmdForeColor6, cmdForeColor7, cmdForeColor8, cmdForeColor9, cmdForeColor10, cmdForeColor11, cmdForeColor12}

        _full_path = ruta
        element = _element
        arrayformat = New CArrayFormat(element.Tipo, _full_path)
    End Sub

    Private Sub frmSearchImage_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        InitForm()
    End Sub

    Private Sub ScaleFont(txt As Control)
        Using g As Graphics = txt.CreateGraphics
            txt.Font = CArrayFormat.ScaleFont(g, txt.Text, txt.Size, txt.Font, StringFormat.GenericTypographic)
        End Using
    End Sub

    Public Sub InitForm()

        For i As Integer = 0 To arrayformat.Contents.Count - 1
            LABELS(i).Text = arrayformat.Descriptions(i)
            TEXTS(i).Text = arrayformat.Contents(i) : TEXTS(i).Enabled = True
            COLORS(i).BackColor = arrayformat.Colors(i) : COLORS(i).Enabled = True
        Next

        Me.txtArrayFileName.Enabled = True
        Me.txtArrayFileName.Text = IO.Path.GetFileNameWithoutExtension(_full_path)

        Me.cmdArrayBack.Enabled = True
        Me.cmdArrayFore.Enabled = True
        Me.cmdArrayColorDel.Enabled = True
        Me.cmdArrayFont.Enabled = True

        Me.cmdArrayBack.BackColor = arrayformat.BackColor
        Select Case arrayformat.BackColor
            Case Color.Transparent : Me.cmdArrayBack.Text = "Transp"
            Case Else : Me.cmdArrayBack.Text = ColorTranslator.ToHtml(Color.FromArgb(arrayformat.BackColor.ToArgb)).Substring(1)
        End Select
        Me.cmdArrayFore.BackColor = arrayformat.ForeColor
        Select Case arrayformat.ForeColor
            Case Color.Transparent : Me.cmdArrayFore.Text = "Transp"
            Case Else : Me.cmdArrayFore.Text = ColorTranslator.ToHtml(Color.FromArgb(arrayformat.ForeColor.ToArgb)).Substring(1)
        End Select

        Me.cmdArrayFont.Font = arrayformat.Font
        Me.cmdArrayFont.Text = arrayformat.Font.Name.ToString : ScaleFont(cmdArrayFont)

        Me.chkAutoscale.Checked = arrayformat.AutoScale


        Me.cmdShadowColor.BackColor = arrayformat.ShadowColor
        Select Case arrayformat.ShadowColor
            Case Color.Transparent : Me.cmdShadowColor.Text = ""
            Case Else : Me.cmdShadowColor.Text = ColorTranslator.ToHtml(Color.FromArgb(arrayformat.ShadowColor.ToArgb)).Substring(1)
        End Select

        Try : Me.txtShadowX.Value = arrayformat.ShadowX : Catch : End Try
        Try : Me.txtShadowY.Value = arrayformat.ShadowY : Catch : End Try
    End Sub

    Private Sub cmdOK_Click(sender As System.Object, e As System.EventArgs) Handles cmdOk.Click
        If Not ArrayGenerate() Then Return
        RaiseEvent OnOk(element)
    End Sub
    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdArrayFont_Click(sender As Object, e As EventArgs) Handles cmdArrayFont.Click
        Try
            dlgFont.Font = arrayformat.Font
            If dlgFont.ShowDialog() <> System.Windows.Forms.DialogResult.OK Then Return
        Catch ex As Exception
            MB(TIPO_DBG.ERR, ex.Message)
            Return
        End Try
        arrayformat.Font = dlgFont.Font

        cmdArrayFont.Font = New Font(dlgFont.Font.Name, dlgFont.Font.Size, dlgFont.Font.Style, GraphicsUnit.Point)
        cmdArrayFont.Text = dlgFont.Font.Name.ToString : ScaleFont(cmdArrayFont)
    End Sub
    Private Sub cmdArrayColors_Click(sender As Object, e As EventArgs) Handles cmdArrayFore.Click, cmdArrayBack.Click, cmdShadowColor.Click
        Dim boton As Button = sender

        dlgColor.Color = boton.BackColor
        If dlgColor.ShowDialog() <> System.Windows.Forms.DialogResult.OK Then Return

        boton.BackColor = dlgColor.Color
        boton.Text = ColorTranslator.ToHtml(Color.FromArgb(dlgColor.Color.ToArgb)).Substring(1)
    End Sub
    Private Sub cmdArrayColorDel_Click(sender As Object, e As EventArgs) Handles cmdArrayColorDel.Click
        cmdArrayBack.BackColor = Color.Transparent : cmdArrayBack.Text = "Transp"
        'cmdArrayFore.BackColor = Color.Black : cmdArrayFore.Text = "000000"
    End Sub

    Private Sub cmdContentsColor_Click(sender As Object, e As EventArgs) Handles cmdForeColor0.Click, cmdForeColor1.Click, cmdForeColor2.Click, cmdForeColor3.Click, cmdForeColor4.Click, cmdForeColor5.Click, cmdForeColor6.Click, cmdForeColor7.Click, cmdForeColor8.Click, cmdForeColor9.Click, cmdForeColor10.Click, cmdForeColor11.Click, cmdForeColor12.Click
        Dim boton As Button = sender
        dlgColor.Color = boton.BackColor
        If dlgColor.ShowDialog() <> System.Windows.Forms.DialogResult.OK Then Return
        boton.BackColor = dlgColor.Color
    End Sub
    Private Sub cmdContentsColorDel_Click(sender As Object, e As EventArgs) Handles cmdContentsColorDel.Click
        For i As Integer = 0 To COLORS.Count - 1
            COLORS(i).BackColor = Color.Transparent
        Next
    End Sub

    Private Function ArrayGenerate() As Boolean
        Try
            If txtArrayFileName.Text.Trim = "" Then Me.txtArrayFileName.Focus() : Throw New Exception("Must enter a valid array name.")
            Dim destino As String = String.Format("{0}\{1}\{2}.xml", PATH_SKINS, element.SkinCanvas.Name, IO.Path.GetFileNameWithoutExtension(txtArrayFileName.Text))

            Cursor.Current = Cursors.WaitCursor

            arrayformat.BackColor = cmdArrayBack.BackColor
            arrayformat.ForeColor = cmdArrayFore.BackColor
            arrayformat.AutoScale = chkAutoscale.Checked
            'arrayformat.Font = New Font(cmdArrayFont.Font.Name, cmdArrayFont.Font.Size, cmdArrayFont.Font.Style, GraphicsUnit.Pixel)

            For i As Integer = 0 To arrayformat.Contents.Count - 1
                arrayformat.Contents(i) = TEXTS(i).Text
                arrayformat.Colors(i) = COLORS(i).BackColor
            Next

            arrayformat.ShadowX = txtShadowX.Value
            arrayformat.ShadowY = txtShadowY.Value
            arrayformat.ShadowColor = cmdShadowColor.BackColor

            element.FileName = arrayformat.Save(element, destino)
            Me.txtArrayFileName.Text = IO.Path.GetFileNameWithoutExtension(element.FileName) 'Por si cambia de nombre
        Catch ex As Exception
            Cursor.Current = Cursors.Default

            MB(TIPO_DBG.ERR, ex.Message)
            Return False
        Finally
            Cursor.Current = Cursors.Default
        End Try

        Return True
    End Function

    Private Sub cmdView_Click(sender As Object, e As EventArgs) Handles cmdView.Click
        If Not IO.File.Exists(element.FileName) Then Return
        Dim frm As New frmSearchArray(IO.Path.GetDirectoryName(element.FileName), IO.Path.GetFileName(element.FileName))
        frm.ShowDialog()
    End Sub

End Class