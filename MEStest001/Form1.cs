using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.IO;
using System.Management;
using System.Text.RegularExpressions;
using System.Threading;
using System.Net;
using System.Diagnostics;

namespace MEStest001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tb_url.Text = "http://172.17.32.29:5611/Bobcat/sfc_response.aspx";

            dataTB.Text = "c=QUERY_RECORD_PANEL&panel_sn=123&StationID=qwa&GET_SN=0&cmd=QUERY_PANEL_LOCATION";
        }

        private string WebRequst(string url, string content,string method,ref string error)
        {
            string result = "";
            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
                req.Timeout = 5000;
                req.Method = method;
                req.ContentType = "application/x-www-form-urlencoded";

                #region 添加Post 参数
                byte[] data = Encoding.UTF8.GetBytes(content);
                req.ContentLength = data.Length;
                using (Stream reqStream = req.GetRequestStream())
                {
                    reqStream.Write(data, 0, data.Length);
                    reqStream.Close();
                }
                #endregion

                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
                Stream stream = resp.GetResponseStream();
                //获取响应内容
                using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                {
                    result = reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                error = ex.ToString();
            }
            //调试输出
            Console.WriteLine("Info:POST result:" + result);
            return result;
        }

        private void btn_request_Click(object sender, EventArgs e)
        {
            lb_status.BackColor = Color.Yellow;
            lb_status.Text = "Request...";

            msgTB.Text = string.Format("[{0}]:{1}\r\n", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss:fff"),"Request...");

            string str_URL = tb_url.Text;
            string str_DATA= dataTB.Text;
            if (str_URL == "" || str_DATA == "")
            {
                MessageBox.Show("URL or DATA empty error!");
                return;
            }
            string method = "POST";
            if (rb_GET.Checked) method = "GET";
            string error = "";
            string mesMsg = WebRequst(str_URL, str_DATA,method,ref error);
            if(error != "")
            {
                lb_status.BackColor = Color.Red;
                lb_status.Text = "Error.";
            }
            else
            {
                lb_status.BackColor = Color.Green;
                lb_status.Text = "Done.";
            }
            Console.WriteLine(error+mesMsg );
            msgTB.Text += string.Format("[{0}]:{1}", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss:fff"), error + mesMsg); 
        }
    }
}
