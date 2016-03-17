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

Public Class CArrayFormat
    Public Property Font As Font = New Font(FontFamily.GenericSerif, 19, FontStyle.Regular, GraphicsUnit.Point)
    Public Property ForeColor As Color = Color.Black
    Public Property BackColor As Color = Color.Transparent
    Public Property ShadowColor As Color = Color.Gray
    Public Property ShadowX As Integer = 0
    Public Property ShadowY As Integer = 0

    Public ReadOnly Property Tipo As TIPO_ELEMENTO = TIPO_ELEMENTO.ARRAY_END
    Public ReadOnly Property Descriptions As New List(Of String)
    Public ReadOnly Property Filenames As New List(Of String)
    Public Property Contents As New List(Of String)
    Public Property Colors As New List(Of Color)
    Public Property AutoScale As Boolean = True

    Public Sub New(tipo As TIPO_ELEMENTO, filename As String)
        Me.Tipo = tipo

        Select Case Me.Tipo
            Case TIPO_ELEMENTO.array_hour, TIPO_ELEMENTO.array_minute, TIPO_ELEMENTO.array_second, TIPO_ELEMENTO.array_heartrate
                Contents = New List(Of String)({"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", Globalization.DateTimeFormatInfo.CurrentInfo.TimeSeparator})
                Descriptions = New List(Of String)({"Number 0", "Number 1", "Number 2", "Number 3", "Number 4", "Number 5", "Number 6", "Number 7", "Number 8", "Number 9", "Time separator"})
                Filenames = New List(Of String)({"num_0", "num_1", "num_2", "num_3", "num_4", "num_5", "num_6", "num_7", "num_8", "num_9", "num_colon"})
                Colors = New List(Of Color)({Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent})
            Case TIPO_ELEMENTO.array_hourminute
                Contents = New List(Of String)({"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", Globalization.DateTimeFormatInfo.CurrentInfo.TimeSeparator, "", ""})
                Descriptions = New List(Of String)({"Number 0", "Number 1", "Number 2", "Number 3", "Number 4", "Number 5", "Number 6", "Number 7", "Number 8", "Number 9", "Time separator", "AM (optional)", "PM (optional)"})
                Filenames = New List(Of String)({"num_0", "num_1", "num_2", "num_3", "num_4", "num_5", "num_6", "num_7", "num_8", "num_9", "num_colon", "num_am", "num_pm"})
                Colors = New List(Of Color)({Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent})
            Case TIPO_ELEMENTO.array_monthday
                Contents = New List(Of String)({"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", Globalization.DateTimeFormatInfo.CurrentInfo.DateSeparator})
                Descriptions = New List(Of String)({"Number 0", "Number 1", "Number 2", "Number 3", "Number 4", "Number 5", "Number 6", "Number 7", "Number 8", "Number 9", "Date separator"})
                Filenames = New List(Of String)({"num_0", "num_1", "num_2", "num_3", "num_4", "num_5", "num_6", "num_7", "num_8", "num_9", "num_minus"})
                Colors = New List(Of Color)({Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent})
            Case TIPO_ELEMENTO.array_day
                Contents = New List(Of String)({"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", Globalization.DateTimeFormatInfo.CurrentInfo.DateSeparator})
                Descriptions = New List(Of String)({"Number 0", "Number 1", "Number 2", "Number 3", "Number 4", "Number 5", "Number 6", "Number 7", "Number 8", "Number 9", "Date separator"})
                Filenames = New List(Of String)({"num_0", "num_1", "num_2", "num_3", "num_4", "num_5", "num_6", "num_7", "num_8", "num_9", "num_minus"})
                Colors = New List(Of Color)({Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent})
            Case TIPO_ELEMENTO.array_steps, TIPO_ELEMENTO.array_arc_steps
                Contents = New List(Of String)({"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"})
                Descriptions = New List(Of String)({"Number 0", "Number 1", "Number 2", "Number 3", "Number 4", "Number 5", "Number 6", "Number 7", "Number 8", "Number 9"})
                Filenames = New List(Of String)({"num_0", "num_1", "num_2", "num_3", "num_4", "num_5", "num_6", "num_7", "num_8", "num_9"})
                Colors = New List(Of Color)({Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent})
            Case TIPO_ELEMENTO.array_year
                Contents = New List(Of String)({"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", Globalization.DateTimeFormatInfo.CurrentInfo.DateSeparator})
                Descriptions = New List(Of String)({"Number 0", "Number 1", "Number 2", "Number 3", "Number 4", "Number 5", "Number 6", "Number 7", "Number 8", "Number 9", "Date separator"})
                Filenames = New List(Of String)({"num_0", "num_1", "num_2", "num_3", "num_4", "num_5", "num_6", "num_7", "num_8", "num_9", "num_minus"})
                Colors = New List(Of Color)({Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent})
            Case TIPO_ELEMENTO.array_temprature
                Contents = New List(Of String)({"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "-", "°"})
                Descriptions = New List(Of String)({"Number 0", "Number 1", "Number 2", "Number 3", "Number 4", "Number 5", "Number 6", "Number 7", "Number 8", "Number 9", "Minus", "Degree"})
                Filenames = New List(Of String)({"num_0", "num_1", "num_2", "num_3", "num_4", "num_5", "num_6", "num_7", "num_8", "num_9", "num_minus", "num_degree"})
                Colors = New List(Of Color)({Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent})
            Case TIPO_ELEMENTO.array_yearmonthday
                Contents = New List(Of String)({"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", Globalization.DateTimeFormatInfo.CurrentInfo.DateSeparator})
                Descriptions = New List(Of String)({"Number 0", "Number 1", "Number 2", "Number 3", "Number 4", "Number 5", "Number 6", "Number 7", "Number 8", "Number 9", "Date separator"})
                Filenames = New List(Of String)({"num_0", "num_1", "num_2", "num_3", "num_4", "num_5", "num_6", "num_7", "num_8", "num_9", "num_colon"})
                Colors = New List(Of Color)({Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent})
            Case TIPO_ELEMENTO.array_month
                For cont As Integer = 1 To 12
                    Contents.Add(String.Format("{0}", MonthName(cont, True)))
                    Descriptions.Add(MonthName(cont))
                Next
                Filenames = New List(Of String)({"jan", "feb", "mar", "apr", "may", "jun", "jul", "aug", "sep", "oct", "nov", "dec"})
                Colors = New List(Of Color)({Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent})
            Case TIPO_ELEMENTO.array_weekday
                For cont As Integer = 1 To 7
                    Contents.Add(String.Format("{0}", WeekdayName(cont, True, FirstDayOfWeek.Sunday)))
                    Descriptions.Add(WeekdayName(cont, False, FirstDayOfWeek.Sunday))
                Next
                Filenames = New List(Of String)({"sun", "mon", "tue", "wed", "thu", "fri", "sat"})
                Colors = New List(Of Color)({Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent})
            Case TIPO_ELEMENTO.array_battery_level, TIPO_ELEMENTO.array_arc_battery
                Contents = New List(Of String)({"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "", "%"})
                Descriptions = New List(Of String)({"Number 0", "Number 1", "Number 2", "Number 3", "Number 4", "Number 5", "Number 6", "Number 7", "Number 8", "Number 9", "Empty", "% (optional)"})
                Filenames = New List(Of String)({"num_0", "num_1", "num_2", "num_3", "num_4", "num_5", "num_6", "num_7", "num_8", "num_9", "none", "percent"})
                Colors = New List(Of Color)({Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent})
            Case Else : Throw New Exception("Array generation not implemented.")
        End Select

        Me.Load(filename)
    End Sub

    Public Function Save(element As CSkinPanel, ByVal ruta As String) As String
        Dim fichero As String = ""
        Dim drawables As New List(Of String)
        Dim scales As New List(Of Double)({1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1})

        Try
            fichero = IO.Path.GetFileNameWithoutExtension(CSkinCanvas.FindUniqueName(element, ruta, ruta))
            ruta = IO.Path.GetDirectoryName(ruta)
            IO.Directory.CreateDirectory(ruta)

            Dim ImagesPerType As Double = 1
            Dim tamano_total As Size = element.Size
            Dim tam_drawable As Size = Size.Empty
            Dim num_imagenes As Integer = Me.Contents.Count

            Select Case Me.Tipo
                Case TIPO_ELEMENTO.array_hour, TIPO_ELEMENTO.array_minute, TIPO_ELEMENTO.array_second, TIPO_ELEMENTO.array_heartrate
                    scales(10) = 0.5
                    ImagesPerType = 2
                Case TIPO_ELEMENTO.array_hourminute
                    scales(10) = 0.5
                    Select Case True
                        Case Contents(11) <> "" OrElse Contents(12) <> "" : ImagesPerType = 5.5
                        Case Else : ImagesPerType = 4.5 : num_imagenes -= 2
                    End Select
                Case TIPO_ELEMENTO.array_monthday
                    ImagesPerType = 5
                Case TIPO_ELEMENTO.array_day
                    ImagesPerType = 2
                Case TIPO_ELEMENTO.array_steps, TIPO_ELEMENTO.array_arc_steps
                    ImagesPerType = 5
                Case TIPO_ELEMENTO.array_year
                    ImagesPerType = 4
                Case TIPO_ELEMENTO.array_temprature
                    scales(11) = 0.5
                    ImagesPerType = 3.5
                Case TIPO_ELEMENTO.array_yearmonthday
                    ImagesPerType = 10
                Case TIPO_ELEMENTO.array_month
                    ImagesPerType = 1
                Case TIPO_ELEMENTO.array_weekday
                    ImagesPerType = 1
                Case TIPO_ELEMENTO.array_battery_level, TIPO_ELEMENTO.array_arc_battery
                    scales(10) = 0
                    Select Case True
                        Case Contents(11) <> "" : ImagesPerType = 3
                        Case Else : ImagesPerType = 2 : num_imagenes -= 1
                    End Select
            End Select

            For cont As Integer = 0 To num_imagenes - 1
                Dim destino As String = CSkinCanvas.FindUniqueNameDrawable(element, ruta, String.Format("{0}_{1}.png", fichero, Me.Filenames(cont)))
                drawables.Add(destino)

                Select Case scales(cont)
                    Case 0 : tam_drawable = New Size(1, 1)
                    Case Else : tam_drawable = New Size(tamano_total.Width / ImagesPerType * scales(cont), tamano_total.Height)
                End Select
                If tam_drawable.Height = 0 OrElse tam_drawable.Width = 0 Then Throw New Exception("Array size not valid.")

                Select Case Me.Colors(cont)
                    Case Color.Transparent
                        SaveImage(drawables(cont), Contents(cont), Me.ForeColor, Me.ShadowX, Me.ShadowY, Me.ShadowColor, tam_drawable, Me.AutoScale)
                    Case Else
                        SaveImage(drawables(cont), Contents(cont), Me.Colors(cont), Me.ShadowX, Me.ShadowY, Me.ShadowColor, tam_drawable, Me.AutoScale)
                End Select
            Next

            SaveDrawables(String.Format("{0}\{1}.xml", ruta, fichero), drawables)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return String.Format("{0}\{1}.xml", ruta, fichero)
    End Function

    Private Sub Load(_filename As String)
        Dim reader As New XmlDocument()

        Try
            If Not IO.File.Exists(_filename) Then Return
            reader.Load(_filename)

            Dim drawables As XmlNode = reader.SelectSingleNode("drawables")
            If drawables Is Nothing Then Throw New Exception("Bad XML format.")

            'AQUI SE LEERIAN LOS DRAWABLES................................

            'LAS PROPIEDADES PERSONALIZADAS SE LEEN DE LOS COMENTARIOS, PARA EVITAR PROBLEMAS
            For Each comment As XmlComment In drawables.SelectNodes("//comment()")
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

                'If Not nodo.Attributes("type") Is Nothing AndAlso nodo.Attributes("type").Value.Trim <> "" Then [Enum].TryParse(Of TIPO_ELEMENTO)(nodo.Attributes("type").Value.Trim, ret.Tipo)
                If Not nodo.Attributes("forecolor") Is Nothing AndAlso nodo.Attributes("forecolor").Value.Trim <> "" Then Me.ForeColor = ColorTranslator.FromHtml(String.Format("#{0}", nodo.Attributes("forecolor").Value.Trim))
                If Not nodo.Attributes("backcolor") Is Nothing AndAlso nodo.Attributes("backcolor").Value.Trim <> "" Then Me.BackColor = ColorTranslator.FromHtml(String.Format("#{0}", nodo.Attributes("backcolor").Value.Trim))
                If Not nodo.Attributes("autoscale") Is Nothing AndAlso nodo.Attributes("autoscale").Value.Trim <> "" Then Me.AutoScale = IIf(nodo.Attributes("autoscale").Value.Trim = "0", False, True)

                If Not nodo.Attributes("shadowx") Is Nothing AndAlso nodo.Attributes("shadowx").Value.Trim <> "" Then Me.ShadowX = nodo.Attributes("shadowx").Value.Trim
                If Not nodo.Attributes("shadowy") Is Nothing AndAlso nodo.Attributes("shadowy").Value.Trim <> "" Then Me.ShadowY = nodo.Attributes("shadowy").Value.Trim
                If Not nodo.Attributes("shadowcolor") Is Nothing AndAlso nodo.Attributes("shadowcolor").Value.Trim <> "" Then Me.ShadowColor = ColorTranslator.FromHtml(String.Format("#{0}", nodo.Attributes("shadowcolor").Value.Trim))

                Dim estilo As FontStyle = FontStyle.Regular
                Dim fontsize As Single = 19
                If Not nodo.Attributes("fontsize") Is Nothing AndAlso nodo.Attributes("fontsize").Value.Trim <> "" Then fontsize = nodo.Attributes("fontsize").Value.Trim
                If Not nodo.Attributes("fontstyle") Is Nothing AndAlso nodo.Attributes("fontstyle").Value.Trim <> "" Then [Enum].TryParse(Of FontStyle)(nodo.Attributes("fontstyle").Value.Trim, estilo) Else
                If Not nodo.Attributes("font") Is Nothing AndAlso nodo.Attributes("font").Value.Trim <> "" Then Me.Font = New Font(nodo.Attributes("font").Value.Trim, fontsize, estilo, GraphicsUnit.Point)

                Dim i As Integer = 0
                For Each content As XmlNode In nodo.SelectNodes("content")
                    If i >= Contents.Count Then Exit For
                    Contents(i) = content.InnerText.Trim
                    If Not content.Attributes("forecolor") Is Nothing AndAlso content.Attributes("forecolor").Value.Trim <> "" Then Colors(i) = ColorTranslator.FromHtml(String.Format("#{0}", content.Attributes("forecolor").Value.Trim))
                    i += 1
                Next

                Exit For 'Saltamos el resto de comentarios
            Next

        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            If Not reader Is Nothing Then reader = Nothing
        End Try

    End Sub
    Private Sub SaveDrawables(ruta As String, drawables As List(Of String))
        Using writer As New XmlTextWriter(ruta, New System.Text.UTF8Encoding(False))
            writer.WriteStartDocument()
            writer.Formatting = Formatting.Indented
            writer.IndentChar = vbTab
            writer.Indentation = 1

            writer.WriteStartElement("drawables")

            For Each imagen As String In drawables
                writer.WriteStartElement("image")
                writer.WriteString(String.Format("{0}", IO.Path.GetFileName(imagen)))
                writer.WriteEndElement()
            Next

            ''ADITIONAL DATA IN COMMENTS TO AVOID PROBLEMS'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Dim metadata As String = My.Resources.COMMENTS_HEADER
            metadata &= vbCrLf
            metadata &= "<metadata"
            metadata &= " gui='rra'"
            metadata &= " version='" & Application.ProductVersion.ToString & "'"
            metadata &= " type='" & Me.Tipo.ToString & "'"
            If Me.BackColor <> Color.Transparent Then metadata &= " backcolor='" & ColorTranslator.ToHtml(Color.FromArgb(Me.BackColor.ToArgb)).Substring(1) & "'"
            If Me.ForeColor <> Color.Black Then metadata &= " forecolor='" & ColorTranslator.ToHtml(Color.FromArgb(Me.ForeColor.ToArgb)).Substring(1) & "'"
            metadata &= " autoscale='" & IIf(Me.AutoScale, "1", "0") & "'"

            If Me.ShadowX <> 0 OrElse Me.ShadowY <> 0 Then
                If Me.ShadowColor <> Color.Gray Then metadata &= " shadowcolor='" & ColorTranslator.ToHtml(Color.FromArgb(Me.ShadowColor.ToArgb)).Substring(1) & "'"
                metadata &= " shadowx='" & Me.ShadowX & "'"
                metadata &= " shadowy='" & Me.ShadowY & "'"
            End If

            metadata &= " font='" & Me.Font.Name.ToString & "'"
            metadata &= " fontstyle='" & Me.Font.Style.ToString & "'"
            metadata &= " fontsize='" & Me.Font.Size.ToString & "'"
            metadata &= ">" & vbCrLf
            For i As Integer = 0 To Me.Contents.Count - 1
                metadata &= "<content"
                If Colors(i) <> Color.Transparent Then metadata &= " forecolor='" & ColorTranslator.ToHtml(Color.FromArgb(Colors(i).ToArgb)).Substring(1) & "'"
                metadata &= ">" & Me.Contents(i) & "</content>" & vbCrLf
            Next
            metadata &= "</metadata>" & vbCrLf
            writer.Indentation = 0
            writer.WriteComment(metadata)
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            writer.WriteEndElement()
            writer.WriteEndDocument()
            writer.Close()
        End Using
    End Sub

    Private Sub SaveImage(fichero As String, texto As String, color As Color, depthx As Integer, depthy As Integer, shadowcolor As Color, tamano As Size, autoscale As Boolean)
        Try
            Using bmp As New Bitmap(tamano.Width, tamano.Height)
                Using g As Graphics = System.Drawing.Graphics.FromImage(bmp)
                    g.Clear(Me.BackColor)

                    Dim rect As New Rectangle(0, 0, bmp.Width, bmp.Height)
                    Dim sf As StringFormat = StringFormat.GenericTypographic
                    sf.Alignment = StringAlignment.Near
                    sf.LineAlignment = StringAlignment.Center
                    sf.FormatFlags = StringFormatFlags.FitBlackBox Or StringFormatFlags.NoWrap

                    If autoscale Then Me.Font = CArrayFormat.ScaleFont(g, texto, rect.Size, Me.Font, sf)


                    If depthx <> 0 OrElse depthy <> 0 Then
                        Dim rect_shadow As New Rectangle(depthx, depthy, bmp.Width, bmp.Height)

                        g.SmoothingMode = Drawing2D.SmoothingMode.HighSpeed
                        g.InterpolationMode = Drawing2D.InterpolationMode.Low
                        g.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias
                        g.DrawString(texto, Me.Font, New SolidBrush(Color.FromArgb(128, shadowcolor.R, shadowcolor.G, shadowcolor.B)), rect_shadow, sf)
                    End If

                    g.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
                    g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBilinear
                    g.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAliasGridFit
                    g.DrawString(texto, Me.Font, New SolidBrush(color), rect, sf)

                    'Dim t As TextFormatFlags = TextFormatFlags.NoPadding
                    'TextRenderer.DrawText(g, texto, Me.Font, rect, Me.ForeColor, t)
                End Using
                bmp.Save(fichero, Imaging.ImageFormat.Png)
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub
    Public Shared Function ScaleFont(g As System.Drawing.Graphics, texto As String, caja As Size, PreferedFont As Font, sf As StringFormat) As Font
        Dim RealSize As SizeF = g.MeasureString(texto, PreferedFont, 0, sf)
        Dim HeightScaleRatio As Double = 0
        Dim WidthScaleRatio As Double = 0
        Dim ScaledFontSize As Double = 0

        If RealSize.Width = 0 OrElse RealSize.Height = 0 Then RealSize = caja

        HeightScaleRatio = caja.Height / RealSize.Height
        WidthScaleRatio = caja.Width / RealSize.Width
        ScaledFontSize = PreferedFont.Size * Math.Min(HeightScaleRatio, WidthScaleRatio)

        Return New Font(PreferedFont.FontFamily, ScaledFontSize, PreferedFont.Style, GraphicsUnit.Point)
    End Function

End Class