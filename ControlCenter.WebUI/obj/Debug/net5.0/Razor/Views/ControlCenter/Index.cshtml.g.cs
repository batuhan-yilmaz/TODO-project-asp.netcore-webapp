#pragma checksum "C:\Users\scary\Downloads\challange-project\challangeproject\ControlCenter.WebUI\Views\ControlCenter\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7707e4abc867bb8324f49a76b5696b65e04d1a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ControlCenter_Index), @"mvc.1.0.view", @"/Views/ControlCenter/Index.cshtml")]
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
#line 1 "C:\Users\scary\Downloads\challange-project\challangeproject\ControlCenter.WebUI\Views\_ViewImports.cshtml"
using General.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\scary\Downloads\challange-project\challangeproject\ControlCenter.WebUI\Views\_ViewImports.cshtml"
using General.DataAccess;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\scary\Downloads\challange-project\challangeproject\ControlCenter.WebUI\Views\_ViewImports.cshtml"
using General.Business;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\scary\Downloads\challange-project\challangeproject\ControlCenter.WebUI\Views\_ViewImports.cshtml"
using ControlCenter.WebUI.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\scary\Downloads\challange-project\challangeproject\ControlCenter.WebUI\Views\_ViewImports.cshtml"
using ControlCenter.WebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7707e4abc867bb8324f49a76b5696b65e04d1a8", @"/Views/ControlCenter/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87b2a70599c224344c10ce9d23bac692ab469ec6", @"/Views/_ViewImports.cshtml")]
    public class Views_ControlCenter_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<userTaskModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-default  letter-icon-title"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ControlCenter", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteDo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\scary\Downloads\challange-project\challangeproject\ControlCenter.WebUI\Views\ControlCenter\Index.cshtml"
  
    ViewData["Title"] = "TO - DO  | YÖNETİM SİSTEMİ";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"





<table id=""example"" class=""table datatable-column-search-selects"">
    <thead>
        <tr>
            <th>Tarih</th>
            <th>Öncelik</th>
            <th>Başlık</th>
            <th>İçerik</th>
            <th>Durum</th>
            <th class=""text-center"">Düzenle</th>
        </tr>
    </thead>
    <tbody>

");
#nullable restore
#line 27 "C:\Users\scary\Downloads\challange-project\challangeproject\ControlCenter.WebUI\Views\ControlCenter\Index.cshtml"
         if (Model.userTasks != null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\scary\Downloads\challange-project\challangeproject\ControlCenter.WebUI\Views\ControlCenter\Index.cshtml"
             foreach (var item in Model.userTasks)
            {
                int pastTime = Convert.ToInt32((DateTime.Now - item.Date).TotalDays);

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td class=\"text-center\">\r\n");
#nullable restore
#line 34 "C:\Users\scary\Downloads\challange-project\challangeproject\ControlCenter.WebUI\Views\ControlCenter\Index.cshtml"
                         if (pastTime == 0 || pastTime < 1)
                        {
                            pastTime = Convert.ToInt32((DateTime.Now - item.Date).TotalHours);

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h6 class=\"mb-0\">");
#nullable restore
#line 37 "C:\Users\scary\Downloads\challange-project\challangeproject\ControlCenter.WebUI\Views\ControlCenter\Index.cshtml"
                                        Write(pastTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                            <div class=\"font-size-sm text-muted line-height-1\">saat önce</div>\r\n");
#nullable restore
#line 39 "C:\Users\scary\Downloads\challange-project\challangeproject\ControlCenter.WebUI\Views\ControlCenter\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h6 class=\"mb-0\">");
#nullable restore
#line 42 "C:\Users\scary\Downloads\challange-project\challangeproject\ControlCenter.WebUI\Views\ControlCenter\Index.cshtml"
                                        Write(pastTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                            <div class=\"font-size-sm text-muted line-height-1\">gün önce</div>\r\n");
#nullable restore
#line 44 "C:\Users\scary\Downloads\challange-project\challangeproject\ControlCenter.WebUI\Views\ControlCenter\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n");
#nullable restore
#line 47 "C:\Users\scary\Downloads\challange-project\challangeproject\ControlCenter.WebUI\Views\ControlCenter\Index.cshtml"
                     if (item.Priority == "0")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <td>
                            <div class=""d-flex align-items-center"">
                                <div class=""mr-3"">
                                    <a href=""#"" class=""btn bg-grey-400 rounded-round btn-icon btn-sm"">
                                        <span class=""letter-icon""></span>
                                    </a>
                                </div>
                                <div>
                                    <a href=""#"" class=""text-default font-weight-semibold letter-icon-title"">Düşük</a>
                                </div>
                            </div>
                        </td>
");
#nullable restore
#line 61 "C:\Users\scary\Downloads\challange-project\challangeproject\ControlCenter.WebUI\Views\ControlCenter\Index.cshtml"
                    }
                    else if (item.Priority == "1")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <td>
                            <div class=""d-flex align-items-center"">
                                <div class=""mr-3"">
                                    <a href=""#"" class=""btn bg-success-400 rounded-round btn-icon btn-sm"">
                                        <span class=""letter-icon""></span>
                                    </a>
                                </div>
                                <div>
                                    <a href=""#"" class=""text-default font-weight-semibold letter-icon-title"">Normal</a>
                                </div>
                            </div>
                        </td>
");
#nullable restore
#line 76 "C:\Users\scary\Downloads\challange-project\challangeproject\ControlCenter.WebUI\Views\ControlCenter\Index.cshtml"
                    }
                    else if (item.Priority == "2")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <td>
                            <div class=""d-flex align-items-center"">
                                <div class=""mr-3"">
                                    <a href=""#"" class=""btn bg-danger-400 rounded-round btn-icon btn-sm"">
                                        <span class=""letter-icon""></span>
                                    </a>
                                </div>
                                <div>
                                    <a href=""#"" class=""text-default font-weight-semibold letter-icon-title"">Yüksek</a>
                                </div>
                            </div>
                        </td>
");
#nullable restore
#line 91 "C:\Users\scary\Downloads\challange-project\challangeproject\ControlCenter.WebUI\Views\ControlCenter\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <td>
                            <div class=""d-flex align-items-center"">
                                <div class=""mr-3"">
                                    <a href=""#"" class=""btn bg-warning-400 rounded-round btn-icon btn-sm"">
                                        <span class=""letter-icon""></span>
                                    </a>
                                </div>
                                <div>
                                    <a href=""#"" class=""text-default font-weight-semibold letter-icon-title"">Bilinmiyor</a>
                                </div>
                            </div>
                        </td>
");
#nullable restore
#line 106 "C:\Users\scary\Downloads\challange-project\challangeproject\ControlCenter.WebUI\Views\ControlCenter\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <td>\r\n                        <div class=\"d-flex align-items-center\">\r\n\r\n                            <div>\r\n                                <a href=\"#\" class=\"text-default font-weight-semibold letter-icon-title\">");
#nullable restore
#line 112 "C:\Users\scary\Downloads\challange-project\challangeproject\ControlCenter.WebUI\Views\ControlCenter\Index.cshtml"
                                                                                                   Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n                            </div>\r\n                        </div>\r\n                    </td>\r\n                    <td>\r\n                        <div class=\"font-weight-semibold\">");
#nullable restore
#line 118 "C:\Users\scary\Downloads\challange-project\challangeproject\ControlCenter.WebUI\Views\ControlCenter\Index.cshtml"
                                                     Write(item.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <span class=\"text-muted\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7707e4abc867bb8324f49a76b5696b65e04d1a814151", async() => {
                WriteLiteral("Dosyayı görüntülemek için tıklayın.");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5027, "~/doFiles/", 5027, 10, true);
#nullable restore
#line 119 "C:\Users\scary\Downloads\challange-project\challangeproject\ControlCenter.WebUI\Views\ControlCenter\Index.cshtml"
AddHtmlAttributeValue("", 5037, item.fileUrl, 5037, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</span>\r\n                    </td>\r\n");
#nullable restore
#line 121 "C:\Users\scary\Downloads\challange-project\challangeproject\ControlCenter.WebUI\Views\ControlCenter\Index.cshtml"
                     if (item.Status == "Active")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                            <div class=\"text-muted font-size-sm\"><span class=\"badge badge-mark border-blue mr-1\"></span> Aktif</div>\r\n                        </td>\r\n");
#nullable restore
#line 126 "C:\Users\scary\Downloads\challange-project\challangeproject\ControlCenter.WebUI\Views\ControlCenter\Index.cshtml"
                    }
                    else if (item.Status == "Complated")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                            <div class=\"text-muted font-size-sm\"><span class=\"badge badge-mark border-success mr-1\"></span> Tamamlandı</div>\r\n                        </td>\r\n");
#nullable restore
#line 132 "C:\Users\scary\Downloads\challange-project\challangeproject\ControlCenter.WebUI\Views\ControlCenter\Index.cshtml"
                    }
                    else if (item.Status == "Cancelled")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                            <div class=\"text-muted font-size-sm\"><span class=\"badge badge-mark border-danger mr-1\"></span> Tamamlandı</div>\r\n                        </td>\r\n");
#nullable restore
#line 138 "C:\Users\scary\Downloads\challange-project\challangeproject\ControlCenter.WebUI\Views\ControlCenter\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                            <div class=\"text-muted font-size-sm\"><span class=\"badge badge-mark border-blue mr-1\"></span> Aktif</div>\r\n                        </td>\r\n");
#nullable restore
#line 144 "C:\Users\scary\Downloads\challange-project\challangeproject\ControlCenter.WebUI\Views\ControlCenter\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <td class=""text-center"">
                        <div class=""list-icons"">
                            <div class=""list-icons-item dropdown"">
                                <a href=""#"" class=""list-icons-item dropdown-toggle caret-0"" data-toggle=""dropdown""><i class=""icon-menu7""></i></a>
                                <div class=""dropdown-menu dropdown-menu-right"">
                                    <a");
            BeginWriteAttribute("href", " href=\"", 6729, "\"", 6766, 2);
            WriteAttributeValue("", 6736, "/ControlCenter/EditDo/", 6736, 22, true);
#nullable restore
#line 150 "C:\Users\scary\Downloads\challange-project\challangeproject\ControlCenter.WebUI\Views\ControlCenter\Index.cshtml"
WriteAttributeValue("", 6758, item.Id, 6758, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"dropdown-item\"><i class=\"icon-undo\"></i> Düzenle</a>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7707e4abc867bb8324f49a76b5696b65e04d1a819234", async() => {
                WriteLiteral("\r\n                                        <input type=\"hidden\" name=\"doId\"");
                BeginWriteAttribute("value", " value=\"", 7012, "\"", 7028, 1);
#nullable restore
#line 152 "C:\Users\scary\Downloads\challange-project\challangeproject\ControlCenter.WebUI\Views\ControlCenter\Index.cshtml"
WriteAttributeValue("", 7020, item.Id, 7020, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                        <button class=\"dropdown-item\" type=\"submit\"><i class=\"icon-cross2 text-danger\"></i>Sil</button>\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </td>\r\n\r\n\r\n                </tr>\r\n");
#nullable restore
#line 163 "C:\Users\scary\Downloads\challange-project\challangeproject\ControlCenter.WebUI\Views\ControlCenter\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 163 "C:\Users\scary\Downloads\challange-project\challangeproject\ControlCenter.WebUI\Views\ControlCenter\Index.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n    </tbody>\r\n</table>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<userTaskModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
