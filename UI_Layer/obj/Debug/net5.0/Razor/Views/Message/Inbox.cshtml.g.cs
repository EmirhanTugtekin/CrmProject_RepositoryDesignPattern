#pragma checksum "D:\Belgelerim\yazılım\Murat Yücedağ Eğitim\projects\Crm_20_09_2022\UI_Layer\Views\Message\Inbox.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e1b75075a69fcb372194367617a53effbe76f60"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Message_Inbox), @"mvc.1.0.view", @"/Views/Message/Inbox.cshtml")]
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
#line 1 "D:\Belgelerim\yazılım\Murat Yücedağ Eğitim\projects\Crm_20_09_2022\UI_Layer\Views\_ViewImports.cshtml"
using UI_Layer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Belgelerim\yazılım\Murat Yücedağ Eğitim\projects\Crm_20_09_2022\UI_Layer\Views\_ViewImports.cshtml"
using UI_Layer.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e1b75075a69fcb372194367617a53effbe76f60", @"/Views/Message/Inbox.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94b670c85b1964e132cc037595f3deea0f2ce7d3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Message_Inbox : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Entity_Layer.Message>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Belgelerim\yazılım\Murat Yücedağ Eğitim\projects\Crm_20_09_2022\UI_Layer\Views\Message\Inbox.cshtml"
  
    ViewData["Title"] = "Inbox";
    Layout = "~/Views/Shared/_MemberLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"container\">\r\n    <h1>Gelen Kutusu</h1>\r\n\r\n    Hoşgeldiniz: ");
#nullable restore
#line 12 "D:\Belgelerim\yazılım\Murat Yücedağ Eğitim\projects\Crm_20_09_2022\UI_Layer\Views\Message\Inbox.cshtml"
            Write(ViewBag.v);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    <table class=\"table table-bordered\">\r\n        <tr>\r\n            <th>Id</th>\r\n            <th>Gönderen</th>\r\n            <th>Konu</th>\r\n            <th>Mesajı aç</th>\r\n        </tr>\r\n");
#nullable restore
#line 21 "D:\Belgelerim\yazılım\Murat Yücedağ Eğitim\projects\Crm_20_09_2022\UI_Layer\Views\Message\Inbox.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 24 "D:\Belgelerim\yazılım\Murat Yücedağ Eğitim\projects\Crm_20_09_2022\UI_Layer\Views\Message\Inbox.cshtml"
               Write(item.MessageID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "D:\Belgelerim\yazılım\Murat Yücedağ Eğitim\projects\Crm_20_09_2022\UI_Layer\Views\Message\Inbox.cshtml"
               Write(item.SenderName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "D:\Belgelerim\yazılım\Murat Yücedağ Eğitim\projects\Crm_20_09_2022\UI_Layer\Views\Message\Inbox.cshtml"
               Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><a href=\"#\" class=\"btn btn-primary\">Mesajı aç</a></td>\r\n            </tr>\n");
#nullable restore
#line 29 "D:\Belgelerim\yazılım\Murat Yücedağ Eğitim\projects\Crm_20_09_2022\UI_Layer\Views\Message\Inbox.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Entity_Layer.Message>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
