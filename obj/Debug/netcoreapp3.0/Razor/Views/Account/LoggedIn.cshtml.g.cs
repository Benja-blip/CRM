#pragma checksum "/home/ben/Programming/ASP.NET/CRM3/Views/Account/LoggedIn.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c1e09fe81dcaceb43108afe1816f1115b19847f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_LoggedIn), @"mvc.1.0.view", @"/Views/Account/LoggedIn.cshtml")]
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
#line 1 "/home/ben/Programming/ASP.NET/CRM3/Views/_ViewImports.cshtml"
using CRM3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/ben/Programming/ASP.NET/CRM3/Views/_ViewImports.cshtml"
using CRM3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c1e09fe81dcaceb43108afe1816f1115b19847f", @"/Views/Account/LoggedIn.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8751b012c2b8987b2be2dd5ba21ff0464315dca0", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_LoggedIn : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""container mt-5"">
  <h1 style=""text-align:center;"">Welcome</h1>
</div>

<div class=""container mt-5"">
  <div class=""row"">
    <div class=""col text-center"">
        <button style=""margin:1px;"" type=""button"" class=""ebButton"" onclick=""window.location.href = '/companies/index';"">View Companies</button>
    </div>
    <div class=""col text-center"">
        <button style=""margin:1px;"" type=""button"" class=""ebButton"" onclick=""window.location.href = '/dashboard/index';"">View Dashboard</button>
    </div>
  </div>
</div>

<style>

.body {
  display: flex;
  align-items: center;
  justify-content: center;
  height: 100vh;
  margin: 0;
}

.ebButton {
  border-radius: 10px;
  background-color: #eee;
  color: #444;
  cursor: pointer;
  padding: 18px;
  width: 50%;
  border: 0;
  text-align: center;
  outline: none;
  font-size: 20px;
  float: center;
}

.ebButton:focus {outline:0;}

.active, .ebButton:hover {
  background-color: #ccc;
}

</style>");
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
