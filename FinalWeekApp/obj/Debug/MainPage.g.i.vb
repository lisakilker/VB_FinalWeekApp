﻿

#ExternalChecksum("c:\users\lisakilker\documents\visual studio 2012\Projects\FinalWeekApp\FinalWeekApp\MainPage.xaml", "{406ea660-64cf-4c82-b6f0-42d48172a799}", "E7A61226167BF719A7795DD319A3F5A6")
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On


Namespace Global.FinalWeekApp

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
    Partial Class MainPage
        Inherits Global.Windows.UI.Xaml.Controls.Page

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents lblCheckTotal As Global.Windows.UI.Xaml.Controls.TextBlock
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents lblPartySize As Global.Windows.UI.Xaml.Controls.TextBlock
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents lblTipAmount As Global.Windows.UI.Xaml.Controls.TextBlock
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents txtCheckTotal As Global.Windows.UI.Xaml.Controls.TextBox
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents cboPartySize As Global.Windows.UI.Xaml.Controls.ComboBox
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents cboTipAmount As Global.Windows.UI.Xaml.Controls.ComboBox
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents btnCalculate As Global.Windows.UI.Xaml.Controls.Button
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents lblDisplay As Global.Windows.UI.Xaml.Controls.TextBlock

        Private _contentLoaded As Boolean

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub InitializeComponent()
            If _contentLoaded Then
                Return
            End If
            _contentLoaded = true

            Dim uri As New Global.System.Uri("ms-appx:///MainPage.xaml")
            Global.Windows.UI.Xaml.Application.LoadComponent(Me, uri, Global.Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation.Application)

            lblCheckTotal = CType(Me.FindName("lblCheckTotal"), Global.Windows.UI.Xaml.Controls.TextBlock)
            lblPartySize = CType(Me.FindName("lblPartySize"), Global.Windows.UI.Xaml.Controls.TextBlock)
            lblTipAmount = CType(Me.FindName("lblTipAmount"), Global.Windows.UI.Xaml.Controls.TextBlock)
            txtCheckTotal = CType(Me.FindName("txtCheckTotal"), Global.Windows.UI.Xaml.Controls.TextBox)
            cboPartySize = CType(Me.FindName("cboPartySize"), Global.Windows.UI.Xaml.Controls.ComboBox)
            cboTipAmount = CType(Me.FindName("cboTipAmount"), Global.Windows.UI.Xaml.Controls.ComboBox)
            btnCalculate = CType(Me.FindName("btnCalculate"), Global.Windows.UI.Xaml.Controls.Button)
            lblDisplay = CType(Me.FindName("lblDisplay"), Global.Windows.UI.Xaml.Controls.TextBlock)
        End Sub
    End Class

End Namespace

