using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Text;
using System.Net;

namespace WebClient
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                TextBox3.Text = "";
                string content;
                string Method = txtMetodo.Text.Trim();
                string uri = txtUrl.Text.Trim();

                HttpWebRequest req = WebRequest.Create(uri) as HttpWebRequest;
                req.KeepAlive = false;
                req.Method = Method.ToUpper();

                if (("POST,PUT").Split(',').Contains(Method.ToUpper()))
                {
                    string FilePath = "D:\\Pruebas\\prueba.txt";
                    content = (File.OpenText(@FilePath)).ReadToEnd();
                    //content = txtData.Text;

                    byte[] buffer = Encoding.ASCII.GetBytes(content);
                    req.ContentLength = buffer.Length;
                    req.ContentType = "text/xml";
                    Stream PostData = req.GetRequestStream();
                    PostData.Write(buffer, 0, buffer.Length);
                    PostData.Close();

                }

                HttpWebResponse resp = req.GetResponse() as HttpWebResponse;


                Encoding enc = System.Text.Encoding.GetEncoding(1252);
                StreamReader loResponseStream = new StreamReader(resp.GetResponseStream(), enc);

                string Response = loResponseStream.ReadToEnd();

                loResponseStream.Close();
                resp.Close();
                TextBox3.Text = Response;
            }
            catch (Exception ex)
            {
                TextBox3.Text = ex.Message.ToString();
            }
        }
    }
}
