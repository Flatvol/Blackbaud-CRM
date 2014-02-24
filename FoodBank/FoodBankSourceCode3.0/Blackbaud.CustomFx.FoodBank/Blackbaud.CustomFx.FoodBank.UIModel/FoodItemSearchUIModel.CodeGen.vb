﻿Option Strict On
Option Explicit On
Option Infer On

'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by BBUIModelLibrary
'     Version:  2.93.429.0
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------
''' <summary>
''' Represents the UI model for the 'Food Item Search' data form
''' </summary>
<Global.Blackbaud.AppFx.UIModeling.Core.SearchListUIModelMetadata("2c247add-e19e-407f-b6c3-8f3bc5216ccd", "Food Item")> _
Partial Public Class [FoodItemSearchUIModel]
	Inherits Global.Blackbaud.AppFx.UIModeling.Core.SearchListUIModel

#Region "Extensibility methods"

    Partial Private Sub OnCreated()
    End Sub

#End Region

    Private WithEvents _name As Global.Blackbaud.AppFx.UIModeling.Core.StringField

	<System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.93.429.0")> _
    Public Sub New()
        MyBase.New()

        _name = New Global.Blackbaud.AppFx.UIModeling.Core.StringField

        MyBase.SearchListId = New Guid("2c247add-e19e-407f-b6c3-8f3bc5216ccd")
        MyBase.SearchRecordType = "Food Item"
        MyBase.FORMHEADER.Value = "Food Item Search"
        MyBase.TranslationFunctionId = New Guid("9edced28-35ef-481f-9bb9-cfb110a92881")
        MyBase.UserInterfaceUrl = "browser/htmlforms/custom/blackbaud.customfx.foodbank/FoodItemSearch.html"

        '
        '_name
        '
        _name.Name = "NAME"
        _name.Caption = "Name"
        _name.MaxLength = 100
        Me.Fields.Add(_name)

		OnCreated()

    End Sub
    
    ''' <summary>
    ''' Name
    ''' </summary>
    <System.ComponentModel.Description("Name")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.93.429.0")> _
    Public ReadOnly Property [NAME]() As Global.Blackbaud.AppFx.UIModeling.Core.StringField
        Get
            Return _name
        End Get
    End Property
    
End Class
