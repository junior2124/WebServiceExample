using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for CalculatorService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class CalculatorService : System.Web.Services.WebService
{

    public CalculatorService()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public decimal Add(decimal x, decimal y)
    {
        return Math.Round(x + y, 2);
    }
    [WebMethod]
    public decimal Sub(decimal x, decimal y)
    {
        return Math.Round(x - y, 2);
    }
    [WebMethod]
    public decimal Mul(decimal x, decimal y)
    {
        return Math.Round(x * y, 2);
    }
    [WebMethod]
    public decimal Div(decimal x, decimal y)
    {
        return Math.Round(x / y, 2);
    }

}
