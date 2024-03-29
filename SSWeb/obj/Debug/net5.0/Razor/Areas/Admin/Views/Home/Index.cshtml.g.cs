#pragma checksum "D:\ken\SSweb\SSWeb\Areas\Admin\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "febe8589cf4cab9ec6c2d4c6b6c544e700951c4f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/Index.cshtml")]
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
#line 1 "D:\ken\SSweb\SSWeb\Areas\Admin\Views\_ViewImports.cshtml"
using SSWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ken\SSweb\SSWeb\Areas\Admin\Views\_ViewImports.cshtml"
using SSWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"febe8589cf4cab9ec6c2d4c6b6c544e700951c4f", @"/Areas/Admin/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2e3172f25faaefc9733487812966652994aa6b7", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SSWeb.Models.Employee>>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\ken\SSweb\SSWeb\Areas\Admin\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Container fluid  -->
<!-- ============================================================== -->
<div class=""container-fluid"">
    <!-- ============================================================== -->
    <!-- Three charts -->
    <!-- ============================================================== -->
    <div class=""row justify-content-center"">
        <div class=""col-lg-4 col-md-12"">
            <div class=""white-box analytics-info"">
                <h3 class=""box-title"">Total Visit</h3>
                <ul class=""list-inline two-part d-flex align-items-center mb-0"">
                    <li>
                        <div id=""sparklinedash"">
                            <canvas width=""67"" height=""30""
                                    style=""display: inline-block; width: 67px; height: 30px; vertical-align: top;""></canvas>
                        </div>
                    </li>
                    <li class=""ms-auto""><span class=""counter text-success"">659</span></li>
                </ul>");
            WriteLiteral(@"
            </div>
        </div>
        <div class=""col-lg-4 col-md-12"">
            <div class=""white-box analytics-info"">
                <h3 class=""box-title"">Total Page Views</h3>
                <ul class=""list-inline two-part d-flex align-items-center mb-0"">
                    <li>
                        <div id=""sparklinedash2"">
                            <canvas width=""67"" height=""30""
                                    style=""display: inline-block; width: 67px; height: 30px; vertical-align: top;""></canvas>
                        </div>
                    </li>
                    <li class=""ms-auto""><span class=""counter text-purple"">869</span></li>
                </ul>
            </div>
        </div>
        <div class=""col-lg-4 col-md-12"">
            <div class=""white-box analytics-info"">
                <h3 class=""box-title"">Unique Visitor</h3>
                <ul class=""list-inline two-part d-flex align-items-center mb-0"">
                    <li>
                ");
            WriteLiteral(@"        <div id=""sparklinedash3"">
                            <canvas width=""67"" height=""30""
                                    style=""display: inline-block; width: 67px; height: 30px; vertical-align: top;""></canvas>
                        </div>
                    </li>
                    <li class=""ms-auto"">
                        <span class=""counter text-info"">911</span>
                    </li>
                </ul>
            </div>
        </div>
    </div>
    <!-- ============================================================== -->
    <!-- PRODUCTS YEARLY SALES -->
    <!-- ============================================================== -->
    <div class=""row"">
        <div class=""col-md-12 col-lg-12 col-sm-12 col-xs-12"">
            <div class=""white-box"">
                <h3 class=""box-title"">Products Yearly Sales</h3>
                <div class=""d-md-flex"">
                    <ul class=""list-inline d-flex ms-auto"">
                        <li class=""ps-3"">
            ");
            WriteLiteral(@"                <h5><i class=""fa fa-circle me-1 text-info""></i>Mac</h5>
                        </li>
                        <li class=""ps-3"">
                            <h5><i class=""fa fa-circle me-1 text-inverse""></i>Windows</h5>
                        </li>
                    </ul>
                </div>
                <div id=""ct-visits"" style=""height: 405px;"">
                    <div class=""chartist-tooltip"" style=""top: -17px; left: -12px;"">
                        <span class=""chartist-tooltip-value"">6</span>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- ============================================================== -->
    <!-- RECENT SALES -->
    <!-- ============================================================== -->
    <div class=""row"">
        <div class=""col-md-12 col-lg-12 col-sm-12"">
            <div class=""white-box"">
                <div class=""d-md-flex mb-3"">
                    <h3 class=""box-title mb-0""");
            WriteLiteral(">Recent sales</h3>\r\n                    <div class=\"col-md-3 col-sm-4 col-xs-6 ms-auto\">\r\n                        <select class=\"form-select shadow-none row border-top\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "febe8589cf4cab9ec6c2d4c6b6c544e700951c4f7810", async() => {
                WriteLiteral("March 2021");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "febe8589cf4cab9ec6c2d4c6b6c544e700951c4f8800", async() => {
                WriteLiteral("April 2021");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "febe8589cf4cab9ec6c2d4c6b6c544e700951c4f9790", async() => {
                WriteLiteral("May 2021");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "febe8589cf4cab9ec6c2d4c6b6c544e700951c4f10778", async() => {
                WriteLiteral("June 2021");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "febe8589cf4cab9ec6c2d4c6b6c544e700951c4f11768", async() => {
                WriteLiteral("July 2021");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </select>
                    </div>
                </div>
                <div class=""table-responsive"">
                    <table class=""table no-wrap"">
                        <thead>
                            <tr>
                                <th class=""border-top-0"">#</th>
                                <th class=""border-top-0"">Name</th>
                                <th class=""border-top-0"">Status</th>
                                <th class=""border-top-0"">Date</th>
                                <th class=""border-top-0"">Price</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>1</td>
                                <td class=""txt-oflo"">Elite admin</td>
                                <td>SALE</td>
                                <td class=""txt-oflo"">April 18, 2021</td>
                                <td><span class=""text-suc");
            WriteLiteral(@"cess"">$24</span></td>
                            </tr>
                            <tr>
                                <td>2</td>
                                <td class=""txt-oflo"">Real Homes WP Theme</td>
                                <td>EXTENDED</td>
                                <td class=""txt-oflo"">April 19, 2021</td>
                                <td><span class=""text-info"">$1250</span></td>
                            </tr>
                            <tr>
                                <td>3</td>
                                <td class=""txt-oflo"">Ample Admin</td>
                                <td>EXTENDED</td>
                                <td class=""txt-oflo"">April 19, 2021</td>
                                <td><span class=""text-info"">$1250</span></td>
                            </tr>
                            <tr>
                                <td>4</td>
                                <td class=""txt-oflo"">Medical Pro WP Theme</td>
                        ");
            WriteLiteral(@"        <td>TAX</td>
                                <td class=""txt-oflo"">April 20, 2021</td>
                                <td><span class=""text-danger"">-$24</span></td>
                            </tr>
                            <tr>
                                <td>5</td>
                                <td class=""txt-oflo"">Hosting press html</td>
                                <td>SALE</td>
                                <td class=""txt-oflo"">April 21, 2021</td>
                                <td><span class=""text-success"">$24</span></td>
                            </tr>
                            <tr>
                                <td>6</td>
                                <td class=""txt-oflo"">Digital Agency PSD</td>
                                <td>SALE</td>
                                <td class=""txt-oflo"">April 23, 2021</td>
                                <td><span class=""text-danger"">-$14</span></td>
                            </tr>
                            <");
            WriteLiteral(@"tr>
                                <td>7</td>
                                <td class=""txt-oflo"">Helping Hands WP Theme</td>
                                <td>MEMBER</td>
                                <td class=""txt-oflo"">April 22, 2021</td>
                                <td><span class=""text-success"">$64</span></td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>
    <!-- ============================================================== -->
    <!-- Recent Comments -->
    <!-- ============================================================== -->
    <div class=""row"">
        <!-- .col -->
        <div class=""col-md-12 col-lg-8 col-sm-12"">
            <div class=""card white-box p-0"">
                <div class=""card-body"">
                    <h3 class=""box-title mb-0"">Recent Comments</h3>
                </div>
                <div class=""comment-widgets"">
          ");
            WriteLiteral(@"          <!-- Comment Row -->
                    <div class=""d-flex flex-row comment-row p-3 mt-0"">
                        <div class=""p-2""><img src=""plugins/images/users/varun.jpg"" alt=""user"" width=""50"" class=""rounded-circle""></div>
                        <div class=""comment-text ps-2 ps-md-3 w-100"">
                            <h5 class=""font-medium"">James Anderson</h5>
                            <span class=""mb-3 d-block"">Lorem Ipsum is simply dummy text of the printing and type setting industry.It has survived not only five centuries. </span>
                            <div class=""comment-footer d-md-flex align-items-center"">
                                <span class=""badge bg-primary rounded"">Pending</span>

                                <div class=""text-muted fs-2 ms-auto mt-2 mt-md-0"">April 14, 2021</div>
                            </div>
                        </div>
                    </div>
                    <!-- Comment Row -->
                    <div class=""d-flex fle");
            WriteLiteral(@"x-row comment-row p-3"">
                        <div class=""p-2""><img src=""plugins/images/users/genu.jpg"" alt=""user"" width=""50"" class=""rounded-circle""></div>
                        <div class=""comment-text ps-2 ps-md-3 active w-100"">
                            <h5 class=""font-medium"">Michael Jorden</h5>
                            <span class=""mb-3 d-block"">Lorem Ipsum is simply dummy text of the printing and type setting industry.It has survived not only five centuries. </span>
                            <div class=""comment-footer d-md-flex align-items-center"">

                                <span class=""badge bg-success rounded"">Approved</span>

                                <div class=""text-muted fs-2 ms-auto mt-2 mt-md-0"">April 14, 2021</div>
                            </div>
                        </div>
                    </div>
                    <!-- Comment Row -->
                    <div class=""d-flex flex-row comment-row p-3"">
                        <div class=""p-2""><img");
            WriteLiteral(@" src=""plugins/images/users/ritesh.jpg"" alt=""user"" width=""50"" class=""rounded-circle""></div>
                        <div class=""comment-text ps-2 ps-md-3 w-100"">
                            <h5 class=""font-medium"">Johnathan Doeting</h5>
                            <span class=""mb-3 d-block"">Lorem Ipsum is simply dummy text of the printing and type setting industry.It has survived not only five centuries. </span>
                            <div class=""comment-footer d-md-flex align-items-center"">

                                <span class=""badge rounded bg-danger"">Rejected</span>

                                <div class=""text-muted fs-2 ms-auto mt-2 mt-md-0"">April 14, 2021</div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-lg-4 col-md-12 col-sm-12"">
            <div class=""card white-box p-0"">
                <div class=""card-heading"">
                    <h3 c");
            WriteLiteral(@"lass=""box-title mb-0"">Chat Listing</h3>
                </div>
                <div class=""card-body"">
                    <ul class=""chatonline"">
                        <li>
                            <div class=""call-chat"">
                                <button class=""btn btn-success text-white btn-circle btn"" type=""button"">
                                    <i class=""fas fa-phone""></i>
                                </button>
                                <button class=""btn btn-info btn-circle btn"" type=""button"">
                                    <i class=""far fa-comments text-white""></i>
                                </button>
                            </div>
                            <a href=""javascript:void(0)"" class=""d-flex align-items-center"">
                                <img src=""plugins/images/users/varun.jpg"" alt=""user-img"" class=""img-circle"">
                                <div class=""ms-2"">
                                    <span class=""text-dark"">
       ");
            WriteLiteral(@"                                 Varun Dhavan <small class=""d-block text-success d-block"">online</small>
                                    </span>
                                </div>
                            </a>
                        </li>
                        <li>
                            <div class=""call-chat"">
                                <button class=""btn btn-success text-white btn-circle btn"" type=""button"">
                                    <i class=""fas fa-phone""></i>
                                </button>
                                <button class=""btn btn-info btn-circle btn"" type=""button"">
                                    <i class=""far fa-comments text-white""></i>
                                </button>
                            </div>
                            <a href=""javascript:void(0)"" class=""d-flex align-items-center"">
                                <img src=""plugins/images/users/genu.jpg"" alt=""user-img"" class=""img-circle"">
                 ");
            WriteLiteral(@"               <div class=""ms-2"">
                                    <span class=""text-dark"">
                                        Genelia
                                        Deshmukh <small class=""d-block text-warning"">Away</small>
                                    </span>
                                </div>
                            </a>
                        </li>
                        <li>
                            <div class=""call-chat"">
                                <button class=""btn btn-success text-white btn-circle btn"" type=""button"">
                                    <i class=""fas fa-phone""></i>
                                </button>
                                <button class=""btn btn-info btn-circle btn"" type=""button"">
                                    <i class=""far fa-comments text-white""></i>
                                </button>
                            </div>
                            <a href=""javascript:void(0)"" class=""d-flex align-ite");
            WriteLiteral(@"ms-center"">
                                <img src=""plugins/images/users/ritesh.jpg"" alt=""user-img"" class=""img-circle"">
                                <div class=""ms-2"">
                                    <span class=""text-dark"">
                                        Ritesh
                                        Deshmukh <small class=""d-block text-danger"">Busy</small>
                                    </span>
                                </div>
                            </a>
                        </li>
                        <li>
                            <div class=""call-chat"">
                                <button class=""btn btn-success text-white btn-circle btn"" type=""button"">
                                    <i class=""fas fa-phone""></i>
                                </button>
                                <button class=""btn btn-info btn-circle btn"" type=""button"">
                                    <i class=""far fa-comments text-white""></i>
                    ");
            WriteLiteral(@"            </button>
                            </div>
                            <a href=""javascript:void(0)"" class=""d-flex align-items-center"">
                                <img src=""plugins/images/users/arijit.jpg"" alt=""user-img"" class=""img-circle"">
                                <div class=""ms-2"">
                                    <span class=""text-dark"">
                                        Arijit
                                        Sinh <small class=""d-block text-muted"">Offline</small>
                                    </span>
                                </div>
                            </a>
                        </li>
                        <li>
                            <div class=""call-chat"">
                                <button class=""btn btn-success text-white btn-circle btn"" type=""button"">
                                    <i class=""fas fa-phone""></i>
                                </button>
                                <button class=""btn btn-");
            WriteLiteral(@"info btn-circle btn"" type=""button"">
                                    <i class=""far fa-comments text-white""></i>
                                </button>
                            </div>
                            <a href=""javascript:void(0)"" class=""d-flex align-items-center"">
                                <img src=""plugins/images/users/govinda.jpg"" alt=""user-img""
                                     class=""img-circle"">
                                <div class=""ms-2"">
                                    <span class=""text-dark"">
                                        Govinda
                                        Star <small class=""d-block text-success"">online</small>
                                    </span>
                                </div>
                            </a>
                        </li>
                        <li>
                            <div class=""call-chat"">
                                <button class=""btn btn-success text-white btn-circle btn"" ty");
            WriteLiteral(@"pe=""button"">
                                    <i class=""fas fa-phone""></i>
                                </button>
                                <button class=""btn btn-info btn-circle btn"" type=""button"">
                                    <i class=""far fa-comments text-white""></i>
                                </button>
                            </div>
                            <a href=""javascript:void(0)"" class=""d-flex align-items-center"">
                                <img src=""plugins/images/users/hritik.jpg"" alt=""user-img"" class=""img-circle"">
                                <div class=""ms-2"">
                                    <span class=""text-dark"">
                                        John
                                        Abraham<small class=""d-block text-success"">online</small>
                                    </span>
                                </div>
                            </a>
                        </li>
                    </ul>
          ");
            WriteLiteral(@"      </div>
            </div>
        </div>
        <!-- /.col -->
    </div>
</div>
<!-- ============================================================== -->
<!-- End Container fluid  -->
<!-- ============================================================== -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SSWeb.Models.Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
