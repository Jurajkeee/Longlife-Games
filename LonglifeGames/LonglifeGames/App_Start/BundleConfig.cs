using System;
using System.Web;
using System.Web.Optimization;


    public class BundleConfig
    {
       public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundle/css").Include("~/Views/Css/anima.css", "~/Views/Css/normalize.css", "~/Views/Css/stylesheet.css"));

            bundles.Add(new StyleBundle("~/bundle/bootstrap/css").Include("~/Views/Bootstrap/css/bootstrap-grid.css"));

            bundles.Add(new ScriptBundle("~/bundle/js").Include("~/Views/JS/JQuery.js", "~/Views/JS/Custom.js"));

            BundleTable.EnableOptimizations = true;
        }
    }

