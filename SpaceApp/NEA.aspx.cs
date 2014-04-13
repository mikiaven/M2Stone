using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;

namespace SpaceApp
{
    public partial class NEA : System.Web.UI.Page
    {
        private DataTable dtlMeteors;
        private spaceWS.spaceWS wsSpace;

        public NEA()
        {
            this.wsSpace = new spaceWS.spaceWS();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }


        public string getMeteorsHtmlTable()
        {
            this.dtlMeteors = this.wsSpace.getNEA_MayorMagnitud();

            StringBuilder sMeteors = new StringBuilder();

            for (int i = 1; i <= this.dtlMeteors.Rows.Count; i++)
            {
                sMeteors.Append("<img  id=\"Foto"+ i +"\" class=\"cajafoto\" src=\"asteroids/"+ i +".png\" width=\"2000\" height=\"2000\"/> \n");
                sMeteors.Append("<div id=Descripcion" + i +" class=\"cajafuera descripcion\"><h1> \n");
                sMeteors.Append(this.dtlMeteors.Rows[i-1]["Designation"].ToString());
                sMeteors.Append("</h1><table><tr>");
                sMeteors.Append("<td><img src=\"rings1.png\" width=\"35\"/></td><td class=\"red\">Magnitud: <span>" + this.dtlMeteors.Rows[i-1]["AbsoluteMagnitudeH"].ToString() + "</span> </td>");
                sMeteors.Append("</tr><tr><td><img src=\"satellite.png\" width=\"35\"/></td><td class=\"green\">Observaciones: <span>" + this.dtlMeteors.Rows[i-1]["NumberofObservations"].ToString() + "</span></td>");
                sMeteors.Append(@"</tr><tr><td><img src=""time.png"" width=""30""/></td><td class=""blue"">Ultima Obs.: <span>" + this.dtlMeteors.Rows[i-1]["DateoflastObservation"].ToString() + "</span></td>");
                sMeteors.Append("</tr></table></div>");
            }
            return sMeteors.ToString();
        }
    }
}