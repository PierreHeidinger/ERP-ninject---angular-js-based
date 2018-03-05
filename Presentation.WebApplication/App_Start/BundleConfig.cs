using System.Web;
using System.Web.Optimization;

namespace Presentation.WebApplication
{
    public class BundleConfig
    {

        public static void RegisterBundles(BundleCollection bundles)
        {
            #region Application
            //Bootstrap CSS
            bundles.Add(new StyleBundle("~/bundles/bootstrap").Include(
                      "~/Modules/bootstrap/css/bootstrap.min.css"));
            //Theme App CSS
            bundles.Add(new StyleBundle("~/bundles/theme").Include(
                      "~/Modules/theme/css/style.css",
                      "~/Modules/theme/css/font-awesome.css",
                      "~/Modules/theme/css/icon-font.min.css",
                      "~/Modules/theme/css/animate.css"));
            //Datatable Css
            bundles.Add(new StyleBundle("~/bundles/dynatable").Include(
                      "~/Modules/datatable/css/datatable.css"));

            //Jquery
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                                  "~/Modules/jquery/jquery-3.3.1.min.js"));

            //Bootstrap JS
            bundles.Add(new ScriptBundle("~/bundles/bootstrapjs").Include(
                      "~/Modules/bootstrap/js/bootstrap.min.js"));
            //Theme App Js
            bundles.Add(new ScriptBundle("~/bundles/themejs").Include(
                "~/Modules/theme/js/jquery.nicescroll.js",
                "~/Modules/theme/js/scripts.js"
                ));
            //Datatable js
            bundles.Add(new ScriptBundle("~/bundles/dynatablejs").Include(
                                  "~/Modules/datatable/js/datatable.js"));



            //Angular js
            bundles.Add(new ScriptBundle("~/bundles/angularjs").Include(
                                  "~/Modules/angular/angular.min.js",
                                  "~/Modules/angular-route/angular-route.min.js",
                                  "~/Scripts/app.js"));
            #endregion

            #region Angular Application

            //Products
            bundles.Add(new ScriptBundle("~/bundles/Productjs").Include(
                                  "~/Scripts/_controllers/ProductController.js",
                                  "~/Scripts/_services/ProductService.js",
                                  "~/Scripts/_factorys/ProductFactory.js",
                                  "~/Scripts/_directives/ProductDirective.js"));

            #endregion

        }
    }
}
