#pragma checksum "C:\Users\14may\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\SocialMediaList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "920f4f827e72d7897e9699e37db9ed6043652762"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SocialMediaList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/SocialMediaList/Default.cshtml")]
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
#line 1 "C:\Users\14may\source\repos\Core_Proje\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\14may\source\repos\Core_Proje\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\14may\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\SocialMediaList\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"920f4f827e72d7897e9699e37db9ed6043652762", @"/Views/Shared/Components/SocialMediaList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_SocialMediaList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SocialMedia>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"social-nav\" data-aos=\"fade-up\" data-aos-delay=\"200\">\r\n    <nav role=\"navigation\">\r\n        <ul class=\"nav justify-content-left\">\r\n\r\n");
#nullable restore
#line 8 "C:\Users\14may\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\SocialMediaList\Default.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"nav-item\"><a class=\"nav-link\"");
            BeginWriteAttribute("href", " href=\"", 310, "\"", 326, 1);
#nullable restore
#line 10 "C:\Users\14may\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\SocialMediaList\Default.cshtml"
WriteAttributeValue("", 317, item.Url, 317, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 327, "\"", 345, 1);
#nullable restore
#line 10 "C:\Users\14may\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\SocialMediaList\Default.cshtml"
WriteAttributeValue("", 335, item.Name, 335, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i");
            BeginWriteAttribute("class", " class=\"", 349, "\"", 367, 1);
#nullable restore
#line 10 "C:\Users\14may\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\SocialMediaList\Default.cshtml"
WriteAttributeValue("", 357, item.Icon, 357, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i><span class=\"menu-title sr-only\">");
#nullable restore
#line 10 "C:\Users\14may\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\SocialMediaList\Default.cshtml"
                                                                                                                                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></a></li>\r\n");
#nullable restore
#line 11 "C:\Users\14may\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\SocialMediaList\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n    </nav>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SocialMedia>> Html { get; private set; }
    }
}
#pragma warning restore 1591
