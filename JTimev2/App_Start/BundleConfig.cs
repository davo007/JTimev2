﻿using System.Web;
using System.Web.Optimization;

namespace JTimev2
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/lib").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/bootstrap.js",
                        "~/scripts/bootbox.js",
                        "~/Scripts/respond.js",
                        "~/scripts/pdfmake/pdfmake.min.js",
                      "~/scripts/pdfmake/vfs_fonts.js",
                      "~/content/selectize/js/standalone/selectize.js",
                      "~/scripts/datatables/jquery.datatables.js",
                      "~/scripts/datatables/datatables.bootstrap.js",
                      "~/scripts/datatables/datatables.buttons.js",
                      "~/scripts/datatables/datatables.select.js",
                      "~/scripts/datatables/buttons.html5.min.js",
                      "~/scripts/datatables/buttons.print.js",
                      "~/scripts/datatableseditor/datatables.editor.js",
                      "~/scripts/jquery.mask.js",
                      "~/scripts/datatableseditor/editor.mask.js",
                      "~/scripts/datatableseditor/editor.selectize.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));
                      

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/content/datatables/css/datatables.bootstrap.css",
                      "~/content/datatables/css/jquery.datatables.css",
                      "~/content/datatables/css/buttons.datatables.css",
                      "~/content/datatables/css/select.datatables.css",
                      "~/content/selectize/template-selectize.css",
                      "~/content/datatableseditor/editor.datatables.css",
                      "~/content/datatableseditor/editor.selectize.css",
                      "~/Content/site.css"));
        }
    }
}
