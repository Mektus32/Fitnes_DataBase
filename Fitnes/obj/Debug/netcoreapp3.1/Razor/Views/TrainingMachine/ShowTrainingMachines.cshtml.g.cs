#pragma checksum "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\TrainingMachine\ShowTrainingMachines.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "544772912641e964c43399150b8d03f6a195660e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TrainingMachine_ShowTrainingMachines), @"mvc.1.0.view", @"/Views/TrainingMachine/ShowTrainingMachines.cshtml")]
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
#line 1 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\TrainingMachine\ShowTrainingMachines.cshtml"
using Fitnes.Storage.Repository;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"544772912641e964c43399150b8d03f6a195660e", @"/Views/TrainingMachine/ShowTrainingMachines.cshtml")]
    public class Views_TrainingMachine_ShowTrainingMachines : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TrainingMachine>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 50px; width: 50px; display: block;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/MainBG.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\TrainingMachine\ShowTrainingMachines.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<table class=""table table-hover"">
    <thead>
        <tr>
            <th scope=""col"">Image</th>
            <th scope=""col"">TrainingMachineId</th>
            <th scope=""col"">Name</th>
            <th scope=""col"">Is for hand</th>
            <th scope=""col"">Is for leg</th>
            <th scope=""col"">Is for back</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 18 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\TrainingMachine\ShowTrainingMachines.cshtml"
         foreach (var elem in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr class=\"table-success\">\r\n            <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "544772912641e964c43399150b8d03f6a195660e4532", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 20 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\TrainingMachine\ShowTrainingMachines.cshtml"
AddHtmlAttributeValue("", 644, elem.Name, 644, 10, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue(" ", 654, "photo", 655, 6, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\TrainingMachine\ShowTrainingMachines.cshtml"
           Write(elem.TrainingMachineId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\TrainingMachine\ShowTrainingMachines.cshtml"
           Write(elem.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 23 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\TrainingMachine\ShowTrainingMachines.cshtml"
             if (elem.IsForHand == true) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>Yes</td>\r\n");
#nullable restore
#line 25 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\TrainingMachine\ShowTrainingMachines.cshtml"
            }
            else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>No</td>\r\n");
#nullable restore
#line 28 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\TrainingMachine\ShowTrainingMachines.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\TrainingMachine\ShowTrainingMachines.cshtml"
             if (elem.IsForLeg == true) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>Yes</td>\r\n");
#nullable restore
#line 31 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\TrainingMachine\ShowTrainingMachines.cshtml"
            }
            else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>No</td>\r\n");
#nullable restore
#line 34 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\TrainingMachine\ShowTrainingMachines.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\TrainingMachine\ShowTrainingMachines.cshtml"
             if (elem.IsForBack == true) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>Yes</td>\r\n");
#nullable restore
#line 37 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\TrainingMachine\ShowTrainingMachines.cshtml"
            }
            else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>No</td>\r\n");
#nullable restore
#line 40 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\TrainingMachine\ShowTrainingMachines.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>\r\n");
#nullable restore
#line 42 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\TrainingMachine\ShowTrainingMachines.cshtml"
                 using (Html.BeginForm("UpdateTrainingMachine", "TrainingMachine", FormMethod.Get)) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div>\r\n                        <input type=\"hidden\" name=\"id\"");
            BeginWriteAttribute("value", " value=\"", 1408, "\"", 1439, 1);
#nullable restore
#line 44 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\TrainingMachine\ShowTrainingMachines.cshtml"
WriteAttributeValue("", 1416, elem.TrainingMachineId, 1416, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        <input type=\"submit\" class=\"btn btn-outline-success\" value=\"Update\" />\r\n                    </div>\r\n");
#nullable restore
#line 47 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\TrainingMachine\ShowTrainingMachines.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n");
#nullable restore
#line 50 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\TrainingMachine\ShowTrainingMachines.cshtml"
                 using (Html.BeginForm("DeleteTrainingMachine", "TrainingMachine", FormMethod.Get)) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div>\r\n                        <input type=\"hidden\" name=\"id\"");
            BeginWriteAttribute("value", " value=\"", 1809, "\"", 1840, 1);
#nullable restore
#line 52 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\TrainingMachine\ShowTrainingMachines.cshtml"
WriteAttributeValue("", 1817, elem.TrainingMachineId, 1817, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        <input type=\"submit\" class=\"btn btn-outline-success\" value=\"Delete\" />\r\n                    </div>\r\n");
#nullable restore
#line 55 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\TrainingMachine\ShowTrainingMachines.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n        </tr>\r\n");
#nullable restore
#line 58 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\TrainingMachine\ShowTrainingMachines.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
#nullable restore
#line 61 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\TrainingMachine\ShowTrainingMachines.cshtml"
 using (Html.BeginForm("CreateTrainingMachine", "TrainingMachine", FormMethod.Get)) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <input type=\"submit\" class=\"btn btn-success\" value=\"Add training machine\" />\r\n    </div>\r\n");
#nullable restore
#line 65 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\TrainingMachine\ShowTrainingMachines.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TrainingMachine>> Html { get; private set; }
    }
}
#pragma warning restore 1591