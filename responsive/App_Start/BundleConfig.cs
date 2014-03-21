using System.Web;
using System.Web.Optimization;

namespace responsive
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/sass/main.css"));

        }
    }
}

// For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725