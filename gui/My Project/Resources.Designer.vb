﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.42000
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'StronglyTypedResourceBuilder generó automáticamente esta clase
    'a través de una herramienta como ResGen o Visual Studio.
    'Para agregar o quitar un miembro, edite el archivo .ResX y, a continuación, vuelva a ejecutar ResGen
    'con la opción /str o recompile su proyecto de VS.
    '''<summary>
    '''  Clase de recurso fuertemente tipado, para buscar cadenas traducidas, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Devuelve la instancia de ResourceManager almacenada en caché utilizada por esta clase.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("ClockSkinMaker.gui.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Reemplaza la propiedad CurrentUICulture del subproceso actual para todas las
        '''  búsquedas de recursos mediante esta clase de recurso fuertemente tipado.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property element_new() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("element_new", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Busca una cadena traducida similar a                     GNU GENERAL PUBLIC LICENSE
        '''                       Version 3, 29 June 2007
        '''
        ''' Copyright (C) 2007 Free Software Foundation, Inc. &lt;http://fsf.org/&gt;
        ''' Everyone is permitted to copy and distribute verbatim copies
        ''' of this license document, but changing it is not allowed.
        '''
        '''                            Preamble
        '''
        '''  The GNU General Public License is a free, copyleft license for
        '''software and other kinds of works.
        '''
        '''  The licenses for most software and other practical works are designed
        '''to [resto de la cadena truncado]&quot;;.
        '''</summary>
        Friend ReadOnly Property LICENSE() As String
            Get
                Return ResourceManager.GetString("LICENSE", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Busca una cadena traducida similar a ClockSkinMaker gui
        '''==================================
        '''
        '''Copyright (c) 2016 richi &lt;rromeroa@hotmail.com&gt;
        '''
        '''ClockSkinMaker is distributed under the GNU General Public License GPLv3 or
        '''higher, please see LICENSE.TXT for details.
        '''
        '''The included software is provided as-is by Ricardo Romero.
        '''
        '''IMPORTANT
        '''==================================
        '''YOU AGREE THAT YOUR USE OF THIS SOFTWARE IS ENTIRELY AT YOUR OWN RISK.
        '''
        '''KNOWN ISSUES AND LIMITATIONS
        '''==================================
        '''- The &quot;pedometer text&quot; and &quot;he [resto de la cadena truncado]&quot;;.
        '''</summary>
        Friend ReadOnly Property README() As String
            Get
                Return ResourceManager.GetString("README", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.Byte[].
        '''</summary>
        Friend ReadOnly Property SampleLibZip() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("SampleLibZip", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property warning() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("warning", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
    End Module
End Namespace
