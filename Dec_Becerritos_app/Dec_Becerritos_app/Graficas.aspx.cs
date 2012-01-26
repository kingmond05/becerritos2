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
        protected void Grafica(objetos x)
        {
            string script, script2, script3;
            script = "google.load('visualization', '1', { packages: ['corechart'] }); google.setOnLoadCallback(drawChart1); function drawChart1() { var data = new google.visualization.DataTable(); data.addColumn('string', 'Día'); data.addColumn('number', 'Promedio duración llamadas (segundos)');";
            script2 = "data.addRows(" + dias.Length + ");";
            int cont = 0;
            foreach (sp_GetREGISTRO_USUARIOResult aux in dias)
            {
                script2 += "data.setValue(" + cont + ",0, '" + aux.FECHA + "'); ";
                script2 += "data.setValue(" + cont + ", 1, " + aux.SUMA + "); ";
                cont++;
            }
            script3 = "var chart = new google.visualization.ColumnChart(document.getElementById('divRegistroDiario_2')); chart.draw(data, { width: 520, height: 350,legend:'bottom' ,hAxis: {direction:-1} });}";
            jscript += script + script2 + script3;
        
        }
    }

    

}