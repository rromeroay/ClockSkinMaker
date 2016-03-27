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

Imports System.Text

Public Class CFileIni
    Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal section As String, ByVal key As String, ByVal val As String, ByVal filePath As String) As Long
    Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal section As String, ByVal key As String, ByVal def As String, ByVal retVal As StringBuilder, ByVal size As Integer, ByVal filePath As String) As Integer

    Private _file As String 'Nombre del fichero
    Private _path As String 'Path al fichero

    Public ReadOnly Property Path() As String
        Get
            Return _path
        End Get
    End Property
    Public ReadOnly Property File() As String
        Get
            Return _file
        End Get
    End Property
    Public ReadOnly Property FullPath() As String
        Get
            Return Me._path & Me._file
        End Get
    End Property

    Public Sub Write(ByRef Section As String, ByRef Key As String, ByVal Value As String)
        If Value.StartsWith(" ") OrElse Value.EndsWith(" ") OrElse Value.StartsWith("""") Then Value = """" & Value & """"

        If Value.Contains(vbCr) Then Value = Value.Replace(vbCr, Chr(1))
        If Value.Contains(vbLf) Then Value = Value.Replace(vbLf, Chr(2))

        WritePrivateProfileString(Section, Key, Value, Me.FullPath)
    End Sub
    Public Function Read(ByRef Section As String, ByRef Key As String) As String
        Return Read(Section, Key, Nothing)
    End Function
    Public Function Read(ByRef Seccion As String, ByRef Clave As String, ByRef Defecto As Object) As String
        Dim temp As StringBuilder = New StringBuilder(2048)
        Dim i As Integer = 0

        i = GetPrivateProfileString(Seccion, Clave, "", temp, 2048, Me.FullPath)
        Dim ret As String = temp.ToString

        If ret.Contains(Chr(1)) Then ret = ret.Replace(Chr(1), vbCr)
        If ret.Contains(Chr(2)) Then ret = ret.Replace(Chr(2), vbLf)

        If ret = "" AndAlso Not Defecto Is Nothing Then
            Write(Seccion, Clave, Defecto.ToString)
            Return Defecto.ToString
        End If

        Return ret
    End Function
    Public Sub New(ByRef fullpath As String) 'Consutructor pasándole la ruta completa
        Dim info As New System.IO.FileInfo(fullpath)

        'Se separa la ruta completa en su path y su fichero
        Me._file = info.Name
        Me._path = info.DirectoryName
        Me._path &= IIf(Not Me._path.EndsWith("\"), "\", "")
    End Sub

End Class
