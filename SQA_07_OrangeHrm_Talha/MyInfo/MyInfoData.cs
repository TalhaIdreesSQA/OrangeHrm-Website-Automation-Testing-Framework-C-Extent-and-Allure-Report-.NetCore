using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQA_07_OrangeHrm_Talha
{
    public class MyInfoData : BasePage
    {
        public static string filename = "myInfoPage.json";
        public static JObject? myInfoPage = ReadJson(@"JsonFile\myInfoPage.json".ToString());
        public static string EmpFirst = myInfoPage.SelectToken("empfirstname").Value<string>();
        public static string EmpMiddle = myInfoPage.SelectToken("empmiddlename").Value<string>();
        public static string EmpLast = myInfoPage.SelectToken("emplastname").Value<string>();


        public static JObject ReadJson(string filename)
        {
            string myJsonString = File.ReadAllText(@"..\\..\\..\\" + filename);
            var myJObject = JObject.Parse(myJsonString);
            return myJObject;
        }
    }
}
