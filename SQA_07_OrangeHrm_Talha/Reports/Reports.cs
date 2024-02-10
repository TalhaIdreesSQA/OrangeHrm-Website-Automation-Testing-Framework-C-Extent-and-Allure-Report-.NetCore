using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using MongoDB.Bson.Serialization.Conventions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQA_07_OrangeHrm_Talha
{
    public class Reports : BasePage
    {
        public static ExtentHtmlReporter htmlreporter = new ExtentHtmlReporter(path);
        public static ExtentReports report = new ExtentReports();
        public static ExtentTest parent;
        public static ExtentTest child;
        public static void ParentNode(string Name)
        {
            parent = report.CreateTest(Name);
        }
        public static void ChildNode(string Name)
        {
            child = parent.CreateNode(Name);
        }
        public static void ExtentReportPass(string Filename, string StepDetail)
        {
            BasePage.Screenshot(Filename);
            child.Log(Status.Pass, (StepDetail + " : Passed"), MediaEntityBuilder.CreateScreenCaptureFromPath(path + Filename).Build());
        }
        public static void ExtentReportFail(string Filename, string StepDetail)
        {
            BasePage.Screenshot(Filename);
            child.Log(Status.Fail, (StepDetail + " :Failed"), MediaEntityBuilder.CreateScreenCaptureFromPath(path + Filename).Build());
        }
        public static void Report()
        {
            report.AttachReporter(htmlreporter);
        }
        public static void flush()
        {
            report.Flush();
        }
    }


}
