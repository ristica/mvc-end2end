﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Demo.Client;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Product/Delete.cshtml")]
    public partial class _Views_Product_Delete_cshtml : System.Web.Mvc.WebViewPage<Demo.ViewModels.ProductViewModel>
    {
        public _Views_Product_Delete_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Product\Delete.cshtml"
  
    ViewBag.Title = "Delete Product";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<fieldset");

WriteLiteral(" style=\"margin-top: 50px;\"");

WriteLiteral(">\r\n    <legend>Delete product</legend>\r\n\r\n    <h4");

WriteLiteral(" id=\"question\"");

WriteLiteral(">");

            
            #line 10 "..\..\Views\Product\Delete.cshtml"
                 Write(ViewBag.Question);

            
            #line default
            #line hidden
WriteLiteral("</h4>\r\n    <div>\r\n        <dl");

WriteLiteral(" class=\"dl-horizontal\"");

WriteLiteral(">\r\n            <dt>\r\n");

WriteLiteral("                ");

            
            #line 14 "..\..\Views\Product\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductId));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </dt>\r\n\r\n            <dd");

WriteLiteral(" id=\"productId\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 18 "..\..\Views\Product\Delete.cshtml"
           Write(Html.DisplayFor(model => model.ProductId));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </dd>\r\n\r\n            <dt>\r\n");

WriteLiteral("                ");

            
            #line 22 "..\..\Views\Product\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductName));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </dt>\r\n\r\n            <dd");

WriteLiteral(" id=\"productName\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 26 "..\..\Views\Product\Delete.cshtml"
           Write(Html.DisplayFor(model => model.ProductName));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </dd>\r\n\r\n            <dt>\r\n");

WriteLiteral("                ");

            
            #line 30 "..\..\Views\Product\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductDescription));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </dt>\r\n\r\n            <dd");

WriteLiteral(" id=\"productDescription\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 34 "..\..\Views\Product\Delete.cshtml"
           Write(Html.DisplayFor(model => model.ProductDescription));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </dd>\r\n\r\n            <dt>\r\n");

WriteLiteral("                ");

            
            #line 38 "..\..\Views\Product\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductPrice));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </dt>\r\n\r\n            <dd");

WriteLiteral(" id=\"productPrice\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 42 "..\..\Views\Product\Delete.cshtml"
           Write(Html.DisplayFor(model => model.ProductPrice));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </dd>\r\n\r\n        </dl>\r\n\r\n");

            
            #line 47 "..\..\Views\Product\Delete.cshtml"
        
            
            #line default
            #line hidden
            
            #line 47 "..\..\Views\Product\Delete.cshtml"
         using (Html.BeginForm())
        {
            
            
            #line default
            #line hidden
            
            #line 49 "..\..\Views\Product\Delete.cshtml"
       Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 49 "..\..\Views\Product\Delete.cshtml"
                                    


            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"form-actions no-color\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" value=\"Delete\"");

WriteLiteral(" id=\"btnDelete\"");

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(" /> |\r\n");

WriteLiteral("                ");

            
            #line 53 "..\..\Views\Product\Delete.cshtml"
           Write(Html.ActionLink("Back to List", "List"));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n");

            
            #line 55 "..\..\Views\Product\Delete.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n\r\n</fieldset>\r\n");

        }
    }
}
#pragma warning restore 1591
