#pragma checksum "C:\Users\sepehr\Desktop\TopLearn\TopLearn\TopLearn.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd7aaa290d8a88e95c035f60503166a6851568b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd7aaa290d8a88e95c035f60503166a6851568b3", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\sepehr\Desktop\TopLearn\TopLearn\TopLearn.Web\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "خانه";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("SearchBox", async() => {
                WriteLiteral("\r\n    <header>\r\n        <a");
                BeginWriteAttribute("href", " href=\"", 87, "\"", 94, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""logo""><img src=""/images/logo.png""></a>
        <h1> با اساتید مجرب و کارآزموده در خودآموز تاپ لرن </h1>
        <h2> آموزش ببینید ، تجربه کسب کنید و بازار کار شوید </h2>
        <h3> با کمترین هزینه خودت یاد بگیر </h3>
    </header>
    <div class=""search-form"">
        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd7aaa290d8a88e95c035f60503166a6851568b33605", async() => {
                    WriteLiteral("\r\n            <input type=\"text\"");
                    BeginWriteAttribute("name", " name=\"", 418, "\"", 425, 0);
                    EndWriteAttribute();
                    WriteLiteral(" placeholder=\"چی دوست داری یاد بگیری ؟\">\r\n            <button><i class=\"zmdi zmdi-search\"></i></button>\r\n        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </div>\r\n");
            }
            );
            WriteLiteral("<main id=\"home-page\">\r\n    <div class=\"container\">\r\n        <section class=\"terms-items\">\r\n            <header>\r\n                <h2> آخرین دوره های تاپ لرن </h2>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 745, "\"", 752, 0);
            EndWriteAttribute();
            WriteLiteral("> مشاهده همه دوره ها </a>\r\n            </header>\r\n            <div class=\"row\">\r\n                <!-- col -->\r\n                <div class=\"col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col\">\r\n                    <article>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 998, "\"", 1005, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-layer\"><img src=\"/images/pic/1.jpg\"></a>\r\n                        <h2><a");
            BeginWriteAttribute("href", " href=\"", 1090, "\"", 1097, 0);
            EndWriteAttribute();
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a></h2>
                        <span> رایگان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a");
            BeginWriteAttribute("href", " href=\"", 1479, "\"", 1486, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-layer\"><img src=\"/images/pic/2.jpg\"></a>\r\n                        <h2><a");
            BeginWriteAttribute("href", " href=\"", 1571, "\"", 1578, 0);
            EndWriteAttribute();
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a></h2>
                        <span> رایگان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a");
            BeginWriteAttribute("href", " href=\"", 1960, "\"", 1967, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-layer\"><img src=\"/images/pic/3.jpg\"></a>\r\n                        <h2><a");
            BeginWriteAttribute("href", " href=\"", 2052, "\"", 2059, 0);
            EndWriteAttribute();
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a></h2>
                        <span> 150.000 تومان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a");
            BeginWriteAttribute("href", " href=\"", 2448, "\"", 2455, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-layer\"><img src=\"/images/pic/4.jpg\"></a>\r\n                        <h2><a");
            BeginWriteAttribute("href", " href=\"", 2540, "\"", 2547, 0);
            EndWriteAttribute();
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a></h2>
                        <span> رایگان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a");
            BeginWriteAttribute("href", " href=\"", 2929, "\"", 2936, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-layer\"><img src=\"/images/pic/5.jpg\"></a>\r\n                        <h2><a");
            BeginWriteAttribute("href", " href=\"", 3021, "\"", 3028, 0);
            EndWriteAttribute();
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a></h2>
                        <span> 15.000 تومان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a");
            BeginWriteAttribute("href", " href=\"", 3416, "\"", 3423, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-layer\"><img src=\"/images/pic/6.jpg\"></a>\r\n                        <h2><a");
            BeginWriteAttribute("href", " href=\"", 3508, "\"", 3515, 0);
            EndWriteAttribute();
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a></h2>
                        <span> رایگان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a");
            BeginWriteAttribute("href", " href=\"", 3897, "\"", 3904, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-layer\"><img src=\"/images/pic/7.jpg\"></a>\r\n                        <h2><a");
            BeginWriteAttribute("href", " href=\"", 3989, "\"", 3996, 0);
            EndWriteAttribute();
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a></h2>
                        <span> 20.000 تومان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a");
            BeginWriteAttribute("href", " href=\"", 4384, "\"", 4391, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-layer\"><img src=\"/images/pic/8.jpg\"></a>\r\n                        <h2><a");
            BeginWriteAttribute("href", " href=\"", 4476, "\"", 4483, 0);
            EndWriteAttribute();
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a></h2>
                        <span> 75.000 تومان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
            </div>
        </section>

        <hr>

        <section class=""terms-items"">
            <header>
                <h2> دوره های محبوب تاپ لرن </h2>
                <a");
            BeginWriteAttribute("href", " href=\"", 4895, "\"", 4902, 0);
            EndWriteAttribute();
            WriteLiteral("> مشاهده همه دوره ها </a>\r\n            </header>\r\n            <div class=\"row\">\r\n                <!-- col -->\r\n                <div class=\"col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col\">\r\n                    <article>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 5148, "\"", 5155, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-layer\"><img src=\"/images/pic/1.jpg\"></a>\r\n                        <h2><a");
            BeginWriteAttribute("href", " href=\"", 5240, "\"", 5247, 0);
            EndWriteAttribute();
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a></h2>
                        <span> رایگان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a");
            BeginWriteAttribute("href", " href=\"", 5629, "\"", 5636, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-layer\"><img src=\"/images/pic/2.jpg\"></a>\r\n                        <h2><a");
            BeginWriteAttribute("href", " href=\"", 5721, "\"", 5728, 0);
            EndWriteAttribute();
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a></h2>
                        <span> رایگان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a");
            BeginWriteAttribute("href", " href=\"", 6110, "\"", 6117, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-layer\"><img src=\"/images/pic/3.jpg\"></a>\r\n                        <h2><a");
            BeginWriteAttribute("href", " href=\"", 6202, "\"", 6209, 0);
            EndWriteAttribute();
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a></h2>
                        <span> 150.000 تومان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a");
            BeginWriteAttribute("href", " href=\"", 6598, "\"", 6605, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-layer\"><img src=\"/images/pic/4.jpg\"></a>\r\n                        <h2><a");
            BeginWriteAttribute("href", " href=\"", 6690, "\"", 6697, 0);
            EndWriteAttribute();
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a></h2>
                        <span> رایگان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a");
            BeginWriteAttribute("href", " href=\"", 7079, "\"", 7086, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-layer\"><img src=\"/images/pic/5.jpg\"></a>\r\n                        <h2><a");
            BeginWriteAttribute("href", " href=\"", 7171, "\"", 7178, 0);
            EndWriteAttribute();
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a></h2>
                        <span> 15.000 تومان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a");
            BeginWriteAttribute("href", " href=\"", 7566, "\"", 7573, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-layer\"><img src=\"/images/pic/6.jpg\"></a>\r\n                        <h2><a");
            BeginWriteAttribute("href", " href=\"", 7658, "\"", 7665, 0);
            EndWriteAttribute();
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a></h2>
                        <span> رایگان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a");
            BeginWriteAttribute("href", " href=\"", 8047, "\"", 8054, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-layer\"><img src=\"/images/pic/7.jpg\"></a>\r\n                        <h2><a");
            BeginWriteAttribute("href", " href=\"", 8139, "\"", 8146, 0);
            EndWriteAttribute();
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a></h2>
                        <span> 20.000 تومان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
                <!-- col -->
                <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
                    <article>
                        <a");
            BeginWriteAttribute("href", " href=\"", 8534, "\"", 8541, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-layer\"><img src=\"/images/pic/8.jpg\"></a>\r\n                        <h2><a");
            BeginWriteAttribute("href", " href=\"", 8626, "\"", 8633, 0);
            EndWriteAttribute();
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a></h2>
                        <span> 75.000 تومان </span>
                        <i>1:52:32</i>
                    </article>
                </div>
                <!-- /col -->
            </div>
        </section>
    </div>
</main>");
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