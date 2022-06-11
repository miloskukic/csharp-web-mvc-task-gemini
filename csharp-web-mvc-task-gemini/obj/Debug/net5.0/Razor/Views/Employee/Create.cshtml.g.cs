#pragma checksum "C:\Users\Milos Kukic\source\repos\csharp-web-mvc-task-gemini\csharp-web-mvc-task-gemini\Views\Employee\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5d8f511d88d5fd13defe066871acab8fb1d96b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Create), @"mvc.1.0.view", @"/Views/Employee/Create.cshtml")]
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
#line 1 "C:\Users\Milos Kukic\source\repos\csharp-web-mvc-task-gemini\csharp-web-mvc-task-gemini\Views\_ViewImports.cshtml"
using csharp_web_mvc_task_gemini;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Milos Kukic\source\repos\csharp-web-mvc-task-gemini\csharp-web-mvc-task-gemini\Views\_ViewImports.cshtml"
using csharp_web_mvc_task_gemini.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5d8f511d88d5fd13defe066871acab8fb1d96b9", @"/Views/Employee/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d77f7fe360daca99c4ad6f705f38b87e6cb3ceaf", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<script src=""/js/obracun-doprinosa.js""></script>
<script src=""/js/collapse-container.js""></script>
<h2 class=""m-4"">Dodavanje novog radnika</h2>
<div class=""from-container mt-5"" style=""max-width:50%"">
    <div class=""mb-3 row"">
        <label for=""firstName"" class=""form-label"">Ime</label>
        <input type=""text"" class=""form-control"" id=""firstName"">
    </div>
    <div class=""mb-3 row"">
        <label for=""lastName"" class=""form-label"">Prezime</label>
        <input type=""text"" class=""form-control"" id=""lastName"">
    </div>
    <div class=""mb-3 row"">
        <label for=""address"" class=""form-label"">Adresa</label>
        <input type=""text"" class=""form-control"" id=""address"">
    </div>
    <div class=""mb-3 row"">
        <label for=""netoSalary"" class=""form-label"">Neto plata</label>
        <input type=""number"" class=""form-control"" id=""netoSalary"">
    </div>
    <div style=""margin:35px 0px;"">
        <p>
            <button class=""btn btn-primary mb-3"" id=""collapseBtn"">
                <i ");
            WriteLiteral(@"class=""fa-solid fa-angle-down mr-2""></i>Parametri za izračunavanje bruto zarade i dodatnih troškova (opciono)
            </button>
        </p>
        <div class=""optionalContainer"" style=""display:none;margin:0px,20px;"">
            <h5 class=""mb-3"">Porez na dohodak</h5>
            <hr />
            <div class=""row mb-3 align-items-center"">
                <div class=""col-auto"">
                    <label for=""inputPassword6"" class=""col-form-label"">Porez</label>
                </div>
                <div class=""col-auto"">
                    <input type=""number"" id=""porez-field"" class=""form-control"" aria-describedby=""passwordHelpInline"" value=""10"" step=""0.1"" style=""background-color: #51ff125c;"">
                </div>
                <div class=""col-auto"">
                    <span id=""passwordHelpInline"" class=""form-text"">
                        %
                    </span>
                </div>
            </div>
            <div class=""row mb-3 align-items-center"">
             ");
            WriteLiteral(@"   <div class=""col-auto"">
                    <label for=""inputPassword6"" class=""col-form-label"">Osnovica</label>
                </div>
                <div class=""col-auto"">
                    <input type=""number"" id=""osnovica-field"" class=""form-control"" aria-describedby=""passwordHelpInline"" value=""30.880"" style=""background-color: #51ff125c;"">
                </div>
                <div class=""col-auto"">
                    <span id=""passwordHelpInline"" class=""form-text"">
                        din
                    </span>
                </div>
            </div>
            <h5 class=""mb-3"">Doprinosi - troškovi (Zaposlen)</h5>
            <hr />
            <div class=""row mb-3 align-items-center"">
                <div class=""col-auto"">
                    <label for=""inputPassword6"" class=""col-form-label"">PIO</label>
                </div>
                <div class=""col-auto"">
                    <input type=""number"" id=""pio-field"" class=""form-control"" aria-describedby=""passwordH");
            WriteLiteral(@"elpInline"" value=""11"" step=""0.1"" style=""background-color: #ffdd125c;"">
                </div>
                <div class=""col-auto"">
                    <span id=""passwordHelpInline"" class=""form-text"">
                        %  ( <span class=""pio-din-value"">0</span> din )
                    </span>
                </div>
            </div>
            <div class=""row mb-3 align-items-center"">
                <div class=""col-auto"">
                    <label for=""inputPassword6"" class=""col-form-label"">Zdravstveno osiguranje</label>
                </div>
                <div class=""col-auto"">
                    <input type=""number"" id=""zdravstveno-field"" class=""form-control"" aria-describedby=""passwordHelpInline"" value=""5.5"" step=""0.1"" style=""background-color: #ffdd125c;"">
                </div>
                <div class=""col-auto"">
                    <span id=""passwordHelpInline"" class=""form-text"">
                        %  ( <span class=""zdravstveno-din-value"">0</span> din )
          ");
            WriteLiteral(@"          </span>
                </div>
            </div>
            <div class=""row mb-3 align-items-center"">
                <div class=""col-auto"">
                    <label for=""inputPassword6"" class=""col-form-label"">Nezaposlenost</label>
                </div>
                <div class=""col-auto"">
                    <input type=""number"" id=""nezaposlenost-field"" class=""form-control"" aria-describedby=""passwordHelpInline"" value=""0.75"" step=""0.1"" style=""background-color: #ffdd125c;"">
                </div>
                <div class=""col-auto"">
                    <span id=""passwordHelpInline"" class=""form-text"">
                        %  ( <span class=""nezaposlenost-din-value"">0</span> din )
                    </span>
                </div>
            </div>
            <h5 class=""mb-3"">Doprinosi - troškovi (Poslodavac)</h5>
            <hr />
            <div class=""row mb-3 align-items-center"">
                <div class=""col-auto"">
                    <label for=""inputPassword6");
            WriteLiteral(@""" class=""col-form-label"">PIO</label>
                </div>
                <div class=""col-auto"">
                    <input type=""number"" id=""pio-poslodavac-field"" class=""form-control"" aria-describedby=""passwordHelpInline"" value=""11"" step=""0.1"" style=""background-color: #62cefd5c;"">
                </div>
                <div class=""col-auto"">
                    <span id=""passwordHelpInline"" class=""form-text"">
                        %  ( <span class=""pio-poslodavac-din-value"">0</span> din )
                    </span>
                </div>
            </div>
            <div class=""row mb-3 align-items-center"">
                <div class=""col-auto"">
                    <label for=""inputPassword6"" class=""col-form-label"">Zdravstveno osiguranje</label>
                </div>
                <div class=""col-auto"">
                    <input type=""number"" id=""zdravstveno-poslodavac-field"" class=""form-control"" aria-describedby=""passwordHelpInline"" value=""5.5"" step=""0.1"" style=""background-color: ");
            WriteLiteral(@"#62cefd5c;"">
                </div>
                <div class=""col-auto"">
                    <span id=""passwordHelpInline"" class=""form-text"">
                        %  ( <span class=""zdravstveno-poslodavac-din-value"">0</span> din )
                    </span>
                </div>
            </div>
            <div class=""row mb-3 align-items-center"">
                <div class=""col-auto"">
                    <label for=""inputPassword6"" class=""col-form-label"">Nezaposlenost</label>
                </div>
                <div class=""col-auto"">
                    <input type=""number"" id=""nezaposlenost-poslodavac-field"" class=""form-control"" aria-describedby=""passwordHelpInline"" value=""0"" step=""0.1"" style=""background-color: #62cefd5c;"">
                </div>
                <div class=""col-auto"">
                    <span id=""passwordHelpInline"" class=""form-text"">
                        %  ( <span class=""nezaposlenost-poslodavac-din-value"">0</span> din )
                    </span>
     ");
            WriteLiteral("           </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"row mb-3\">\r\n        <button class=\"btn btn-dark\">Unesi korisnika</button>\r\n        <button class=\"btn btn-light ml-3\">Odustani</button>\r\n    </div>\r\n</div>");
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