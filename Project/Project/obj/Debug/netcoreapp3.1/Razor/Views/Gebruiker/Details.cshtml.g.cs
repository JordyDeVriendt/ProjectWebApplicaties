#pragma checksum "C:\Users\shado\Desktop\Project_Webapplicaties_Copy_0418\Project_Webapplicaties\Project\Project\Views\Gebruiker\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25d76232fe666bca59dc24397c87a0fb84a7997a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Gebruiker_Details), @"mvc.1.0.view", @"/Views/Gebruiker/Details.cshtml")]
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
#line 1 "C:\Users\shado\Desktop\Project_Webapplicaties_Copy_0418\Project_Webapplicaties\Project\Project\Views\_ViewImports.cshtml"
using Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\shado\Desktop\Project_Webapplicaties_Copy_0418\Project_Webapplicaties\Project\Project\Views\_ViewImports.cshtml"
using Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25d76232fe666bca59dc24397c87a0fb84a7997a", @"/Views/Gebruiker/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89e31fbbec8fb4222cf117a26f28137c5b00e63f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Gebruiker_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Project.ViewModels.GebruikersDetailsViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\shado\Desktop\Project_Webapplicaties_Copy_0418\Project_Webapplicaties\Project\Project\Views\Gebruiker\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n    <h1>");
#nullable restore
#line 9 "C:\Users\shado\Desktop\Project_Webapplicaties_Copy_0418\Project_Webapplicaties\Project\Project\Views\Gebruiker\Details.cshtml"
   Write(Model.Naam);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <p>\r\n        Id: ");
#nullable restore
#line 11 "C:\Users\shado\Desktop\Project_Webapplicaties_Copy_0418\Project_Webapplicaties\Project\Project\Views\Gebruiker\Details.cshtml"
       Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n    <p>\r\n        Username: ");
#nullable restore
#line 14 "C:\Users\shado\Desktop\Project_Webapplicaties_Copy_0418\Project_Webapplicaties\Project\Project\Views\Gebruiker\Details.cshtml"
             Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n    <p>\r\n        Geboortedatum: ");
#nullable restore
#line 17 "C:\Users\shado\Desktop\Project_Webapplicaties_Copy_0418\Project_Webapplicaties\Project\Project\Views\Gebruiker\Details.cshtml"
                  Write(Model.GeboorteDatum);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n    ");
#nullable restore
#line 19 "C:\Users\shado\Desktop\Project_Webapplicaties_Copy_0418\Project_Webapplicaties\Project\Project\Views\Gebruiker\Details.cshtml"
Write(Html.ActionLink("Terug","Index","Gebruiker"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Project.ViewModels.GebruikersDetailsViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
