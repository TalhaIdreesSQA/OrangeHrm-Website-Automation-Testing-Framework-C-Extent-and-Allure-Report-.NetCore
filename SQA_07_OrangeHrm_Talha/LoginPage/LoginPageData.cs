using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQA_07_OrangeHrm_Talha
{
    public class LoginPageData : BasePage
    {
        public static string filename = "LoginPageJ.json";
        public static JObject? LoginPageJ = ReadJson(@"JsonFile\LoginPageJ.json".ToString());
        public static string Url = LoginPageJ.SelectToken("url").Value<string>();
        public static string Username = LoginPageJ.SelectToken("username").Value<string>();
        public static string Password = LoginPageJ.SelectToken("password").Value<string>();
        public static string Expected = LoginPageJ.SelectToken("expected").Value<string>();
        public static JObject ReadJson(string filename)
        {
            string myJsonString = File.ReadAllText(@"..\\..\\..\\" + filename);
            var myOject = JObject.Parse(myJsonString);
            return myOject;
        }
    }
}
