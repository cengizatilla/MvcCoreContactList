#pragma checksum "C:\Coderinside\GitHub\MyGitHubProfile\MvcCoreContactList\CengizAtilla.ContactList\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7471b701f768651d1f98be487d2539dda53444bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7471b701f768651d1f98be487d2539dda53444bc", @"/Views/Shared/_Layout.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 27, true);
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(27, 1027, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7471b701f768651d1f98be487d2539dda53444bc2948", async() => {
                BeginContext(33, 792, true);
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
    <meta name=""description"" content="""">
    <meta name=""author"" content=""Mark Otto, Jacob Thornton, and Bootstrap contributors"">
    <meta name=""generator"" content=""Jekyll v4.0.1"">
    <title>Pricing example · Bootstrap</title>

    <link rel=""canonical"" href=""https://getbootstrap.com/docs/4.5/examples/pricing/"">

    <!-- Bootstrap core CSS -->
    <link href=""dist/css/bootstrap.min.css"" rel=""stylesheet"">

    <style>
      .bd-placeholder-img {
        font-size: 1.125rem;
        text-anchor: middle;
        -webkit-user-select: none;
        -moz-user-select: none;
        -ms-user-select: none;
        user-select: none;
      }

      ");
                EndContext();
                BeginContext(826, 221, true);
                WriteLiteral("@media (min-width: 768px) {\r\n        .bd-placeholder-img-lg {\r\n          font-size: 3.5rem;\r\n        }\r\n      }\r\n    </style>\r\n    <!-- Custom styles for this template -->\r\n    <link href=\"pricing.css\" rel=\"stylesheet\">\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1054, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1056, 3177, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7471b701f768651d1f98be487d2539dda53444bc5302", async() => {
                BeginContext(1062, 1016, true);
                WriteLiteral(@"
    <div class=""d-flex flex-column flex-md-row align-items-center p-3 px-md-4 mb-3 bg-white border-bottom shadow-sm"">
        <h5 class=""my-0 mr-md-auto font-weight-normal"">Company name</h5>
        <nav class=""my-2 my-md-0 mr-md-3"">
            <a class=""p-2 text-dark"" href=""#"">Features</a>
            <a class=""p-2 text-dark"" href=""#"">Enterprise</a>
            <a class=""p-2 text-dark"" href=""#"">Support</a>
            <a class=""p-2 text-dark"" href=""#"">Pricing</a>
        </nav>
        <a class=""btn btn-outline-primary"" href=""#"">Sign up</a>
    </div>

    <div class=""pricing-header px-3 py-3 pt-md-5 pb-md-4 mx-auto text-center"">
        <h1 class=""display-4"">Pricing</h1>
        <p class=""lead"">Quickly build an effective pricing table for your potential customers with this Bootstrap example. It’s built with default Bootstrap components and utilities with little customization.</p>
    </div>

    <div class=""container"">
        <div class=""card-deck mb-3 text-center"">
           ");
                EndContext();
                BeginContext(2079, 12, false);
#line 55 "C:\Coderinside\GitHub\MyGitHubProfile\MvcCoreContactList\CengizAtilla.ContactList\Views\Shared\_Layout.cshtml"
      Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(2091, 2135, true);
                WriteLiteral(@"
        </div>

        <footer class=""pt-4 my-md-5 pt-md-5 border-top"">
            <div class=""row"">
                <div class=""col-12 col-md"">
                    <img class=""mb-2"" src=""../assets/brand/bootstrap-solid.svg"" alt="""" width=""24"" height=""24"">
                    <small class=""d-block mb-3 text-muted"">&copy; 2017-2020</small>
                </div>
                <div class=""col-6 col-md"">
                    <h5>Features</h5>
                    <ul class=""list-unstyled text-small"">
                        <li><a class=""text-muted"" href=""#"">Cool stuff</a></li>
                        <li><a class=""text-muted"" href=""#"">Random feature</a></li>
                        <li><a class=""text-muted"" href=""#"">Team feature</a></li>
                        <li><a class=""text-muted"" href=""#"">Stuff for developers</a></li>
                        <li><a class=""text-muted"" href=""#"">Another one</a></li>
                        <li><a class=""text-muted"" href=""#"">Last time</a></li>
           ");
                WriteLiteral(@"         </ul>
                </div>
                <div class=""col-6 col-md"">
                    <h5>Resources</h5>
                    <ul class=""list-unstyled text-small"">
                        <li><a class=""text-muted"" href=""#"">Resource</a></li>
                        <li><a class=""text-muted"" href=""#"">Resource name</a></li>
                        <li><a class=""text-muted"" href=""#"">Another resource</a></li>
                        <li><a class=""text-muted"" href=""#"">Final resource</a></li>
                    </ul>
                </div>
                <div class=""col-6 col-md"">
                    <h5>About</h5>
                    <ul class=""list-unstyled text-small"">
                        <li><a class=""text-muted"" href=""#"">Team</a></li>
                        <li><a class=""text-muted"" href=""#"">Locations</a></li>
                        <li><a class=""text-muted"" href=""#"">Privacy</a></li>
                        <li><a class=""text-muted"" href=""#"">Terms</a></li>
               ");
                WriteLiteral("     </ul>\r\n                </div>\r\n            </div>\r\n        </footer>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4233, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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