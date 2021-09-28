using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace time
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTime_Click(object sender, EventArgs e)
        {
            lbl_servertime.Text = ServerTime.getServerTime().ToLocalTime().ToString();
        }
        internal class ServerTime
        {
            private static string[] servers = { "132.163.96.1", "132.163.96.2", "129.6.15.28", "129.6.15.29" };


            public static DateTime getServerTime()
            {
                foreach (string server in servers)
                {
                    DateTime result = connectServer(server);
                    if (result > DateTime.MinValue)
                        return result;
                }
                return DateTime.MinValue;
            }

            private static DateTime connectServer(string host)
            {
                string time;
                try
                {
                    StreamReader read = new StreamReader(new TcpClient(host, 13).GetStream());
                    DateTime systemTime = DateTime.UtcNow;
                    time = read.ReadToEnd();
                }
                catch (Exception)
                {
                    return DateTime.MinValue;
                }

                if (time.Substring(38, 9) != "UTC(NIST)") return DateTime.MinValue;
                if (time.Substring(30, 1) != "0") return DateTime.MinValue;

                int jd = int.Parse(time.Substring(1, 5));
                int yr = int.Parse(time.Substring(7, 2));
                int mo = int.Parse(time.Substring(10, 2));
                int dy = int.Parse(time.Substring(13, 2));
                int hr = int.Parse(time.Substring(16, 2));
                int mm = int.Parse(time.Substring(19, 2));
                int sc = int.Parse(time.Substring(22, 2));


                if (jd < 15020) return DateTime.MinValue; //trước năm 1900

                if (jd > 51544)
                    yr += 2000;
                else
                    yr += 1900;

                return new DateTime(yr, mo, dy, hr, mm, sc);
            }
        }
    }
}
