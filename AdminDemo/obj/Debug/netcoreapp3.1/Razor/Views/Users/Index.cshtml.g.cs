#pragma checksum "E:\DIP RECOVERY\ASP.NET MVC CORE PROJECT BACKUPS\ASP.NET MVC Core Trial Backup 5\AdminDemo\AdminDemo\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a9cfc02f4ed8bd616750f3e2cd041463955ff12"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Index), @"mvc.1.0.view", @"/Views/Users/Index.cshtml")]
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
#line 1 "E:\DIP RECOVERY\ASP.NET MVC CORE PROJECT BACKUPS\ASP.NET MVC Core Trial Backup 5\AdminDemo\AdminDemo\Views\_ViewImports.cshtml"
using AdminDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\DIP RECOVERY\ASP.NET MVC CORE PROJECT BACKUPS\ASP.NET MVC Core Trial Backup 5\AdminDemo\AdminDemo\Views\_ViewImports.cshtml"
using AdminDemo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\DIP RECOVERY\ASP.NET MVC CORE PROJECT BACKUPS\ASP.NET MVC Core Trial Backup 5\AdminDemo\AdminDemo\Views\_ViewImports.cshtml"
using AdminDemo.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\DIP RECOVERY\ASP.NET MVC CORE PROJECT BACKUPS\ASP.NET MVC Core Trial Backup 5\AdminDemo\AdminDemo\Views\Users\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a9cfc02f4ed8bd616750f3e2cd041463955ff12", @"/Views/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c01fe5756c5c65e7e49c37d71e625f729883c76c", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AdminDemo.ViewModels.RegisterViewModels>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "E:\DIP RECOVERY\ASP.NET MVC CORE PROJECT BACKUPS\ASP.NET MVC Core Trial Backup 5\AdminDemo\AdminDemo\Views\Users\Index.cshtml"
  
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome ");
#nullable restore
#line 10 "E:\DIP RECOVERY\ASP.NET MVC CORE PROJECT BACKUPS\ASP.NET MVC Core Trial Backup 5\AdminDemo\AdminDemo\Views\Users\Index.cshtml"
                             Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AdminDemo.ViewModels.RegisterViewModels>> Html { get; private set; }
    }
}
#pragma warning restore 1591
