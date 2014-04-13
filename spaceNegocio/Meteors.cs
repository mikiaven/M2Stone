using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;


namespace spaceNegocio
{
    public class Meteors
    {
        private DataTable objData;
        private CnxData objCnx;


        public Meteors()
        {
            this.objData = new DataTable();
            this.objCnx = new CnxData();            
        }

        public DataTable getMeteors()
        {
            this.objData = CnxData.GetData("select * from v_Meteors");
            return this.objData;
        }

        public DataTable getNEAs()
        {
            this.objData = CnxData.GetData("select n.*, (select COUNT(*) from NEAM) total from NEAM n");
            return this.objData;
        }

        public DataTable getNEA_MayorMagnitud()
        {
            this.objData = CnxData.GetData("select top 10 * from NEAM order by AbsoluteMagnitudeH desc");
            return this.objData;            
        }

        public DataTable getPHA()
        {
            this.objData = CnxData.GetData("select n.*, (select COUNT(*) from PHA) total from PHA n");
            return this.objData;
        }

        public DataTable getPHA_MayorMagnitud()
        {
            this.objData = CnxData.GetData("select top 10 * from PHA order by AbsoluteMagnitudeH desc");
            return this.objData;
        }

        public DataTable getMeteorsByContinent()
        {
            string sSQl = @"select Continent, COUNT(*) impacts
                            from dbo.Meteors
                            group by Continent
                            order by COUNT(*) desc";
            this.objData = CnxData.GetData(sSQl);
            return this.objData;
        }

        
    }
}
