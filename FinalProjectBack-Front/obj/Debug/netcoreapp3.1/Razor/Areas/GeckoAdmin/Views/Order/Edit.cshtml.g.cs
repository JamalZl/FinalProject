#pragma checksum "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Areas\GeckoAdmin\Views\Order\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f8952a92239a92d7dc65a8a0d4b1da01ca549a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_GeckoAdmin_Views_Order_Edit), @"mvc.1.0.view", @"/Areas/GeckoAdmin/Views/Order/Edit.cshtml")]
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
#line 1 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Areas\GeckoAdmin\Views\_ViewImports.cshtml"
using FinalProjectBack_Front;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Areas\GeckoAdmin\Views\_ViewImports.cshtml"
using FinalProjectBack_Front.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Areas\GeckoAdmin\Views\_ViewImports.cshtml"
using FinalProjectBack_Front.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f8952a92239a92d7dc65a8a0d4b1da01ca549a0", @"/Areas/GeckoAdmin/Views/Order/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05d3603fef94bdb14b3d92d803ead7e2cc6bb707", @"/Areas/GeckoAdmin/Views/_ViewImports.cshtml")]
    public class Areas_GeckoAdmin_Views_Order_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Order>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-labeled btn-dark mb-2 mr-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Accept", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-labeled btn-success mb-2 mr-1 orderAccept"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "reject", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-labeled btn-danger mb-2 mr-1 orderReject"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Areas\GeckoAdmin\Views\Order\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""main-content"">
    <!--Content Header (Page header)-->
    <div class=""content-header row align-items-center m-0"">
        <div class=""col-sm-8 header-title p-0"">
            <div class=""media"">
                <div class=""header-icon text-success mr-3""><i class=""typcn typcn-document-text""></i></div>
                <div class=""media-body"">
                    <h1 class=""font-weight-bold"">Order</h1>
                </div>
            </div>
        </div>
    </div>
    <!--/.Content Header (Page header)-->
    <div class=""body-content"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""row"">
                    <div class=""col-sm-6 text-left"">
                        <h1 class=""h3"">Fullname:");
#nullable restore
#line 24 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Areas\GeckoAdmin\Views\Order\Edit.cshtml"
                                           Write(Model.AppUser.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 24 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Areas\GeckoAdmin\Views\Order\Edit.cshtml"
                                                               Write(Model.AppUser.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                        <address>\r\n                            <strong>Country:");
#nullable restore
#line 26 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Areas\GeckoAdmin\Views\Order\Edit.cshtml"
                                       Write(Model.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong><br>\r\n                            <strong>State:");
#nullable restore
#line 27 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Areas\GeckoAdmin\Views\Order\Edit.cshtml"
                                     Write(Model.State);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong><br />\r\n                            <strong>Address:");
#nullable restore
#line 28 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Areas\GeckoAdmin\Views\Order\Edit.cshtml"
                                       Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong><br />  \r\n                            <strong>Order time:");
#nullable restore
#line 29 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Areas\GeckoAdmin\Views\Order\Edit.cshtml"
                                          Write(Model.Date.ToString("dddd, dd MMMM yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                        </address>\r\n                        <a style=\"text-decoration:none;\"");
            BeginWriteAttribute("href", " href=\"", 1331, "\"", 1365, 2);
            WriteAttributeValue("", 1338, "mailto:", 1338, 7, true);
#nullable restore
#line 31 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Areas\GeckoAdmin\Views\Order\Edit.cshtml"
WriteAttributeValue("", 1345, Model.AppUser.Email, 1345, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Email:");
#nullable restore
#line 31 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Areas\GeckoAdmin\Views\Order\Edit.cshtml"
                                                                                             Write(Model.AppUser.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                    </div>
                </div>
                <div class=""container mt-4"">
                    <div class=""row"">
                        <div class=""col-12"">
                            <div class=""card my-4"">
                                <div class=""card-header p-0 position-relative mt-n4 mx-3 z-index-2"">
                                    <div style=""background-color: rgb(55,160,0);height:65px;border-radius:5px;"" class=""shadow-primary border-radius-lg pt-4 pb-3 d-flex align-items-center"">
                                        <h4 style=""padding:10px;"" class=""text-white text-capitalize ps-3"">Order items</h4>
                                    </div>
                                </div>
                                <div class=""card-body px-0 pb-2"">
                                    <div class=""table-responsive p-0"">
                                        <table class=""table align-items-center mb-0"">
                                            <thead>
   ");
            WriteLiteral(@"                                             <tr>
                                                    <th class=""text-uppercase text-secondary text-xxs font-weight-bolder opacity-7 px-2"">#</th>
                                                    <th class=""text-uppercase text-secondary text-xxs font-weight-bolder opacity-7 px-2"">Name</th>
                                                    <th class=""text-uppercase text-secondary text-xxs font-weight-bolder opacity-7 px-2"">Price</th>
                                                    <th class=""text-uppercase text-secondary text-xxs font-weight-bolder opacity-7 px-2"">Count</th>
                                                </tr>
                                            </thead>
                                            <tbody>
");
#nullable restore
#line 55 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Areas\GeckoAdmin\Views\Order\Edit.cshtml"
                                                 foreach (OrderItem order in Model.OrderItems)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                    <tr style=""height:60px;"">
                                                        <td class=""px-1"">
                                                            <div class=""d-flex"">
                                                                <h6 class=""mb-0 text-sm mx-1"">");
#nullable restore
#line 60 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Areas\GeckoAdmin\Views\Order\Edit.cshtml"
                                                                                         Write(order.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
                                                            </div>
                                                        </td>
                                                        <td class=""px-1"">
                                                            <div class=""d-flex"">
                                                                <h6 class=""mb-0 text-sm mx-1"">");
#nullable restore
#line 65 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Areas\GeckoAdmin\Views\Order\Edit.cshtml"
                                                                                         Write(order.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
                                                            </div>
                                                        </td>
                                                        <td class=""px-1"">
                                                            <div class=""d-flex"">
                                                                <h6 class=""mb-0 text-sm mx-1"">$");
#nullable restore
#line 70 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Areas\GeckoAdmin\Views\Order\Edit.cshtml"
                                                                                          Write(order.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
                                                            </div>
                                                        </td>
                                                        <td class=""px-1"">
                                                            <div class=""d-flex"">
                                                                <h6 class=""mb-0 text-sm mx-1"">");
#nullable restore
#line 75 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Areas\GeckoAdmin\Views\Order\Edit.cshtml"
                                                                                         Write(order.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                                            </div>\r\n                                                        </td>\r\n                                                    </tr>\r\n");
#nullable restore
#line 79 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Areas\GeckoAdmin\Views\Order\Edit.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-sm-4"">
                            <ul class=""list-unstyled text-left"">
                                <li>
                                    <strong style=""font-size:18px"">Total price: <span style=""font-size:14px;"">$");
#nullable restore
#line 91 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Areas\GeckoAdmin\Views\Order\Edit.cshtml"
                                                                                                          Write(Model.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></strong>\r\n                                </li>\r\n                            </ul>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 96 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Areas\GeckoAdmin\Views\Order\Edit.cshtml"
                     if (Model.Status == null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"d-flex\">\r\n                            <p class=\"btn btn-info rounded-pill mr-1\"><i class=\"fas fa-circle-notch fa-spin\"></i> <span style=\"font-size:10px;\">Pending</span> </p>\r\n                        </div>\r\n");
#nullable restore
#line 101 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Areas\GeckoAdmin\Views\Order\Edit.cshtml"
                    }
                    else if (Model.Status == true)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"d-flex\">\r\n                            <p class=\"btn btn-success rounded-pill mr-1\"><i class=\"fas fa-check\"></i> <span style=\"font-size:10px;\">Accepted</span> </p>\r\n                        </div>\r\n");
#nullable restore
#line 107 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Areas\GeckoAdmin\Views\Order\Edit.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"d-flex\">\r\n                            <p class=\"btn btn-danger rounded-pill mr-1\"><i class=\"fas fa-times\"></i> <span style=\"font-size:10px;\">Rejected</span> </p>\r\n                        </div>\r\n");
#nullable restore
#line 113 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Areas\GeckoAdmin\Views\Order\Edit.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f8952a92239a92d7dc65a8a0d4b1da01ca549a018830", async() => {
                WriteLiteral("\r\n                        <textarea class=\"form-control mt-5 OrderMessage\" placeholder=\"Write your message here\" cols=\"65\" rows=\"8\"></textarea>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n\r\n\r\n            </div>\r\n");
#nullable restore
#line 121 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Areas\GeckoAdmin\Views\Order\Edit.cshtml"
             if (Model.Status == true)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"container mx-1\">\r\n                    <div class=\"card-footer\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f8952a92239a92d7dc65a8a0d4b1da01ca549a020696", async() => {
                WriteLiteral("\r\n                            <span class=\"btn-label\"><i class=\"fas fa-redo-alt\"></i></span>Go Back\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 130 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Areas\GeckoAdmin\Views\Order\Edit.cshtml"
            }
            else if (Model.Status == false)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"container mx-1\">\r\n                    <div class=\"card-footer\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f8952a92239a92d7dc65a8a0d4b1da01ca549a022749", async() => {
                WriteLiteral("\r\n                            <span class=\"btn-label\"><i class=\"fas fa-check\"></i></span>Accept\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 135 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Areas\GeckoAdmin\Views\Order\Edit.cshtml"
                                                                        WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f8952a92239a92d7dc65a8a0d4b1da01ca549a025402", async() => {
                WriteLiteral("\r\n                            <span class=\"btn-label\"><i class=\"fas fa-redo-alt\"></i></span>Go Back\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 143 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Areas\GeckoAdmin\Views\Order\Edit.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"container mx-1\">\r\n                    <div class=\"card-footer\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f8952a92239a92d7dc65a8a0d4b1da01ca549a027428", async() => {
                WriteLiteral("\r\n                            <span class=\"btn-label\"><i class=\"fas fa-check\"></i></span>Accept\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 148 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Areas\GeckoAdmin\Views\Order\Edit.cshtml"
                                                                        WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f8952a92239a92d7dc65a8a0d4b1da01ca549a030081", async() => {
                WriteLiteral("\r\n                            <span class=\"btn-label\"><i class=\"fas fa-times\"></i></span>Reject\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 151 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Areas\GeckoAdmin\Views\Order\Edit.cshtml"
                                                                        WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f8952a92239a92d7dc65a8a0d4b1da01ca549a032734", async() => {
                WriteLiteral("\r\n                            <span class=\"btn-label\"><i class=\"fas fa-redo-alt\"></i></span>Go Back\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 159 "C:\Users\User\Desktop\FinalProject-BackEnd-main\FinalProjectBack-Front\Areas\GeckoAdmin\Views\Order\Edit.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div><!--/.body content-->\r\n</div>\r\n\r\n");
            DefineSection("AdminScripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {

            $("".orderAccept"").click(function (e) {
                e.preventDefault();
                var message = $("".OrderMessage"").val();
                var link = $(this).attr(""href"") + ""/?message="" + message
                fetch(link).then(res => res.json()).then(data => {
                    if (data.status == 200) {
                        location.href = ""https://localhost:44349/GeckoAdmin/order/index""
                    } else {

                    }
                })
            })

            $("".orderReject"").click(function (e) {
                e.preventDefault();
                var message = $("".OrderMessage"").val();
                var link = $(this).attr(""href"") + ""/?message="" + message
                fetch(link).then(res => res.json()).then(data => {
                    if (data.status == 200) {
                        location.href = ""https://localhost:44349/GeckoAdmin/order/index""
                    } ");
                WriteLiteral("else {\r\n\r\n                    }\r\n                })\r\n            })\r\n        })\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Order> Html { get; private set; }
    }
}
#pragma warning restore 1591
