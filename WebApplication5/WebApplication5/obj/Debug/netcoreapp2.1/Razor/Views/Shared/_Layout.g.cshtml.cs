#pragma checksum "C:\Users\7343\source\repos\WebApplication5\WebApplication5\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c598b0ee1b0ff77741db02090c591b8519c1aa6a"
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
#line 1 "C:\Users\7343\source\repos\WebApplication5\WebApplication5\Views\_ViewImports.cshtml"
using WebApplication5;

#line default
#line hidden
#line 2 "C:\Users\7343\source\repos\WebApplication5\WebApplication5\Views\_ViewImports.cshtml"
using WebApplication5.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c598b0ee1b0ff77741db02090c591b8519c1aa6a", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ac7a6a20369a094c1643b76f0e92e19ec3cef6a", @"/Views/_ViewImports.cshtml")]
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
            BeginContext(27, 2178, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d03e0bc032464d8e8430157fbf164e19", async() => {
                BeginContext(33, 2165, true);
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width"" />
    <title>i2icell</title>
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css"">
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/js/bootstrap.min.js""></script>
    <style>
        /* Remove the navbar's default margin-bottom and rounded borders */

        html {
            height: 100%;
            width: 100%;
        }

        body {
            min-height: 100%;
        }


        .navbar {
            margin-bottom: 0;
            border-radius: 0;
        }

        .navbar-nav li a {
            color: black !important;
            font-weig");
                WriteLiteral(@"ht: bold;
            margin-left: 50px;
            margin-right: 50px;
        }
        /* Set height of the grid so .sidenav can be 100% (adjust as needed) */
        .row.content {
            height: 100%;
        }

        /* Set gray background color and 100% height */
        .sidenav {
            padding-top: 20px;
            background-color: #41ACE4;
            height: 100%;
            
        }

        /* Set black background color, white text and some padding */
        footer {
            background-color: #D3D3D3;
            color: black;
            padding: 15px;
        }

        .navbar-inverse {
            background-color: #D3D3D3;
            border-color: #D3D3D3;
            color: black;
        }

        .sidenav {
            color: white;
        }

        .content-form {
            border: 1px solid #ccc;
            -webkit-border-radius: 6px;
            -moz-border-radius: 6px;
            border-radius: 6px;
            pad");
                WriteLiteral("ding: 20px;\r\n        }\r\n\r\n        /* On small screens, set height to \'auto\' for sidenav and grid */\r\n\r\n    </style>\r\n");
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
            BeginContext(2205, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2207, 4032, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "026b5dd4be684a3ab7c4aa87f10b2446", async() => {
                BeginContext(2213, 812, true);
                WriteLiteral(@"

    <div class=""container-fluid text-center"">
        <div class=""row"">
            <div class=""col-sm-4 sidenav""></div>
            <div class=""col-sm-8""><br></div>
        </div>
    </div>
    <nav class=""navbar navbar-inverse"">
        <div class=""container-fluid"">
            <div class=""navbar-header col-sm-4"">
                <ul class=""nav navbar-nav navbar-left"">
                    <li>
                        <img src=""https://a.icons8.com/TtfefVqX/wTMJyC/ade7ef70-0b01-4b58-8.png"" width=""64px"" height=""64px"">
                        <b style=""font-size:21px"">i2i Cell</b>
                    </li>
                </ul>
            </div>
            <div class=""collapse navbar-collapse"" id=""myNavbar"">
                <ul class=""nav navbar-nav"">
                    <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3025, "\"", 3059, 1);
#line 99 "C:\Users\7343\source\repos\WebApplication5\WebApplication5\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3032, Url.Action("Index","Home"), 3032, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3060, 158, true);
                WriteLiteral(">Anasayfa</a></li>\r\n                    <li><a href=\"#\">Paketler</a></li>\r\n                    <li><a href=\"#\">Hakkımızda</a></li>\r\n                    <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3218, "\"", 3252, 1);
#line 102 "C:\Users\7343\source\repos\WebApplication5\WebApplication5\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3225, Url.Action("Index","Home"), 3225, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3253, 943, true);
                WriteLiteral(@" >Çıkış</a></li>
                </ul>
                <ul class=""nav navbar-nav navbar-right"">
                    <li><img src=""https://a.icons8.com/TtfefVqX/3UxC4m/oval.png"" width=""64px"" height=""64px""></li>
                </ul>
            </div>
        </div>
    </nav>

    <div class=""container-fluid text-center"">
        <div class=""row content"">
            <div class=""col-sm-4 sidenav"">
                <h1 class=""display-1"" style=""font-family: cursive;font-size:4em;opacity: 0.5;"">Merhaba</h1>
                <h3 style=""font-family: cursive;font-size:2em;opacity: 0.5;"">Biz İletişiminizi Sağlıyoruz.</h3>
                <img src=""https://a.icons8.com/TtfefVqX/Z8tVL5/f37d0b74-e9d1-44a5-a.png"" height=""500px"" width=""300px"">
            </div>
            <div class=""col-sm-8 text-left"">
                <br> <br> <br>
                <div class=""col-sm-3""> </div>
                <div>
                    ");
                EndContext();
                BeginContext(4197, 12, false);
#line 122 "C:\Users\7343\source\repos\WebApplication5\WebApplication5\Views\Shared\_Layout.cshtml"
               Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(4209, 2023, true);
                WriteLiteral(@"
                </div>

            </div>
        </div>
    </div>

    <footer class=""page-footer font-small special-color-dark pt-4"">

        <!-- Footer Elements -->
        <div class=""container-fluid"">

            <!-- Social buttons -->
            <ul class=""list-unstyled list-inline text-center align-middle"">
                <li class=""list-inline-item"">
                    <a class=""btn-floating btn-tw mx-1"">
                        <img src=""https://a.icons8.com/TtfefVqX/k8v5yy/icons8_twitter_100px.png"" width=""50px"" height=""50px"">
                    </a>
                </li>
                <li class=""list-inline-item"">
                    <br>
                    <span class=""text"">Bizi Takip Edin <p>i2icell</p></span>
                </li>
                <li class=""list-inline-item"">
                    <a class=""btn-floating btn-tw mx-1"">
                        <img src=""https://a.icons8.com/TtfefVqX/uNNcjF/icons8_technical_sup.png"" width=""50px"" height=""50px"">
 ");
                WriteLiteral(@"                   </a>
                </li>
                <li class=""list-inline-item"">
                    <br>
                    <span class=""text"">Bizi Arayın <p>+90(850) 346 75 76</p></span>
                </li>
                <li class=""list-inline-item"">
                    <a class=""btn-floating btn-tw mx-1"">
                        <img src=""https://a.icons8.com/TtfefVqX/QtTjqZ/icons8_filled_messag.png"" width=""50px"" height=""50px"">
                    </a>
                </li>
                <li class=""list-inline-item"">
                    <br>
                    <span>Bize Yazın <p>info@i2i-systems.com</p></span>
                </li>
            </ul>

        </div>
        <!-- Footer Elements -->
        <!-- Copyright -->
        <div class=""footer-copyright text-center py-3"">
            © 2019 Copyright:
            <a href=""http://i2i-systems.com/"">i2iSystem Academy</a>
        </div>
        <!-- Copyright -->

    </footer>


");
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
            BeginContext(6239, 11, true);
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
