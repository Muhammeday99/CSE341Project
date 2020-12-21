using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using projedeneme2.InputControllers;

namespace projedeneme2.InputControllers
{
    public class encryption
    {
        static public string EnryptString(string strEncrypted)
        {
            byte[] b = System.Text.ASCIIEncoding.ASCII.GetBytes(strEncrypted);
            string encrypted = Convert.ToBase64String(b);
            return encrypted;
        }
        static public string DecryptString(string strEncrypted)
        {
            byte[] b = System.Text.ASCIIEncoding.ASCII.GetBytes(strEncrypted);
            string encrypted = Convert.ToBase64String(b);
            return encrypted;
        }

        // Normally this decryptString function must be use but ıt doesnt work exactly
        // public string DecryptString(string encrString)
        //{
        //byte[] b;
        //string decrypted;
        //try
        //{
        //  b = Convert.FromBase64String(encrString);
        //   decrypted = System.Text.ASCIIEncoding.ASCII.GetString(b);
        //}
        //catch (FormatException fe)
        //{
        //   decrypted = "";
        //  }
        //   return decrypted;
        //}
    }
}