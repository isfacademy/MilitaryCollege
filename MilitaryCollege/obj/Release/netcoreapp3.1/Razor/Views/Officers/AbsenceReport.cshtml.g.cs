#pragma checksum "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\AbsenceReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4bc51d72844b927dd1adfb8e019b4cf77639ad6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Officers_AbsenceReport), @"mvc.1.0.view", @"/Views/Officers/AbsenceReport.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bc51d72844b927dd1adfb8e019b4cf77639ad6d", @"/Views/Officers/AbsenceReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3054cbe11b3537a2b6c9743cac8d19e3344331d", @"/Views/_ViewImports.cshtml")]
    public class Views_Officers_AbsenceReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MilitaryCollege.Models.ViewModels.OfficerVM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<table class=""dataTable table-striped table-bordered mb-3 mt-2"" style=""width:100%"">
    <thead>
        <tr>
            <th>
                الاسم و الشهرة
            </th>
            <th>
                السبب
            </th>
            <th>
                من
            </th>
            <th>
                الى
            </th>
            <th>
                عدد الايام
            </th>
            <th>ملاحظات</th>
            <th>المجموع </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 26 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\AbsenceReport.cshtml"
          
            var i = 0;
            string trclass = "";

        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 33 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\AbsenceReport.cshtml"
         foreach (var officer in Model)
        {
            trclass = i % 2 == 0 ? "even" : "odd";

            // blue border bottom on td with rowspan
            string latestRecord = i == Model.Count() - 1 ? "border-bottom : 2px solid #3397fb !important" : "";
            int TotalCountOfIncidentsForOfficer = officer.TotalCountOfIncidentsForOfficer != 0 ? officer.TotalCountOfIncidentsForOfficer : 0;
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\AbsenceReport.cshtml"
             if (TotalCountOfIncidentsForOfficer == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr");
            BeginWriteAttribute("class", " class=\"", 1184, "\"", 1200, 1);
#nullable restore
#line 42 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\AbsenceReport.cshtml"
WriteAttributeValue("", 1192, trclass, 1192, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"border-top:2px solid #3397fb !important\">\r\n                    <td");
            BeginWriteAttribute("style", " style=\"", 1275, "\"", 1296, 1);
#nullable restore
#line 43 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\AbsenceReport.cshtml"
WriteAttributeValue("", 1283, latestRecord, 1283, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><b>");
#nullable restore
#line 43 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\AbsenceReport.cshtml"
                                            Write(officer.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n                    <td>-</td>\r\n                    <td>-</td>\r\n                    <td>-</td>\r\n                    <td>-</td>\r\n                    <td>-</td>\r\n                    <td>-</td>\r\n                </tr>\r\n");
#nullable restore
#line 51 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\AbsenceReport.cshtml"

            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr");
            BeginWriteAttribute("class", " class=\"", 1609, "\"", 1625, 1);
#nullable restore
#line 55 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\AbsenceReport.cshtml"
WriteAttributeValue("", 1617, trclass, 1617, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"border-top:2px solid #3397fb !important\">\r\n                    <td");
            BeginWriteAttribute("rowspan", " rowspan=\"", 1700, "\"", 1742, 1);
#nullable restore
#line 56 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\AbsenceReport.cshtml"
WriteAttributeValue("", 1710, TotalCountOfIncidentsForOfficer, 1710, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("style", " style=\"", 1743, "\"", 1764, 1);
#nullable restore
#line 56 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\AbsenceReport.cshtml"
WriteAttributeValue("", 1751, latestRecord, 1751, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><b>");
#nullable restore
#line 56 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\AbsenceReport.cshtml"
                                                                                       Write(officer.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n                    <td>");
#nullable restore
#line 57 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\AbsenceReport.cshtml"
                   Write(officer.DailyIncidentents.First().ReasonOfIncident.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 58 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\AbsenceReport.cshtml"
                   Write(officer.DailyIncidentents.First().StartDate.Value.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 59 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\AbsenceReport.cshtml"
                   Write(officer.DailyIncidentents.First().EndDate.Value.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 60 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\AbsenceReport.cshtml"
                   Write(officer.DailyIncidentents.First().CountDaysOfIncident);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 61 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\AbsenceReport.cshtml"
                   Write(officer.DailyIncidentents.First().Explanation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 62 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\AbsenceReport.cshtml"
                     if (TotalCountOfIncidentsForOfficer != 1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td");
            BeginWriteAttribute("rowspan", " rowspan=\"", 2362, "\"", 2404, 1);
#nullable restore
#line 64 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\AbsenceReport.cshtml"
WriteAttributeValue("", 2372, TotalCountOfIncidentsForOfficer, 2372, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("style", " style=\"", 2405, "\"", 2426, 1);
#nullable restore
#line 64 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\AbsenceReport.cshtml"
WriteAttributeValue("", 2413, latestRecord, 2413, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 64 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\AbsenceReport.cshtml"
                                                                                        Write(officer.SumOfDaysInIncidentsForOfficer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 65 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\AbsenceReport.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td");
            BeginWriteAttribute("style", " style=\"", 2573, "\"", 2594, 1);
#nullable restore
#line 68 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\AbsenceReport.cshtml"
WriteAttributeValue("", 2581, latestRecord, 2581, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 68 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\AbsenceReport.cshtml"
                                             Write(officer.SumOfDaysInIncidentsForOfficer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 69 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\AbsenceReport.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </tr>\r\n");
#nullable restore
#line 72 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\AbsenceReport.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\AbsenceReport.cshtml"
             


            var j = 0;
            if (officer.DailyIncidentents.Count > 0)
            {
                foreach (var di in officer.DailyIncidentents)
                {
                    if (j != 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr");
            BeginWriteAttribute("class", " class=\"", 2967, "\"", 2983, 1);
#nullable restore
#line 82 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\AbsenceReport.cshtml"
WriteAttributeValue("", 2975, trclass, 2975, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                            <td>");
#nullable restore
#line 84 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\AbsenceReport.cshtml"
                           Write(di.ReasonOfIncident.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 85 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\AbsenceReport.cshtml"
                           Write(di.StartDate.Value.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 86 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\AbsenceReport.cshtml"
                           Write(di.EndDate.Value.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 87 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\AbsenceReport.cshtml"
                           Write(di.CountDaysOfIncident);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 88 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\AbsenceReport.cshtml"
                           Write(di.Explanation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 90 "C:\Users\DAMAJ-PC\Documents\Visual Studio 2019\Project\MilitaryCollege\MilitaryCollege\Views\Officers\AbsenceReport.cshtml"
                    }
                    j++;
                }

                i++;
            }
          
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n\r\n");
            DefineSection("Styles", async() => {
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


        tr.odd > td {
            border-color: #b5b5b5 !important;
        }

        thead {
            font-size: 1.3em;
        }

        table tr:last-child {
            border-bottom: 2px solid #3397fb !important;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MilitaryCollege.Models.ViewModels.OfficerVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
