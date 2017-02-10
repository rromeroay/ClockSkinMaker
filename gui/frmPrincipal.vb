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

Imports System.ComponentModel
Imports System.IO
Imports ClockSkinMaker.core

Public Class frmPrincipal
    Private WithEvents canvas As CSkinCanvas = Nothing

    Public Sub New()
        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        canvas = New CSkinCanvas(Me.pnlCanvas)
        Me.dirWatcher.Path = PATH_SKINS
    End Sub

    Private Sub mnuPrincAbout_Click(sender As Object, e As EventArgs) Handles mnuPrincAbout.Click
        Dim f As New frmAbout : f.ShowDialog()
    End Sub
    Private Sub mnuPrincHelp_Click(sender As Object, e As EventArgs) Handles mnuPrincHelp.ButtonClick
        Try
            Process.Start("http://clockskinmaker.codeplex.com")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub canvas_OnMouseMove(sender As CSkinCanvas, e As Point) Handles canvas.OnMouseMove
        lblX.Text = "X:" & e.X
        lblY.Text = "Y:" & e.Y
    End Sub
    Private Sub canvas_OnUpdatedElement(sender As CSkinCanvas, e As CSkinPanel) Handles canvas.OnUpdatedElement
        Show_Element(e)
    End Sub
    Private Sub canvas_DoubleClickElement(sender As CSkinCanvas, e As CSkinPanel) Handles canvas.OnDoubleClickElement
        cmdFileName_Click(sender, EventArgs.Empty)
    End Sub
    Private Sub cmdClear_Click(sender As System.Object, e As System.EventArgs) Handles cmdClear.Click
        canvas.Clear()
        Show_Clock()
    End Sub

    Private Sub mnuPrincExit_Click(sender As Object, e As EventArgs) Handles mnuPrincExit.Click
        Me.Close()
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Init_Form()
    End Sub
    Private Sub Init_Form()
        lstToolBox.Items.Clear()
        For Each p In [Enum].GetValues(GetType(TIPO_ELEMENTO))
            Select Case True
                Case p = TIPO_ELEMENTO.ROTATE_END : Continue For
                Case p >= TIPO_ELEMENTO.ARRAY_END : Continue For
            End Select
            lstToolBox.Items.Add(p)
        Next

        cmbDirection.Items.Clear()
        cmbDirection.Items.AddRange({"", "clockwise", "counter"})

        cmbColorBat.Items.Clear()
        cmbColorBat.Items.AddRange({"white", "black"})

        '''''''''''''''''''''''''TESTS VALUES, FILL DEFAULTS
        cmbMonth.Items.Clear()
        For i = 1 To 12
            cmbMonth.Items.Add(MonthName(i, True))
        Next
        cmbMonth.SelectedIndex = canvas.Month - 1

        cmbWeekday.Items.Clear()
        For i = 1 To 7
            cmbWeekday.Items.Add(WeekdayName(i, True, FirstDayOfWeek.Monday))
        Next
        cmbWeekday.SelectedIndex = canvas.Weekday - 1

        cmbWeather.Items.Clear()
        cmbWeather.Items.AddRange({"sunny", "cloudy", "overcast", "fog", "rain", "showers", "storm", "rainstorm", "snow", "rainsnow", "hot", "cold", "windy", "sunny_night", "cloudy_night"})
        cmbWeather.SelectedIndex = canvas.Weather

        cmbMoon.Items.Clear()
        cmbMoon.Items.AddRange({"new moon", "waxing crescent", "first quarter", "waxing gibbous", "full moon", "waning gibbous", "last quarter", "waning crescent"})
        cmbMoon.SelectedIndex = canvas.Moon

        txtHour.Value = canvas.Hour
        txtMinutes.Value = canvas.Minutes
        txtSeconds.Value = canvas.Seconds
        txtBatt.Value = canvas.Batt
        txtDay.Value = canvas.Day
        txtYear.Value = canvas.Year
        txtHeart.Value = canvas.Heartrate
        txtTemperature.Value = canvas.Temprature
        txtSteps.Value = canvas.Steps

        Show_Explorer()
        Show_Clock()
    End Sub

    Public Sub Show_Explorer(Optional elem As String = "")
        Dim di As IO.DirectoryInfo = New IO.DirectoryInfo(PATH_SKINS)
        Dim lstimg As New ImageList
        Dim img As Integer = -1

        Try
            lstimg.ImageSize = New Size(48, 48)

            lvwExplorer.BeginUpdate()
            lvwExplorer.Items.Clear()
            lvwExplorer.SmallImageList = lstimg

            For Each directorio As IO.DirectoryInfo In di.GetDirectories().OrderBy(Function(x) x.Name)
                If directorio.GetFiles("clock_skin.xml").Count = 0 Then Continue For

                Dim ruta As String = String.Format("{0}\{1}\clock_skin_model.png", PATH_SKINS, directorio.Name)

                img = -1
                If IO.File.Exists(ruta) Then
                    Using fs As New System.IO.FileStream(ruta, IO.FileMode.Open, IO.FileAccess.Read)
                        lstimg.Images.Add(directorio.Name, Image.FromStream(fs))
                        fs.Close()
                    End Using
                    img = lstimg.Images.IndexOfKey(directorio.Name)
                End If

                lvwExplorer.Items.Add(directorio.Name, directorio.Name, img)
            Next
            Select Case lvwExplorer.Items.Count
                Case 0 : lvwExplorer.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
                Case Else : lvwExplorer.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
            End Select

            If elem = "" AndAlso lvwExplorer.Items.Count > 0 Then elem = lvwExplorer.Items(0).Text
            If lvwExplorer.Items.ContainsKey(elem) Then lvwExplorer.Items(elem).Selected = True : lvwExplorer.Items(elem).EnsureVisible()
        Catch
        Finally
            lvwExplorer.EndUpdate()
        End Try

    End Sub
    Private Sub lvwExplorer_DoubleClick(sender As Object, e As System.EventArgs) Handles lvwExplorer.DoubleClick
        cmdLoadSkin_Click(sender, e)
    End Sub
    Private Sub lvwCanvas_KeyUp(sender As Object, e As KeyEventArgs) Handles lvwCanvas.KeyUp
        Select Case e.KeyCode
            Case Keys.Delete : cmdDel_Click(sender, EventArgs.Empty)
            Case Keys.Enter : cmdFileName_Click(sender, EventArgs.Empty)
        End Select
    End Sub
    Private Sub lvwExplorer_KeyUp(sender As Object, e As KeyEventArgs) Handles lvwExplorer.KeyUp
        Select Case e.KeyCode
            Case Keys.Delete : cmdDelSkin_Click(sender, EventArgs.Empty)
            Case Keys.Insert : cmdNewSkin_Click(sender, EventArgs.Empty)
            Case Keys.Enter : cmdLoadSkin_Click(sender, EventArgs.Empty)
        End Select
    End Sub
    Private Sub lvwExplorer_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lvwExplorer.SelectedIndexChanged
        If lvwExplorer.SelectedItems.Count <= 0 Then Return
        Try
            Using fs As New System.IO.FileStream(String.Format("{0}\{1}\clock_skin_model.png", PATH_SKINS, lvwExplorer.SelectedItems(0).Text), IO.FileMode.Open, IO.FileAccess.Read)
                picPrevio.BackgroundImage = System.Drawing.Image.FromStream(fs)
                fs.Close()
            End Using
        Catch ex As Exception
            picPrevio.BackgroundImage = My.Resources.warning
        End Try
    End Sub
    Private Sub lstToolBox_KeyUp(sender As Object, e As KeyEventArgs) Handles lstToolBox.KeyUp
        Select Case e.KeyCode
            Case Keys.Enter : lstToolBox_DoubleClick(sender, EventArgs.Empty)
        End Select
    End Sub
    Private Sub lstToolBox_DoubleClick(sender As Object, e As System.EventArgs) Handles lstToolBox.DoubleClick
        Dim nuevo As CSkinPanel = canvas.CreateElement(lstToolBox.SelectedItem)

        Dim item As New ListViewItem(nuevo.Tipo.ToString)
        item.Tag = nuevo

        Select Case nuevo.Tipo
            Case TIPO_ELEMENTO.array_charging_batt, TIPO_ELEMENTO.array_special_second 'Imágenes fijas
            Case Else : item.ImageKey = "new"
        End Select
        item.SubItems.Add(nuevo.Description)
        lvwCanvas.Items.Add(item)

        lvwCanvas.Items(lvwCanvas.Items.Count - 1).Selected = True : lvwCanvas.EnsureVisible(lvwCanvas.Items.Count - 1)
    End Sub

    Private Sub lvwCanvas_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lvwCanvas.SelectedIndexChanged
        If lvwCanvas.SelectedItems.Count <= 0 Then Return
        Show_Element(lvwCanvas.SelectedItems(0).Tag)
    End Sub

    Private Sub lstCanvas_DoubleClick(sender As Object, e As System.EventArgs) Handles lvwCanvas.DoubleClick
        cmdFileName_Click(sender, e)
    End Sub

    Private Sub cmdDelSkin_Click(sender As Object, e As EventArgs) Handles cmdDelSkin.Click
        If lvwExplorer.SelectedItems.Count <= 0 Then Return
        If MessageBox.Show("The selected skin will be delete, are you sure?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.No Then Return

        Dim ruta As String = String.Format("{0}\{1}", PATH_SKINS, lvwExplorer.SelectedItems(0).Text)
        Try
            If lvwExplorer.SelectedItems(0).Text = canvas.Name Then canvas.Clear() : Show_Clock()
            If Directory.Exists(ruta) Then Directory.Delete(ruta, True) Else Show_Explorer()
        Catch ex As Exception
            MB(TIPO_DBG.ERR, ex.Message)
        End Try
    End Sub

    Private Sub cmdNewSkin_Click(sender As System.Object, e As System.EventArgs) Handles cmdNewSkin.Click
        Dim cont As Integer = 1
        Dim nombre As String = String.Format("ClockSkinRR{0:000}", cont)
        While lvwExplorer.Items.ContainsKey(nombre)
            nombre = String.Format("ClockSkinRR{0:000}", cont)
            cont += 1
        End While

        lvwExplorer.Items.Add(nombre, nombre, -1)
        lvwExplorer.Items(nombre).Selected = True : lvwExplorer.Items(nombre).EnsureVisible()
        picPrevio.BackgroundImage = My.Resources.element_new

        canvas.[New](nombre)
        Show_Clock()
    End Sub

    Private Sub cmdSave_Click(sender As System.Object, e As System.EventArgs) Handles cmdSave.Click
        Try
            If txtName.Text.Trim = "" Then Me.txtName.Focus() : Throw New Exception("Must enter clockskin name.")
            Cursor.Current = Cursors.WaitCursor

            canvas.Save(String.Format("{0}\{1}", PATH_SKINS, txtName.Text.Trim))
            canvas.Load(String.Format("{0}\{1}", PATH_SKINS, canvas.Name)) 'Recarga, por si el proceso ha generado nuevas imagenes por que ya existían las seleccionadas
            Show_Explorer(canvas.Name)

            Select Case lvwCanvas.SelectedIndices.Count
                Case > 0 : Show_Clock(lvwCanvas.SelectedIndices(0))
                Case Else : Show_Clock()
            End Select
        Catch ex As Exception
            Cursor.Current = Cursors.Default
            MB(TIPO_DBG.CRI, ex.Message)
        Finally
            Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub cmdLoadSkin_Click(sender As System.Object, e As System.EventArgs) Handles cmdLoad.Click
        If lvwExplorer.SelectedItems.Count <= 0 Then Return

        Try
            Cursor.Current = Cursors.WaitCursor

            canvas.Load(String.Format("{0}\{1}", PATH_SKINS, lvwExplorer.SelectedItems(0).Text))
            Show_Clock()
        Catch ex As Exception
            Cursor.Current = Cursors.Default

            MB(TIPO_DBG.CRI, ex.Message)
        Finally
            Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub cmdXML_Click(sender As System.Object, e As System.EventArgs) Handles cmdXml.Click
        If lvwExplorer.SelectedItems.Count <= 0 Then Return
        Try
            Dim ruta As String = String.Format("{0}\{1}\clock_skin.xml", PATH_SKINS, lvwExplorer.SelectedItems(0).Text)
            If IO.File.Exists(ruta) Then Process.Start(ruta)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdFileExplorer_Click(sender As Object, e As EventArgs) Handles cmdFileExplorer.Click
        If lvwExplorer.SelectedItems.Count <= 0 Then Return
        Try
            Dim ruta As String = String.Format("{0}\{1}", PATH_SKINS, lvwExplorer.SelectedItems(0).Text)
            If IO.Directory.Exists(ruta) Then Process.Start("explorer.exe", ruta)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Show_Clock(Optional elem As Integer = 0)
        Me.txtName.Text = canvas.Name

        Show_Element(Nothing) 'Deactivate properties

        lvwCanvas.BeginUpdate()
        lvwCanvas.Items.Clear()
        For Each element As CSkinPanel In canvas.Elements
            Dim img As String = ""
            Dim item As New ListViewItem(element.Tipo.ToString)
            item.Tag = element

            Select Case element.Status
                Case ESTADO_ELEMENTO.NEW : img = "new"
                Case ESTADO_ELEMENTO.FAIL : img = "warning"
            End Select
            item.ImageKey = img
            item.SubItems.Add(element.Description)
            lvwCanvas.Items.Add(item)
        Next
        'Select Case lvwCanvas.Items.Count
        '    Case 0 : lvwCanvas.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
        '    Case Else : lvwCanvas.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
        'End Select

        If elem = 0 AndAlso lvwCanvas.Items.Count > 0 Then elem = 0
        If elem >= 0 AndAlso elem <= lvwCanvas.Items.Count - 1 Then lvwCanvas.Items(elem).Selected = True : lvwCanvas.EnsureVisible(elem)

        lvwCanvas.EndUpdate()
    End Sub

    Private Sub txtCenterX_ValueChanged(sender As System.Object, e As System.EventArgs) Handles txtCenterX.ValueChanged
        If lvwCanvas.SelectedItems.Count <= 0 Then Return
        lvwCanvas.SelectedItems(0).Tag.CenterX = txtCenterX.Value
    End Sub
    Private Sub txtCenterY_ValueChanged(sender As System.Object, e As System.EventArgs) Handles txtCenterY.ValueChanged
        If lvwCanvas.SelectedItems.Count <= 0 Then Return
        lvwCanvas.SelectedItems(0).Tag.CenterY = txtCenterY.Value
    End Sub
    Private Sub txtWidth_ValueChanged(sender As System.Object, e As System.EventArgs) Handles txtWidth.ValueChanged
        If lvwCanvas.SelectedItems.Count <= 0 Then Return
        lvwCanvas.SelectedItems(0).Tag.Width = txtWidth.Value
    End Sub
    Private Sub txtHeight_ValueChanged(sender As System.Object, e As System.EventArgs) Handles txtHeight.ValueChanged
        If lvwCanvas.SelectedItems.Count <= 0 Then Return
        lvwCanvas.SelectedItems(0).Tag.Height = txtHeight.Value
    End Sub
    Private Sub txtAngle_ValueChanged(sender As System.Object, e As System.EventArgs) Handles txtAngle.ValueChanged
        If lvwCanvas.SelectedItems.Count <= 0 Then Return
        lvwCanvas.SelectedItems(0).Tag.Angle = txtAngle.Value
    End Sub
    Private Sub txtStartAngle_ValueChanged(sender As System.Object, e As System.EventArgs) Handles txtStartAngle.ValueChanged
        If lvwCanvas.SelectedItems.Count <= 0 Then Return
        lvwCanvas.SelectedItems(0).Tag.StartAngle = txtStartAngle.Value
    End Sub
    Private Sub cmbDirection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDirection.SelectedIndexChanged
        If lvwCanvas.SelectedItems.Count <= 0 Then Return
        If cmbDirection.SelectedIndex < 0 Then Return
        lvwCanvas.SelectedItems(0).Tag.Direction = cmbDirection.SelectedIndex
    End Sub
    Private Sub cmbColorBat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbColorBat.SelectedIndexChanged
        If cmbColorBat.SelectedIndex < 0 Then Return
        If lvwCanvas.SelectedItems.Count <= 0 Then Return
        lvwCanvas.SelectedItems(0).Tag.ColorBat = cmbColorBat.SelectedIndex
    End Sub
    Private Sub txtMulRotate_ValueChanged(sender As System.Object, e As System.EventArgs) Handles txtMulRotate.ValueChanged
        If lvwCanvas.SelectedItems.Count <= 0 Then Return
        lvwCanvas.SelectedItems(0).Tag.MulRotate = Me.txtMulRotate.Value
    End Sub

    ' allelimo - select all field on tab and enter mouse
    Private txtSelectByMouse As Boolean = False
    Private Sub txt_GotFocus(sender As System.Object, e As System.EventArgs) Handles txtCenterX.GotFocus, txtCenterY.GotFocus, txtWidth.GotFocus, txtHeight.GotFocus, txtMulRotate.GotFocus, txtAngle.GotFocus, txtStartAngle.GotFocus, txtBatt.GotFocus, txtDay.GotFocus, txtHeart.GotFocus, txtHour.GotFocus, txtMinutes.GotFocus, txtSeconds.GotFocus, txtSteps.GotFocus, txtTemperature.GotFocus, txtYear.GotFocus
        Dim box As NumericUpDown = sender
        box.Select(0, box.Value.ToString.Length)
    End Sub
    Private Sub txt_Enter(sender As System.Object, e As System.EventArgs) Handles txtCenterX.Enter, txtCenterY.Enter, txtWidth.Enter, txtHeight.Enter, txtMulRotate.Enter, txtAngle.Enter, txtStartAngle.Enter, txtBatt.Enter, txtDay.Enter, txtHeart.Enter, txtHour.Enter, txtMinutes.Enter, txtSeconds.Enter, txtSteps.Enter, txtTemperature.Enter, txtYear.Enter
        Dim box As NumericUpDown = sender
        box.Select(0, box.Value.ToString.Length)
        If MouseButtons = MouseButtons.Left Then txtSelectByMouse = True
    End Sub
    Private Sub txt_MouseDown(sender As System.Object, e As MouseEventArgs) Handles txtCenterX.MouseDown, txtCenterY.MouseDown, txtWidth.MouseDown, txtHeight.MouseDown, txtMulRotate.MouseDown, txtAngle.MouseDown, txtStartAngle.MouseDown, txtBatt.MouseDown, txtDay.MouseDown, txtHeart.MouseDown, txtHour.MouseDown, txtMinutes.MouseDown, txtSeconds.MouseDown, txtSteps.MouseDown, txtTemperature.MouseDown, txtYear.MouseDown
        Dim box As NumericUpDown = sender
        If txtSelectByMouse Then box.Select(0, box.Value.ToString.Length)
        txtSelectByMouse = False
    End Sub

    Private Sub cmdColorDel_Click(sender As Object, e As EventArgs) Handles cmdColorDel.Click
        If lvwCanvas.SelectedItems.Count <= 0 Then Return

        lvwCanvas.SelectedItems(0).Tag.Color1 = Color.Transparent
        lvwCanvas.SelectedItems(0).Tag.Color2 = Color.Transparent

        cmdColor1.BackColor = Color.Transparent : cmdColor1.Text = "Transp"
        cmdColor2.BackColor = Color.Transparent : cmdColor2.Text = "Transp"
    End Sub

    Private Sub cmdColor1_Click(sender As Object, e As EventArgs) Handles cmdColor1.Click
        If lvwCanvas.SelectedItems.Count <= 0 Then Return

        dlgColor.Color = cmdColor1.BackColor
        If dlgColor.ShowDialog() <> System.Windows.Forms.DialogResult.OK Then Return
        lvwCanvas.SelectedItems(0).Tag.Color1 = dlgColor.Color

        cmdColor1.BackColor = dlgColor.Color
        cmdColor1.Text = ColorTranslator.ToHtml(Color.FromArgb(dlgColor.Color.ToArgb)).Substring(1)
    End Sub

    Private Sub cmdColor2_Click(sender As Object, e As EventArgs) Handles cmdColor2.Click
        If lvwCanvas.SelectedItems.Count <= 0 Then Return

        dlgColor.Color = cmdColor2.BackColor
        If dlgColor.ShowDialog() <> System.Windows.Forms.DialogResult.OK Then Return
        lvwCanvas.SelectedItems(0).Tag.Color2 = dlgColor.Color

        cmdColor2.BackColor = dlgColor.Color
        cmdColor2.Text = ColorTranslator.ToHtml(Color.FromArgb(dlgColor.Color.ToArgb)).Substring(1)
    End Sub

    Private Sub Show_Element(element As CSkinPanel)
        If element Is Nothing Then
            Me.txtCenterX.Enabled = False
            Me.txtCenterY.Enabled = False
            Me.txtWidth.Enabled = False
            Me.txtHeight.Enabled = False
            Me.txtAngle.Enabled = False
            Me.txtStartAngle.Enabled = False
            Me.txtMulRotate.Enabled = False
            Me.cmbDirection.Enabled = False
            Me.cmbDirection.SelectedIndex = -1
            Me.cmbColorBat.Enabled = False
            Me.cmbColorBat.SelectedIndex = -1

            Me.cmdColor1.Enabled = False
            Me.cmdColor2.Enabled = False
            Me.cmdColorDel.Enabled = False
            Me.cmdColor1.BackColor = Color.Transparent : Me.cmdColor1.Text = "Transp"
            Me.cmdColor2.BackColor = Color.Transparent : Me.cmdColor2.Text = "Transp"
            Me.cmdFileName.Enabled = False
            Me.cmdArray.Enabled = False
            Return
        End If

        canvas.SelectElement(element)

        Select Case element.Tipo
            Case TIPO_ELEMENTO.array_special_second
                Me.txtCenterX.Enabled = False
                Me.txtCenterY.Enabled = False

                element.CenterX = 0
                element.CenterY = 0
            Case TIPO_ELEMENTO.image To TIPO_ELEMENTO.ARRAY_END - 1 'en todos los elementos se puede mover cel centro
                Me.txtCenterX.Enabled = True
                Me.txtCenterY.Enabled = True
        End Select
        Try : Me.txtCenterX.Value = element.CenterX : Catch : End Try
        Try : Me.txtCenterY.Value = element.CenterY : Catch : End Try

        Select Case element.Tipo
            Case TIPO_ELEMENTO.array_charging_batt, TIPO_ELEMENTO.array_special_second
                Me.txtWidth.Enabled = False
                Me.txtHeight.Enabled = False
            Case TIPO_ELEMENTO.image To TIPO_ELEMENTO.ARRAY_END - 1
                Me.txtWidth.Enabled = True
                Me.txtHeight.Enabled = True
        End Select
        Try : Me.txtWidth.Value = element.Width : Catch : End Try
        Try : Me.txtHeight.Value = element.Height : Catch : End Try

        Select Case element.Tipo
            Case TIPO_ELEMENTO.rotate_hour To TIPO_ELEMENTO.ROTATE_END - 1
                Me.txtAngle.Enabled = True 'Propiedades solo de rotates
                Me.txtStartAngle.Enabled = True
                Me.txtMulRotate.Enabled = True
                Me.cmbDirection.Enabled = True
            Case Else
                Me.txtAngle.Enabled = False
                Me.txtStartAngle.Enabled = False
                Me.txtMulRotate.Enabled = False
                Me.cmbDirection.Enabled = False

                element.Angle = 0
                element.StartAngle = 0
                element.MulRotate = 0
                element.Direction = 0
        End Select
        Try : Me.txtAngle.Value = element.Angle : Catch : End Try
        Try : Me.txtStartAngle.Value = element.StartAngle : Catch : End Try
        Try : Me.txtMulRotate.Value = element.MulRotate : Catch : End Try
        Me.cmbDirection.SelectedIndex = element.Direction

        Select Case element.Tipo
            Case TIPO_ELEMENTO.array_charging_batt
                Me.cmbColorBat.Enabled = True
                Me.cmbColorBat.SelectedIndex = element.ColorBat
            Case Else
                Me.cmbColorBat.Enabled = False
                Me.cmbColorBat.SelectedIndex = -1
        End Select

        Select Case element.Tipo
            Case TIPO_ELEMENTO.array_arc_battery, TIPO_ELEMENTO.array_arc_steps, TIPO_ELEMENTO.array_special_second
                Me.cmdColor1.Enabled = True
                Me.cmdColor2.Enabled = True
                Me.cmdColorDel.Enabled = True
            Case Else
                Me.cmdColor1.Enabled = False
                Me.cmdColor2.Enabled = False
                Me.cmdColorDel.Enabled = False

                element.Color1 = Color.Transparent
                element.Color2 = Color.Transparent
        End Select

        Me.cmdColor1.BackColor = element.Color1
        Me.cmdColor2.BackColor = element.Color2
        Select Case element.Color1
            Case Color.Transparent : Me.cmdColor1.Text = "Transp"
            Case Else : Me.cmdColor1.Text = ColorTranslator.ToHtml(Color.FromArgb(element.Color1.ToArgb)).Substring(1)
        End Select
        Select Case element.Color2
            Case Color.Transparent : Me.cmdColor2.Text = "Transp"
            Case Else : Me.cmdColor2.Text = ColorTranslator.ToHtml(Color.FromArgb(element.Color2.ToArgb)).Substring(1)
        End Select

        Select Case element.Tipo
            Case TIPO_ELEMENTO.array_charging_batt, TIPO_ELEMENTO.array_special_second
                Me.cmdFileName.Enabled = False
            Case Else
                Me.cmdFileName.Enabled = True
        End Select

        '''''''''' OPCIONES DE ARRAY GENERATOR
        Select Case element.Tipo
            Case TIPO_ELEMENTO.array_charging_batt, TIPO_ELEMENTO.array_special_second, TIPO_ELEMENTO.array_moon_phase, TIPO_ELEMENTO.array_weather
                Me.cmdArray.Enabled = False
            Case TIPO_ELEMENTO.ROTATE_END + 1 To TIPO_ELEMENTO.ARRAY_END - 1
                Me.cmdArray.Enabled = True
            Case Else
                Me.cmdArray.Enabled = False
        End Select
    End Sub

    Private Sub cmdFileName_Click(sender As System.Object, e As System.EventArgs) Handles cmdFileName.Click
        If lvwCanvas.SelectedItems.Count <= 0 Then Return
        If lvwExplorer.SelectedItems.Count <= 0 Then Return
        Dim element As CSkinPanel = lvwCanvas.SelectedItems(0).Tag

        Try
            Select Case element.Tipo
                Case TIPO_ELEMENTO.array_charging_batt, TIPO_ELEMENTO.array_special_second : Return
                Case TIPO_ELEMENTO.image To TIPO_ELEMENTO.ROTATE_END - 1
                    Dim frm As New frmSearchImage(String.Format("{0}\{1}", PATH_SKINS, lvwExplorer.SelectedItems(0).Text))
                    If frm.ShowDialog() <> System.Windows.Forms.DialogResult.OK Then Return

                    element.FileName = frm.FileName
                    lvwCanvas.SelectedItems(0).ImageKey = ""
                    lvwCanvas.SelectedItems(0).SubItems(1).Text = element.Description 'Ha cambiado el nombre, se carga para mostrarlo

                    Show_Element(element)
                Case TIPO_ELEMENTO.ROTATE_END + 1 To TIPO_ELEMENTO.ARRAY_END - 1
                    Dim frm As New frmSearchArray(String.Format("{0}\{1}", PATH_SKINS, lvwExplorer.SelectedItems(0).Text), element.FileName)
                    If frm.ShowDialog() <> System.Windows.Forms.DialogResult.OK Then Return

                    element.FileName = frm.FileName
                    lvwCanvas.SelectedItems(0).ImageKey = ""
                    lvwCanvas.SelectedItems(0).SubItems(1).Text = element.Description 'Ha cambiado el nombre, se carga para mostrarlo

                    Show_Element(element)
            End Select
        Catch ex As Exception
            lvwCanvas.SelectedItems(0).ImageKey = "warning"
            MB(TIPO_DBG.ERR, ex.Message)
        End Try
    End Sub

    Private Sub cmdDel_Click(sender As System.Object, e As System.EventArgs) Handles cmdDel.Click
        If lvwCanvas.SelectedItems.Count <= 0 Then Return

        canvas.RemoveElement(lvwCanvas.SelectedItems(0).Tag)
        lvwCanvas.Items.RemoveAt(lvwCanvas.SelectedIndices(0))
        Show_Clock()
    End Sub

    Private Sub cmdUp_Click(sender As System.Object, e As System.EventArgs) Handles cmdUp.Click
        If lvwCanvas.SelectedItems.Count <= 0 Then Return

        If Not canvas.UpElement(lvwCanvas.SelectedItems(0).Tag) Then Return
        Dim act As Integer = lvwCanvas.SelectedIndices(0)
        Show_Clock(act - 1)
    End Sub

    Private Sub cmdDown_Click(sender As System.Object, e As System.EventArgs) Handles cmdDown.Click
        If lvwCanvas.SelectedItems.Count <= 0 Then Return
        If Not canvas.DownElement(lvwCanvas.SelectedItems(0).Tag) Then Return

        Dim act As Integer = lvwCanvas.SelectedIndices(0)
        Show_Clock(act + 1)
    End Sub
    Private Sub cmdImport_Click(sender As Object, e As EventArgs) Handles cmdImport.Click
        dlgFileName.InitialDirectory = PATH_SKINS
        dlgFileName.Filter = "(*.watch)|*.watch"
        If dlgFileName.ShowDialog() <> System.Windows.Forms.DialogResult.OK Then Return

        Try
            canvas.ImportFromWatch(dlgFileName.FileName, PATH_SKINS)

            'Se añade al editor
            If Not lvwExplorer.Items.ContainsKey(canvas.Name) Then lvwExplorer.Items.Add(canvas.Name, canvas.Name, -1)
            lvwExplorer.Items(canvas.Name).Selected = True : lvwExplorer.Items(canvas.Name).EnsureVisible()

            canvas.Load(String.Format("{0}\{1}", PATH_SKINS, canvas.Name))
            Show_Clock()

            MB(TIPO_DBG.MSJ, "Remember this action ONLY imports images, you MUST manually add elements.")
        Catch ex As Exception
            MB(TIPO_DBG.CRI, ex.Message)
        End Try

    End Sub


    Private Sub OnOkArrayGenerator(sender As CSkinPanel)
        For Each item As ListViewItem In lvwCanvas.Items
            If sender Is item.Tag Then
                item.ImageKey = ""
                item.SubItems(1).Text = sender.Description 'Ha cambiado el nombre, se carga para mostrarlo
                Exit For
            End If
        Next
    End Sub
    Private Sub cmdArray_Click(sender As Object, e As EventArgs) Handles cmdArray.Click
        If lvwCanvas.SelectedItems.Count <= 0 Then Return
        Dim element As CSkinPanel = lvwCanvas.SelectedItems(0).Tag

        Try
            Dim frm As New frmArrayGenerator(element, element.FileName)
            AddHandler frm.OnOk, AddressOf OnOkArrayGenerator
            frm.Show()
        Catch ex As Exception
            MB(TIPO_DBG.ERR, ex.Message)
        End Try
    End Sub

    Private Sub dirWatcher_Changed(sender As Object, e As FileSystemEventArgs) Handles dirWatcher.Created, dirWatcher.Deleted, dirWatcher.Renamed
        Select Case e.ChangeType
            Case WatcherChangeTypes.Deleted
                If e.Name.ToString.ToLower = canvas.Name.ToLower Then canvas.Clear()
            Case WatcherChangeTypes.Renamed
                If DirectCast(e, RenamedEventArgs).OldName.ToString.ToLower = canvas.Name.ToLower Then canvas.Load(String.Format("{0}\{1}", PATH_SKINS, e.Name))
        End Select
        Show_Explorer(canvas.Name)
    End Sub

    Private Sub optMode_CheckedChanged(sender As Object, e As EventArgs) Handles optModeEdit.CheckedChanged, optModeTest.CheckedChanged, chkNow.CheckedChanged
        If Not Me.IsHandleCreated Then Return
        Select Case True
            Case optModeEdit.Checked : canvas.Mode = TIPO_MODO.EDIT
            Case optModeTest.Checked : canvas.Mode = IIf(chkNow.Checked, TIPO_MODO.NOW, TIPO_MODO.TEST)
        End Select

        txtHour.Enabled = canvas.Mode = TIPO_MODO.TEST
        txtMinutes.Enabled = canvas.Mode = TIPO_MODO.TEST
        txtSeconds.Enabled = canvas.Mode = TIPO_MODO.TEST
        cmbWeekday.Enabled = canvas.Mode = TIPO_MODO.TEST
        cmbMonth.Enabled = canvas.Mode = TIPO_MODO.TEST
        txtDay.Enabled = canvas.Mode = TIPO_MODO.TEST
        txtYear.Enabled = canvas.Mode = TIPO_MODO.TEST

        chkNow.Enabled = canvas.Mode = TIPO_MODO.TEST OrElse canvas.Mode = TIPO_MODO.NOW
        txtBatt.Enabled = canvas.Mode = TIPO_MODO.TEST OrElse canvas.Mode = TIPO_MODO.NOW
        txtHeart.Enabled = canvas.Mode = TIPO_MODO.TEST OrElse canvas.Mode = TIPO_MODO.NOW
        txtTemperature.Enabled = canvas.Mode = TIPO_MODO.TEST OrElse canvas.Mode = TIPO_MODO.NOW
        txtSteps.Enabled = canvas.Mode = TIPO_MODO.TEST OrElse canvas.Mode = TIPO_MODO.NOW
        cmbMoon.Enabled = canvas.Mode = TIPO_MODO.TEST OrElse canvas.Mode = TIPO_MODO.NOW
        cmbWeather.Enabled = canvas.Mode = TIPO_MODO.TEST OrElse canvas.Mode = TIPO_MODO.NOW

        grpMode.Visible = canvas.Mode = TIPO_MODO.TEST OrElse canvas.Mode = TIPO_MODO.NOW
    End Sub

    Private Sub txtTest_ValueChanged(sender As Object, e As EventArgs) Handles txtHour.ValueChanged, txtMinutes.ValueChanged, txtSeconds.ValueChanged, txtBatt.ValueChanged, txtDay.ValueChanged, txtYear.ValueChanged, txtHeart.ValueChanged, txtTemperature.ValueChanged, txtSteps.ValueChanged
        If Not Me.IsHandleCreated Then Return
        Select Case True
            Case sender Is txtHour : canvas.Hour = txtHour.Value
            Case sender Is txtMinutes : canvas.Minutes = txtMinutes.Value
            Case sender Is txtSeconds : canvas.Seconds = txtSeconds.Value
            Case sender Is txtBatt : canvas.Batt = txtBatt.Value
            Case sender Is txtDay : canvas.Day = txtDay.Value
            Case sender Is txtYear : canvas.Year = txtYear.Value
            Case sender Is txtHeart : canvas.Heartrate = txtHeart.Value
            Case sender Is txtTemperature : canvas.Temprature = txtTemperature.Value
            Case sender Is txtSteps : canvas.Steps = txtSteps.Value
        End Select
    End Sub

    Private Sub cmbTest_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbWeekday.SelectedIndexChanged, cmbMonth.SelectedIndexChanged, cmbMoon.SelectedIndexChanged, cmbWeather.SelectedIndexChanged
        Select Case True
            Case sender Is cmbWeekday : If cmbWeekday.SelectedIndex >= 0 Then canvas.Weekday = cmbWeekday.SelectedIndex + 1
            Case sender Is cmbMonth : If cmbMonth.SelectedIndex >= 0 Then canvas.Month = cmbMonth.SelectedIndex + 1
            Case sender Is cmbMoon : If cmbMoon.SelectedIndex >= 0 Then canvas.Moon = cmbMoon.SelectedIndex
            Case sender Is cmbWeather : If cmbWeather.SelectedIndex >= 0 Then canvas.Weather = cmbWeather.SelectedIndex
        End Select
    End Sub
End Class


