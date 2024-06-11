using appInvictusStyle.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appInvictusStyle.Layers.Servicio
{
    public class ServiceProvincia
    {
        public static List<ProvinciaJson> GetAllProvince()
        {
            HttpClient client = new HttpClient();
            string path = "";
            string json = "";
            try
            {
                List<ProvinciaJson> provincia = new List<ProvinciaJson>();

                path = @"https://api.pruebayerror.com/locaciones/v1/provincias";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(path);
                request.Method = "GET";
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader sr = new StreamReader(response.GetResponseStream());
                json = sr.ReadToEnd();

                RootProvincia root = JSONGenericObject<RootProvincia>.JSonToObject(json);

                foreach (var item in root.Data)
                {
                    provincia.Add(item);
                }


                return provincia;

            }
            catch (Exception er)
            {

                MessageBox.Show("Error al obtener las provincias: " + er.Message);
                throw;
            }
        }
    }
}
