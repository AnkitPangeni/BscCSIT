#pragma checksum "G:\BscCsit\sem6\NCC\assignments\Lab4\Views\TestQueryString\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48bed7ca3c89635725184f388d75e8b8fa2c4e97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TestQueryString_Index), @"mvc.1.0.view", @"/Views/TestQueryString/Index.cshtml")]
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
#line 1 "G:\BscCsit\sem6\NCC\assignments\Lab4\Views\_ViewImports.cshtml"
using Lab4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\BscCsit\sem6\NCC\assignments\Lab4\Views\_ViewImports.cshtml"
using Lab4.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48bed7ca3c89635725184f388d75e8b8fa2c4e97", @"/Views/TestQueryString/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f7534b8557b9a1fc9f023eb2603558152a347ab", @"/Views/_ViewImports.cshtml")]
    public class Views_TestQueryString_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "G:\BscCsit\sem6\NCC\assignments\Lab4\Views\TestQueryString\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<h2>Id is ");
#nullable restore
#line 9 "G:\BscCsit\sem6\NCC\assignments\Lab4\Views\TestQueryString\Index.cshtml"
     Write(ViewData["id"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<h2>Name is ");
#nullable restore
#line 10 "G:\BscCsit\sem6\NCC\assignments\Lab4\Views\TestQueryString\Index.cshtml"
       Write(ViewData["name"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
