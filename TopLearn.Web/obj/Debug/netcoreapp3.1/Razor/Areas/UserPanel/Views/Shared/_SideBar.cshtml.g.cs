#pragma checksum "C:\Users\sepehr\Desktop\TopLearn\TopLearn\TopLearn.Web\Areas\UserPanel\Views\Shared\_SideBar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a07668d7c77bfd5e2d90e9c0849f9d5473f1f5c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_UserPanel_Views_Shared__SideBar), @"mvc.1.0.view", @"/Areas/UserPanel/Views/Shared/_SideBar.cshtml")]
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
#line 1 "C:\Users\sepehr\Desktop\TopLearn\TopLearn\TopLearn.Web\Areas\UserPanel\Views\Shared\_SideBar.cshtml"
using TopLearn.Core.Services.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sepehr\Desktop\TopLearn\TopLearn\TopLearn.Web\Areas\UserPanel\Views\Shared\_SideBar.cshtml"
using TopLearn.Core.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sepehr\Desktop\TopLearn\TopLearn\TopLearn.Web\Areas\UserPanel\Views\Shared\_SideBar.cshtml"
using TopLearn.Core.Convertors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sepehr\Desktop\TopLearn\TopLearn\TopLearn.Web\Areas\UserPanel\Views\Shared\_SideBar.cshtml"
using TopLearn.Core.DTOs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a07668d7c77bfd5e2d90e9c0849f9d5473f1f5c", @"/Areas/UserPanel/Views/Shared/_SideBar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Areas/UserPanel/Views/_ViewImports.cshtml")]
    public class Areas_UserPanel_Views_Shared__SideBar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "C:\Users\sepehr\Desktop\TopLearn\TopLearn\TopLearn.Web\Areas\UserPanel\Views\Shared\_SideBar.cshtml"
   
    SideBarUserPanelViewModel user = _userPanelServices.GetSideBarUserInformation(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-md-3 col-sm-4 col-xs-12\">\r\n    <aside>\r\n\r\n        <div class=\"avatar-layer\">\r\n            <div class=\"img-layer\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 441, "\"", 448, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"change-image\"><i class=\"zmdi zmdi-edit\"></i></a>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4a07668d7c77bfd5e2d90e9c0849f9d5473f1f5c4365", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 533, "~/UserAvatar/", 533, 13, true);
#nullable restore
#line 15 "C:\Users\sepehr\Desktop\TopLearn\TopLearn\TopLearn.Web\Areas\UserPanel\Views\Shared\_SideBar.cshtml"
AddHtmlAttributeValue("", 546, user.ImageName, 546, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <div class=\"detail\">\r\n                <span> ");
#nullable restore
#line 18 "C:\Users\sepehr\Desktop\TopLearn\TopLearn\TopLearn.Web\Areas\UserPanel\Views\Shared\_SideBar.cshtml"
                  Write(user.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n                <span> عضویت : ");
#nullable restore
#line 19 "C:\Users\sepehr\Desktop\TopLearn\TopLearn\TopLearn.Web\Areas\UserPanel\Views\Shared\_SideBar.cshtml"
                          Write(user.RegisterDate.ToShamsi());

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </span>
            </div>
        </div>

        <section>
            <header><h3> میز کار </h3></header>
            <div class=""inner"">
                <ul>
                    <li><a href=""/userpanel""> مشاهده حساب کابری </a></li>
                    <li><a href=""/userpanel/wallet""> کیف پول شما </a></li>
                    <li><a href=""/userpanel/editprofile""> ویرایش حساب کابری </a></li>
                    <li><a href=""/userpanel/changepassword""> تغییر رمز عبور </a></li>
                    <li><a");
            BeginWriteAttribute("href", " href=\"", 1248, "\"", 1255, 0);
            EndWriteAttribute();
            WriteLiteral("> تنظیمات حساب کاربری </a></li>\r\n                    <li><a href=\"/logout\"> خروج از حساب کاربری </a></li>\r\n                </ul>\r\n            </div>\r\n        </section>\r\n    </aside>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IUserPanelServices _userPanelServices { get; private set; }
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
