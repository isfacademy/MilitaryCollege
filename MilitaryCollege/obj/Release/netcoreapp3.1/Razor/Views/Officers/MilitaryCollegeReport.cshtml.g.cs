#pragma checksum "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\MilitaryCollegeReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e160872077fc9a7440d0675ebb6c3eb2366b5fb5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Officers_MilitaryCollegeReport), @"mvc.1.0.view", @"/Views/Officers/MilitaryCollegeReport.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e160872077fc9a7440d0675ebb6c3eb2366b5fb5", @"/Views/Officers/MilitaryCollegeReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3054cbe11b3537a2b6c9743cac8d19e3344331d", @"/Views/_ViewImports.cshtml")]
    public class Views_Officers_MilitaryCollegeReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MilitaryCollege.Models.Officer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<table class=""dataTable table-striped table-bordered mb-3 mt-2"" style=""width:100%"">
    <thead>
        <tr>
            <th rowspan=""2"">
                الاسم و الشهرة
            </th>
            <th colspan=""2"">
                التصنيف عند الدخول
            </th>
            <th rowspan=""2"">
                الاختصاص
            </th>
            <th colspan=""2"">
                التصنيف عند التخرج
            </th>
        </tr>
        <tr>
            <th>عام</th>
            <th>قوى امن</th>
            <th>عام</th>
            <th>قوى امن</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 26 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\MilitaryCollegeReport.cshtml"
         foreach (var officer in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                <b>");
#nullable restore
#line 30 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\MilitaryCollegeReport.cshtml"
              Write(Html.DisplayFor(model => officer.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 33 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\MilitaryCollegeReport.cshtml"
           Write(Html.DisplayFor(model => officer.RatingEnteringYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 36 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\MilitaryCollegeReport.cshtml"
           Write(Html.DisplayFor(model => officer.RatingEnteringNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 39 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\MilitaryCollegeReport.cshtml"
           Write(Html.DisplayFor(model => officer.Specialization));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 42 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\MilitaryCollegeReport.cshtml"
           Write(Html.DisplayFor(model => officer.RatingGradutionYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 45 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\MilitaryCollegeReport.cshtml"
           Write(Html.DisplayFor(model => officer.RatingGradutionNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 48 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\MilitaryCollegeReport.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n\r\n    </tbody>\r\n</table>\r\n\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n<style>\r\n    table.dataTable td, table.dataTable th {\r\n        text-align: center;\r\n        vertical-align: middle !important;\r\n    }\r\n    thead {\r\n        font-size:1.3em;\r\n    }\r\n  \r\n</style>\r\n\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MilitaryCollege.Models.Officer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
