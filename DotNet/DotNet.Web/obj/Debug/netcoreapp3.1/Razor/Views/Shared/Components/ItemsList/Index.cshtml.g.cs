#pragma checksum "D:\STUDIA\aspdotnet\Laby\ASP.NET-WSEI\DotNet\DotNet.Web\Views\Shared\Components\ItemsList\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b844d609000c688457d562632060e3402abe2676"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ItemsList_Index), @"mvc.1.0.view", @"/Views/Shared/Components/ItemsList/Index.cshtml")]
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
#line 1 "D:\STUDIA\aspdotnet\Laby\ASP.NET-WSEI\DotNet\DotNet.Web\Views\_ViewImports.cshtml"
using DotNet.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\STUDIA\aspdotnet\Laby\ASP.NET-WSEI\DotNet\DotNet.Web\Views\_ViewImports.cshtml"
using DotNet.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b844d609000c688457d562632060e3402abe2676", @"/Views/Shared/Components/ItemsList/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be6a85350792ddf59d394cb09e5c91bf03925af1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ItemsList_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DotNet.Web.Entities.ItemEntity>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div>Latest item added: ");
#nullable restore
#line 3 "D:\STUDIA\aspdotnet\Laby\ASP.NET-WSEI\DotNet\DotNet.Web\Views\Shared\Components\ItemsList\Index.cshtml"
                   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DotNet.Web.Entities.ItemEntity> Html { get; private set; }
    }
}
#pragma warning restore 1591