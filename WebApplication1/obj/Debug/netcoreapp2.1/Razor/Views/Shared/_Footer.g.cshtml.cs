#pragma checksum "C:\Users\MarcoHuang\Desktop\HappyFarmer\WebApplication1\Views\Shared\_Footer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7539ee1fda086f9372af22f742a2dc52ea17251"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Footer), @"mvc.1.0.view", @"/Views/Shared/_Footer.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Footer.cshtml", typeof(AspNetCore.Views_Shared__Footer))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7539ee1fda086f9372af22f742a2dc52ea17251", @"/Views/Shared/_Footer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Footer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 408, true);
            WriteLiteral(@"<div class=""row align-items-center justify-content-xl-between"">
    <div class=""col-xl-6"">
        <div class=""copyright text-center text-xl-left text-muted"">
            &copy; Purdue University CNIT 581-IoT 2018
        </div>
    </div>
    <div class=""col-xl-6"">
        <ul class=""nav nav-footer justify-content-center justify-content-xl-end"">
            <li class=""nav-item"">
                ");
            EndContext();
            BeginContext(409, 86, false);
#line 10 "C:\Users\MarcoHuang\Desktop\HappyFarmer\WebApplication1\Views\Shared\_Footer.cshtml"
           Write(Html.ActionLink("About Us", "About", "Home", new {@class="nav-link", target="_blank"}));

#line default
#line hidden
            EndContext();
            BeginContext(495, 72, true);
            WriteLiteral("\r\n            </li>\r\n            <li class=\"nav-item\">\r\n                ");
            EndContext();
            BeginContext(568, 87, false);
#line 13 "C:\Users\MarcoHuang\Desktop\HappyFarmer\WebApplication1\Views\Shared\_Footer.cshtml"
           Write(Html.ActionLink("Contact", "Contact", "Home", new {@class="nav-link", target="_blank"}));

#line default
#line hidden
            EndContext();
            BeginContext(655, 54, true);
            WriteLiteral("\r\n            </li>\r\n        </ul>\r\n    </div>\r\n</div>");
            EndContext();
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