#pragma checksum "C:\Users\muhammad.zunair\Desktop\BasicImageGallery-vs2019-launch\CoreImageGallery\CoreImageGallery\Pages\UploadSuccess.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39c740ff4f5201703389ce286c23fa9433190872"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CoreImageGallery.Pages.Pages_UploadSuccess), @"mvc.1.0.razor-page", @"/Pages/UploadSuccess.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/UploadSuccess.cshtml", typeof(CoreImageGallery.Pages.Pages_UploadSuccess), null)]
namespace CoreImageGallery.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\muhammad.zunair\Desktop\BasicImageGallery-vs2019-launch\CoreImageGallery\CoreImageGallery\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\muhammad.zunair\Desktop\BasicImageGallery-vs2019-launch\CoreImageGallery\CoreImageGallery\Pages\_ViewImports.cshtml"
using CoreImageGallery;

#line default
#line hidden
#line 3 "C:\Users\muhammad.zunair\Desktop\BasicImageGallery-vs2019-launch\CoreImageGallery\CoreImageGallery\Pages\_ViewImports.cshtml"
using CoreImageGallery.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39c740ff4f5201703389ce286c23fa9433190872", @"/Pages/UploadSuccess.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"851008172138ebaba5ff564f18960b2ea02bbf8a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_UploadSuccess : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\muhammad.zunair\Desktop\BasicImageGallery-vs2019-launch\CoreImageGallery\CoreImageGallery\Pages\UploadSuccess.cshtml"
  
    ViewData["Title"] = "UploadSuccess";

#line default
#line hidden
            BeginContext(101, 198, true);
            WriteLiteral("\n<h2>Upload recieved</h2>\n<h3>\n    File is processing, it will be available shortly\n</h3>\n\n<div class=\"row\">\n    <div class=\"col-md-2 success-text\">File</div>\n    <div class=\"col-md-3 success-text\">");
            EndContext();
            BeginContext(300, 14, false);
#line 14 "C:\Users\muhammad.zunair\Desktop\BasicImageGallery-vs2019-launch\CoreImageGallery\CoreImageGallery\Pages\UploadSuccess.cshtml"
                                  Write(Model.FileName);

#line default
#line hidden
            EndContext();
            BeginContext(314, 125, true);
            WriteLiteral("</div>\n</div>\n<div class=\"row\">\n    <div class=\"col-md-2 success-text\">Recieved</div>\n    <div class=\"col-md-3 success-text\">");
            EndContext();
            BeginContext(440, 10, false);
#line 18 "C:\Users\muhammad.zunair\Desktop\BasicImageGallery-vs2019-launch\CoreImageGallery\CoreImageGallery\Pages\UploadSuccess.cshtml"
                                  Write(Model.Time);

#line default
#line hidden
            EndContext();
            BeginContext(450, 93, true);
            WriteLiteral("</div>\n</div>\n\n<br /><br />\n<a class=\"btn btn-primary\" href=\"/Index\">Return to Gallery</a>\n\n\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreImageGallery.Pages.UploadSuccessModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CoreImageGallery.Pages.UploadSuccessModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CoreImageGallery.Pages.UploadSuccessModel>)PageContext?.ViewData;
        public CoreImageGallery.Pages.UploadSuccessModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591