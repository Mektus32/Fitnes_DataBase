#pragma checksum "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\TrainingMachine\UpdateTrainingMachine.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8e10731c5831fd9ab40bafba02401be6adf66cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TrainingMachine_UpdateTrainingMachine), @"mvc.1.0.view", @"/Views/TrainingMachine/UpdateTrainingMachine.cshtml")]
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
#line 1 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\TrainingMachine\UpdateTrainingMachine.cshtml"
using Fitnes.Storage.Repository;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8e10731c5831fd9ab40bafba02401be6adf66cf", @"/Views/TrainingMachine/UpdateTrainingMachine.cshtml")]
    public class Views_TrainingMachine_UpdateTrainingMachine : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TrainingMachine>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\TrainingMachine\UpdateTrainingMachine.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\TrainingMachine\UpdateTrainingMachine.cshtml"
 using (Html.BeginForm("Update", "TrainingMachine", FormMethod.Post)) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <fieldset class=\"container\">\r\n        <input type=\"hidden\" name=\"id\"");
            BeginWriteAttribute("value", " value=\"", 237, "\"", 269, 1);
#nullable restore
#line 8 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\TrainingMachine\UpdateTrainingMachine.cshtml"
WriteAttributeValue("", 245, Model.TrainingMachineId, 245, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <legend>Update data</legend>\r\n        <div class=\"form-group\">\r\n            <label for=\"name\">Name</label>\r\n            <input type=\"text\" required class=\"form-control\" name=\"Name\" id=\"name\" aria-describedby=\"nameHelp\"");
            BeginWriteAttribute("value", " value=\"", 501, "\"", 509, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        </div>\r\n        <div class=\"form-group\">\r\n");
#nullable restore
#line 15 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\TrainingMachine\UpdateTrainingMachine.cshtml"
             if (Model.IsForHand == true) {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""custom-control custom-checkbox"">
                    <input type=""checkbox"" class=""custom-control-input"" id=""isForHand"" value=""true"" name=""IsForHand"" checked>
                    <label class=""custom-control-label"" for=""isForHand"">Is for hand</label>
                </div>
");
#nullable restore
#line 20 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\TrainingMachine\UpdateTrainingMachine.cshtml"
            }
            else {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""custom-control custom-checkbox"">
                    <input type=""checkbox"" class=""custom-control-input"" id=""isForHand"" value=""true"" name=""IsForHand"">
                    <label class=""custom-control-label"" for=""isForHand"">Is for hand</label>
                </div>
");
#nullable restore
#line 26 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\TrainingMachine\UpdateTrainingMachine.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\TrainingMachine\UpdateTrainingMachine.cshtml"
             if (Model.IsForLeg == true) {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""custom-control custom-checkbox"">
                    <input type=""checkbox"" class=""custom-control-input"" id=""isForLeg"" value=""true"" name=""IsForLeg"" checked>
                    <label class=""custom-control-label"" for=""isForLeg"">Is for leg</label>
                </div>
");
#nullable restore
#line 32 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\TrainingMachine\UpdateTrainingMachine.cshtml"
            }
            else {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""custom-control custom-checkbox"">
                    <input type=""checkbox"" class=""custom-control-input"" id=""isForLeg"" value=""true"" name=""IsForLeg"">
                    <label class=""custom-control-label"" for=""isForLeg"">Is for leg</label>
                </div>
");
#nullable restore
#line 38 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\TrainingMachine\UpdateTrainingMachine.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\TrainingMachine\UpdateTrainingMachine.cshtml"
             if (Model.IsForBack == true) {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""custom-control custom-checkbox"">
                    <input type=""checkbox"" class=""custom-control-input"" id=""isForBack"" value=""true"" name=""IsForBack"" checked>
                    <label class=""custom-control-label"" for=""isForBack"">Is for back</label>
                </div>
");
#nullable restore
#line 44 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\TrainingMachine\UpdateTrainingMachine.cshtml"
            }
            else {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""custom-control custom-checkbox"">
                    <input type=""checkbox"" class=""custom-control-input"" id=""isForBack"" value=""true"" name=""IsForBack"">
                    <label class=""custom-control-label"" for=""isForBack"">Is for back</label>
                </div>
");
#nullable restore
#line 50 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\TrainingMachine\UpdateTrainingMachine.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <button type=\"submit\" class=\"btn btn-primary\">Update</button>\r\n    </fieldset>\r\n");
#nullable restore
#line 54 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\TrainingMachine\UpdateTrainingMachine.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TrainingMachine> Html { get; private set; }
    }
}
#pragma warning restore 1591
