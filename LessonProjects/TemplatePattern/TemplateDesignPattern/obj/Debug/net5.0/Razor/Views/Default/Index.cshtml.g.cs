#pragma checksum "C:\Users\User\Desktop\UpSchoolBootcamp\Template_Design_Pattern\Template_Design_Pattern\Views\Default\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2888dbe4bd0d4662b08b2798e8e5f972de1bf15e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Default_Index), @"mvc.1.0.view", @"/Views/Default/Index.cshtml")]
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
#line 1 "C:\Users\User\Desktop\UpSchoolBootcamp\Template_Design_Pattern\Template_Design_Pattern\Views\_ViewImports.cshtml"
using Template_Design_Pattern;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\UpSchoolBootcamp\Template_Design_Pattern\Template_Design_Pattern\Views\_ViewImports.cshtml"
using Template_Design_Pattern.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\UpSchoolBootcamp\Template_Design_Pattern\Template_Design_Pattern\Views\_ViewImports.cshtml"
using Template_Design_Pattern.DAL.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2888dbe4bd0d4662b08b2798e8e5f972de1bf15e", @"/Views/Default/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bab45e260b08f548a30addd144a8d0d22f954729", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Default_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AppUser>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Template_Design_Pattern.TemplateDesignPattern.UserCardTagHelper __Template_Design_Pattern_TemplateDesignPattern_UserCardTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\Desktop\UpSchoolBootcamp\Template_Design_Pattern\Template_Design_Pattern\Views\Default\Index.cshtml"
  
    Layout = null;
    int count = 0;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2888dbe4bd0d4662b08b2798e8e5f972de1bf15e4605", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<br />\r\n<br />\r\n");
#nullable restore
#line 9 "C:\Users\User\Desktop\UpSchoolBootcamp\Template_Design_Pattern\Template_Design_Pattern\Views\Default\Index.cshtml"
 foreach(var item in Model){
    count++;
    if(count==1|| count%3==1){
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\User\Desktop\UpSchoolBootcamp\Template_Design_Pattern\Template_Design_Pattern\Views\Default\Index.cshtml"
   Write(Html.Raw("<div class='row row-cols-1 row-cols-md-3 g-4'>"));

#line default
#line hidden
#nullable disable
            WriteLiteral("            <!--Html.Raw c# içinde html kodları yazmamızı sağlar.\r\n                Burada %3 yaparak sayfada 3 lük kartlar oluşturmayı sağlar\r\n                \r\n            -->\r\n");
#nullable restore
#line 17 "C:\Users\User\Desktop\UpSchoolBootcamp\Template_Design_Pattern\Template_Design_Pattern\Views\Default\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("user-card", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2888dbe4bd0d4662b08b2798e8e5f972de1bf15e6770", async() => {
            }
            );
            __Template_Design_Pattern_TemplateDesignPattern_UserCardTagHelper = CreateTagHelper<global::Template_Design_Pattern.TemplateDesignPattern.UserCardTagHelper>();
            __tagHelperExecutionContext.Add(__Template_Design_Pattern_TemplateDesignPattern_UserCardTagHelper);
#nullable restore
#line 19 "C:\Users\User\Desktop\UpSchoolBootcamp\Template_Design_Pattern\Template_Design_Pattern\Views\Default\Index.cshtml"
__Template_Design_Pattern_TemplateDesignPattern_UserCardTagHelper.AppUser = item;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("app-user", __Template_Design_Pattern_TemplateDesignPattern_UserCardTagHelper.AppUser, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" <!--kendi hazırladığım UserCardTagHelper\r\n            tag helper\'ı\'\r\n        -->\r\n\r\n    </div>\r\n");
#nullable restore
#line 24 "C:\Users\User\Desktop\UpSchoolBootcamp\Template_Design_Pattern\Template_Design_Pattern\Views\Default\Index.cshtml"
    if(count%3==0){
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\User\Desktop\UpSchoolBootcamp\Template_Design_Pattern\Template_Design_Pattern\Views\Default\Index.cshtml"
   Write(Html.Raw("</div>"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\User\Desktop\UpSchoolBootcamp\Template_Design_Pattern\Template_Design_Pattern\Views\Default\Index.cshtml"
                           
    }
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AppUser>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
