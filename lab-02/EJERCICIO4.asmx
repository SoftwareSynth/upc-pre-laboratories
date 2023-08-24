<%@ WebService Language="C#" CodeBehind="~/App_Code/ServCitas.cs" Class="ServCitas" %>

using System;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Linq;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
public class ServCitas : System.Web.Services.WebService
{
    public ServCitas()
    {

    }

    [WebMethod]
    public string HelloWorld()
    {
        return "Hello World";
    }

    [WebMethod]
    public String dameCita() 
    {
        String[] citas = {
            "No hay mal que por bien no venga",
            "FRASE DE PRUEBA 2",
            "No por mucho madrugar amanece mas temprano"
        };
        Random random = new Random();
        int numCita = random.Next(0, 3);
        return citas[numCita];
    }

    [WebMethod]
    public String citaPropia(String laCita)
    {
        return ("Esta es tu cita: " + laCita);
    }
}





