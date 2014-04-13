using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using spaceNegocio;
using System.Data;

namespace WSpaceApp
{
    /// <summary>
    /// Summary description for spaceWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class spaceWS : System.Web.Services.WebService
    {
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public DataTable GetMeteors()
        {
            DataTable dtlResult = new DataTable("Result");
            spaceNegocio.Meteors objMeteors = new Meteors();
            dtlResult = objMeteors.getMeteors();
            return dtlResult;
        }

        [WebMethod]
        public DataTable GetNEA()
        {
            DataTable dtlResult = new DataTable("Result");
            spaceNegocio.Meteors objMeteors = new Meteors();
            dtlResult = objMeteors.getNEAs();
            return dtlResult;
        }

        [WebMethod]
        public DataTable GetPHA()
        {
            DataTable dtlResult = new DataTable("Result");
            spaceNegocio.Meteors objMeteors = new Meteors();
            dtlResult = objMeteors.getPHA();
            return dtlResult;
        }

        [WebMethod]
        public DataTable getNEA_MayorMagnitud()
        {
            DataTable dtlResult = new DataTable("Result");
            spaceNegocio.Meteors objMeteors = new Meteors();
            dtlResult = objMeteors.getNEA_MayorMagnitud();
            return dtlResult;
        }

        [WebMethod]
        public DataTable getPHA_MayorMagnitud()
        {
            DataTable dtlResult = new DataTable("Result");
            spaceNegocio.Meteors objMeteors = new Meteors();
            dtlResult = objMeteors.getPHA_MayorMagnitud();
            return dtlResult;
        }

        [WebMethod]
        public DataTable getMeteorsByContinent()
        {
            DataTable dtlResult = new DataTable("Result");
            spaceNegocio.Meteors objMeteors = new Meteors();
            dtlResult = objMeteors.getMeteorsByContinent();
            return dtlResult;
        }
    }
}
