#pragma checksum "C:\Users\Stephen\Desktop\updated\DLA\DLA_Thesis\Views\User\ChangePassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "634d4253f04c54b7446078ce6e222f8f62cb5b8a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_ChangePassword), @"mvc.1.0.view", @"/Views/User/ChangePassword.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/ChangePassword.cshtml", typeof(AspNetCore.Views_User_ChangePassword))]
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
#line 1 "C:\Users\Stephen\Desktop\updated\DLA\DLA_Thesis\Views\_ViewImports.cshtml"
using DLA_Thesis;

#line default
#line hidden
#line 2 "C:\Users\Stephen\Desktop\updated\DLA\DLA_Thesis\Views\_ViewImports.cshtml"
using DLA_Thesis.Models;

#line default
#line hidden
#line 3 "C:\Users\Stephen\Desktop\updated\DLA\DLA_Thesis\Views\_ViewImports.cshtml"
using DLA_Thesis.Data.Model;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"634d4253f04c54b7446078ce6e222f8f62cb5b8a", @"/Views/User/ChangePassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf7e3b34e2e060632a06c52427a34d454a7ba707", @"/Views/_ViewImports.cshtml")]
    public class Views_User_ChangePassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("change-pass"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Stephen\Desktop\updated\DLA\DLA_Thesis\Views\User\ChangePassword.cshtml"
  
    ViewData["Title"] = "ChangePassword";
    Layout = "~/Views/Shared/adminLayout.cshtml";

#line default
#line hidden
            BeginContext(103, 589, true);
            WriteLiteral(@"
<div class=""content"">

    <div class=""row"">
        <div class=""col-md-12"">
            <div style=""padding:2%;"" class=""card"">





                <style>


                    small {
                        color: red;
                    }
                </style>

                <br />
                <br />


                <div class=""features"">
                    <div id=""container"" class=""container"">





                        <h3>Change Password</h3>

                        <div id=""success""></div>





                        ");
            EndContext();
            BeginContext(692, 1753, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "634d4253f04c54b7446078ce6e222f8f62cb5b8a5148", async() => {
                BeginContext(745, 1693, true);
                WriteLiteral(@"




                            <div class=""row features_row"">
                                <input id=""lrn"" type=""hidden"" />
                                <!-- Features Item -->
                                <div class=""col-md-12 feature_col"">
                                    <label> Old Password </label>
                                    <input id=""old_pass"" class=""form-control"" type=""password"" />    <small id=""old_pass_v""></small>
                                </div>



                            </div>


                            <div class=""row features_row"">

                                <!-- Features Item -->
                                <div class=""col-md-12 feature_col"">
                                    <label> Password </label>
                                    <input id=""pass"" class=""form-control"" type=""password"" />    <small id=""pass_v""></small>
                                </div>



                            </div>

                  ");
                WriteLiteral(@"          <div class=""row features_row"">

                                <!-- Features Item -->
                                <div class=""col-md-12 feature_col"">
                                    <label> Repeat Password </label>
                                    <input id=""r_pass"" class=""form-control"" type=""password"" />    <small id=""r_pass_v""></small>
                                </div>



                            </div>







                            <br />




                            <br />
                            <input class=""btn btn-primary"" type=""submit"" value=""Change Password"" />
                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2445, 1765, true);
            WriteLiteral(@"


                    </div>
                </div>

                <script>
                    var username = sessionStorage.getItem(""username"");
                    $.ajax({

                        url: '/Student/GetStudent',
                        type: 'get',
                        data: { username: username },
                        success: function (e) {
                            $('#lrn').val(e.lrn);
                        }

                    });

                </script>







            </div>
        </div>
    </div>
</div>



<script>
     $('#changepass').addClass('active');

    document.getElementById('change-pass').onsubmit = function () {

      
        var lrn = $('#lrn').val();




        if ($('#pass').val() != $('#r_pass').val()) {
            $('#r_pass_v').html(""Password Doesn't Match"");
            return false;
        } else {
               $('#r_pass_v').html("""");
        }


      
        $.ajax({
         ");
            WriteLiteral(@"   type: ""POST"",
            url: '/User/ChangePasswordExecute',
            data: { lrn: lrn, oldpass: $('#old_pass').val() , newpass: $('#pass').val() },
            success: function (data) {

                if (data.split(',').includes(""wrong_old_password"")) {
                    $('#old_pass_v').html(""Wrong Old Password"");
                }else {
                   $('#old_pass_v').html("""");
                }

           

                if (data == ""success"") {
                    $('#success').html(""  <div class='alert alert-success'>Successfully Changed</div>"");
                       $('#old_pass_v').html("""");
                }

            }
        });

        return false;
    }

</script>

");
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
