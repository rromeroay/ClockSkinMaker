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
Imports System.Drawing

Public Enum TIPO_MODO
    EDIT = 0
    TEST
    NOW
End Enum

Public Class CSkinCanvas
    Private _name As String = ""
    Public ReadOnly Property Name As String
        Get
            Return Me._name
        End Get
    End Property

    Private WithEvents Window As Panel
    Private WithEvents Sizer As CPictureBoxTransparent

    Public ReadOnly Elements As New List(Of CSkinPanel)
    Private SelectedElement As CSkinPanel = Nothing

    Public Event OnMouseMove(sender As CSkinCanvas, e As Point)
    Public Event OnUpdatedElement(sender As CSkinCanvas, e As CSkinPanel)
    Public Event OnDoubleClickElement(sender As CSkinCanvas, e As CSkinPanel)

    Private bMoviendo As Boolean = False
    Private bCambiandoTam As Boolean = False
    Private MoveOffset As Point
    Private MousePosition As New Point(0, 0)
    Private Sub Window_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Window.MouseMove
        Me.MousePosition = Me.Window.PointToClient(Cursor.Position) - New Point(200, 200)
        RaiseEvent OnMouseMove(Me, Me.MousePosition)
    End Sub
    Private Sub Sizer_MouseDown(sender As Object, e As MouseEventArgs) Handles Sizer.MouseDown
        If SelectedElement Is Nothing Then Return
        bMoviendo = False
        bCambiandoTam = False
        MoveOffset = New Point(e.Location.X, e.Location.Y)
    End Sub
    Private Sub Sizer_MouseMove(sender As Object, e As MouseEventArgs) Handles Sizer.MouseMove
        If SelectedElement Is Nothing Then Return
        Select Case e.Button
            Case MouseButtons.Left
                bMoviendo = True
                Sizer.Location += New Point(e.Location.X - MoveOffset.X, e.Location.Y - MoveOffset.Y)
                SelectedElement.Location = Sizer.Location

                Me.MousePosition = New Point(SelectedElement.CenterX, SelectedElement.CenterY)
                RaiseEvent OnMouseMove(Me, Me.MousePosition)
            Case MouseButtons.Right
                Select Case SelectedElement.Tipo
                    Case TIPO_ELEMENTO.array_charging_batt, TIPO_ELEMENTO.array_special_second  'no se permite cambiar de tamaño
                    Case Else
                        bCambiandoTam = True
                        Sizer.Size = New Size(e.Location.X, e.Location.Y)
                        SelectedElement.Size = Sizer.Size
                End Select
        End Select
        Me.Refresh()
    End Sub
    Private Sub Sizer_MouseUp(sender As Object, e As MouseEventArgs) Handles Sizer.MouseUp
        If SelectedElement Is Nothing Then Return
        Select Case True
            Case bMoviendo, bCambiandoTam
                RaiseEvent OnUpdatedElement(Me, SelectedElement)
            Case Else
                'mouse click 
                If Not Sizer.ClientRectangle.Contains(e.Location) Then Return
        End Select
    End Sub
    Private Sub Sizer_DoubleClick(sender As Object, e As EventArgs) Handles Sizer.DoubleClick
        If SelectedElement Is Nothing Then Return
        RaiseEvent OnDoubleClickElement(Me, SelectedElement)
    End Sub

    Private _timer As System.Threading.Timer
    Private _mode As TIPO_MODO = TIPO_MODO.EDIT
    Private ahora As DateTime = Date.Now
    Public Property Mode As TIPO_MODO
        Get
            Return _mode
        End Get
        Set(value As TIPO_MODO)
            _mode = value
            Select Case _mode
                Case TIPO_MODO.NOW, TIPO_MODO.TEST : _timer.Change(0, 16)
                Case Else : _timer.Change(Threading.Timeout.Infinite, Threading.Timeout.Infinite) : Me.Refresh()
            End Select
        End Set
    End Property

    Private Sub OnTimer_Tick(ByVal stateInfo As Object)
        ahora = Now
        Me.Refresh()
    End Sub

    Private Ready As Boolean = False
    Private IsPainting As Boolean = False
    Private Sub Window_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Window.Paint
        If Not Me.Ready Then Return
        If Me.IsPainting Then Return

        Try
            Me.IsPainting = True

            For Each elemento As CSkinPanel In Me.Elements
                If Not IsNothing(elemento.Imagen) AndAlso elemento.Visible = True Then
                    Select Case Me.Mode
                        Case TIPO_MODO.EDIT
                            Select Case elemento.Tipo
                                Case TIPO_ELEMENTO.array_arc_battery, TIPO_ELEMENTO.array_arc_steps, TIPO_ELEMENTO.array_special_second
                                    e.Graphics.DrawImage(elemento.Imagen, 0, 0, 400, 400)
                                Case Else
                                    e.Graphics.DrawImage(elemento.Imagen, elemento.Left, elemento.Top, elemento.Width, elemento.Height)
                            End Select
                        Case TIPO_MODO.NOW
                            If elemento.Status <> ESTADO_ELEMENTO.LOADED Then Continue For
                            Dim value As Single = 0
                            Select Case elemento.Tipo
                                Case TIPO_ELEMENTO.rotate_hour, TIPO_ELEMENTO.rotate_shadow_hour, TIPO_ELEMENTO.array_hour : value = ahora.Hour + ahora.Minute / 60
                                Case TIPO_ELEMENTO.rotate_minute, TIPO_ELEMENTO.rotate_shadow_minute, TIPO_ELEMENTO.array_minute : value = ahora.Minute '+ ahora.Second / 60
                                Case TIPO_ELEMENTO.rotate_second, TIPO_ELEMENTO.rotate_shadow_second, TIPO_ELEMENTO.array_second, TIPO_ELEMENTO.array_special_second : value = ahora.Second + ahora.Millisecond / 1000
                                Case TIPO_ELEMENTO.rotate_month, TIPO_ELEMENTO.array_month : value = ahora.Month
                                Case TIPO_ELEMENTO.rotate_weekday, TIPO_ELEMENTO.array_weekday : value = DateAndTime.Weekday(ahora, FirstDayOfWeek.Monday)
                                Case TIPO_ELEMENTO.rotate_daynight : value = ahora.Hour

                                Case TIPO_ELEMENTO.array_day : value = ahora.Day
                                Case TIPO_ELEMENTO.array_hourminute : value = String.Format("{0:00}{1:00}", ahora.Hour, ahora.Minute)
                                Case TIPO_ELEMENTO.array_monthday : value = String.Format("{0:00}{1:00}", ahora.Month, ahora.Day)
                                Case TIPO_ELEMENTO.array_yearmonthday : value = String.Format("{0:0000}{1:00}{2:00}", ahora.Year, ahora.Month, ahora.Day)
                                Case TIPO_ELEMENTO.array_year : value = ahora.Year

                                Case TIPO_ELEMENTO.array_weather : value = Me.Weather
                                Case TIPO_ELEMENTO.array_moon_phase : value = Me.Moon
                                Case TIPO_ELEMENTO.array_temprature : value = Me.Temprature
                                Case TIPO_ELEMENTO.array_heartrate : value = Me.Heartrate
                                Case TIPO_ELEMENTO.array_steps, TIPO_ELEMENTO.array_arc_steps : value = Me.Steps
                                Case TIPO_ELEMENTO.array_arc_battery, TIPO_ELEMENTO.array_battery_level, TIPO_ELEMENTO.rotate_battery : value = Me.Batt
                            End Select

                            e.Graphics.DrawImage(elemento.Sample(value), 0, 0, 400, 400) 'Los samples van sobre 400x400,para que esté visible tenga el angulo que tenga
                        Case TIPO_MODO.TEST
                            If elemento.Status <> ESTADO_ELEMENTO.LOADED Then Continue For

                            Dim value As Single = 0
                            Select Case elemento.Tipo
                                Case TIPO_ELEMENTO.rotate_hour, TIPO_ELEMENTO.rotate_shadow_hour, TIPO_ELEMENTO.array_hour : value = Me.Hour
                                Case TIPO_ELEMENTO.rotate_minute, TIPO_ELEMENTO.rotate_shadow_minute, TIPO_ELEMENTO.array_minute : value = Me.Minutes
                                Case TIPO_ELEMENTO.rotate_second, TIPO_ELEMENTO.rotate_shadow_second, TIPO_ELEMENTO.array_second, TIPO_ELEMENTO.array_special_second : value = Me.Seconds
                                Case TIPO_ELEMENTO.rotate_month, TIPO_ELEMENTO.array_month : value = Me.Month
                                Case TIPO_ELEMENTO.rotate_weekday, TIPO_ELEMENTO.array_weekday : value = Me.Weekday
                                Case TIPO_ELEMENTO.rotate_daynight : value = Me.Hour
                                Case TIPO_ELEMENTO.array_day : value = Me.Day
                                Case TIPO_ELEMENTO.array_hourminute : value = String.Format("{0:00}{1:00}", Me.Hour, Me.Minutes)
                                Case TIPO_ELEMENTO.array_monthday : value = String.Format("{0:00}{1:00}", Me.Month, Me.Day)
                                Case TIPO_ELEMENTO.array_yearmonthday : value = String.Format("{0:0000}{1:00}{2:00}", Me.Year, Me.Month, Me.Day)
                                Case TIPO_ELEMENTO.array_year : value = Me.Year

                                Case TIPO_ELEMENTO.array_weather : value = Me.Weather
                                Case TIPO_ELEMENTO.array_moon_phase : value = Me.Moon
                                Case TIPO_ELEMENTO.array_temprature : value = Me.Temprature
                                Case TIPO_ELEMENTO.array_heartrate : value = Me.Heartrate
                                Case TIPO_ELEMENTO.array_steps, TIPO_ELEMENTO.array_arc_steps : value = Me.Steps
                                Case TIPO_ELEMENTO.array_arc_battery, TIPO_ELEMENTO.array_battery_level, TIPO_ELEMENTO.rotate_battery : value = Me.Batt

                                Case TIPO_ELEMENTO.array_special_second : value = Me.Seconds
                            End Select

                            e.Graphics.DrawImage(elemento.Sample(value), 0, 0, 400, 400) 'Los samples van sobre 400x400,para que esté visible tenga el angulo que tenga
                    End Select
                End If
            Next

            If Me.Mode <> TIPO_MODO.EDIT Then Return

            If Not SelectedElement Is Nothing Then
                Select Case SelectedElement.Tipo
                    Case TIPO_ELEMENTO.array_charging_batt
                        Sizer.Size = SelectedElement.Size - New Size(50, 0)
                        Sizer.Location = SelectedElement.Location + New Point(50, 0)
                    Case Else
                        Sizer.Size = SelectedElement.Size
                        Sizer.Location = SelectedElement.Location
                End Select

                Using p As Pen = New Pen(Brushes.LimeGreen, 2) 'Borde
                    p.DashPattern = {5, 2, 15, 4}
                    e.Graphics.DrawRectangle(p, Sizer.Left, Sizer.Top, Sizer.Width, Sizer.Height)
                End Using
                Using p As Pen = New Pen(Brushes.LimeGreen, 1) 'cruceta
                    e.Graphics.DrawLine(p, Sizer.Left + Single.Parse((Sizer.Width / 2)) - 5, Sizer.Top + Single.Parse((Sizer.Height / 2)), Sizer.Left + Single.Parse((Sizer.Width / 2)) + 5, Sizer.Top + Single.Parse((Sizer.Height / 2)))
                    e.Graphics.DrawLine(p, Sizer.Left + Single.Parse((Sizer.Width / 2)), Sizer.Top + Single.Parse((Sizer.Height / 2)) - 5, Sizer.Left + Single.Parse((Sizer.Width / 2)), Sizer.Top + Single.Parse((Sizer.Height / 2)) + 5)
                End Using

                If (SelectedElement.Angle <> 0 OrElse SelectedElement.StartAngle <> 0) AndAlso (Sizer.Width <> 0 AndAlso Sizer.Height <> 0) Then
                    Using p As Pen = New Pen(Brushes.Red, 2)
                        Dim rect As New Rectangle(Sizer.Left, Sizer.Top, Sizer.Width, Sizer.Height)
                        e.Graphics.DrawPie(p, rect, -90 + SelectedElement.Angle + SelectedElement.StartAngle, 0.01)
                    End Using
                    Using p As Pen = New Pen(Brushes.Yellow, 2)
                        Dim rect As New Rectangle(Sizer.Left, Sizer.Top, Sizer.Width, Sizer.Height)
                        e.Graphics.DrawPie(p, rect, -90 + SelectedElement.Angle, 0.01)
                    End Using
                End If
            End If
        Catch

        Finally
            Me.IsPainting = False
        End Try
    End Sub

    Public Sub Refresh()
        If Not Me.Ready Then Return
        If Me.IsPainting Then Return
        Me.Window.Invalidate()
    End Sub

    Public Sub New(preview As Panel)
        Me.Window = preview
        Me.Window.Width = 400
        Me.Window.Height = 400
        Me.Window.BackgroundImage = My.Resources.canvas
        Me.Window.BackColor = Color.Transparent

        Me.Sizer = New CPictureBoxTransparent
        Me.Window.Controls.Add(Me.Sizer)
        Me.Clear()

        _timer = New System.Threading.Timer(New System.Threading.TimerCallback(AddressOf OnTimer_Tick), Nothing, Threading.Timeout.Infinite, Threading.Timeout.Infinite)
    End Sub

    Public Function CreateElement(tipo As TIPO_ELEMENTO) As CSkinPanel
        Dim elemento As New CSkinPanel(Me, tipo)
        Me.AddElement(elemento)
        Return elemento
    End Function
    Private Sub AddElement(elemento As CSkinPanel)
        Try
            'Se ponsen los elementos por capas
            Me.Elements.Add(elemento)

            Me.Window.Controls.Add(elemento)
            Me.Window.Controls.SetChildIndex(elemento, 0)
            Me.Window.Controls.SetChildIndex(Me.Sizer, 0)

            Me.SelectedElement = elemento
            AddHandler elemento.MouseMove, AddressOf Me.Window_MouseMove
        Finally
            Me.Refresh()
        End Try
    End Sub
    Public Sub RemoveElement(element As CSkinPanel)
        Try
            If Elements.Contains(element) Then Me.Elements.Remove(element)
            If Me.Window.Controls.Contains(element) Then Me.Window.Controls.Remove(element)
            If element Is SelectedElement Then SelectedElement = Nothing

            element.Dispose() : element = Nothing
        Finally
            Me.Refresh()
        End Try
    End Sub

    Public Function GetElementsByName(nombre As String) As List(Of CSkinPanel)
        Dim ret As New List(Of CSkinPanel)
        For Each elemento As CSkinPanel In Me.Elements
            If IO.Path.GetFileName(elemento.FileName).ToLower = nombre.ToLower Then ret.Add(elemento)
        Next
        Return ret
    End Function
    Public Function GetElementsByDrawable(nombre As String) As List(Of CSkinPanel)
        Dim ret As New List(Of CSkinPanel)
        For Each elemento As CSkinPanel In Me.Elements
            For Each drawable As String In elemento.Drawables
                If IO.Path.GetFileName(drawable).ToLower = nombre.ToLower Then ret.Add(elemento)
            Next
        Next
        Return ret
    End Function
    Public Function GetElementsByType(ParamArray tipos() As TIPO_ELEMENTO) As List(Of CSkinPanel)
        Dim ret As New List(Of CSkinPanel)
        If tipos.Length <= 0 Then Return ret

        For Each elemento As CSkinPanel In Me.Elements
            If tipos.Contains(elemento.Tipo) Then ret.Add(elemento)
        Next

        Return ret
    End Function

    Public Shared Function FindUniqueName(element As CSkinPanel, ruta As String, initial As String) As String
        Dim ret As String = String.Format("{0}\{1}", ruta, IO.Path.GetFileName(initial))

        For Each otro As CSkinPanel In element.SkinCanvas.GetElementsByName(IO.Path.GetFileName(initial))
            If Not otro Is element Then 'Exists another element with same name, its needed to rename (really it's only necessary if changes sizes...)
                Dim i As Integer = 0
                Do
                    i += 1
                    ret = String.Format("{0}\{1}_{2}{3}", ruta, IO.Path.GetFileNameWithoutExtension(initial), i, IO.Path.GetExtension(initial))
                Loop Until Not IO.File.Exists(ret) 'Find a free name
                Exit For
            End If
        Next

        Return ret
    End Function
    Public Shared Function FindUniqueNameDrawable(element As CSkinPanel, ruta As String, initial As String) As String
        Dim ret As String = String.Format("{0}\{1}", ruta, IO.Path.GetFileName(initial))

        For Each otro As CSkinPanel In element.SkinCanvas.GetElementsByDrawable(IO.Path.GetFileName(initial))
            If Not otro Is element Then 'Exists another element with same name, its needed to rename (really it's only necessary if changes sizes...)
                Dim i As Integer = 0
                Do
                    i += 1
                    ret = String.Format("{0}\{1}_{2}{3}", ruta, IO.Path.GetFileNameWithoutExtension(initial), i, IO.Path.GetExtension(initial))
                Loop Until Not IO.File.Exists(ret) 'Find a free name
                Exit For
            End If
        Next

        Return ret
    End Function

    Public Function UpElement(element As CSkinPanel) As Boolean
        Try
            If Not Elements.Contains(element) Then Return False
            If Not Me.Window.Controls.Contains(element) Then Return False

            Dim pos As Integer = Elements.IndexOf(element)
            If pos <= 0 Then Return False

            Dim temp As CSkinPanel = Elements(pos)
            Elements(pos) = Elements(pos - 1)
            Elements(pos - 1) = temp

            Me.Window.Controls.SetChildIndex(element, Me.Window.Controls.GetChildIndex(element) + 1)
        Catch ex As Exception : Return False
        Finally
            Me.Refresh()
        End Try

        Return True
    End Function
    Public Function DownElement(element As CSkinPanel) As Boolean
        Try
            If Not Elements.Contains(element) Then Return False
            If Not Me.Window.Controls.Contains(element) Then Return False
            Dim pos As Integer = Elements.IndexOf(element)

            If pos < 0 OrElse pos >= Elements.Count - 1 Then Return False

            Dim temp As CSkinPanel = Elements(pos)
            Elements(pos) = Elements(pos + 1)
            Elements(pos + 1) = temp

            Me.Window.Controls.SetChildIndex(element, Me.Window.Controls.GetChildIndex(element) - 1)
        Catch ex As Exception : Return False
        Finally
            Me.Refresh()
        End Try

        Return True
    End Function
    Public Sub SelectElement(element As CSkinPanel)
        Me.SelectedElement = element
        'Me.Refresh()
    End Sub

    Public Sub Clear()
        Try
            Me.Ready = False

            For Each elemento As CSkinPanel In Me.Elements
                elemento.Parent = Nothing
                elemento.Dispose() : elemento = Nothing
            Next
            SelectedElement = Nothing

            Me.Elements.Clear()
            Me.Window.Controls.Clear()
            Me.Window.Controls.Add(Me.Sizer)
        Finally
            Me.Ready = True
            Me.Refresh()
        End Try
    End Sub
    Public Sub [New](nombre As String)
        Try
            Me.Clear()

            Me.Ready = False
            Me._name = nombre
        Finally

            Me.Ready = True
            Me.Refresh()
        End Try
    End Sub

    Public Sub Snapshot(ruta As String)
        Try
            _timer.Change(Threading.Timeout.Infinite, Threading.Timeout.Infinite)

            If Me.Name.Trim = "" Then Throw New Exception("No name.")
            System.IO.Directory.CreateDirectory(ruta)

            Using bmp As New Bitmap(Window.Width, Window.Height)
                Using g As Graphics = Graphics.FromImage(bmp)
                    For Each element As CSkinPanel In Elements
                        If element.Status <> ESTADO_ELEMENTO.LOADED Then Continue For

                        Dim value As Single = 0
                        Select Case element.Tipo
                            Case TIPO_ELEMENTO.array_charging_batt : Continue For
                            Case TIPO_ELEMENTO.rotate_hour, TIPO_ELEMENTO.rotate_shadow_hour, TIPO_ELEMENTO.array_hour : value = 10
                            Case TIPO_ELEMENTO.rotate_minute, TIPO_ELEMENTO.rotate_shadow_minute, TIPO_ELEMENTO.array_minute : value = 9
                            Case TIPO_ELEMENTO.rotate_second, TIPO_ELEMENTO.rotate_shadow_second, TIPO_ELEMENTO.array_second, TIPO_ELEMENTO.array_special_second : value = 34
                            Case TIPO_ELEMENTO.rotate_month, TIPO_ELEMENTO.array_month : value = 9
                            Case TIPO_ELEMENTO.rotate_weekday, TIPO_ELEMENTO.array_weekday : value = 3
                            Case TIPO_ELEMENTO.rotate_daynight : value = 18
                            Case TIPO_ELEMENTO.array_day : value = 26
                            Case TIPO_ELEMENTO.array_hourminute : value = String.Format("{0:00}{1:00}", 10, 9)
                            Case TIPO_ELEMENTO.array_monthday : value = String.Format("{0:00}{1:00}", 9, 26)
                            Case TIPO_ELEMENTO.array_yearmonthday : value = String.Format("{0:0000}{1:00}{2:00}", 2016, 9, 26)
                            Case TIPO_ELEMENTO.array_year : value = 1973

                            Case TIPO_ELEMENTO.array_weather : value = 0
                            Case TIPO_ELEMENTO.array_moon_phase : value = 0
                            Case TIPO_ELEMENTO.array_temprature : value = 20
                            Case TIPO_ELEMENTO.array_heartrate : value = 68
                            Case TIPO_ELEMENTO.array_steps, TIPO_ELEMENTO.array_arc_steps : value = 1234
                            Case TIPO_ELEMENTO.array_arc_battery, TIPO_ELEMENTO.array_battery_level, TIPO_ELEMENTO.rotate_battery : value = 55
                        End Select

                        g.DrawImage(element.Sample(value), 0, 0, 400, 400) 'Los samples van sobre 400x400,para que esté visible tenga el angulo que tenga
                    Next
                End Using
                bmp.Save(String.Format("{0}\clock_skin_model.png", ruta), Imaging.ImageFormat.Png)
            End Using
        Catch ex As Exception
            Throw New Exception("CSkinCanvas.SnapShot:" & ex.Message)
        Finally
            Me.Mode = _mode 'Restore 
        End Try
    End Sub
    Public Sub ImportFromWatch(source As String, clockskinpath As String)
        Dim destino As String = ""
        Dim tmp As String = ""

        Try
            Me.Clear()

            Me.Ready = False

            destino = String.Format("{0}\{1}", clockskinpath, IO.Path.GetFileNameWithoutExtension(source))

            'Generamos xml vacío
            Save(destino) 'Aquí se le asigna el nombre

            tmp = String.Format("{0}\.tmp\{1}", clockskinpath, Me.Name)
            'Descomprimimos watch en tmp
            If IO.Directory.Exists(tmp) Then IO.Directory.Delete(tmp, FileIO.DeleteDirectoryOption.DeleteAllContents)
            IO.Directory.CreateDirectory(tmp)

            IO.Compression.ZipFile.ExtractToDirectory(source, tmp)

            'copiamos imagenes en destino
            My.Computer.FileSystem.CopyDirectory(String.Format("{0}\images", tmp), destino, True)

            'Convierte jpg en png
            For Each fichero As String In IO.Directory.GetFiles(destino, "*.jpg")
                Using bmp As Bitmap = Drawing.Image.FromFile(fichero)
                    bmp.Save(String.Format("{0}\{1}.png", destino, IO.Path.GetFileNameWithoutExtension(fichero)), Imaging.ImageFormat.Png)
                End Using
                My.Computer.FileSystem.DeleteFile(fichero)
            Next

            'Generamos imagen model
            If IO.File.Exists(String.Format("{0}\preview.jpg", tmp)) Then
                Using bmp As Bitmap = Drawing.Image.FromFile(String.Format("{0}\preview.jpg", tmp))
                    bmp.Save(String.Format("{0}\clock_skin_model.png", destino), Imaging.ImageFormat.Png)
                End Using
            End If

            ''Opional, copy fonts to folder
            'If IO.Directory.Exists(String.Format("{0}\fonts", tmp)) Then
            '    'My.Computer.FileSystem.CopyDirectory(String.Format("{0}\fonts", tmp), destino, True)

            '    'Registra (si puede) la fuente en la sesion actual
            '    For Each fichero As String In IO.Directory.GetFiles(String.Format("{0}\fonts", tmp))
            '        Try
            '            Dim pfc As New System.Drawing.Text.PrivateFontCollection()
            '            pfc.AddFontFile(fichero)
            '        Catch
            '        End Try
            '    Next
            'End If
            ''''''''''''''''''''''''''''''''READ .WATCH XML

            IO.Directory.Delete(String.Format("{0}\.tmp", clockskinpath), FileIO.DeleteDirectoryOption.DeleteAllContents)
        Catch ex As Exception
            Throw New Exception("CSkinCanvas.ImportFromWatch:" & ex.Message)
        Finally
            Me.Ready = True
        End Try
    End Sub
    Public Sub Save(fullpath As String)
        Try
            Me.Ready = False
            Me._name = IO.Path.GetFileName(fullpath)

            If Me.Name.Trim = "" Then Throw New Exception("No name.")
            System.IO.Directory.CreateDirectory(fullpath)

            Using writer As New XmlTextWriter(String.Format("{0}\clock_skin.xml", fullpath), New System.Text.UTF8Encoding(False))
                writer.WriteStartDocument()
                writer.Formatting = Formatting.Indented
                writer.IndentChar = vbTab
                writer.Indentation = 1

                writer.WriteStartElement("clockskin")

                For Each elemento As CSkinPanel In Me.Elements
                    Try
                        elemento.Save(writer, fullpath)
                    Catch ex As Exception
                        Continue For
                    End Try
                Next

                ''ADITIONAL DATA IN COMMENTS TO AVOID PROBLEMS'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                Dim metadata As String = My.Resources.COMMENTS_HEADER
                metadata &= vbCrLf
                metadata &= "<metadata"
                metadata &= " gui='rra'"
                metadata &= " version='" & Application.ProductVersion.ToString & "'"
                metadata &= "/>" & vbCrLf
                writer.Indentation = 0
                writer.WriteComment(metadata)
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

                writer.WriteEndElement()
                writer.WriteEndDocument()
                writer.Flush()
                writer.Close()
            End Using

            Me.Snapshot(fullpath)
        Catch ex As Exception
            Throw New Exception("CSkinCanvas.Save:" & ex.Message)
        Finally
            Me.Ready = True
        End Try
    End Sub
    Public Sub Load(fullpath As String)
        Dim reader As New XmlDocument()
        Dim modo_rra As Boolean = False

        Try
            Me.Clear()

            Me.Ready = False
            Me._name = IO.Path.GetFileName(fullpath)

            If Me.Name.Trim = "" Then Throw New Exception("No name.")

            reader.Load(String.Format("{0}\clock_skin.xml", fullpath))

            Dim clockskin As XmlNode = reader.SelectSingleNode("clockskin")
            If clockskin Is Nothing Then Throw New Exception("Bad XML format.")

            'LAS PROPIEDADES PERSONALIZADAS SE LEEN DE LOS COMENTARIOS, PARA EVITAR PROBLEMAS
            For Each comment As XmlComment In clockskin.SelectNodes("//comment()")
                Dim comentarios As New Xml.XmlDocument
                Dim nodo As XmlNode = Nothing
                Try
                    If Not comment.Value.ToLower.StartsWith(My.Resources.COMMENTS_HEADER.ToLower) Then Continue For
                    comentarios.LoadXml(comment.Value.Replace(My.Resources.COMMENTS_HEADER, "").Replace(vbCrLf, "").Trim) 'Intenta convertir comentarios a xml

                    nodo = comentarios.SelectSingleNode("metadata")
                    If nodo Is Nothing Then Continue For
                Catch : Continue For
                Finally
                    If Not comentarios Is Nothing Then comentarios = Nothing
                End Try
                If nodo.Attributes("gui") Is Nothing OrElse nodo.Attributes("gui").Value.Trim.ToLower <> "rra" Then Continue For

                modo_rra = True
                Exit For
            Next
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            Dim lista As XmlNodeList = clockskin.SelectNodes("drawable")
            For Each drawable As XmlNode In lista
                Dim rotate As XmlNode = drawable.SelectSingleNode("rotate")
                Dim arraytype As XmlNode = drawable.SelectSingleNode("arraytype")
                Dim name As XmlNode = drawable.SelectSingleNode("name")
                Dim tipo As Integer = 0
                Dim elemento As CSkinPanel = Nothing

                Select Case True
                    Case Not rotate Is Nothing
                        Integer.TryParse(rotate.InnerText.Trim, tipo)

                        Select Case tipo
                            Case 1 : elemento = Me.CreateElement(TIPO_ELEMENTO.rotate_hour)
                            Case 2 : elemento = Me.CreateElement(TIPO_ELEMENTO.rotate_minute)
                            Case 3 : elemento = Me.CreateElement(TIPO_ELEMENTO.rotate_second)
                            Case 4 : elemento = Me.CreateElement(TIPO_ELEMENTO.rotate_month)
                            Case 5 : elemento = Me.CreateElement(TIPO_ELEMENTO.rotate_weekday)
                            Case 6 : elemento = Me.CreateElement(TIPO_ELEMENTO.rotate_battery)
                            Case 7 : elemento = Me.CreateElement(TIPO_ELEMENTO.rotate_daynight)
                            Case 8 : elemento = Me.CreateElement(TIPO_ELEMENTO.rotate_shadow_hour)
                            Case 9 : elemento = Me.CreateElement(TIPO_ELEMENTO.rotate_shadow_minute)
                            Case 10 : elemento = Me.CreateElement(TIPO_ELEMENTO.rotate_shadow_second)
                            Case Else : elemento = Me.CreateElement(TIPO_ELEMENTO.image) 'By default, it will be treated like an image
                        End Select
                    Case Not arraytype Is Nothing
                        Integer.TryParse(arraytype.InnerText.Trim, tipo)

                        Select Case tipo
                            Case 1 : elemento = Me.CreateElement(TIPO_ELEMENTO.array_yearmonthday)
                            Case 2 : elemento = Me.CreateElement(TIPO_ELEMENTO.array_monthday)
                            Case 3 : elemento = Me.CreateElement(TIPO_ELEMENTO.array_month)
                            Case 4 : elemento = Me.CreateElement(TIPO_ELEMENTO.array_day)
                            Case 5 : elemento = Me.CreateElement(TIPO_ELEMENTO.array_weekday)
                            Case 6 : elemento = Me.CreateElement(TIPO_ELEMENTO.array_hourminute)
                            Case 7 : elemento = Me.CreateElement(TIPO_ELEMENTO.array_hour)
                            Case 8 : elemento = Me.CreateElement(TIPO_ELEMENTO.array_minute)
                            Case 9 : elemento = Me.CreateElement(TIPO_ELEMENTO.array_second)
                            Case 10 : elemento = Me.CreateElement(TIPO_ELEMENTO.array_weather)
                            Case 11 : elemento = Me.CreateElement(TIPO_ELEMENTO.array_temprature)
                            Case 12 : elemento = Me.CreateElement(TIPO_ELEMENTO.array_steps)
                            Case 13 : elemento = Me.CreateElement(TIPO_ELEMENTO.array_heartrate)
                            Case 14 : elemento = Me.CreateElement(TIPO_ELEMENTO.array_battery_level)
                            Case 15 : elemento = Me.CreateElement(TIPO_ELEMENTO.array_special_second)

                            Case 16 : elemento = Me.CreateElement(TIPO_ELEMENTO.array_year)
                            Case 17 : elemento = Me.CreateElement(TIPO_ELEMENTO.array_arc_battery)
                            Case 18 : elemento = Me.CreateElement(TIPO_ELEMENTO.array_arc_steps)
                            Case 19 : elemento = Me.CreateElement(TIPO_ELEMENTO.array_moon_phase)

                            Case 97 : elemento = Me.CreateElement(TIPO_ELEMENTO._array_pedometer_text)
                            Case 98 : elemento = Me.CreateElement(TIPO_ELEMENTO._array_heartrate_text)
                            Case 99 : elemento = Me.CreateElement(TIPO_ELEMENTO.array_charging_batt)
                            Case Else : Continue For
                        End Select
                    Case Not name Is Nothing
                        elemento = Me.CreateElement(TIPO_ELEMENTO.image)
                    Case Else : Continue For
                End Select

                Try
                    elemento.Load(drawable, fullpath)
                Catch ex As Exception
                    Continue For
                End Try
            Next
        Catch ex As Exception
            Throw New Exception("CSkinCanvas.Load:" & ex.Message)
        Finally
            If Not reader Is Nothing Then reader = Nothing

            Me.Ready = True
            Me.Refresh()
        End Try
    End Sub

    Public Property Hour As Integer = 10
    Public Property Minutes As Integer = 09
    Public Property Seconds As Integer = 34
    Public Property Month As Integer = 9
    Public Property Day As Integer = 26
    Public Property Year As Integer = 2016
    Public Property Weekday As Integer = 3

    Public Property Weather As Integer = 0
    Public Property Moon As Integer = 0

    Public Property Temprature As Integer = 20
    Public Property Heartrate As Integer = 68
    Public Property Steps As Integer = 1234
    Public Property Batt As Integer = 55

End Class
