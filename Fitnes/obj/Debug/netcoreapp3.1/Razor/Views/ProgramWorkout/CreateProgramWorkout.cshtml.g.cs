#pragma checksum "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\ProgramWorkout\CreateProgramWorkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "485e6fe463edff1cea14404525346345037d3be1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProgramWorkout_CreateProgramWorkout), @"mvc.1.0.view", @"/Views/ProgramWorkout/CreateProgramWorkout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"485e6fe463edff1cea14404525346345037d3be1", @"/Views/ProgramWorkout/CreateProgramWorkout.cshtml")]
    public class Views_ProgramWorkout_CreateProgramWorkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<KeyValuePair<int, string>>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\ProgramWorkout\CreateProgramWorkout.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\ProgramWorkout\CreateProgramWorkout.cshtml"
 using (Html.BeginForm("Create", "ProgramWorkout", FormMethod.Post)) {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <fieldset class=""container"">
        <legend>Create data</legend>
        <div class=""form-group"">
            <label for=""name"">Name</label>
            <input type=""text"" required class=""form-control"" name=""Name"" id=""name"" aria-describedby=""nameHelp""");
            BeginWriteAttribute("value", " value=\"", 406, "\"", 414, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"selectAuthor\">Choose author</label>\r\n            <select class=\"form-control\" name=\"AuthorId\" id=\"selectAuthor\">\r\n");
#nullable restore
#line 16 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\ProgramWorkout\CreateProgramWorkout.cshtml"
                 foreach (var elem in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <option");
            BeginWriteAttribute("value", " value=\"", 681, "\"", 698, 1);
#nullable restore
#line 17 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\ProgramWorkout\CreateProgramWorkout.cshtml"
WriteAttributeValue("", 689, elem.Key, 689, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 17 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\ProgramWorkout\CreateProgramWorkout.cshtml"
                                         Write(elem.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 18 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\ProgramWorkout\CreateProgramWorkout.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </select>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"period\">Period</label>\r\n            <input type=\"number\" required class=\"form-control\" min=\"1\" name=\"Period\" id=\"period\" aria-describedby=\"periodHelp\"");
            BeginWriteAttribute("value", " value=\"", 988, "\"", 996, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        </div>\r\n        <button type=\"submit\" class=\"btn btn-primary\">Create</button>\r\n    </fieldset>\r\n");
#nullable restore
#line 27 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\ProgramWorkout\CreateProgramWorkout.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<KeyValuePair<int, string>>> Html { get; private set; }
    }
}
#pragma warning restore 1591
