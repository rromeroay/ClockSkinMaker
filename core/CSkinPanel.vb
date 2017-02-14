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

Public Enum TIPO_ELEMENTO As Integer
    image = 0
    rotate_hour
    rotate_minute
    rotate_second
    rotate_month
    rotate_weekday
    rotate_battery
    rotate_24hrs
    rotate_shadow_hour
    rotate_shadow_minute
    rotate_shadow_second
    ROTATE_END

    array_yearmonthday
    array_monthday
    array_month
    array_day
    array_weekday
    array_hourminute
    array_hour
    array_minute
    array_second
    array_weather
    array_temprature
    array_steps
    array_heartrate
    array_battery_level
    array_special_second
    array_year

    array_moon_phase
    array_arc_battery
    array_arc_steps

    array_charging_batt
    ARRAY_END

    _array_pedometer_text
    _array_heartrate_text
End Enum
Public Enum ESTADO_ELEMENTO
    [NEW] = 0
    LOADED
    FAIL
End Enum

Public Class CSkinPanel
    Inherits Panel

    Public ReadOnly Property Drawables As New List(Of String)
    Public ReadOnly Property SkinCanvas As CSkinCanvas = Nothing

    Private _imagen As New CPictureBoxTransparent
    Public ReadOnly Property Imagen As Bitmap
        Get
            Select Case Me.Tipo
                Case TIPO_ELEMENTO.array_special_second, TIPO_ELEMENTO.array_arc_battery, TIPO_ELEMENTO.array_arc_steps : Return Me.Sample(0)
            End Select
            Return Me._imagen.Image
        End Get
    End Property

    Private _estado As ESTADO_ELEMENTO = ESTADO_ELEMENTO.[NEW]
    Public ReadOnly Property Status As ESTADO_ELEMENTO
        Get
            Return _estado
        End Get
    End Property
    Private _tipo As TIPO_ELEMENTO = TIPO_ELEMENTO.image
    Public ReadOnly Property Tipo As TIPO_ELEMENTO
        Get
            Return _tipo
        End Get
    End Property
    Private _filename As String = ""
    Public Property FileName As String
        Get
            Return _filename
        End Get
        Set(value As String)
            _filename = value
            _description = IO.Path.GetFileName(_filename)
            LoadDrawables()
        End Set
    End Property
    Private _color1 As Color = Color.Transparent
    Public Property Color1 As Color
        Get
            Return _color1
        End Get
        Set(value As Color)
            _color1 = value
            Me.Invalidate()
        End Set
    End Property
    Private _color2 As Color = Color.Transparent
    Public Property Color2 As Color
        Get
            Return _color2
        End Get
        Set(value As Color)
            _color2 = value
            Me.Invalidate()
        End Set
    End Property

    Private _metadata As String = ""

    Private _description As String = ""
    Public Property Description As String
        Get
            Select Case Me.Tipo
                Case TIPO_ELEMENTO.array_charging_batt : Return "[charge]"
                Case TIPO_ELEMENTO.array_special_second : Return "[special_second]"
                Case Else : Return _description
            End Select
        End Get
        Set(value As String)
            _description = value
        End Set
    End Property

    Private _centerX As Integer = 0
    Private _centerY As Integer = 0
    Public Property CenterX As Integer
        Get
            Return _centerX
        End Get
        Set(value As Integer)
            _centerX = value
            Me.Left = _centerX + 200 - Me.Width / 2

            'exceptions in postion aligment
            Select Case Me._tipo
                Case TIPO_ELEMENTO.array_hour, TIPO_ELEMENTO.array_minute, TIPO_ELEMENTO.array_second, TIPO_ELEMENTO.array_day, TIPO_ELEMENTO.array_heartrate     'align to left
                    Me.Left = _centerX + 200
                    If IO.File.Exists(Drawables(0)) Then Me.Left -= System.Drawing.Image.FromFile(Drawables(0)).Width 'zero is de default value in loadpicture
                Case TIPO_ELEMENTO.array_battery_level
                    Select Case Me.Drawables.Count
                        Case Is >= 12 'Remove the percent symbol ocuppation (_centerX + 200 - (Me.Width - System.Drawing.Image.FromFile(Drawables(11)).Size.Width) / 2)
                            If IO.File.Exists(Drawables(11)) Then Me.Left += (System.Drawing.Image.FromFile(Drawables(11)).Size.Width / 2)
                    End Select
            End Select

            Me.Invalidate()
        End Set
    End Property
    Public Property CenterY As Integer
        Get
            Return _centerY
        End Get
        Set(value As Integer)
            _centerY = value
            Me.Top = _centerY + 200 - Me.Height / 2
            Me.Invalidate()
        End Set
    End Property

    Public Shadows Property Location As Point
        Get
            Return MyBase.Location
        End Get
        Set(value As Point)
            Me.CenterX = value.X - 200 + Me.Width / 2
            Me.CenterY = value.Y - 200 + Me.Height / 2
        End Set
    End Property

    Private _Angle As Integer = 0
    Private _StartAngle As Integer = 0
    Public Property Angle As Integer
        Get
            Return _Angle
        End Get
        Set(value As Integer)
            _Angle = value
            Me.Invalidate()
        End Set
    End Property
    Public Property StartAngle As Integer
        Get
            Return _StartAngle
        End Get
        Set(value As Integer)
            _StartAngle = value
            Me.Invalidate()
        End Set
    End Property

    Private _direction As Integer = 0
    Public Property Direction As Integer
        Get
            Return _direction
        End Get
        Set(value As Integer)
            _direction = value
        End Set
    End Property
    Private _colorbat As Integer = 0
    Public Property ColorBat As Integer
        Get
            Return _colorbat
        End Get
        Set(value As Integer)
            _colorbat = value
            LoadDrawables()
        End Set
    End Property
    Private _mulrotate As Integer = 0
    Public Property MulRotate As Integer
        Get
            Return _mulrotate
        End Get
        Set(value As Integer)
            _mulrotate = value
        End Set
    End Property

    Private _loaded_size As Size = Size.Empty
    Private _width As Integer = 0
    Public Shadows Property Width As Integer
        Get
            Return _width
        End Get
        Set(value As Integer)
            _width = value

            MyBase.Width = _width
            Me.CenterX = _centerX
            Me.CenterY = _centerY
            Me.Invalidate()
        End Set
    End Property
    Private _height As Integer = 0
    Public Shadows Property Height As Integer
        Get
            Return _height
        End Get
        Set(value As Integer)
            _height = value

            MyBase.Height = _height
            Me.CenterX = _centerX
            Me.CenterY = _centerY
            Me.Invalidate()
        End Set
    End Property
    Public Shadows Property Size As Size
        Get
            Return MyBase.Size
        End Get
        Set(value As Size)
            Me.Width = value.Width
            Me.Height = value.Height
        End Set
    End Property

    Public Sub New(canvas As CSkinCanvas, tipo As TIPO_ELEMENTO)
        Me.SkinCanvas = canvas
        Me._tipo = tipo

        Me.DoubleBuffered = True
        Me.Capture = True
        Me.BackColor = Color.Transparent
        Me.Padding = New Padding(0)
        Me.Margin = New Padding(0)
        Me.Anchor = AnchorStyles.None
        Me.Dock = DockStyle.None
        Me.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BackgroundImageLayout = ImageLayout.None

        Select Case tipo
            Case TIPO_ELEMENTO.array_special_second, TIPO_ELEMENTO.array_charging_batt : LoadDrawables() 'Imagenes fijas
            Case Else
                _imagen.Image = My.Resources.element_new
                Me._loaded_size = _imagen.Image.Size
                Me.Width = _loaded_size.Width 'Cada vez que se cambia el tamaño hay que calcular su centro
                Me.Height = _loaded_size.Height
        End Select

        Me.Refresh()
    End Sub
    Public Overloads Sub Invalidate()
        MyBase.Invalidate()
        Me.SkinCanvas.Refresh()
    End Sub

    Public Sub Load(drawable As XmlNode, ruta As String)
        Try
            For Each prop In drawable.ChildNodes
                Select Case prop.name.ToString.ToLower
                    Case "rotate" 'El tipo ya está leído
                    Case "arraytype" 'El tipo ya está leído
                    Case "name" : Me.FileName = String.Format("{0}\{1}", ruta, prop.InnerText.trim)
                    Case "centerx" : Me.CenterX = Integer.Parse(prop.InnerText.trim)
                    Case "centery" : Me.CenterY = Integer.Parse(prop.InnerText.trim)
                    Case "angle" : Me.Angle = Integer.Parse(prop.InnerText.trim)
                    Case "startangle" : Me.StartAngle = Integer.Parse(prop.InnerText.trim)
                    Case "direction" : Me.Direction = Integer.Parse(prop.InnerText.trim)
                    Case "color" : Me.ColorBat = Integer.Parse(prop.InnerText.trim)
                    Case "mulrotate" : Me.MulRotate = Integer.Parse(prop.InnerText.trim)
                    Case "colorarray"
                        Dim aux() As String = Split(prop.InnerText.ToString, ",")
                        If aux.Length = 2 Then
                            Me.Color1 = ColorTranslator.FromHtml(String.Format("#{0}", aux(0)))
                            Me.Color2 = ColorTranslator.FromHtml(String.Format("#{0}", aux(1)))
                        End If
                End Select
            Next

            Select Case Me.Tipo
                Case TIPO_ELEMENTO.array_charging_batt : LoadDrawables()
                Case TIPO_ELEMENTO.array_special_second : LoadDrawables()
            End Select
        Catch ex As Exception
            Throw New Exception(String.Format("CSkinPanel.Load ({0}): {1}", Me.Tipo.ToString, ex.Message))
        End Try
    End Sub
    Public Sub Save(writer As System.Xml.XmlTextWriter, ruta As String)
        Try
            SaveImages(ruta)

            'continues with clock_skin.xml.............

            writer.WriteStartElement("drawable")
            Select Case Me.Tipo
                Case TIPO_ELEMENTO.array_charging_batt 'No tiene imagen asociada
                    If Me.ColorBat <> 0 Then
                        writer.WriteStartElement("color")
                        writer.WriteString(String.Format("{0}", Me.ColorBat))
                        writer.WriteEndElement()
                    End If
                Case TIPO_ELEMENTO.array_special_second  'No tiene imagen asociada
                Case Else
                    writer.WriteStartElement("name")
                    writer.WriteString(IO.Path.GetFileName(Me.FileName))
                    writer.WriteEndElement()
            End Select

            Select Case Me.Tipo
                Case TIPO_ELEMENTO.image
                Case TIPO_ELEMENTO.rotate_hour To TIPO_ELEMENTO.ROTATE_END - 1
                    writer.WriteStartElement("rotate")
                    Select Case Me.Tipo
                        Case TIPO_ELEMENTO.rotate_hour : writer.WriteString(String.Format("{0}", 1))
                        Case TIPO_ELEMENTO.rotate_minute : writer.WriteString(String.Format("{0}", 2))
                        Case TIPO_ELEMENTO.rotate_second : writer.WriteString(String.Format("{0}", 3))
                        Case TIPO_ELEMENTO.rotate_month : writer.WriteString(String.Format("{0}", 4))
                        Case TIPO_ELEMENTO.rotate_weekday : writer.WriteString(String.Format("{0}", 5))
                        Case TIPO_ELEMENTO.rotate_battery : writer.WriteString(String.Format("{0}", 6))
                        Case TIPO_ELEMENTO.rotate_24hrs : writer.WriteString(String.Format("{0}", 7))
                        Case TIPO_ELEMENTO.rotate_shadow_hour : writer.WriteString(String.Format("{0}", 8))
                        Case TIPO_ELEMENTO.rotate_shadow_minute : writer.WriteString(String.Format("{0}", 9))
                        Case TIPO_ELEMENTO.rotate_shadow_second : writer.WriteString(String.Format("{0}", 10))
                    End Select
                    writer.WriteEndElement()
                Case TIPO_ELEMENTO.ROTATE_END + 1 To TIPO_ELEMENTO.ARRAY_END - 1
                    writer.WriteStartElement("arraytype")
                    Select Case Me.Tipo
                        Case TIPO_ELEMENTO.array_yearmonthday : writer.WriteString(String.Format("{0}", 1))
                        Case TIPO_ELEMENTO.array_monthday : writer.WriteString(String.Format("{0}", 2))
                        Case TIPO_ELEMENTO.array_month : writer.WriteString(String.Format("{0}", 3))
                        Case TIPO_ELEMENTO.array_day : writer.WriteString(String.Format("{0}", 4))
                        Case TIPO_ELEMENTO.array_weekday : writer.WriteString(String.Format("{0}", 5))
                        Case TIPO_ELEMENTO.array_hourminute : writer.WriteString(String.Format("{0}", 6))
                        Case TIPO_ELEMENTO.array_hour : writer.WriteString(String.Format("{0}", 7))
                        Case TIPO_ELEMENTO.array_minute : writer.WriteString(String.Format("{0}", 8))
                        Case TIPO_ELEMENTO.array_second : writer.WriteString(String.Format("{0}", 9))
                        Case TIPO_ELEMENTO.array_weather : writer.WriteString(String.Format("{0}", 10))
                        Case TIPO_ELEMENTO.array_temprature : writer.WriteString(String.Format("{0}", 11))
                        Case TIPO_ELEMENTO.array_steps : writer.WriteString(String.Format("{0}", 12))
                        Case TIPO_ELEMENTO.array_heartrate : writer.WriteString(String.Format("{0}", 13))
                        Case TIPO_ELEMENTO.array_battery_level : writer.WriteString(String.Format("{0}", 14))
                        Case TIPO_ELEMENTO.array_special_second : writer.WriteString(String.Format("{0}", 15))

                        Case TIPO_ELEMENTO.array_year : writer.WriteString(String.Format("{0}", 16))
                        Case TIPO_ELEMENTO.array_arc_battery : writer.WriteString(String.Format("{0}", 17))
                        Case TIPO_ELEMENTO.array_arc_steps : writer.WriteString(String.Format("{0}", 18))
                        Case TIPO_ELEMENTO.array_moon_phase : writer.WriteString(String.Format("{0}", 19))

                        Case TIPO_ELEMENTO._array_pedometer_text : writer.WriteString(String.Format("{0}", 97))
                        Case TIPO_ELEMENTO._array_heartrate_text : writer.WriteString(String.Format("{0}", 98))
                        Case TIPO_ELEMENTO.array_charging_batt : writer.WriteString(String.Format("{0}", 99))
                    End Select
                    writer.WriteEndElement()
            End Select

            If Me.CenterX <> 0 Then
                writer.WriteStartElement("centerX")
                writer.WriteString(String.Format("{0}", Me.CenterX))
                writer.WriteEndElement()
            End If

            If Me.CenterY <> 0 Then
                writer.WriteStartElement("centerY")
                writer.WriteString(String.Format("{0}", Me.CenterY))
                writer.WriteEndElement()
            End If

            If Me.Angle <> 0 Then
                writer.WriteStartElement("angle")
                writer.WriteString(String.Format("{0}", Me.Angle))
                writer.WriteEndElement()
            End If

            If Me.StartAngle <> 0 Then
                writer.WriteStartElement("startAngle")
                writer.WriteString(String.Format("{0}", Me.StartAngle))
                writer.WriteEndElement()
            End If

            If Me.Direction <> 0 Then
                writer.WriteStartElement("direction")
                writer.WriteString(String.Format("{0}", Me.Direction))
                writer.WriteEndElement()
            End If

            If Me.MulRotate <> 0 Then
                writer.WriteStartElement("mulrotate")
                writer.WriteString(String.Format("{0}", Me.MulRotate))
                writer.WriteEndElement()
            End If

            If Me.Color1 <> Color.Transparent And Me.Color2 <> Color.Transparent Then
                writer.WriteStartElement("colorarray")
                writer.WriteString(String.Format("{0},{1}", ColorTranslator.ToHtml(Color.FromArgb(Me.Color1.ToArgb)).Substring(1), ColorTranslator.ToHtml(Color.FromArgb(Me.Color2.ToArgb)).Substring(1)))
                writer.WriteEndElement()
            End If

            writer.WriteEndElement()
        Catch ex As Exception
            Throw New Exception(String.Format("CSkinPanel.Save ({0}): {1}", Me.Tipo.ToString, ex.Message))
        End Try
    End Sub

    Private Sub LoadDrawables()
        Dim reader As New XmlDocument()

        Try
            _metadata = ""
            Drawables.Clear()
            Select Case _tipo
                Case TIPO_ELEMENTO.array_charging_batt, TIPO_ELEMENTO.array_special_second
                    Drawables.Add("foo")
                Case TIPO_ELEMENTO.image To TIPO_ELEMENTO.ROTATE_END - 1
                    If _filename = "" Then Return 'Los elementos nuevos....
                    If IO.Path.GetExtension(_filename).ToLower <> ".png" Then Throw New Exception("Extension file from rotate drawable not valid.")
                    Drawables.Add(_filename)
                Case TIPO_ELEMENTO.ROTATE_END + 1 To TIPO_ELEMENTO.ARRAY_END - 1
                    If _filename = "" Then Return 'Los elementos nuevos....
                    If IO.Path.GetExtension(_filename).ToLower <> ".xml" Then Throw New Exception("Extension file from array drawable not valid.")

                    reader.Load(_filename)

                    Dim root As XmlNode = reader.SelectSingleNode("drawables")
                    If root Is Nothing Then Throw New Exception("Bad XML format.")

                    For Each drawable As XmlNode In root.SelectNodes("image")
                        Drawables.Add(String.Format("{0}\{1}", IO.Path.GetDirectoryName(_filename), drawable.InnerText.Trim))
                    Next

                    'optionally, read "comments" metadata.... to transcribe as is when save
                    For Each comment As XmlComment In root.SelectNodes("//comment()")
                        Dim nodo As XmlNode = Nothing
                        Try
                            If Not comment.Value.ToLower.StartsWith(My.Resources.COMMENTS_HEADER.ToLower) Then Continue For
                            _metadata = comment.Value
                            Exit For 'Saltamos el resto de comentarios
                        Finally
                        End Try
                    Next
                Case Else : Throw New Exception("Drawable type not implemented.")
            End Select
            If Drawables.Count = 0 Then Throw New Exception("No drawables defined.")

            LoadImage()
            Me._estado = ESTADO_ELEMENTO.LOADED
        Catch ex As Exception
            _imagen.Image = My.Resources.warning
            Me._loaded_size = _imagen.Size
            Me.Width = _loaded_size.Width 'Cada vez que se cambia el tamaño hay que calcular su centro
            Me.Height = _loaded_size.Height

            Me._estado = ESTADO_ELEMENTO.FAIL
            Throw New Exception(ex.Message)
        Finally
            If Not reader Is Nothing Then reader = Nothing
            Me.Refresh()
        End Try

    End Sub

    Private Sub SaveImages(ruta As String)
        Try
            Select Case Me.Tipo
                Case TIPO_ELEMENTO.array_charging_batt : Return 'No tiene imagen asociada
                Case TIPO_ELEMENTO.array_special_second : Return 'No tiene imagen asociada

                Case TIPO_ELEMENTO.image To TIPO_ELEMENTO.ROTATE_END - 1
                    If Me.FileName.Trim = "" Then Throw New Exception("No filename.")
                    If Not IO.File.Exists(Me.FileName) Then Throw New Exception("Source file not exists.")

                    'check and assignt new name if exists another element with same name, its needed to rename
                    Dim destino As String = CSkinCanvas.FindUniqueName(Me, ruta, Me.FileName)
                    If Me.FileName.Trim.ToLower <> destino.Trim.ToLower Then System.IO.File.Copy(Me.FileName, destino, True)
                    Me._filename = destino

                    'FileNames are not allowed starts with "."
                    If IO.Path.GetFileName(_filename).StartsWith(".") Then
                        destino = String.Format("{0}\{1}", IO.Path.GetDirectoryName(_filename), IO.Path.GetFileName(_filename).Substring(1))
                        System.IO.File.Delete(destino) : System.IO.File.Move(_filename, destino)
                        Me._filename = destino
                    End If

                    Dim escala_width As Double = Me.Size.Width / Me._loaded_size.Width
                    Dim escala_heigth As Double = Me.Size.Height / Me._loaded_size.Height
                    If escala_heigth = 0 OrElse escala_width = 0 Then Throw New Exception("Image size not valid.")

                    Me.Drawables(0) = destino 'On rotates, the drawables are themselves

                    'Ha cambiado el tamaño del control, se deben redimensionar las imagenes
                    If Me.Size <> Me._loaded_size Then ResizeImageFile(destino, escala_width, escala_heigth)

                    Me._loaded_size = Me.Size
                Case TIPO_ELEMENTO.ROTATE_END + 1 To TIPO_ELEMENTO.ARRAY_END - 1
                    If Me.FileName.Trim = "" Then Throw New Exception("No filename.")
                    If Not IO.File.Exists(Me.FileName) Then Throw New Exception("Source file not exists.")

                    'First copy xml file
                    'check and assignt new name if exists another element with same name, its needed to rename.
                    'really its not necesary to copy, later will be generated...
                    Dim destino As String = CSkinCanvas.FindUniqueName(Me, ruta, Me.FileName)
                    If Me.FileName.Trim.ToLower <> destino.Trim.ToLower Then System.IO.File.Copy(Me.FileName, destino, True)
                    Me._filename = destino

                    Dim escala_width As Double = Me.Size.Width / Me._loaded_size.Width
                    Dim escala_heigth As Double = Me.Size.Height / Me._loaded_size.Height
                    If escala_heigth = 0 OrElse escala_width = 0 Then Throw New Exception("Image size not valid.")

                    'Now copy drawables
                    For cont As Integer = 0 To Me.Drawables.Count - 1
                        If Not IO.File.Exists(Drawables(cont)) Then Continue For 'Si no existe el origen, lo ignora

                        'check and assign new name if exists another drawable with same name in another element, its needed to rename
                        destino = CSkinCanvas.FindUniqueNameDrawable(Me, ruta, Drawables(cont))

                        If Drawables(cont).Trim.ToLower <> destino.Trim.ToLower Then System.IO.File.Copy(Drawables(cont), destino, True)
                        Drawables(cont) = destino

                        'FileNames are not allowed starts with "."
                        If IO.Path.GetFileName(Drawables(cont)).StartsWith(".") Then
                            destino = String.Format("{0}\{1}", IO.Path.GetDirectoryName(Drawables(cont)), IO.Path.GetFileName(Drawables(cont)).Substring(1))
                            System.IO.File.Delete(destino) : System.IO.File.Move(Drawables(cont), destino)
                            Drawables(cont) = destino
                        End If

                        'Ha cambiado el tamaño del control, se deben redimensionar las imagenes
                        If Me.Size <> Me._loaded_size Then ResizeImageFile(destino, escala_width, escala_heigth)
                    Next

                    Me._loaded_size = Me.Size
                    SaveDrawables()
            End Select
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Private Sub SaveDrawables()
        Using writer As New XmlTextWriter(Me.FileName, New System.Text.UTF8Encoding(False))
            writer.WriteStartDocument()
            writer.Formatting = Formatting.Indented
            writer.IndentChar = vbTab
            writer.Indentation = 1

            writer.WriteStartElement("drawables")

            For Each imagen As String In Me.Drawables
                writer.WriteStartElement("image")
                writer.WriteString(String.Format("{0}", IO.Path.GetFileName(imagen)))
                writer.WriteEndElement()
            Next

            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            writer.Indentation = 0
            If _metadata.Trim <> "" Then writer.WriteComment(_metadata)
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            writer.WriteEndElement()
            writer.WriteEndDocument()
            writer.Flush()
            writer.Close()
        End Using
    End Sub

    Private Sub ResizeImageFile(fichero As String, escala_w As Double, escala_h As Double)
        Dim bmp As Bitmap = Nothing
        Try
            Using fs As New System.IO.FileStream(fichero, IO.FileMode.Open, IO.FileAccess.Read)
                Using original As New Bitmap(System.Drawing.Image.FromStream(fs)) 'Escalamos original
                    bmp = New Bitmap(original, original.Width * escala_w, original.Height * escala_h)
                End Using
                fs.Close()

                bmp.Save(fichero, Imaging.ImageFormat.Png)
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            If Not bmp Is Nothing Then bmp.Dispose() : bmp = Nothing
        End Try
    End Sub

    Private Sub LoadImage()
        Dim tmp As Bitmap = Nothing

        Try
            If Not _imagen.Image Is Nothing Then _imagen.Image.Dispose() : _imagen.Image = Nothing

            Select Case _tipo
                Case TIPO_ELEMENTO.image To TIPO_ELEMENTO.ROTATE_END - 1
                    If Me.Drawables.Count <> 1 Then Throw New Exception("Incorrect number of drawables.")
                    tmp = JoinImages(0)
                Case TIPO_ELEMENTO.array_yearmonthday
                    If Me.Drawables.Count < 11 Then Throw New Exception("Incorrect number of drawables.")
                    tmp = JoinImages(0, 0, 0, 0, 10, 0, 0, 10, 0, 0)
                Case TIPO_ELEMENTO.array_monthday
                    If Me.Drawables.Count < 11 Then Throw New Exception("Incorrect number of drawables.")
                    tmp = JoinImages(0, 0, 10, 0, 0)
                Case TIPO_ELEMENTO.array_month
                    If Me.Drawables.Count < 12 Then Throw New Exception("Incorrect number of drawables.")
                    tmp = JoinImages(0)
                Case TIPO_ELEMENTO.array_day
                    If Me.Drawables.Count < 10 Then Throw New Exception("Incorrect number of drawables.")
                    tmp = JoinImages(0, 0)
                Case TIPO_ELEMENTO.array_weekday
                    If Me.Drawables.Count < 7 Then Throw New Exception("Incorrect number of drawables.")
                    tmp = JoinImages(0)
                Case TIPO_ELEMENTO.array_hourminute
                    Select Case Me.Drawables.Count
                        Case Is >= 13 : tmp = JoinImages(0, 0, 10, 0, 0, 11)
                        Case 11 : tmp = JoinImages(0, 0, 10, 0, 0)
                        Case Else : Throw New Exception("Incorrect number of drawables.")
                    End Select
                Case TIPO_ELEMENTO.array_hour
                    If Me.Drawables.Count < 10 Then Throw New Exception("Incorrect number of drawables.")
                    tmp = JoinImages(0, 0)
                Case TIPO_ELEMENTO.array_minute
                    If Me.Drawables.Count < 10 Then Throw New Exception("Incorrect number of drawables.")
                    tmp = JoinImages(0, 0)
                Case TIPO_ELEMENTO.array_second
                    If Me.Drawables.Count < 10 Then Throw New Exception("Incorrect number of drawables.")
                    tmp = JoinImages(0, 0)
                Case TIPO_ELEMENTO.array_weather
                    If Me.Drawables.Count < 15 Then Throw New Exception("Incorrect number of drawables.")
                    tmp = JoinImages(0)
                Case TIPO_ELEMENTO.array_temprature
                    If Me.Drawables.Count < 12 Then Throw New Exception("Incorrect number of drawables.")
                    tmp = JoinImages(0, 0, 11)
                Case TIPO_ELEMENTO.array_steps, TIPO_ELEMENTO.array_arc_steps
                    Select Case Me.Drawables.Count
                        Case Is >= 11 : tmp = JoinImages(10, 10, 0, 0, 0)
                        Case 10 : tmp = JoinImages(0, 0, 0, 0, 0)
                        Case Else : Throw New Exception("Incorrect number of drawables.")
                    End Select
                Case TIPO_ELEMENTO.array_heartrate
                    If Me.Drawables.Count < 10 Then Throw New Exception("Incorrect number of drawables.")
                    tmp = JoinImages(0, 0)
                Case TIPO_ELEMENTO.array_battery_level, TIPO_ELEMENTO.array_arc_battery
                    Select Case Me.Drawables.Count
                        Case Is >= 12 : tmp = JoinImages(10, 0, 0, 11)
                        Case Is >= 11 : tmp = JoinImages(10, 0, 0)
                        Case Else : Throw New Exception("Incorrect number of drawables.")
                    End Select
                Case TIPO_ELEMENTO.array_year
                    If Me.Drawables.Count < 10 Then Throw New Exception("Incorrect number of drawables.")
                    tmp = JoinImages(0, 0, 0, 0)
                Case TIPO_ELEMENTO.array_moon_phase
                    If Me.Drawables.Count < 8 Then Throw New Exception("Incorrect number of drawables.")
                    tmp = JoinImages(0)

                Case TIPO_ELEMENTO._array_pedometer_text : Throw New Exception("'Pedometer text' not implemented.")
                Case TIPO_ELEMENTO._array_heartrate_text : Throw New Exception("'Heartrate text' not implemented.")

                Case TIPO_ELEMENTO.array_charging_batt
                    Select Case ColorBat
                        Case 1 : tmp = My.Resources.charging_battery_color1
                        Case Else : tmp = My.Resources.charging_battery_color0
                    End Select

                Case TIPO_ELEMENTO.array_special_second
                    tmp = My.Resources.clock_skin_special_seconds
                Case Else : Throw New Exception("Not implemented.")
            End Select

            Me._imagen.Image = tmp
            Me._loaded_size = _imagen.Image.Size
            Me.Width = Me._loaded_size.Width 'Cada vez que se cambia el tamaño hay que calcular su centro
            Me.Height = Me._loaded_size.Height

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub
    Private Function JoinImages(ParamArray indices() As Integer) As Bitmap
        Dim h_max As Integer = 0
        Dim w_total As Integer = 0

        'Calcular ancho final
        For i As Integer = 0 To indices.Length - 1
            If indices(i) >= Drawables.Count OrElse Not IO.File.Exists(Drawables(indices(i))) Then Continue For

            Using fs As New System.IO.FileStream(Drawables(indices(i)), IO.FileMode.Open, IO.FileAccess.Read)
                Using b As Bitmap = System.Drawing.Image.FromStream(fs)
                    h_max = Math.Max(h_max, b.Height)
                    w_total += b.Width
                End Using
                fs.Close()
            End Using
        Next
        If h_max = 0 Then h_max = 1
        If w_total = 0 Then w_total = 1

        Dim bmp As Bitmap = New Bitmap(w_total, h_max)
        Using g As Graphics = Graphics.FromImage(bmp)
            Dim w_ant As Integer = 0

            For i As Integer = 0 To indices.Length - 1
                If indices(i) >= Drawables.Count OrElse Not IO.File.Exists(Drawables(indices(i))) Then Continue For

                Using fs As New System.IO.FileStream(Drawables(indices(i)), IO.FileMode.Open, IO.FileAccess.Read)
                    Using b As Bitmap = System.Drawing.Image.FromStream(fs)
                        g.DrawImage(b, w_ant, 0, b.Width, h_max) ' b.Height) '(bmp.Height - b.Height) \ 2
                        w_ant += b.Width
                    End Using
                End Using
            Next
        End Using

        Return bmp
    End Function

    Private Sub JoinImagesSample(ParamArray indices() As Integer)
        Dim bmp As Bitmap = JoinImages(indices)

        'if The original size has been changed
        If Me.Size <> Me._loaded_size Then
            Dim scale_w As Double = Me.Size.Width / Me._loaded_size.Width
            Dim scale_h As Double = Me.Size.Height / Me._loaded_size.Height

            bmp = New Bitmap(bmp, bmp.Width * scale_w, bmp.Height * scale_h)
        End If

        'should be calculate the position constantly
        Dim _tmp_left As Integer = _centerX + 200 - bmp.Width / 2
        Dim _tmp_top As Integer = _centerY + 200 - bmp.Height / 2

        ''''exceptions in postion aligment
        Select Case Me._tipo
            Case TIPO_ELEMENTO.array_hour, TIPO_ELEMENTO.array_minute, TIPO_ELEMENTO.array_second, TIPO_ELEMENTO.array_day, TIPO_ELEMENTO.array_heartrate     'align to left
                _tmp_left = _centerX + 200
                If IO.File.Exists(Drawables(indices(0))) Then _tmp_left -= System.Drawing.Image.FromFile(Drawables(indices(0))).Width
            Case TIPO_ELEMENTO.array_battery_level
                Select Case Me.Drawables.Count
                    Case Is >= 12 'Remove the percent symbol ocuppation ( _centerX + 200 - (bmp.Width - System.Drawing.Image.FromFile(Drawables(11)).Size.Width) / 2)
                        If IO.File.Exists(Drawables(11)) Then _tmp_left += (System.Drawing.Image.FromFile(Drawables(11)).Size.Width / 2)
                End Select
        End Select

        _imagen_sample = New Bitmap(400, 400)
        Using g As Graphics = Graphics.FromImage(_imagen_sample)
            g.DrawImage(bmp, _tmp_left, _tmp_top, bmp.Width, bmp.Height)
        End Using
        If Not bmp Is Nothing Then bmp.Dispose() : bmp = Nothing
    End Sub
    'Private _ant_value As Double = Double.MinValue
    Private _imagen_sample As Bitmap = Nothing
    Public Function Sample(value As Double) As Bitmap
        Try
            'If value = _ant_value Then Return _imagen_sample
            '_ant_value = value

            'free memory
            If Not _imagen_sample Is Nothing Then _imagen_sample.Dispose() : _imagen_sample = Nothing

            If Me.Status <> ESTADO_ELEMENTO.LOADED Then
                _imagen_sample = New Bitmap(400, 400)
                Return _imagen_sample
            End If

            'Así ya se han validado los drawables (estan loaded)
            Select Case _tipo 'ROTATES
                Case TIPO_ELEMENTO.image To TIPO_ELEMENTO.ROTATE_END - 1
                    Dim ang As Single = 0
                    Dim range As Single = 1

                    'Bug firmware¿?: Start angle only allowed in battery 
                    Select Case Tipo
                        'Case TIPO_ELEMENTO.rotate_battery
                        'range = IIf(StartAngle Mod 180 <> 0, StartAngle, 180) / 180
                        'Case Else
                        'range = IIf(StartAngle Mod 360 <> 0, StartAngle, 360) / 360
                    End Select

                    Select Case Tipo
                        Case TIPO_ELEMENTO.rotate_hour, TIPO_ELEMENTO.rotate_shadow_hour : ang += (360 * range / 12) * (value Mod 12)
                        Case TIPO_ELEMENTO.rotate_minute, TIPO_ELEMENTO.rotate_shadow_minute : ang += (360 * range / 60) * (value Mod 60)
                        Case TIPO_ELEMENTO.rotate_second, TIPO_ELEMENTO.rotate_shadow_second : ang += (360 * range / 60) * (value Mod 60)
                        Case TIPO_ELEMENTO.rotate_month : ang += (360 * range / 12) * (value Mod 12) '0..11
                        Case TIPO_ELEMENTO.rotate_weekday : ang += (360 * range / 7) * ((value - 1) Mod 7) '0..6
                        Case TIPO_ELEMENTO.rotate_battery ': ang += (180 * range / 100) * (value Mod 101) '0..100
                            ang = (value Mod 101) / 100 '0..100 
                            If Me.StartAngle > 0 Then
                                ang = ang * (Me.StartAngle - Me.Angle)
                            Else
                                ang = ang * (180 - Me.Angle)
                            End If
                        Case TIPO_ELEMENTO.rotate_24hrs : ang += (360 * range / 24) * (value Mod 24)
                        Case TIPO_ELEMENTO.image : ang = 0
                        Case Else : Throw New Exception("Sample rotate not implemented.")
                    End Select

                    'Bug in firmware¿?: counter value in seconds affects next seconds elements directions 
                    Dim counterwise As Boolean = False
                    For Each elemento As CSkinPanel In Me.SkinCanvas.Elements
                        Dim sametype As Boolean = False

                        Select Case elemento.Tipo
                            Case TIPO_ELEMENTO.rotate_hour, TIPO_ELEMENTO.rotate_shadow_hour : sametype = (Me.Tipo = TIPO_ELEMENTO.rotate_hour OrElse Me.Tipo = TIPO_ELEMENTO.rotate_shadow_hour)
                            Case TIPO_ELEMENTO.rotate_minute, TIPO_ELEMENTO.rotate_shadow_minute : sametype = (Me.Tipo = TIPO_ELEMENTO.rotate_minute OrElse Me.Tipo = TIPO_ELEMENTO.rotate_shadow_minute)
                            Case TIPO_ELEMENTO.rotate_second, TIPO_ELEMENTO.rotate_shadow_second : sametype = (Me.Tipo = TIPO_ELEMENTO.rotate_second OrElse Me.Tipo = TIPO_ELEMENTO.rotate_shadow_second)
                            Case Else : sametype = (Me.Tipo = elemento.Tipo)
                        End Select

                        If sametype Then
                            Select Case elemento.Direction
                                Case 2 : counterwise = Not counterwise
                            End Select
                        End If
                        If elemento Is Me Then Exit For
                    Next
                    If counterwise Then ang = ang * -1

                    Select Case Me.MulRotate
                        Case 0
                        Case < 0 : ang = ang / Me.MulRotate * -1
                        Case Else : ang = ang * Me.MulRotate
                    End Select

                    'Bug in firmware¿?: if Mulrotate>0 adds angle twice, default is 1
                    Select Case Me.MulRotate
                        Case >= 0 : ang += Me.Angle
                    End Select

                    ang += Me.Angle    'Angulo inicial

                    'rotate image any angles
                    _imagen_sample = New Bitmap(400, 400)
                    Using g As Graphics = Graphics.FromImage(_imagen_sample)
                        Using m As New Drawing2D.Matrix
                            m.RotateAt(ang, New Point(Me.CenterX + 200, Me.CenterY + 200))
                            g.Transform = m
                            g.DrawImage(Me.Imagen, Me.Left, Me.Top, Me.Width, Me.Height)
                        End Using
                    End Using

                    Return _imagen_sample
            End Select

            Select Case _tipo 'ARRAYS
                Case TIPO_ELEMENTO.ROTATE_END + 1 To TIPO_ELEMENTO.ARRAY_END - 1
                    Dim s As String = ""
                    Select Case Me.Tipo
                        Case TIPO_ELEMENTO.array_charging_batt
                            Dim tmp As Bitmap = Nothing

                            Select Case ColorBat
                                Case 1 : tmp = My.Resources.charging_battery_color1
                                Case Else : tmp = My.Resources.charging_battery_color0
                            End Select

                            _imagen_sample = New Bitmap(400, 400)
                            Using g As Graphics = Graphics.FromImage(_imagen_sample)
                                g.DrawImage(tmp, Me.Left, Me.Top, Me.Width, Me.Height)
                            End Using
                            If Not tmp Is Nothing Then tmp.Dispose() : tmp = Nothing

                        Case TIPO_ELEMENTO.array_special_second
                            _imagen_sample = New Bitmap(400, 400)
                            Using g As Graphics = Graphics.FromImage(_imagen_sample)
                                For i As Integer = 0 To 60  '6 grados tiene un segundo
                                    Using m As New Drawing2D.Matrix
                                        m.RotateAt(i * 6, New Point(Me.CenterX + 200, Me.CenterY + 200))
                                        g.Transform = m
                                        g.DrawLine(New Pen(Me.Color2, 12), New Point(Me.CenterX + 200, Me.CenterY + 5), New Point(Me.CenterX + 200, Me.CenterY + 20)) 'linea 12 de ancho y 7 de largo
                                    End Using
                                Next
                            End Using

                            Using g As Graphics = Graphics.FromImage(_imagen_sample)
                                For i As Integer = 0 To (value Mod 60)
                                    Using m As New Drawing2D.Matrix
                                        m.RotateAt(i * 6, New Point(Me.CenterX + 200, Me.CenterY + 200))
                                        g.Transform = m
                                        g.DrawLine(New Pen(Me.Color1, 12), New Point(Me.CenterX + 200, Me.CenterY + 5), New Point(Me.CenterX + 200, Me.CenterY + 20)) 'linea 12 de ancho y 7 de largo
                                    End Using
                                Next
                            End Using

                        Case TIPO_ELEMENTO.array_day, TIPO_ELEMENTO.array_hour, TIPO_ELEMENTO.array_minute, TIPO_ELEMENTO.array_second, TIPO_ELEMENTO.array_heartrate
                            s = String.Format("{0:00}", value)
                            JoinImagesSample(Integer.Parse(s(0)), Integer.Parse(s(1)))
                        Case TIPO_ELEMENTO.array_hourminute
                            Select Case Me.Drawables.Count
                                Case >= 13 : s = String.Format("{0:00}{1:00}", IIf(value.ToString("0000").Substring(0, 2) Mod 12 <> "00", value.ToString("0000").Substring(0, 2) Mod 12, "12"), value.ToString("0000").Substring(2)) 'ampm
                                Case Else : s = String.Format("{0:0000}", value)
                            End Select
                            Select Case Me.Drawables.Count
                                Case Is >= 13 : JoinImagesSample(Integer.Parse(s(0)), Integer.Parse(s(1)), 10, Integer.Parse(s(2)), Integer.Parse(s(3)), IIf(value < 1200, 11, 12)) 'ampm
                                Case 11 : JoinImagesSample(Integer.Parse(s(0)), Integer.Parse(s(1)), 10, Integer.Parse(s(2)), Integer.Parse(s(3)))
                            End Select
                        Case TIPO_ELEMENTO.array_monthday
                            s = String.Format("{0:0000}", value)
                            JoinImagesSample(Integer.Parse(s(0)), Integer.Parse(s(1)), 10, Integer.Parse(s(2)), Integer.Parse(s(3)))
                        Case TIPO_ELEMENTO.array_yearmonthday
                            s = String.Format("{0:00000000}", value)
                            JoinImagesSample(Integer.Parse(s(0)), Integer.Parse(s(1)), Integer.Parse(s(2)), Integer.Parse(s(3)), 10, Integer.Parse(s(4)), Integer.Parse(s(5)), 10, Integer.Parse(s(6)), Integer.Parse(s(7)))
                        Case TIPO_ELEMENTO.array_year
                            s = String.Format("{0:0000}", value)
                            JoinImagesSample(Integer.Parse(s(0)), Integer.Parse(s(1)), Integer.Parse(s(2)), Integer.Parse(s(3)))
                        Case TIPO_ELEMENTO.array_steps, TIPO_ELEMENTO.array_arc_steps
                            s = String.Format("{0}", Integer.Parse(value)).PadLeft(5, " ") 'leading with spaces

                            Select Case Me.Drawables.Count
                                Case Is >= 11 'Exists an image to lead zeros
                                    JoinImagesSample(If(s(0) = " "c, 10, Integer.Parse(s(0))), If(s(1) = " "c, 10, Integer.Parse(s(1))), If(s(2) = " "c, 10, Integer.Parse(s(2))), If(s(3) = " "c, 10, Integer.Parse(s(3))), If(s(4) = " "c, 10, Integer.Parse(s(4))))
                                Case 10
                                    JoinImagesSample(If(s(0) = " "c, 0, Integer.Parse(s(0))), If(s(1) = " "c, 0, Integer.Parse(s(1))), If(s(2) = " "c, 0, Integer.Parse(s(2))), If(s(3) = " "c, 0, Integer.Parse(s(3))), If(s(4) = " "c, 0, Integer.Parse(s(4))))
                            End Select

                            '''''''''''''''''''''''''''''''PINTAR ARCO!
                            If Me.Tipo = TIPO_ELEMENTO.array_arc_steps Then
                                Using g As Graphics = Graphics.FromImage(_imagen_sample)
                                    'g.DrawArc(New Pen(Me.Color1, 7), New RectangleF(Me.CenterX + 200 - (Me.Width + 20) / 2, Me.CenterY + 200 - (Me.Width + 20) / 2, Me.Width + 20, Me.Width + 20), -90, 360)
                                    g.DrawArc(New Pen(Me.Color1, 7), New RectangleF(Me.CenterX + 200 - 53, Me.CenterY + 200 - 53, 53 * 2, 53 * 2), -90, 360)
                                End Using

                                Using g As Graphics = Graphics.FromImage(_imagen_sample)
                                    'g.DrawArc(New Pen(Me.Color2, 7), New RectangleF(Me.CenterX + 200 - (Me.Width + 20) / 2, Me.CenterY + 200 - (Me.Width + 20) / 2, Me.Width + 20, Me.Width + 20), -90, (360 / 7000) * (Math.Min(value, 7000 - 1) Mod 7000)) 'muestra cuanto falta para llegar a 7000 pasos recomendados
                                    g.DrawArc(New Pen(Me.Color2, 7), New RectangleF(Me.CenterX + 200 - 53, Me.CenterY + 200 - 53, 53 * 2, 53 * 2), -90, (360 / 7000) * (Math.Min(value, 7000 - 1) Mod 7000)) 'muestra cuanto falta para llegar a 7000 pasos recomendados
                                End Using
                            End If
                        Case TIPO_ELEMENTO.array_month
                            JoinImagesSample((value - 1) Mod 12) '0..11
                        Case TIPO_ELEMENTO.array_weekday
                            JoinImagesSample(value Mod 7) '0..6
                        Case TIPO_ELEMENTO.array_weather
                            JoinImagesSample(value Mod 15)
                        Case TIPO_ELEMENTO.array_moon_phase
                            JoinImagesSample(value Mod 8)
                        Case TIPO_ELEMENTO.array_temprature
                            s = String.Format("{0:00}", value)
                            Select Case (s(0))
                                Case "-"
                                    JoinImagesSample(10, Integer.Parse(s(1)), Integer.Parse(s(2)), 11)
                                Case Else
                                    JoinImagesSample(Integer.Parse(s(0)), Integer.Parse(s(1)), 11)
                            End Select
                        Case TIPO_ELEMENTO.array_battery_level, TIPO_ELEMENTO.array_arc_battery
                            s = String.Format("{0}", Integer.Parse(value)).PadLeft(3, " ") 'leading with spaces
                            Select Case Me.Drawables.Count
                                Case Is >= 12 'Con %
                                    JoinImagesSample(If(s(0) = " "c, 10, Integer.Parse(s(0))), If(s(1) = " "c, 10, Integer.Parse(s(1))), If(s(2) = " "c, 10, Integer.Parse(s(2))), 11)
                                Case Else
                                    JoinImagesSample(If(s(0) = " "c, 10, Integer.Parse(s(0))), If(s(1) = " "c, 10, Integer.Parse(s(1))), If(s(2) = " "c, 10, Integer.Parse(s(2))))
                            End Select

                            '''''''''''''''''''''''''''''''PINTAR ARCO!
                            If Me.Tipo = TIPO_ELEMENTO.array_arc_battery Then
                                Using g As Graphics = Graphics.FromImage(_imagen_sample)
                                    For i As Integer = 0 To 20
                                        Using m As New Drawing2D.Matrix
                                            m.RotateAt(i * 18, New Point(Me.CenterX + 200, Me.CenterY + 200))
                                            g.Transform = m
                                            'g.DrawLine(New Pen(Me.Color1, 4), New Point(Me.CenterX + 200, Me.CenterY + 200 - (Me.Width / 2) - 16), New Point(Me.CenterX + 200, Me.CenterY + 200 - (Me.Width / 2) - 25)) '4 de ancho, 10 de largo 
                                            g.DrawLine(New Pen(Me.Color1, 4), New Point(Me.CenterX + 200, Me.CenterY + 200 - 50), New Point(Me.CenterX + 200, Me.CenterY + 200 - 57)) '4 de ancho, 7 de largo
                                        End Using
                                    Next
                                End Using

                                Using g As Graphics = Graphics.FromImage(_imagen_sample)
                                    For i As Integer = 1 To (value * 20 / 100)
                                        Using m As New Drawing2D.Matrix
                                            m.RotateAt(i * 18, New Point(Me.CenterX + 200, Me.CenterY + 200))
                                            g.Transform = m
                                            'g.DrawLine(New Pen(Me.Color2, 4), New Point(Me.CenterX + 200, Me.CenterY + 200 - (Me.Width / 2) - 15), New Point(Me.CenterX + 200, Me.CenterY + 200 - (Me.Width / 2) - 25)) '4 de ancho, 10 de largo 
                                            g.DrawLine(New Pen(Me.Color2, 4), New Point(Me.CenterX + 200, Me.CenterY + 200 - 50), New Point(Me.CenterX + 200, Me.CenterY + 200 - 57)) '4 de ancho, 7 de largo
                                        End Using
                                    Next
                                End Using
                            End If
                        Case Else : Throw New Exception("Sample array not implemented.")
                    End Select

                    Return _imagen_sample
            End Select

            Throw New Exception("Sample not implemented.")
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class

Public Class CPictureBoxTransparent
    Inherits PictureBox

    Public Sub New()
        MyBase.New()

        Me.BackColor = Color.Transparent
        Me.Padding = New Padding(0)
        Me.Margin = New Padding(0)
        Me.Dock = DockStyle.None
        Me.Anchor = AnchorStyles.None
        Me.BorderStyle = System.Windows.Forms.BorderStyle.None
    End Sub
End Class