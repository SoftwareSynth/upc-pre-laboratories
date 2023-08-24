
<%@ WebService Language="VB" Class="WebService1" %>

Imports System
Imports System.Web
Imports System.Web.Services
Imports System.Xml.Serialization

Public Class WebService1

    Inherits System.Web.Services.WebService


    <System.Web.Services.WebMethod()> _
    Public Function FahrenheitToCelsius(ByVal Fahrenheit As Double) _
        As Double
        ((Fahrenheit - 32) * 5) / 9
    End Function

    
    <System.Web.Services.WebMethod()> _
    Public Function CelsiusToFahrenheit(ByVal Celsius As Double) _
            As Double
        Return ((Celsius * 9) / 5) + 32
    End Function

    

End Class
