using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Data;
using System.IO;
using System.Collections.Generic;
using System.Web.Script.Serialization;

namespace Dec_Becerritos_app
{
    public partial class Graficas : System.Web.UI.Page
    {
        string json_ = "";
        public string jscript = "";
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void GetJson()
        {
            string pag = "http://apisandbox.junar.com/datastreams/invoke/ESTAD-DE-EMPLE-REPUB-DOMIN?auth_key=c8d666dcdf49f825f5edebb6041c52151d3b2bf6";
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(pag);
            request.ContentType = "application/json; charset=utf-8";
            request.Accept = "application/json, text/javascript, */*";
            request.Method = "GET";
            WebResponse response = request.GetResponse();
            Stream stream = response.GetResponseStream();
            string json = "";

            using (StreamReader reader = new StreamReader(stream))
            {
                while (!reader.EndOfStream)
                {
                    json += reader.ReadLine();
                }
            }
            json_ = json;

        }
        protected void json1_click(object sender, EventArgs e)
        {
            GetJson();
            var serializer_ = new JavaScriptSerializer();
            objetos jsonStructure = serializer_.Deserialize<objetos>(json_);
        }
        
        
    }

    

}