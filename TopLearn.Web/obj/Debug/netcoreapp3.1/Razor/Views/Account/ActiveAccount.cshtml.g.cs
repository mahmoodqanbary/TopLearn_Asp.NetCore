#pragma checksum "C:\Users\sepehr\Desktop\TopLearn\TopLearn_Asp.NetCore\TopLearn.Web\Views\Account\ActiveAccount.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "acbdcca4c4fa5923516ca7e6ef439b32bb77157d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_ActiveAccount), @"mvc.1.0.view", @"/Views/Account/ActiveAccount.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acbdcca4c4fa5923516ca7e6ef439b32bb77157d", @"/Views/Account/ActiveAccount.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_ActiveAccount : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\sepehr\Desktop\TopLearn\TopLearn_Asp.NetCore\TopLearn.Web\Views\Account\ActiveAccount.cshtml"
  
    ViewData["Title"] = "فعالسازی";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <nav aria-label=""breadcrumb"">
        <ul class=""breadcrumb"">
            <li class=""breadcrumb-item""><a href=""/"">تاپ لرن</a></li>
            <li class=""breadcrumb-item active"" aria-current=""page"">فعالسازی حساب کاربری</li>
        </ul>
    </nav>

</div>
<div class=""container"">
");
#nullable restore
#line 16 "C:\Users\sepehr\Desktop\TopLearn\TopLearn_Asp.NetCore\TopLearn.Web\Views\Account\ActiveAccount.cshtml"
     if (ViewBag.IsActive)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-success\">\r\n            <p>حساب شما با موفقیت فعال شد.</p>\r\n            <p><a href=\"/Login\">ورود به سایت</a></p>\r\n        </div>\r\n");
#nullable restore
#line 22 "C:\Users\sepehr\Desktop\TopLearn\TopLearn_Asp.NetCore\TopLearn.Web\Views\Account\ActiveAccount.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-danger\">\r\n            <p>کاربری با مشخصات وارد شده یافت نشد</p>\r\n        </div>\r\n");
#nullable restore
#line 28 "C:\Users\sepehr\Desktop\TopLearn\TopLearn_Asp.NetCore\TopLearn.Web\Views\Account\ActiveAccount.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>\r\n\r\n");
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
