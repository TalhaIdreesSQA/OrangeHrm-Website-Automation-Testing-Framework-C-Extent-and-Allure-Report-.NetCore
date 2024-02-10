using Newtonsoft.Json.Linq;
using SQA_07_OrangeHrm_Talha;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQA_07_OrangeHrm_Talha
{
    public class AdminSearchData : BasePage
    {
        public static string filename = "AdminSearchJ.json";
        public static JObject? AdminSearchJ = ReadJson(@"JsonFile\AdminSearchJ.json".ToString());
        public static string Username = AdminSearchJ.SelectToken("username").Value<string>(); 
        public static string EditUsername = AdminSearchJ.SelectToken("editusername").Value<string>(); 

        public static JObject ReadJson(string filename)
        {
            string myjsonstring = File.ReadAllText(@"..\\..\\..\\" + filename);
            var myJObjct = JObject.Parse(myjsonstring);
            return myJObjct;
        }
    }
}
