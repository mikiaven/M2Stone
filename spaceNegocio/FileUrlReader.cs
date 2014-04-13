using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace spaceNegocio
{
    public class FileUrlReader
    {
        public FileUrlReader()
        {

        }

        public void ReadUrlFile()
        {
            var webRequest = WebRequest.Create(@"http://www.minorplanetcenter.net/iau/MPCORB/NEAm00.txt");

            using (var response = webRequest.GetResponse())
            using (var content = response.GetResponseStream())
            using (var reader = new StreamReader(content))
            {
                var strContent = reader.ReadToEnd();
            }
        }
    }
}
