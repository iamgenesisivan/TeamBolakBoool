using System.Web;
using System.Web.Optimization;

namespace SchulerPrototype
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));


            bundles.Add(new ScriptBundle("~/bundles/teacherjs").Include(
                      "~/Content/js/Teacher/classgradingmngt.js",
                      "~/Content/js/Teacher/dashboard.js",
                      "~/Content/js/Teacher/messagescalendar.js",
                      "~/Content/js/Teacher/tclassattendance.js",
                      "~/Content/js/Teacher/tclassprog.js",
                      "~/Content/js/Teacher/tclasssched.js",
                      "~/Content/js/Teacher/teacherlv.js",
                      "~/Content/js/Teacher/dashboard.js",
                      "~/Content/js/Teacher/teachermngt.js",
                      "~/Content/js/Teacher/tlessonplan.js",
                      "~/Content/js/Teacher/tstudentgrades.js",
                      "~/Content/js/Teacher/tstudgradeschool.js",
                      "~/Content/js/Teacher/tstudprog.js",
                      "~/Content/js/Teacher/tstudgradesdeped.js"));

            bundles.Add(new ScriptBundle("~/bundles/securityjs").Include(
                      "~/Content/js/Security/dashboard.js",
                      "~/Content/js/Security/noidhistory.js",
                      "~/Content/js/Security/noidlist.js",
                      "~/Content/js/Security/visitorhistory.js"));



            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/style.css"));

        }
    }
}
