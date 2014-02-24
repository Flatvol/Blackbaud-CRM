﻿Option Strict On
Option Explicit On
Option Infer On

'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by BBUIModelLibrary
'     Version:  2.94.1232.0
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------
''' <summary>
''' Represents the UI model for the 'Food Bank Top Shortages UI Widget Data List' data form
''' </summary>
<Global.Blackbaud.AppFx.UIModeling.Core.DataListFilterUIModelMetadata("0ef415cd-05ff-47d1-b8b8-c52c74fbae09")> _
Partial Public Class [FoodBankTopShortagesUIWidgetDataListUIModel]
	Inherits Global.Blackbaud.AppFx.UIModeling.Core.DataListFilterUIModel

#Region "Extensibility methods"

    Partial Private Sub OnCreated()
    End Sub

#End Region

    Private WithEvents _businessprocessoutputid As Global.Blackbaud.AppFx.UIModeling.Core.SimpleDataListField(Of Guid)

	<System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.94.1232.0")> _
    Public Sub New()
        MyBase.New()

        _businessprocessoutputid = New Global.Blackbaud.AppFx.UIModeling.Core.SimpleDataListField(Of Guid)

        MyBase.DataListId = New Guid("0ef415cd-05ff-47d1-b8b8-c52c74fbae09")
        MyBase.UserInterfaceUrl = "browser/htmlforms/custom/blackbaud.customfx.foodbank/FoodBankTopShortagesUIWidgetDataList.html"

        '
        '_businessprocessoutputid
        '
        _businessprocessoutputid.Name = "BUSINESSPROCESSOUTPUTID"
        _businessprocessoutputid.Caption = "Low Inventory Snapshot"
        _businessprocessoutputid.SimpleDataListID = New Guid("5710af5e-2cef-4014-a9b4-eec1f246b582")
        _businessprocessoutputid.BlankValueCaption = "Select a Business Process Run"
        Me.Fields.Add(_businessprocessoutputid)

		OnCreated()

    End Sub
    
    ''' <summary>
    ''' Low Inventory Snapshot
    ''' </summary>
    <System.ComponentModel.Description("Low Inventory Snapshot")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.94.1232.0")> _
    Public ReadOnly Property [BUSINESSPROCESSOUTPUTID]() As Global.Blackbaud.AppFx.UIModeling.Core.SimpleDataListField(Of Guid)
        Get
            Return _businessprocessoutputid
        End Get
    End Property
    
End Class
