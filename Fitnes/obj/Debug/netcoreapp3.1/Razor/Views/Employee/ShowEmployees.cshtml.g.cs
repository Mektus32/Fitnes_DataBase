#pragma checksum "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\ShowEmployees.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d625f193104c6eb5ff54d443b1992627ce4d0350"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_ShowEmployees), @"mvc.1.0.view", @"/Views/Employee/ShowEmployees.cshtml")]
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
#line 1 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\ShowEmployees.cshtml"
using Fitnes.Storage.Manager.Employers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d625f193104c6eb5ff54d443b1992627ce4d0350", @"/Views/Employee/ShowEmployees.cshtml")]
    public class Views_Employee_ShowEmployees : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EmployeeWithPositionAndGymName>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\ShowEmployees.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container\">\r\n");
#nullable restore
#line 7 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\ShowEmployees.cshtml"
         using (Html.BeginForm("SearchEmployee", "Employee", FormMethod.Post)) {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"form-inline my-2 my-lg-0\">\r\n                <input class=\"form-control mr-sm-2\" required type=\"text\" name=\"text\" placeholder=\"Search\"");
            BeginWriteAttribute("value", " value=\"", 386, "\"", 394, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                <button class=""btn btn-primary my-2 my-sm-0"" type=""submit"">Search</button>
                <div class=""btn-group btn-group-toggle"" data-toggle=""buttons"">
                    <label class=""btn btn-secondary"">
                        <input type=""radio"" name=""term"" id=""option1"" value=""1"" autocomplete=""off"" checked> Position name
                    </label>
                    <label class=""btn btn-secondary"">
                        <input type=""radio"" name=""term"" id=""option2"" value=""2"" autocomplete=""off""> Name
                    </label>
                    <label class=""btn btn-secondary"">
                        <input type=""radio"" name=""term"" id=""option3"" value=""3"" autocomplete=""off""> Experience
                    </label>
                    <label class=""btn btn-secondary"">
                        <input type=""radio"" name=""term"" id=""option4"" value=""4"" autocomplete=""off""> Salary
                    </label>
                    <label class=""btn btn-secondary"">
         ");
            WriteLiteral("               <input type=\"radio\" name=\"term\" id=\"option5\" value=\"5\" autocomplete=\"off\"> Gym name\r\n                    </label>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 29 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\ShowEmployees.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table table-hover"">
            <thead>
                <tr>
                    <th scope=""col"">EmployeeId</th>
                    <th scope=""col"">Position name</th>
                    <th scope=""col"">Name</th>
                    <th scope=""col"">Experience</th>
                    <th scope=""col"">Salary</th>
                    <th scope=""col"">Gym</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 42 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\ShowEmployees.cshtml"
                 foreach (var elem in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"table-success\">\r\n                        <td>");
#nullable restore
#line 44 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\ShowEmployees.cshtml"
                       Write(elem.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 45 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\ShowEmployees.cshtml"
                       Write(elem.PositionName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 46 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\ShowEmployees.cshtml"
                       Write(elem.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 47 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\ShowEmployees.cshtml"
                       Write(elem.Experience);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 48 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\ShowEmployees.cshtml"
                       Write(elem.Salary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 49 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\ShowEmployees.cshtml"
                       Write(elem.GymName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n");
#nullable restore
#line 51 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\ShowEmployees.cshtml"
                             using (Html.BeginForm("UpdateEmployee", "Employee", FormMethod.Get)) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div>\r\n                                    <input type=\"hidden\" name=\"id\"");
            BeginWriteAttribute("value", " value=\"", 2679, "\"", 2695, 1);
#nullable restore
#line 53 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\ShowEmployees.cshtml"
WriteAttributeValue("", 2687, elem.Id, 2687, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                    <input type=\"submit\" class=\"btn btn-outline-success\" value=\"Update\" />\r\n                                </div>\r\n");
#nullable restore
#line 56 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\ShowEmployees.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                        <td>\r\n");
#nullable restore
#line 59 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\ShowEmployees.cshtml"
                             using (Html.BeginForm("DeleteEmployee", "Employee", FormMethod.Get)) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div>\r\n                                    <input type=\"hidden\" name=\"id\"");
            BeginWriteAttribute("value", " value=\"", 3147, "\"", 3163, 1);
#nullable restore
#line 61 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\ShowEmployees.cshtml"
WriteAttributeValue("", 3155, elem.Id, 3155, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                    <input type=\"submit\" class=\"btn btn-outline-success\" value=\"Delete\" />\r\n                                </div>\r\n");
#nullable restore
#line 64 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\ShowEmployees.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 67 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\ShowEmployees.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 70 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\ShowEmployees.cshtml"
         using (Html.BeginForm("CreateEmployee", "Employee", FormMethod.Get)) {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>\r\n                <input type=\"submit\" class=\"btn btn-success\" value=\"Add employee\" />\r\n            </div>\r\n");
#nullable restore
#line 74 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\ShowEmployees.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\ShowEmployees.cshtml"
         using (Html.BeginForm("ShowPositions", "Position", FormMethod.Get)) {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>\r\n                <input type=\"submit\" class=\"btn btn-success\" value=\"Show positions\" />\r\n            </div>\r\n");
#nullable restore
#line 79 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\ShowEmployees.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EmployeeWithPositionAndGymName>> Html { get; private set; }
    }
}
#pragma warning restore 1591
