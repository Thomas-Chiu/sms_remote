﻿'------------------------------------------------------------------------------
' <auto-generated>
'     這段程式碼是由工具產生的。
'     執行階段版本:2.0.50727.4927
'
'     對這個檔案所做的變更可能會造成錯誤的行為，而且如果重新產生程式碼，
'     變更將會遺失。
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Xml.Serialization

'
'原始程式碼已由 Microsoft.VSDesigner 自動產生，版本 2.0.50727.4927。
'
Namespace SMSService
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.4927"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="SMSSoap", [Namespace]:="http://tempuri.org/")>  _
    Partial Public Class SMS
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        Private getConnectionOperationCompleted As System.Threading.SendOrPostCallback
        
        Private closeConnectionOperationCompleted As System.Threading.SendOrPostCallback
        
        Private sendSMSOperationCompleted As System.Threading.SendOrPostCallback
        
        Private sendParamSMSOperationCompleted As System.Threading.SendOrPostCallback
        
        Private eraseBookingOperationCompleted As System.Threading.SendOrPostCallback
        
        Private getDeliveryStatusOperationCompleted As System.Threading.SendOrPostCallback
        
        Private getCreditOperationCompleted As System.Threading.SendOrPostCallback
        
        Private useDefaultCredentialsSetExplicitly As Boolean
        
        '''<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = Global.Web_Sample_SOAP_.My.MySettings.Default.Web_Sample_SOAP__SMSService_SMS
            If (Me.IsLocalFileSystemWebService(Me.Url) = true) Then
                Me.UseDefaultCredentials = true
                Me.useDefaultCredentialsSetExplicitly = false
            Else
                Me.useDefaultCredentialsSetExplicitly = true
            End If
        End Sub
        
        Public Shadows Property Url() As String
            Get
                Return MyBase.Url
            End Get
            Set
                If (((Me.IsLocalFileSystemWebService(MyBase.Url) = true)  _
                            AndAlso (Me.useDefaultCredentialsSetExplicitly = false))  _
                            AndAlso (Me.IsLocalFileSystemWebService(value) = false)) Then
                    MyBase.UseDefaultCredentials = false
                End If
                MyBase.Url = value
            End Set
        End Property
        
        Public Shadows Property UseDefaultCredentials() As Boolean
            Get
                Return MyBase.UseDefaultCredentials
            End Get
            Set
                MyBase.UseDefaultCredentials = value
                Me.useDefaultCredentialsSetExplicitly = true
            End Set
        End Property
        
        '''<remarks/>
        Public Event getConnectionCompleted As getConnectionCompletedEventHandler
        
        '''<remarks/>
        Public Event closeConnectionCompleted As closeConnectionCompletedEventHandler
        
        '''<remarks/>
        Public Event sendSMSCompleted As sendSMSCompletedEventHandler
        
        '''<remarks/>
        Public Event sendParamSMSCompleted As sendParamSMSCompletedEventHandler
        
        '''<remarks/>
        Public Event eraseBookingCompleted As eraseBookingCompletedEventHandler
        
        '''<remarks/>
        Public Event getDeliveryStatusCompleted As getDeliveryStatusCompletedEventHandler
        
        '''<remarks/>
        Public Event getCreditCompleted As getCreditCompletedEventHandler
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getConnection", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function getConnection(ByVal userID As String, ByVal password As String) As String
            Dim results() As Object = Me.Invoke("getConnection", New Object() {userID, password})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub getConnectionAsync(ByVal userID As String, ByVal password As String)
            Me.getConnectionAsync(userID, password, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub getConnectionAsync(ByVal userID As String, ByVal password As String, ByVal userState As Object)
            If (Me.getConnectionOperationCompleted Is Nothing) Then
                Me.getConnectionOperationCompleted = AddressOf Me.OngetConnectionOperationCompleted
            End If
            Me.InvokeAsync("getConnection", New Object() {userID, password}, Me.getConnectionOperationCompleted, userState)
        End Sub
        
        Private Sub OngetConnectionOperationCompleted(ByVal arg As Object)
            If (Not (Me.getConnectionCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent getConnectionCompleted(Me, New getConnectionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/closeConnection", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function closeConnection(ByVal sessionKey As String) As String
            Dim results() As Object = Me.Invoke("closeConnection", New Object() {sessionKey})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub closeConnectionAsync(ByVal sessionKey As String)
            Me.closeConnectionAsync(sessionKey, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub closeConnectionAsync(ByVal sessionKey As String, ByVal userState As Object)
            If (Me.closeConnectionOperationCompleted Is Nothing) Then
                Me.closeConnectionOperationCompleted = AddressOf Me.OncloseConnectionOperationCompleted
            End If
            Me.InvokeAsync("closeConnection", New Object() {sessionKey}, Me.closeConnectionOperationCompleted, userState)
        End Sub
        
        Private Sub OncloseConnectionOperationCompleted(ByVal arg As Object)
            If (Not (Me.closeConnectionCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent closeConnectionCompleted(Me, New closeConnectionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/sendSMS", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function sendSMS(ByVal sessionKey As String, ByVal subject As String, ByVal content As String, ByVal mobile As String, ByVal sendTime As String) As String
            Dim results() As Object = Me.Invoke("sendSMS", New Object() {sessionKey, subject, content, mobile, sendTime})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub sendSMSAsync(ByVal sessionKey As String, ByVal subject As String, ByVal content As String, ByVal mobile As String, ByVal sendTime As String)
            Me.sendSMSAsync(sessionKey, subject, content, mobile, sendTime, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub sendSMSAsync(ByVal sessionKey As String, ByVal subject As String, ByVal content As String, ByVal mobile As String, ByVal sendTime As String, ByVal userState As Object)
            If (Me.sendSMSOperationCompleted Is Nothing) Then
                Me.sendSMSOperationCompleted = AddressOf Me.OnsendSMSOperationCompleted
            End If
            Me.InvokeAsync("sendSMS", New Object() {sessionKey, subject, content, mobile, sendTime}, Me.sendSMSOperationCompleted, userState)
        End Sub
        
        Private Sub OnsendSMSOperationCompleted(ByVal arg As Object)
            If (Not (Me.sendSMSCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent sendSMSCompleted(Me, New sendSMSCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/sendParamSMS", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function sendParamSMS(ByVal sessionKey As String, ByVal subject As String, ByVal contentXML As String, ByVal sendTime As String) As String
            Dim results() As Object = Me.Invoke("sendParamSMS", New Object() {sessionKey, subject, contentXML, sendTime})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub sendParamSMSAsync(ByVal sessionKey As String, ByVal subject As String, ByVal contentXML As String, ByVal sendTime As String)
            Me.sendParamSMSAsync(sessionKey, subject, contentXML, sendTime, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub sendParamSMSAsync(ByVal sessionKey As String, ByVal subject As String, ByVal contentXML As String, ByVal sendTime As String, ByVal userState As Object)
            If (Me.sendParamSMSOperationCompleted Is Nothing) Then
                Me.sendParamSMSOperationCompleted = AddressOf Me.OnsendParamSMSOperationCompleted
            End If
            Me.InvokeAsync("sendParamSMS", New Object() {sessionKey, subject, contentXML, sendTime}, Me.sendParamSMSOperationCompleted, userState)
        End Sub
        
        Private Sub OnsendParamSMSOperationCompleted(ByVal arg As Object)
            If (Not (Me.sendParamSMSCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent sendParamSMSCompleted(Me, New sendParamSMSCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/eraseBooking", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function eraseBooking(ByVal sessionKey As String, ByVal batchID As String) As String
            Dim results() As Object = Me.Invoke("eraseBooking", New Object() {sessionKey, batchID})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub eraseBookingAsync(ByVal sessionKey As String, ByVal batchID As String)
            Me.eraseBookingAsync(sessionKey, batchID, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub eraseBookingAsync(ByVal sessionKey As String, ByVal batchID As String, ByVal userState As Object)
            If (Me.eraseBookingOperationCompleted Is Nothing) Then
                Me.eraseBookingOperationCompleted = AddressOf Me.OneraseBookingOperationCompleted
            End If
            Me.InvokeAsync("eraseBooking", New Object() {sessionKey, batchID}, Me.eraseBookingOperationCompleted, userState)
        End Sub
        
        Private Sub OneraseBookingOperationCompleted(ByVal arg As Object)
            If (Not (Me.eraseBookingCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent eraseBookingCompleted(Me, New eraseBookingCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getDeliveryStatus", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function getDeliveryStatus(ByVal sessionKey As String, ByVal batchID As String, ByVal pageNo As String) As String
            Dim results() As Object = Me.Invoke("getDeliveryStatus", New Object() {sessionKey, batchID, pageNo})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub getDeliveryStatusAsync(ByVal sessionKey As String, ByVal batchID As String, ByVal pageNo As String)
            Me.getDeliveryStatusAsync(sessionKey, batchID, pageNo, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub getDeliveryStatusAsync(ByVal sessionKey As String, ByVal batchID As String, ByVal pageNo As String, ByVal userState As Object)
            If (Me.getDeliveryStatusOperationCompleted Is Nothing) Then
                Me.getDeliveryStatusOperationCompleted = AddressOf Me.OngetDeliveryStatusOperationCompleted
            End If
            Me.InvokeAsync("getDeliveryStatus", New Object() {sessionKey, batchID, pageNo}, Me.getDeliveryStatusOperationCompleted, userState)
        End Sub
        
        Private Sub OngetDeliveryStatusOperationCompleted(ByVal arg As Object)
            If (Not (Me.getDeliveryStatusCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent getDeliveryStatusCompleted(Me, New getDeliveryStatusCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getCredit", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function getCredit(ByVal sessionKey As String) As String
            Dim results() As Object = Me.Invoke("getCredit", New Object() {sessionKey})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub getCreditAsync(ByVal sessionKey As String)
            Me.getCreditAsync(sessionKey, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub getCreditAsync(ByVal sessionKey As String, ByVal userState As Object)
            If (Me.getCreditOperationCompleted Is Nothing) Then
                Me.getCreditOperationCompleted = AddressOf Me.OngetCreditOperationCompleted
            End If
            Me.InvokeAsync("getCredit", New Object() {sessionKey}, Me.getCreditOperationCompleted, userState)
        End Sub
        
        Private Sub OngetCreditOperationCompleted(ByVal arg As Object)
            If (Not (Me.getCreditCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent getCreditCompleted(Me, New getCreditCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        Public Shadows Sub CancelAsync(ByVal userState As Object)
            MyBase.CancelAsync(userState)
        End Sub
        
        Private Function IsLocalFileSystemWebService(ByVal url As String) As Boolean
            If ((url Is Nothing)  _
                        OrElse (url Is String.Empty)) Then
                Return false
            End If
            Dim wsUri As System.Uri = New System.Uri(url)
            If ((wsUri.Port >= 1024)  _
                        AndAlso (String.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) = 0)) Then
                Return true
            End If
            Return false
        End Function
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.4927")>  _
    Public Delegate Sub getConnectionCompletedEventHandler(ByVal sender As Object, ByVal e As getConnectionCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.4927"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class getConnectionCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.4927")>  _
    Public Delegate Sub closeConnectionCompletedEventHandler(ByVal sender As Object, ByVal e As closeConnectionCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.4927"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class closeConnectionCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.4927")>  _
    Public Delegate Sub sendSMSCompletedEventHandler(ByVal sender As Object, ByVal e As sendSMSCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.4927"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class sendSMSCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.4927")>  _
    Public Delegate Sub sendParamSMSCompletedEventHandler(ByVal sender As Object, ByVal e As sendParamSMSCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.4927"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class sendParamSMSCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.4927")>  _
    Public Delegate Sub eraseBookingCompletedEventHandler(ByVal sender As Object, ByVal e As eraseBookingCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.4927"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class eraseBookingCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.4927")>  _
    Public Delegate Sub getDeliveryStatusCompletedEventHandler(ByVal sender As Object, ByVal e As getDeliveryStatusCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.4927"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class getDeliveryStatusCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.4927")>  _
    Public Delegate Sub getCreditCompletedEventHandler(ByVal sender As Object, ByVal e As getCreditCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.4927"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class getCreditCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
End Namespace
