using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQA_07_OrangeHrm_Talha
{
    public class PIMData : BasePage
    {
        public static string filename = "Pim.json";
        public static JObject? AdminJ = ReadJson(@"JsonFile\Pim.json".ToString());
        public static string EmpFirstname = AdminJ.SelectToken("empfirstname").Value<string>();
        public static string EmpMiddlename = AdminJ.SelectToken("empmiddlename").Value<string>();
        public static string EmpLastname = AdminJ.SelectToken("emplastname").Value<string>();
        public static string Empid = AdminJ.SelectToken("EmpId").Value<string>();


        public static JObject ReadJson(string filename)
        {
            string myJsonString = File.ReadAllText(@"..\\..\\..\\" + filename);
            var myJObject = JObject.Parse(myJsonString);
            return myJObject;
        }
    }
}
