#pragma checksum "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\EducationalAttainmentReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce67c7963d9351f16d2b83c39e2e290f2b83494c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Officers_EducationalAttainmentReport), @"mvc.1.0.view", @"/Views/Officers/EducationalAttainmentReport.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce67c7963d9351f16d2b83c39e2e290f2b83494c", @"/Views/Officers/EducationalAttainmentReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3054cbe11b3537a2b6c9743cac8d19e3344331d", @"/Views/_ViewImports.cshtml")]
    public class Views_Officers_EducationalAttainmentReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MilitaryCollege.Models.Officer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n<div class=\"container\">\r\n");
            WriteLiteral(@"    <div class=""row"">
        <table id=""educationaltable"" class="" dataTable table-striped table-bordered mb-3 mt-2"" style=""width:100%"">
            <thead>
                <tr>
                    <th>
                        الاسم و الشهرة
                    </th>
                    <th>
                        الشهادة
                    </th>
                    <th>
                        المصدر
                    </th>
                    <th>
                        التاريخ
                    </th>
                    <th>
                        العلامة
                    </th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 31 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\EducationalAttainmentReport.cshtml"
                  
                    var i = 0;
                    string trclass = "";
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\EducationalAttainmentReport.cshtml"
                 foreach (var officer in Model)
                {
                    trclass = i % 2 == 0 ? "even" : "odd";


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr");
            BeginWriteAttribute("class", " class=\"", 1197, "\"", 1213, 1);
#nullable restore
#line 39 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\EducationalAttainmentReport.cshtml"
WriteAttributeValue("", 1205, trclass, 1205, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"border-top:2px solid black\">\r\n\r\n                        <td");
            BeginWriteAttribute("rowspan", " rowspan=\"", 1281, "\"", 1328, 1);
#nullable restore
#line 41 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\EducationalAttainmentReport.cshtml"
WriteAttributeValue("", 1291, officer.EducationalAttainments.Count, 1291, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><b>");
#nullable restore
#line 41 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\EducationalAttainmentReport.cshtml"
                                                                          Write(officer.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n                        <td>");
#nullable restore
#line 42 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\EducationalAttainmentReport.cshtml"
                       Write(officer.EducationalAttainments.First().Certificate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 43 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\EducationalAttainmentReport.cshtml"
                       Write(officer.EducationalAttainments.First().Source);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 44 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\EducationalAttainmentReport.cshtml"
                       Write(officer.EducationalAttainments.First().Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 45 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\EducationalAttainmentReport.cshtml"
                       Write(officer.EducationalAttainments.First().Grade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 48 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\EducationalAttainmentReport.cshtml"
                    var j = 0;

                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\EducationalAttainmentReport.cshtml"
                     foreach (var ed in officer.EducationalAttainments)
                    {


                        if (j != 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr");
            BeginWriteAttribute("class", " class=\"", 1941, "\"", 1957, 1);
#nullable restore
#line 56 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\EducationalAttainmentReport.cshtml"
WriteAttributeValue("", 1949, trclass, 1949, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <td>");
#nullable restore
#line 57 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\EducationalAttainmentReport.cshtml"
                               Write(ed.Certificate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 58 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\EducationalAttainmentReport.cshtml"
                               Write(ed.Source);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 59 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\EducationalAttainmentReport.cshtml"
                               Write(ed.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 60 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\EducationalAttainmentReport.cshtml"
                               Write(ed.Grade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 62 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\EducationalAttainmentReport.cshtml"
                        }
                        j++;

                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\EducationalAttainmentReport.cshtml"
                     
                    i++;

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n");
                WriteLiteral(@"
    <style>
        .odd {
            background-color: #dee2e6 !important;
        }

        .even {
            background-color: unset !important;
        }

        table.dataTable td, table.dataTable th {
            text-align: center;
            vertical-align: middle !important;
        }

        .table-bordered td, .table-bordered th {
            border: 1px solid #495057 !important;
        }

        thead {
            background-color: #3397fb;
        }
        
    </style>

");
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
