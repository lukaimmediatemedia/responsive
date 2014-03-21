using System.Web;
using System.Web.Optimization;

namespace responsive
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            //SASS
            var sass = new StyleBundle("~/content/sass");
            sass.Include("~/Content/sass/main.css");
            bundles.Add(sass);

            //jQuery
            var jQuery = new ScriptBundle("~/bundles/jquery");
            jQuery.Include("~/Scripts/jquery/jquery-{version}.js");
            bundles.Add(jQuery);

            //MODERNIZR
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr/modernizr-*"));
        }
    }
}

// For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725