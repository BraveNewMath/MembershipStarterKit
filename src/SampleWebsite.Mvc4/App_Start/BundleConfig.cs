using System.Web.Optimization;

namespace SampleWebsite.Mvc4
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css",
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css"));

            AddMyBundle(bundles);
        }

        private static void AddMyBundle(BundleCollection bundles)
        {
            //<script src="Scripts/jquery-2.1.3.min.js"></script>
            //<script src="Scripts/knockout-3.2.0.js"></script>
            //<script src="Scripts/knockout.mapping-latest.js"></script>
            //<script src="Scripts/bootstrap.min.js"></script>
            //<script src="Scripts/moment.min.js"></script>
            //<link href="Content/bootstrap.css" rel="stylesheet" />
            //<link href="Content/bootstrap-theme.css" rel="stylesheet" />

            //<script src="js/donors.js"></script>
            bundles.Add(new ScriptBundle("~/bundles/donors").Include(
                        "~/Scripts/jquery-2.1.3.min.js",
                        "~/Scripts/knockout-3.2.0.js",
                        "~/Scripts/knockout.mapping-latest.js",
                        "~/Scripts/bootstrap.min.js",
                        "~/Scripts/moment.min.js",
                        "~/js/donors.js"
                        ));

        }
    }
}