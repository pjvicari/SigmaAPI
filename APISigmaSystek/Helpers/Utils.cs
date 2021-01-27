using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace APISigmaSystek.Helpers
{
    public class Utils
    {
        public static void LogJson(string json, string tipo, string empresa)
        {
            StreamWriter sw = null;
            try
            {
                if (!Directory.Exists("C:\\FEL"))
                {
                    Directory.CreateDirectory("C:\\FEL");
                }
                if (!Directory.Exists("C:\\FEL\\Log"))
                {
                    Directory.CreateDirectory("C:\\FEL\\Log");
                }
                if (!Directory.Exists("C:\\FEL\\Log\\" + empresa))
                {
                    Directory.CreateDirectory("C:\\FEL\\Log\\" + empresa);
                }
                string date = DateTime.Now.ToString("dd-MM-yyyy");
                sw = new StreamWriter("C:\\FEL\\Log\\" + empresa + "\\Json_" + date + ".txt", true);
                sw.WriteLine(DateTime.Now.ToString() + " | " + tipo + " : " + json);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (sw != null)
                {
                    sw.Flush();
                    sw.Dispose();
                    sw.Close();
                }
            }
        }
        
    }
}