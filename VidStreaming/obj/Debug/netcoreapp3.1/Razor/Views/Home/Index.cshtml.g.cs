#pragma checksum "C:\Users\Chain\Documents\ISTA422\VidStreaming\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc25a0a43c03b50e4be81c04c99683db2217691b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc25a0a43c03b50e4be81c04c99683db2217691b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VidStreaming.Models.ViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Chain\Documents\ISTA422\VidStreaming\Views\Home\Index.cshtml"
   
    var sources = new string[Model.Videos.Count()];
    int i = 0;
    foreach(var video in Model.Videos)
    {
        sources[i] = video.Source;
        i++;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-sm-2\">\r\n        <a class=\'navLink\' href=\'#\'>Videos</a>\r\n        <a class=\'navLink\' href=\'#\'>Favorites</a>\r\n        <a class=\'navLink\' href=\'#\'>Playlists</a>\r\n    </div>\r\n    <div class=\"col-sm-10\">\r\n");
#nullable restore
#line 18 "C:\Users\Chain\Documents\ISTA422\VidStreaming\Views\Home\Index.cshtml"
         foreach (var video in Model.Videos)
        {
            i = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\'vid\'>\r\n                <iframe class=\'video\' height=\"200px\"");
            BeginWriteAttribute("src", " src=", 600, "", 616, 1);
#nullable restore
#line 22 "C:\Users\Chain\Documents\ISTA422\VidStreaming\Views\Home\Index.cshtml"
WriteAttributeValue("", 605, sources[i], 605, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" frameborder=\"0\"\r\n                        allow=\"accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen>\r\n                </iframe>\r\n                <div class=\'comment\'>");
#nullable restore
#line 25 "C:\Users\Chain\Documents\ISTA422\VidStreaming\Views\Home\Index.cshtml"
                                Write(video.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            </div>\r\n");
#nullable restore
#line 27 "C:\Users\Chain\Documents\ISTA422\VidStreaming\Views\Home\Index.cshtml"
            i++;
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VidStreaming.Models.ViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
