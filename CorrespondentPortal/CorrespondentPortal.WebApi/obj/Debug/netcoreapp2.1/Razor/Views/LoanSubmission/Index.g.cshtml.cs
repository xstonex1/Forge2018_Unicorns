#pragma checksum "C:\Users\athigpen\Source\Repos\Forge2018_Unicorns\CorrespondentPortal\CorrespondentPortal.WebApi\Views\LoanSubmission\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b05227477bcacc6634b2eaacef1ce2f360fc799"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LoanSubmission_Index), @"mvc.1.0.view", @"/Views/LoanSubmission/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/LoanSubmission/Index.cshtml", typeof(AspNetCore.Views_LoanSubmission_Index))]
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
#line 4 "C:\Users\athigpen\Source\Repos\Forge2018_Unicorns\CorrespondentPortal\CorrespondentPortal.WebApi\Views\LoanSubmission\Index.cshtml"
using CorrespondentPortal.WebApi.Infrastructure.Shared;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b05227477bcacc6634b2eaacef1ce2f360fc799", @"/Views/LoanSubmission/Index.cshtml")]
    public class Views_LoanSubmission_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\athigpen\Source\Repos\Forge2018_Unicorns\CorrespondentPortal\CorrespondentPortal.WebApi\Views\LoanSubmission\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(156, 6279, true);
            WriteLiteral(@"

<div class=""page-command-area"">
    <div class=""command-heading"">
        <h1 class=""header"">Loan Submission</h1>
    </div>
    <div class=""command-toolbox"">
        <button class=""btn btn-default"">Cancel</button>
    </div>
</div>
<div id=""loanSubmissionDiv"" class=""p-md-5 p-sm-3 p-2"" style=""display:none"">
    <div class=""meta-table"">
        <div class=""card card-knockout"">
            <div class=""card-header"">
                <a aria-controls=""cardCollapse1"" aria-expanded=""true"" class=""collapse-heading collapsed""
                   data-toggle=""collapse"" href=""#cardCollapse1"">
                    Loan Attributes
                </a>
            </div>
            <div aria-labelledby=""cardCollapse1"" class=""collapse"" id=""cardCollapse1"" role=""tabpanel"">
                <div class=""card-body"">
                    <h4 class=""card-title"">First, give us some basic information about the loan:</h4>
                    <div class=""row"">
                        <div class=""col-4"">
         ");
            WriteLiteral(@"                   <div class=""form-group"">
                                <label class=""required"">Loan Reference Number</label>
                                <input aria-required=""true"" class=""form-control"" required=""true""
                                       aria-label=""Loan Reference Number"">
                            </div>
                        </div>
                        <div class=""col-4"">
                            <div class=""form-group"">
                                <label class=""required"">Borrower Name</label>
                                <input aria-required=""true"" class=""form-control"" required=""true""
                                       aria-label=""Borrower Name"">
                            </div>
                        </div>
                        <div class=""col-4"">
                            <div class=""form-group"">
                                <label for=""demoInputField"">Anticipated Closing Date</label>
                                <input class=");
            WriteLiteral(@"""form-control"" id=""demoInputField"">
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""card-footer d-flex justify-content-end"">
                    <button class=""btn btn-primary"">Next</button>
                </div>
            </div>
        </div>

        <div class=""card card-knockout"">
            <div class=""card-header"">
                <a aria-controls=""cardCollapse1"" aria-expanded=""true"" class=""collapse-heading collapsed""
                   data-toggle=""collapse"" href=""#cardCollapse1"">
                    Documents
                </a>
            </div>
            <div aria-labelledby=""cardCollapse1"" class=""collapse"" id=""cardCollapse1"" role=""tabpanel"">
                <div class=""card-body"">
                    <h4 class=""card-title"">Provide any relevant documents for the loan:</h4>
                    <div class=""row"">
                        <div class=""col-4"">
                    ");
            WriteLiteral(@"        <div class=""form-group"">
                                <label for=""fileInput"" class=""required"">Mismo XML</label>
                                <div class=""custom-file"">
                                    <input id=""fileInput"" type=""file"" class=""custom-file-input"" required=""true"" aria-required=""true"">
                                    <div class=""custom-file-control"">
                                        <div class=""input-group"">
                                            <div class=""form-control""></div>
                                            <div class=""input-group-append"">
                                                <button class=""btn btn-default"" type=""button"">Browse</button>
                                            </div>
                                            <button aria-pressed=""false"" class=""btn btn-primary btn-lg btn-icon-only"" data-animation=""false"" data-toggle=""tooltip"" tabindex=""0"" title="""" type=""button"" data-original-title=""Create Order"">
            ");
            WriteLiteral(@"                                    <span class=""fa fa-plus""></span>
                                                <span class=""sr-only"">Add File</span>
                                            </button>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-8""></div>
                    </div>
                    <div class=""row"">
                        <div class=""col-12"">
                            <table class=""table table-bordered col-2-bloat col-1-align-center"">
                                <thead>
                                    <tr>
                                        <th scope=""col"">Filename</th>
                                        <th scope=""col"">Status</th>
                                    </tr>
                                </thead>
                                <tbody data");
            WriteLiteral(@"-bind=""foreach: FilesToUpload"">
                                    <tr data-bind="""">
                                        <td data-bind=""""></td>
                                        <td data-bind=""""></td>
                                    </tr>
                                </tbody>
                            </table>

                        </div>
                    </div>
                </div>
                <div class=""card-footer d-flex justify-content-end"">
                    <button class=""btn btn-primary"">Next</button>
                </div>
            </div>
        </div>
    </div>

</div>
<script>
    jQuery(document).ready(function () {
        $.ajax('Init', {
            contentType: 'application/json; charset=UTF-8',
            cache: false,
            type: 'POST',
            success: function (data) {
                viewModel = new LoanSubmissionViewModel(data, $('#fileInput'));
                ko.applyBindings(viewModel, $('#loanSubmissionDiv'");
            WriteLiteral(")[0]);\r\n                $(\'#loanSubmissionDiv\').show();\r\n                $.unblockUI();\r\n            }\r\n        });\r\n    });\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
