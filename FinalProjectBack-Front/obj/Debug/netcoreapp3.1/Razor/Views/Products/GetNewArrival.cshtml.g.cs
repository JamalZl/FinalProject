#pragma checksum "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Views\Products\GetNewArrival.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9416a6bc6a88d7fa597b70f0ffde786fae02fc86"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_GetNewArrival), @"mvc.1.0.view", @"/Views/Products/GetNewArrival.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Views\_ViewImports.cshtml"
using FinalProjectBack_Front;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Views\_ViewImports.cshtml"
using FinalProjectBack_Front.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Views\_ViewImports.cshtml"
using FinalProjectBack_Front.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9416a6bc6a88d7fa597b70f0ffde786fae02fc86", @"/Views/Products/GetNewArrival.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05d3603fef94bdb14b3d92d803ead7e2cc6bb707", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_GetNewArrival : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Views\Products\GetNewArrival.cshtml"
  
    ViewData["Title"] = "GetNewArrival";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section id=\"Entrance\">\r\n    <div class=\"row\">\r\n        <h1>\r\n");
#nullable restore
#line 9 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Views\Products\GetNewArrival.cshtml"
             if (Model.ProductByNewArrival.Count == 0)
            {

            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span>New Arrivals</span>\r\n");
#nullable restore
#line 16 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Views\Products\GetNewArrival.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </h1>\r\n    </div>\r\n</section>\r\n");
#nullable restore
#line 20 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Views\Products\GetNewArrival.cshtml"
 if (Model.ProductByNewArrival.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""row justify-content-center align-items-center"" style=""height:214px;"">
        <p style=""display: inline-block; text-align:center; color: rgb(203,3,29);"">
            <span style=""font-size:20px;font-weight:bold;"">
                NOT FOUND
            </span>
        </p>
    </div>
");
#nullable restore
#line 29 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Views\Products\GetNewArrival.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <section id=\"products\">\r\n        <div class=\"container\">\r\n            <div class=\"d-flex justify-content-center\">\r\n            </div>\r\n            <div class=\"row\">\r\n                ");
#nullable restore
#line 37 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Views\Products\GetNewArrival.cshtml"
           Write(await Html.PartialAsync("_ProductPartialView", Model.ProductByNewArrival));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </section>\r\n");
#nullable restore
#line 41 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Views\Products\GetNewArrival.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
