#pragma checksum "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Subscription\UpdateSubscription.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "551d5e55adfe4ee9e43594ffad37ec5324687204"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Subscription_UpdateSubscription), @"mvc.1.0.view", @"/Views/Subscription/UpdateSubscription.cshtml")]
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
#line 1 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Subscription\UpdateSubscription.cshtml"
using Fitnes.Storage.Repository;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"551d5e55adfe4ee9e43594ffad37ec5324687204", @"/Views/Subscription/UpdateSubscription.cshtml")]
    public class Views_Subscription_UpdateSubscription : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Subscription>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Subscription\UpdateSubscription.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Subscription\UpdateSubscription.cshtml"
 using (Html.BeginForm("Update", "Subscription", FormMethod.Post)) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <fieldset class=\"container\">\r\n        <input type=\"hidden\" name=\"id\"");
            BeginWriteAttribute("value", " value=\"", 232, "\"", 261, 1);
#nullable restore
#line 9 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Subscription\UpdateSubscription.cshtml"
WriteAttributeValue("", 240, Model.SubscriptionId, 240, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <legend>Update data</legend>\r\n        <div class=\"form-group\">\r\n            <label for=\"name\">Name</label>\r\n            <input type=\"text\" required class=\"form-control\" name=\"Name\" id=\"name\" aria-describedby=\"nameHelp\"");
            BeginWriteAttribute("value", " value=\"", 493, "\"", 512, 1);
#nullable restore
#line 13 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Subscription\UpdateSubscription.cshtml"
WriteAttributeValue("", 501, Model.Name, 501, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"price\">Price</label>\r\n            <input type=\"number\" required class=\"form-control\" name=\"Price\" id=\"price\"");
            BeginWriteAttribute("value", " value=\"", 698, "\"", 718, 1);
#nullable restore
#line 17 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Subscription\UpdateSubscription.cshtml"
WriteAttributeValue("", 706, Model.Price, 706, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"time\">Months</label>\r\n            <input type=\"number\" required class=\"form-control\" name=\"Time\" id=\"price\"");
            BeginWriteAttribute("value", " value=\"", 903, "\"", 922, 1);
#nullable restore
#line 21 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Subscription\UpdateSubscription.cshtml"
WriteAttributeValue("", 911, Model.Time, 911, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
        </div>
        <div class=""form-group"">
            <label for=""exampleInputFile"">File input</label>
            <input type=""file"" class=""form-control-file"" id=""exampleInputFile"" aria-describedby=""fileHelp"">
            <small id=""fileHelp"" class=""form-text text-muted"">You can input photo new subscription</small>
        </div>
        <button type=""submit"" class=""btn btn-primary"">Update</button>
    </fieldset>
");
#nullable restore
#line 30 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Subscription\UpdateSubscription.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Subscription> Html { get; private set; }
    }
}
#pragma warning restore 1591