#pragma checksum "D:\Belgelerim\yazılım\Murat Yücedağ Eğitim\projects\Crm_20_09_2022\UI_Layer\Views\Shared\Components\Chart\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aff514fb92a053841b24ce0f1a05374d9caeee09"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Chart_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Chart/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aff514fb92a053841b24ce0f1a05374d9caeee09", @"/Views/Shared/Components/Chart/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94b670c85b1964e132cc037595f3deea0f2ce7d3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_Chart_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n<script src=\"https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.5.0/Chart.min.js\"></script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aff514fb92a053841b24ce0f1a05374d9caeee093403", async() => {
                WriteLiteral("\r\n\r\n    <canvas id=\"myChart\" style=\"width:100%;max-width:600px\"></canvas>\r\n\r\n    <script>\r\n        var xValues = [\"bulaşık deterjanı\", \"toz deterjan\", \"sıvı sabun\", \"şampuan\", \"temizlik bezi\"];\r\n        var yValues = [");
#nullable restore
#line 10 "D:\Belgelerim\yazılım\Murat Yücedağ Eğitim\projects\Crm_20_09_2022\UI_Layer\Views\Shared\Components\Chart\Default.cshtml"
                  Write(ViewBag.product1);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 10 "D:\Belgelerim\yazılım\Murat Yücedağ Eğitim\projects\Crm_20_09_2022\UI_Layer\Views\Shared\Components\Chart\Default.cshtml"
                                     Write(ViewBag.product2);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 10 "D:\Belgelerim\yazılım\Murat Yücedağ Eğitim\projects\Crm_20_09_2022\UI_Layer\Views\Shared\Components\Chart\Default.cshtml"
                                                        Write(ViewBag.product3);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 10 "D:\Belgelerim\yazılım\Murat Yücedağ Eğitim\projects\Crm_20_09_2022\UI_Layer\Views\Shared\Components\Chart\Default.cshtml"
                                                                           Write(ViewBag.product4);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 10 "D:\Belgelerim\yazılım\Murat Yücedağ Eğitim\projects\Crm_20_09_2022\UI_Layer\Views\Shared\Components\Chart\Default.cshtml"
                                                                                              Write(ViewBag.product5);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"];
        var barColors = [""red"", ""green"", ""blue"", ""orange"", ""brown""];

        new Chart(""myChart"", {
            type: ""bar"",
            data: {
                labels: xValues,
                datasets: [{
                    backgroundColor: barColors,
                    data: yValues
                }]
            },
            options: {
                legend: { display: false },
                title: {
                    display: true,
                    text: ""Ürün stok grafiği ");
#nullable restore
#line 26 "D:\Belgelerim\yazılım\Murat Yücedağ Eğitim\projects\Crm_20_09_2022\UI_Layer\Views\Shared\Components\Chart\Default.cshtml"
                                        Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"\r\n                }\r\n            }\r\n        });\r\n    </script>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591