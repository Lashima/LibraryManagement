#pragma checksum "C:\Users\lashima\source\repos\LibraryManagementSystem\LibraryWeb\Views\Catalog\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9b5738a6c9458263fbbf39dbe43fe38042962d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalog_Search), @"mvc.1.0.view", @"/Views/Catalog/Search.cshtml")]
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
#line 1 "C:\Users\lashima\source\repos\LibraryManagementSystem\LibraryWeb\Views\_ViewImports.cshtml"
using LibraryWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lashima\source\repos\LibraryManagementSystem\LibraryWeb\Views\_ViewImports.cshtml"
using LibraryWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9b5738a6c9458263fbbf39dbe43fe38042962d2", @"/Views/Catalog/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c99ae578f8eaac6ff644c6d16210b9e535ba815", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalog_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\lashima\source\repos\LibraryManagementSystem\LibraryWeb\Views\Catalog\Search.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\lashima\source\repos\LibraryManagementSystem\LibraryWeb\Views\Catalog\Search.cshtml"
 using (Html.BeginForm("Searching", "Catalog", FormMethod.Get))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\lashima\source\repos\LibraryManagementSystem\LibraryWeb\Views\Catalog\Search.cshtml"
Write(Html.TextBox("searchquery"));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"submit\" value=\"Search\" />\r\n");
#nullable restore
#line 10 "C:\Users\lashima\source\repos\LibraryManagementSystem\LibraryWeb\Views\Catalog\Search.cshtml"
}

#line default
#line hidden
#nullable disable
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