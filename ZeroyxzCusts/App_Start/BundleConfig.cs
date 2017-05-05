using System.Web;
using System.Web.Optimization;

namespace ZeroyxzCusts
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Client/Scripts/Vendor/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Client/Scripts/Vendor/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Client/Scripts/Vendor/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Client/Scripts/Vendor/bootstrap.js",
                      "~/Client/Scripts/Vendor/respond.js"));

            bundles.Add(new StyleBundle("~/Client/Stylesheets").Include(
                      "~/Client/Stylesheets/bootstrap.css",
                      "~/Client/Stylesheets/customers.css",
                      "~/Client/Stylesheets/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/knockout").Include(
                "~/Client/Scripts/Vendor/knockout-{version}.js"));

        }
    }
}
