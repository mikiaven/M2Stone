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
    public partial class MAS : System.Web.UI.Page
    {
        private DataTable dtlMeteors;
        private spaceWS.spaceWS wsSpace;

        public MAS()
        {
            this.wsSpace = new spaceWS.spaceWS();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }


        public string getMeteorsHtmlTable()
        {
            this.dtlMeteors = this.wsSpace.getMeteorsByContinent();

            StringBuilder sMeteors = new StringBuilder();

            sMeteors.Append("<section class=\"main\"> \n");
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
            
            return sMeteors.ToString();
        }
    }
}