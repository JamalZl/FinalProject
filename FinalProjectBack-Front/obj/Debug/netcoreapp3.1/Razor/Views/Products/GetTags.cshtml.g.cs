#pragma checksum "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Views\Products\GetTags.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1b0b782b124ae55e79a9bf185115ecc94407641"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_GetTags), @"mvc.1.0.view", @"/Views/Products/GetTags.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1b0b782b124ae55e79a9bf185115ecc94407641", @"/Views/Products/GetTags.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05d3603fef94bdb14b3d92d803ead7e2cc6bb707", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_GetTags : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Views\Products\GetTags.cshtml"
  
    ViewData["Title"] = "GetTags";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section id=""Entrance"">
    <div class=""row productEntranceRow"">
        <div class=""productImage-Content"">
            <div class=""productImage""><img src=""https://m.media-amazon.com/images/S/aplus-media/vc/932f56fe-0014-43a5-aa27-505cebe9b99d.__CR0,0,1464,600_PT0_SX1464_V1___.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 346, "\"", 352, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n            <div class=\"productContent\">\r\n                <span>\r\n");
#nullable restore
#line 11 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Views\Products\GetTags.cshtml"
                     if (Model.ProductByTags.Count == 0)
                    {

                    }
                    else
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Views\Products\GetTags.cshtml"
                   Write(Model.ProductByTags.Where(p => p.Tag.Name == Model.ProductByTags.FirstOrDefault().Tag.Name).FirstOrDefault().Tag.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>\r\n                            (");
#nullable restore
#line 19 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Views\Products\GetTags.cshtml"
                        Write(Model.ProductByTags.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n                        </span>\r\n");
#nullable restore
#line 21 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Views\Products\GetTags.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </span>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
#nullable restore
#line 28 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Views\Products\GetTags.cshtml"
 if (Model.ProductByTags.Count == 0)
{

}
else
{
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Views\Products\GetTags.cshtml"
 if (Model.ProductByTags.Count == 0)
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
#line 44 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Views\Products\GetTags.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <section id=\"products\">\r\n        <div class=\"container\">\r\n            <div class=\"d-flex justify-content-center\">\r\n            </div>\r\n            <div class=\"row\">\r\n                ");
#nullable restore
#line 52 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Views\Products\GetTags.cshtml"
           Write(await Html.PartialAsync("_ProductPartialView", Model.ProductByTags));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </section>\r\n");
#nullable restore
#line 56 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Views\Products\GetTags.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
