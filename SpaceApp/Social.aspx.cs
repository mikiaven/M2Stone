using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;
using System.Text.RegularExpressions;

namespace SpaceApp
{
    public partial class Meteors : System.Web.UI.Page
    {
        private DataTable dtlMeteors;
        private spaceWS.spaceWS wsSpace;

        public Meteors()
        {
            this.wsSpace = new spaceWS.spaceWS();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }


        public string getMeteorsHtmlTable()
        {
            this.dtlMeteors = this.wsSpace.GetMeteors();

            StringBuilder sMeteors = new StringBuilder();

            sMeteors.Append("<table id=\"data\"> \n");
            sMeteors.Append("<tfoot> \n");
            sMeteors.Append("<tr> \n");
            for (int i = 0; i < this.dtlMeteors.Rows.Count; i++)
            {
                sMeteors.Append("<th>" + this.dtlMeteors.Rows[i]["CraterName"].ToString() + "</th> \n");
            }
            sMeteors.Append("</tr> \n");
            sMeteors.Append("</tfoot> \n");
            sMeteors.Append("<tbody> \n");
            sMeteors.Append("<tr> \n");
            for (int i = 0; i < this.dtlMeteors.Rows.Count; i++)
            {
                sMeteors.Append("<td>" + this.dtlMeteors.Rows[i]["Location"].ToString() + "</td> \n");
            }
            sMeteors.Append("</tr> \n");
            sMeteors.Append("</tbody> \n");
            sMeteors.Append("<thead> \n");
            sMeteors.Append("<tr> \n");
            for (int i = 0; i < this.dtlMeteors.Rows.Count; i++)
            {
                sMeteors.Append("<th>" + this.dtlMeteors.Rows[i]["Latitude3"].ToString() + "," + this.dtlMeteors.Rows[i]["Longitude3"].ToString() + "</th> \n");
            }
            sMeteors.Append("</tr> \n");
            sMeteors.Append("</thead> \n");
            sMeteors.Append("</table> \n");
            sMeteors.Append(@"      <div id=""urls"">");
            for (int i = 0; i < this.dtlMeteors.Rows.Count; i++)
            {

                sMeteors.Append(@"<span>http://www.passc.net/EarthImpactDatabase/" + this.dtlMeteors.Rows[i]["page"].ToString() + @".html </span>");
                            
            }
            sMeteors.Append(@"</div>");
            return sMeteors.ToString();
        }
    }
}