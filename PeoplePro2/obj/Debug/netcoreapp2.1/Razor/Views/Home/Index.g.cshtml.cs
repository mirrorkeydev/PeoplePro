#pragma checksum "C:\Users\gutzmanm\source\repos\PeoplePro\PeoplePro2\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95ae110e551fa31bacb125b71a8c799127fc158c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\gutzmanm\source\repos\PeoplePro\PeoplePro2\Views\_ViewImports.cshtml"
using PeoplePro2;

#line default
#line hidden
#line 2 "C:\Users\gutzmanm\source\repos\PeoplePro\PeoplePro2\Views\_ViewImports.cshtml"
using PeoplePro2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95ae110e551fa31bacb125b71a8c799127fc158c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94b2db3662b76133b0cd0e84b81a00ae1ed765aa", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\gutzmanm\source\repos\PeoplePro\PeoplePro2\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(42, 2641, true);
            WriteLiteral(@"
<div id=""myCarousel"" class=""carousel slide"" data-ride=""carousel"" data-interval=""6000"">
    <ol class=""carousel-indicators"">
        <li data-target=""#myCarousel"" data-slide-to=""0"" class=""active""></li>
        <li data-target=""#myCarousel"" data-slide-to=""1""></li>
        <li data-target=""#myCarousel"" data-slide-to=""2""></li>
    </ol>
    <div class=""carousel-inner"" role=""listbox"">
        <div class=""item active"">
            <img src=""https://www.gre.ac.uk/__data/assets/image/0003/1170768/varieties/v1200.jpg"" alt=""ASP.NET"" class=""img-responsive"" />
            <div class=""carousel-caption"" role=""option"">
                <p>
                    Manage your employees from one place.
                    <a class=""btn btn-default"" href=""https://go.microsoft.com/fwlink/?LinkID=525028&clcid=0x409"">
                        Learn More
                    </a>
                </p>
            </div>
        </div>
        <div class=""item"">
            <img src=""http://hyback.com/live/wp-content/uploads/AdobeStock_94");
            WriteLiteral(@"931527-2000x800.jpeg"" alt=""Visual Studio"" class=""img-responsive"" />
            <div class=""carousel-caption"" role=""option"">
                <p>
                    Simple overview of buildings on your work campus.
                    <a class=""btn btn-default"" href=""https://go.microsoft.com/fwlink/?LinkID=525030&clcid=0x409"">
                        Learn More
                    </a>
                </p>
            </div>
        </div>
        <div class=""item"">
            <img src=""https://www.exasol.com/wp-content/uploads/2017/10/women-online-shopping-banner.jpg"" alt=""Microsoft Azure"" class=""img-responsive"" />
            <div class=""carousel-caption"" role=""option"">
                <p>
                    No payment needed!
                    <a class=""btn btn-default"" href=""https://go.microsoft.com/fwlink/?LinkID=525027&clcid=0x409"">
                        Learn More
                    </a>
                </p>
            </div>
        </div>
    </div>
    <a class=""left carousel-control"" href=""");
            WriteLiteral(@"#myCarousel"" role=""button"" data-slide=""prev"">
        <span class=""glyphicon glyphicon-chevron-left"" aria-hidden=""true""></span>
        <span class=""sr-only"">Previous</span>
    </a>
    <a class=""right carousel-control"" href=""#myCarousel"" role=""button"" data-slide=""next"">
        <span class=""glyphicon glyphicon-chevron-right"" aria-hidden=""true""></span>
        <span class=""sr-only"">Next</span>
    </a>
</div>

<div class=""row"">
    <div class=""col"">
        <h2>PeoplePro</h2>
        <ul>
            <li>Employee, Department, and Building Directory</li>
        </ul>
    </div>
</div>
");
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
