using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VesteBem
{
	public partial class Teste : System.Web.UI.Page
	{

		protected void Page_Load(object sender, EventArgs e)
		{
            string Paths = Environment.GetEnvironmentVariable("temp");

            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(Paths))
                {
                    File.Delete(Paths);
                }

                // Create a new file     
                using (FileStream fs = File.Create(Paths))
                {
                    var json = JsonConvert.SerializeObject("[]");
                    json = json.Replace("\"", "");
                    File.WriteAllText(Environment.CurrentDirectory + "\\Paths.json", json);
                }

                // Open the stream and read it back.    
                using (StreamReader sr = File.OpenText(Paths))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }


	}
}