#pragma checksum "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Views\Products\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26c828333690f2d1682582c6c6afcbe857dbd90e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Details), @"mvc.1.0.view", @"/Views/Products/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26c828333690f2d1682582c6c6afcbe857dbd90e", @"/Views/Products/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05d3603fef94bdb14b3d92d803ead7e2cc6bb707", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/homeowlcarousel/owl.carousel.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/homeowlcarousel/owl.theme.default.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-lg-4 col-md-12"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/homeowlcarousel/owl.carousel.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/Js/details.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Views\Products\Details.cshtml"
   ViewData["Title"] = "Details";

    

#line default
#line hidden
#nullable disable
            DefineSection("CSS", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "26c828333690f2d1682582c6c6afcbe857dbd90e6874", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "26c828333690f2d1682582c6c6afcbe857dbd90e8051", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
            }
            );
            WriteLiteral("\n<section id=\"details\">\n    <div class=\"container\">\n        <div class=\"row\">\n            <div class=\"images col-lg-6 col-md-6\">\n                <div class=\"row detailsRowBigImage\">\n                    <div class=\"bigImage\">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "26c828333690f2d1682582c6c6afcbe857dbd90e9550", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 500, "~/assets/images/", 500, 16, true);
#nullable restore
#line 16 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Views\Products\Details.cshtml"
AddHtmlAttributeValue("", 516, Model.Product.ProductImages.FirstOrDefault().Image, 516, 51, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    </div>\n                </div>\n                <div class=\"row detailsRowSmallImage\">\n                    <div class=\"smallImages\">\n");
#nullable restore
#line 22 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Views\Products\Details.cshtml"
                         foreach (var img in Model.Product.ProductImages)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"image\">\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "26c828333690f2d1682582c6c6afcbe857dbd90e11731", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 947, "~/assets/images/", 947, 16, true);
#nullable restore
#line 25 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Views\Products\Details.cshtml"
AddHtmlAttributeValue("", 963, img.Image, 963, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            </div>\n");
#nullable restore
#line 28 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Views\Products\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n                </div>\n            </div>\n            <div class=\"info col-lg-6 col-md-6\">\n                <div class=\"row titleRow\">\n                    <div class=\"title\">\n                        <span>");
#nullable restore
#line 36 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Views\Products\Details.cshtml"
                         Write(Model.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                    </div>\n                </div>\n                <div class=\"row priceRow\">\n                    <ul>\n                        <li>\n                            <span class=\"price\">$ ");
#nullable restore
#line 42 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Views\Products\Details.cshtml"
                                             Write(Model.Product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                        </li>\n");
#nullable restore
#line 44 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Views\Products\Details.cshtml"
                         if (Model.Product.InStock)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li><span class=\"in-outStock\">In Stock</span></li>\r\n");
#nullable restore
#line 47 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Views\Products\Details.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li><span class=\"in-outStock\" style=\"color: rgb(203, 3, 29);\">Out Of Stock</span></li>\r\n");
#nullable restore
#line 51 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Views\Products\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\n                </div>\n                <div class=\"row reviewRow\">\n                    <a");
            BeginWriteAttribute("href", " href=\"", 2096, "\"", 2103, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""reviews"">
                        <span class=""reviewIcons"">
                            <span class=""fa-regular fa-star""></span>
                            <span class=""fa-regular fa-star""></span>
                            <span class=""fa-regular fa-star""></span>
                            <span class=""fa-regular fa-star""></span>
                            <span class=""fa-regular fa-star""></span>
                        </span>
                        <span class=""reviewText"">No rewievs</span>
                    </a>
                </div>
                <div class=""row descRow"">
");
#nullable restore
#line 67 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Views\Products\Details.cshtml"
                     if (Model.Product.Description.Length <= 190)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>\n                            ");
#nullable restore
#line 70 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Views\Products\Details.cshtml"
                       Write(Model.Product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </p>\n");
#nullable restore
#line 72 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Views\Products\Details.cshtml"
                    }
                    else if(Model.Product.Description.Length >= 190)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>\n                            ");
#nullable restore
#line 76 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Views\Products\Details.cshtml"
                       Write(Model.Product.Description.Substring(0, 190));

#line default
#line hidden
#nullable disable
            WriteLiteral("...\n                        </p>\r\n");
#nullable restore
#line 78 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Views\Products\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\n                <div class=\"row colorRow\">\n                    <p class=\"colorVal\">COLOR: <span></span></p>\n                    <ul class=\"color\">\n\n");
#nullable restore
#line 84 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Views\Products\Details.cshtml"
                         foreach (var color in Model.Product.ProductColors)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                             <li class=\"colorLi\" data-value=\"");
#nullable restore
#line 86 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Views\Products\Details.cshtml"
                                                        Write(color.Color.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\n                                <a");
            BeginWriteAttribute("style", " style=\"", 3569, "\"", 3614, 3);
            WriteAttributeValue("", 3577, "background-color:", 3577, 17, true);
#nullable restore
#line 87 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Views\Products\Details.cshtml"
WriteAttributeValue(" ", 3594, color.Color.Value, 3595, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3613, ";", 3613, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 3615, "\"", 3622, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\n                             </li>\n");
#nullable restore
#line 89 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Views\Products\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\n                </div>\n                <div class=\"row sizeRow\">\n                    <p class=\"sizeVal\">SIZE: <span></span></p>\n                    <ul class=\"size\">\n");
#nullable restore
#line 95 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Views\Products\Details.cshtml"
                         foreach (var size in Model.Product.ProductSizes.OrderBy(ps=>ps.Size.Value))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li  class=\"sizeLi\" data-value=\"");
#nullable restore
#line 97 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Views\Products\Details.cshtml"
                                                       Write(size.Size.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><span>");
#nullable restore
#line 97 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Views\Products\Details.cshtml"
                                                                               Write(size.Size.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\n");
#nullable restore
#line 98 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Views\Products\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </ul>
                </div>
                <div class=""row addToCardRow"">
                    <div class=""counter col-lg-2 col-md-3 col-sm-6 col-xs-2"">
                        <button class=""minus""><i class=""fa-solid fa-minus""></i></button>
                        <input id=""productCounter"" value=""1"" type=""text"">
                        <button class=""plus""><i class=""fa-solid fa-plus""></i></button>
                    </div>
                    <div class=""whishList col-lg-2 col-md-3 col-sm-6 col-xs-2"">
                        <a");
            BeginWriteAttribute("href", " href=\"", 4706, "\"", 4713, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <i class=""bi bi-heart whishListIcon""></i>
                        </a>
                    </div>
                    <button class=""addCard col-lg-4 col-md-12 col-sm-12 col-xs-12"">
                        ADD TO CARD
                    </button>
                </div>
                <div class=""row buyItRow col-lg-7 col-md-12 col-sm-12 col-xs-12"">
                    <button>
                        BUY IT NOW
                    </button>
                </div>
                <div class=""row categoryRow"">
                    <span class=""name"">Brand:<span class=""content"">");
#nullable restore
#line 123 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Views\Products\Details.cshtml"
                                                              Write(Model.Product.Brand.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></span>\n                    <span class=\"name\">Category:<span class=\"content\">");
#nullable restore
#line 124 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Views\Products\Details.cshtml"
                                                                       foreach (var item in Model.Product.ProductCategories)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 126 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Views\Products\Details.cshtml"
                   Write(item.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>  </span>\r\n");
#nullable restore
#line 127 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Views\Products\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></span>\n                    <span class=\"name\">Tag:<span class=\"content\">");
#nullable restore
#line 128 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Views\Products\Details.cshtml"
                                                            Write(Model.Product.Tag.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></span>
                </div>
            </div>
        </div>
    </div>
</section>
<section id=""description"">
    <div class=""container"">
        <div class=""row descRow"">
            <ul>
                <li class=""descriptionName"">
                    <span class=""tabName tabActive"" data-id=""descriptionTab"">Description</span>
                </li>
                <li class=""comments"">
                    <span class=""tabName"" data-id=""commentsTab"">Comments</span>
                </li>
            </ul>
        </div>
        <div class=""row descContentRow tab"" id=""descriptionTab"">
            <div class=""descContent"">
                <span>DESCRIPTION</span>
                <p>
                    ");
#nullable restore
#line 150 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Views\Products\Details.cshtml"
               Write(Model.Product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </p>\n            </div>\n            <div class=\"row descImage\">\n");
#nullable restore
#line 154 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Views\Products\Details.cshtml"
                 foreach (var item in Model.Product.DescriptionImages)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "26c828333690f2d1682582c6c6afcbe857dbd90e25905", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6699, "~/assets/images/", 6699, 16, true);
#nullable restore
#line 157 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Views\Products\Details.cshtml"
AddHtmlAttributeValue("", 6715, item.Image, 6715, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 159 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Views\Products\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

            </div>
        </div>
        <div class=""row detailsTitleRow tab d-none"" id=""commentsTab"">
            <span class=""customerReviewText"">Customer Comments</span>
            <div class=""title"">
                <div class=""star-review"">
                    <span class=""noReview  d-none"">
                        No comments yet
                    </span>
                    <span class=""starIcons"">
                        <i class=""fa-solid fa-star""></i>
                        <i class=""fa-solid fa-star""></i>
                        <i class=""fa-solid fa-star""></i>
                        <i class=""fa-solid fa-star""></i>
                        <i class=""fa-solid fa-star""></i>
                    </span>
                    <span class=""basedOn"">
                        Based on 1 comment
                    </span>
                </div>
                <a href=""#"" id=""writeComment"">Write a comment</a>
            </div>
            <div class=""row writeCommentRow"">
                <hr>
       ");
            WriteLiteral("         <p class=\"writeCmmnt\">\n                    Write a comment\n                </p>\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26c828333690f2d1682582c6c6afcbe857dbd90e29010", async() => {
                WriteLiteral(@"
                    <label class=""nameLbl"" for=""name"">Name</label><br>
                    <input class=""name-mail"" type=""text"" id=""name"" placeholder=""Enter your name""><br><br>
                    <label class=""mailLbl"" for=""mail"">Email</label><br>
                    <input class=""name-mail"" type=""email"" id=""mail"" placeholder=""jamalaz@code.edu.az""><br><br>
                    <label class=""rating"">
                        Rating
                    </label><br>
                    <div class=""starRating"">
                        <input name=""star""");
                BeginWriteAttribute("class", " class=\"", 8479, "\"", 8487, 0);
                EndWriteAttribute();
                WriteLiteral(@" value=""1"" data-value=""1"" type=""radio"" id=""rating1"">
                        <label for=""rating1"" class=""fa-regular fa-star myStar""></label>
                        <input name=""star"" value=""2"" data-value=""2"" type=""radio"" id=""rating2"">
                        <label for=""rating2"" class=""fa-regular fa-star myStar""></label>
                        <input name=""star"" value=""3"" data-value=""3"" type=""radio"" id=""rating3"">
                        <label for=""rating3"" class=""fa-regular fa-star myStar""></label>
                        <input name=""star"" value=""4"" data-value=""4"" type=""radio"" id=""rating4"">
                        <label for=""rating4"" class=""fa-regular fa-star myStar""></label>
                        <input name=""star"" value=""5"" data-value=""5"" type=""radio"" id=""rating5"">
                        <label for=""rating5"" class=""fa-regular fa-star myStar""></label>
                    </div>
                    <label class=""txtAreaLbl"" for=""comment"">Body of comment</label><br>
                    <textarea class=");
                WriteLiteral("\"txtArea\"");
                BeginWriteAttribute("name", " name=\"", 9521, "\"", 9528, 0);
                EndWriteAttribute();
                WriteLiteral(" id=\"comment\" cols=\"150\" rows=\"8\"\n                              placeholder=\"Write your comment here\"></textarea>\n                    <button class=\"commentFormSubmit\" type=\"submit\">Submit Comment</button>\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <div class=""row commentsRow"">
                <div class=""comment"">
                    <hr>
                    <div class=""commentIcons"">
                        <i class=""fa-solid fa-star""></i>
                        <i class=""fa-solid fa-star""></i>
                        <i class=""fa-solid fa-star""></i>
                        <i class=""fa-solid fa-star""></i>
                        <i class=""fa-solid fa-star""></i>
                    </div>
                    <div class=""name-date"">
                        <span>
                            <span class=""name"">Camal</span> on <span class=""date"">Mar 17,2022</span>
                        </span>
                    </div>
                    <div class=""commentContent"">
                        <p>
                            Salam Dostlar Necesiz
                        </p>
                    </div>
                </div>
                <div class=""comment"">
                    <hr>
                    <div class=""comm");
            WriteLiteral(@"entIcons"">
                        <i class=""fa-solid fa-star""></i>
                        <i class=""fa-solid fa-star""></i>
                        <i class=""fa-solid fa-star""></i>
                        <i class=""fa-solid fa-star""></i>
                        <i class=""fa-solid fa-star""></i>
                    </div>
                    <div class=""name-date"">
                        <span>
                            <span class=""name"">Camal</span> on <span class=""date"">Mar 17,2022</span>
                        </span>
                    </div>
                    <div class=""commentContent"">
                        <p>
                            Salam Dostlar Necesiz
                        </p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<section id=""relatedProducts"">
    <div class=""container"">
        <div class=""row"">
            <span class=""relatedTitle"">You may also like</span>
        </div>
        <div class=""row"">
            <d");
            WriteLiteral("iv class=\"related owl-carousel owl-theme\">\n                ");
#nullable restore
#line 267 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Views\Products\Details.cshtml"
           Write(await Html.PartialAsync("_ProductPartialView",Model.Products));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>
    </div>
</section>
<section id=""recentlyViewed"">
    <div class=""container"">
        <div class=""row"">
            <span class=""recentlyTitle"">Recently Viewed</span>
        </div>
        <div class=""row"">
            <div class=""recently owl-carousel owl-theme"">
                ");
#nullable restore
#line 279 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Views\Products\Details.cshtml"
           Write(await Html.PartialAsync("_ProductPartialView",Model.Products));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n</section>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26c828333690f2d1682582c6c6afcbe857dbd90e35903", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26c828333690f2d1682582c6c6afcbe857dbd90e37001", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
            }
            );
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
