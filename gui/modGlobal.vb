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

Imports System.IO
Imports System.IO.Compression

Module modGlobal
    Public Enum TIPO_DBG
        MSJ = 0
        WRN = 1
        ERR = 2
        CRI = 3
    End Enum

    Public PATH_SKINS As String = ""
    Public INI As CFileIni = Nothing

    Public Sub Main(ByVal CommandLineArgs() As String)
        File.WriteAllText(String.Format("{0}\LICENSE.txt", Application.StartupPath), My.Resources.LICENSE)
        File.WriteAllText(String.Format("{0}\README.gui.txt", Application.StartupPath), My.Resources.README)

        INI = New CFileIni(String.Format("{0}\.clockskinmaker", Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)))
        PATH_SKINS = INI.Read("ClockSkin", "Path", String.Format("{0}ClockSkin", INI.Path)).Trim

        Dim tmp As String = String.Format("{0}\.tmp", PATH_SKINS)
        If Not Directory.Exists(PATH_SKINS) Then
            If MessageBox.Show("YOU AGREE THAT YOUR USE OF THIS SOFTWARE IS ENTIRELY AT YOUR OWN RISK.", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.No Then End

            Directory.CreateDirectory(PATH_SKINS)
            Try
                If Not Directory.Exists(tmp) Then Directory.CreateDirectory(tmp)
                File.WriteAllBytes(String.Format("{0}\ClockSkin.zip", tmp), My.Resources.SampleLibZip)
                IO.Compression.ZipFile.ExtractToDirectory(String.Format("{0}\ClockSkin.zip", tmp), PATH_SKINS)

                My.Computer.FileSystem.DeleteDirectory(tmp, FileIO.DeleteDirectoryOption.DeleteAllContents)
            Catch ex As Exception
                MB(TIPO_DBG.WRN, ex.Message)
            End Try
        End If

        Application.Run(New frmPrincipal)
    End Sub

    Public Sub MB(ByVal tipo As TIPO_DBG, ByVal mensaje As String, Optional ByVal asincrono As Boolean = False)
        Dim estilo As MsgBoxStyle = MsgBoxStyle.Information

        Select Case tipo
            Case TIPO_DBG.MSJ
                estilo = MsgBoxStyle.Information
            Case TIPO_DBG.WRN
                estilo = MsgBoxStyle.Exclamation
            Case TIPO_DBG.ERR
                estilo = MsgBoxStyle.Critical
            Case TIPO_DBG.CRI
                estilo = MsgBoxStyle.Critical
            Case Else
                estilo = MsgBoxStyle.Critical
        End Select

        If asincrono Then
            Dim foo As New Threading.Thread(AddressOf ShowMessageBox)
            foo.Start(New Object() {mensaje, estilo})
            Return
        End If
        ShowMessageBox(New Object() {mensaje, estilo})
    End Sub
    Private Sub ShowMessageBox(ByVal params() As Object)
        Using fmb As New Form
            fmb.TopMost = True
            fmb.StartPosition = FormStartPosition.CenterParent
            MessageBox.Show(fmb, params(0).ToString(), Application.ProductName, MessageBoxButtons.OK, params(1))
        End Using
    End Sub

End Module
