#pragma checksum "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\OfficerNotesReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40f642c16683befc3497c5cb0220f72296ddb260"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Officers_OfficerNotesReport), @"mvc.1.0.view", @"/Views/Officers/OfficerNotesReport.cshtml")]
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
#line 1 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\_ViewImports.cshtml"
using MilitaryCollege;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\_ViewImports.cshtml"
using MilitaryCollege.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\_ViewImports.cshtml"
using MilitaryCollege.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40f642c16683befc3497c5cb0220f72296ddb260", @"/Views/Officers/OfficerNotesReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3054cbe11b3537a2b6c9743cac8d19e3344331d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Officers_OfficerNotesReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MilitaryCollege.Models.Officer>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<table class=""dataTable table-striped table-bordered mb-3 mt-2"" style=""width:100%"">
    <thead>
        <tr>
            <th>
                الاسم و الشهرة
            </th>
            <th>
                ملاحظات آمر الدورة
            </th>

        </tr>

    </thead>
    <tbody>
");
#nullable restore
#line 16 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\OfficerNotesReport.cshtml"
         foreach (var officer in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    <b>");
#nullable restore
#line 20 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\OfficerNotesReport.cshtml"
                  Write(Html.DisplayFor(model => officer.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 23 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\OfficerNotesReport.cshtml"
               Write(Html.TextAreaFor(model => officer.Notes, new { @class = "textAreaNote", @readonly = "readonly" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 27 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\OfficerNotesReport.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </tbody>\r\n</table>\r\n\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral(@"
    <style>
        table.dataTable td, table.dataTable th {
            text-align: center;
            vertical-align: middle !important;
        }

        thead {
            /*height: 100px;*/
            font-size: 1.5em;
        }


        .textAreaNote {
            width: 100%;
            border: hidden;
            background: transparent !important;
            resize: none;
            outline: none;
        }
    </style>

");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(""textarea"").each(function () {
            this.setAttribute(""style"", ""height:"" + (this.scrollHeight) + ""px;overflow-y:hidden;"");
        }).on(""input"", function () {
            this.style.height = ""auto"";
            this.style.height = (this.scrollHeight) + ""px"";
        });
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MilitaryCollege.Models.Officer>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
