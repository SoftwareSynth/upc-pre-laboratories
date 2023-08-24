<%@ WebService Language="C#" Class="WebService1" %>

using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Web;
using System.Web.Services;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
public class WebService1 : System.Web.Services.WebService 
{
    public WebService1()
    {
        //
        // TODO: agregar el código de constructor necesario
        //
    }
    // EJEMPLO DE SERVICIO WEB
    // El servicio de ejemplo HelloWorld() devuelve la cadena Hola a todos.

    [WebMethod]
    public string HelloWorld()
    {
        return "Hola a todos";
    }
}