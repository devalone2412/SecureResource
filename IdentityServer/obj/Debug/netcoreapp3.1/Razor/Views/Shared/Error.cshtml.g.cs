#pragma checksum "/home/sang/projects/run-aspnet-identityserver4/SecureResource/IdentityServer/Views/Shared/Error.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "a7f0cc00dbcfb4b8612419cf818e5c39b86fc217d339dee445497bd241a6167a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/home/sang/projects/run-aspnet-identityserver4/SecureResource/IdentityServer/Views/_ViewImports.cshtml"
using IdentityServerHost.Quickstart.UI;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"a7f0cc00dbcfb4b8612419cf818e5c39b86fc217d339dee445497bd241a6167a", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"70172ad1e11deb98c0fed2168cf30f9a40e06246251c96f3cd8e3b0a42d7f218", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ErrorViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/home/sang/projects/run-aspnet-identityserver4/SecureResource/IdentityServer/Views/Shared/Error.cshtml"
  
    var error = Model?.Error?.Error;
    var errorDescription = Model?.Error?.ErrorDescription;
    var request_id = Model?.Error?.RequestId;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"error-page\">\n    <div class=\"lead\">\n        <h1>Error</h1>\n    </div>\n\n    <div class=\"row\">\n        <div class=\"col-sm-6\">\n            <div class=\"alert alert-danger\">\n                Sorry, there was an error\n\n");
#nullable restore
#line 19 "/home/sang/projects/run-aspnet-identityserver4/SecureResource/IdentityServer/Views/Shared/Error.cshtml"
                 if (error != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <strong>\n                        <em>\n                            : ");
#nullable restore
#line 23 "/home/sang/projects/run-aspnet-identityserver4/SecureResource/IdentityServer/Views/Shared/Error.cshtml"
                         Write(error);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </em>\n                    </strong>\n");
#nullable restore
#line 26 "/home/sang/projects/run-aspnet-identityserver4/SecureResource/IdentityServer/Views/Shared/Error.cshtml"

                    if (errorDescription != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div>");
#nullable restore
#line 29 "/home/sang/projects/run-aspnet-identityserver4/SecureResource/IdentityServer/Views/Shared/Error.cshtml"
                        Write(errorDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
#nullable restore
#line 30 "/home/sang/projects/run-aspnet-identityserver4/SecureResource/IdentityServer/Views/Shared/Error.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n\n");
#nullable restore
#line 34 "/home/sang/projects/run-aspnet-identityserver4/SecureResource/IdentityServer/Views/Shared/Error.cshtml"
             if (request_id != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"request-id\">Request Id: ");
#nullable restore
#line 36 "/home/sang/projects/run-aspnet-identityserver4/SecureResource/IdentityServer/Views/Shared/Error.cshtml"
                                               Write(request_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
#nullable restore
#line 37 "/home/sang/projects/run-aspnet-identityserver4/SecureResource/IdentityServer/Views/Shared/Error.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrorViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
