#pragma checksum "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\PersonelInformationReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b055e2137f27b6bf1bf55452c845dc7fefe3f02"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Officers_PersonelInformationReport), @"mvc.1.0.view", @"/Views/Officers/PersonelInformationReport.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b055e2137f27b6bf1bf55452c845dc7fefe3f02", @"/Views/Officers/PersonelInformationReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3054cbe11b3537a2b6c9743cac8d19e3344331d", @"/Views/_ViewImports.cshtml")]
    public class Views_Officers_PersonelInformationReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MilitaryCollege.Models.Officer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\PersonelInformationReport.cshtml"
  
    ViewData["Title"] = "PersonelInformationReport";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"dataTable table-striped table-bordered mb-3 mt-2\" style=\"width:100%\">\r\n    <thead>\r\n        <tr>\r\n            <th>م</th>\r\n            <th>\r\n                ");
#nullable restore
#line 12 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\PersonelInformationReport.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 15 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\PersonelInformationReport.cshtml"
           Write(Html.DisplayNameFor(model => model.MilitaryNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\PersonelInformationReport.cshtml"
           Write(Html.DisplayNameFor(model => model.BirthDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\PersonelInformationReport.cshtml"
           Write(Html.DisplayNameFor(model => model.BirthAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\PersonelInformationReport.cshtml"
           Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\PersonelInformationReport.cshtml"
           Write(Html.DisplayNameFor(model => model.BloodType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 30 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\PersonelInformationReport.cshtml"
           Write(Html.DisplayNameFor(model => model.Height));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 33 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\PersonelInformationReport.cshtml"
           Write(Html.DisplayNameFor(model => model.Nationality));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 36 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\PersonelInformationReport.cshtml"
           Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 39 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\PersonelInformationReport.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 43 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\PersonelInformationReport.cshtml"
           Write(Html.DisplayNameFor(model => model.PreviousJob));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 46 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\PersonelInformationReport.cshtml"
           Write(Html.DisplayNameFor(model => model.HealthProblem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 52 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\PersonelInformationReport.cshtml"
           var index = 1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\PersonelInformationReport.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 56 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\PersonelInformationReport.cshtml"
               Write(index);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <b>");
#nullable restore
#line 58 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\PersonelInformationReport.cshtml"
                  Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 61 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\PersonelInformationReport.cshtml"
               Write(Html.DisplayFor(modelItem => item.MilitaryNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 64 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\PersonelInformationReport.cshtml"
               Write(Html.DisplayFor(modelItem => item.BirthDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 67 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\PersonelInformationReport.cshtml"
               Write(Html.DisplayFor(modelItem => item.BirthAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 70 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\PersonelInformationReport.cshtml"
               Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 73 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\PersonelInformationReport.cshtml"
               Write(Html.DisplayFor(modelItem => item.BloodType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 76 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\PersonelInformationReport.cshtml"
               Write(Html.DisplayFor(modelItem => item.Height));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 79 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\PersonelInformationReport.cshtml"
               Write(Html.DisplayFor(modelItem => item.Nationality));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 83 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\PersonelInformationReport.cshtml"
               Write(Html.DisplayFor(modelItem => item.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 86 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\PersonelInformationReport.cshtml"
               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 90 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\PersonelInformationReport.cshtml"
               Write(Html.DisplayFor(modelItem => item.PreviousJob));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 93 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\PersonelInformationReport.cshtml"
               Write(Html.DisplayFor(modelItem => item.HealthProblem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 97 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\PersonelInformationReport.cshtml"
            index++;
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral(" \r\n\r\n<style>\r\n    table.dataTable td, table.dataTable th {\r\n        text-align: center;\r\n        vertical-align: middle !important;\r\n    }\r\n\r\n\r\n\r\n    thead {\r\n        /*height: 100px;*/\r\n        font-size: 1.1em;\r\n    }\r\n\r\n</style>\r\n");
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
