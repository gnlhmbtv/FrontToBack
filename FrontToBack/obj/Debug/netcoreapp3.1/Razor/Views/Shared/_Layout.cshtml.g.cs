#pragma checksum "C:\Users\user\Desktop\mvc\FrontToBack\FrontToBack\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63615672d9264d9ec0b5bb155f22e9cbfd830d07"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\user\Desktop\mvc\FrontToBack\FrontToBack\Views\_ViewImports.cshtml"
using FrontToBack.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Desktop\mvc\FrontToBack\FrontToBack\Views\_ViewImports.cshtml"
using FrontToBack.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63615672d9264d9ec0b5bb155f22e9cbfd830d07", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f4ac931d5edb120660d7139af0f0a8b325eff0e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/home.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63615672d9264d9ec0b5bb155f22e9cbfd830d074481", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <link rel=""preconnect"" href=""https://fonts.googleapis.com"">
    <link rel=""preconnect"" href=""https://fonts.gstatic.com"" crossorigin>
    <script src=""https://code.jquery.com/jquery-3.2.1.slim.min.js""
            integrity=""sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN""
            crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js""
            integrity=""sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q""
            crossorigin=""anonymous""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js""
            integrity=""sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl""
            crossorigin=""anonymous""></script>
    <link href=""https://fonts.googleapis");
                WriteLiteral(@".com/css2?family=Montserrat:wght@100&family=Playfair+Display&family=Poppins:wght@600&display=swap""
          rel=""stylesheet"">
    <link href=""https://fonts.googleapis.com/css2?family=Lora&family=Montserrat:wght@100&family=Playfair+Display&family=Poppins:wght@600&family=Quicksand:wght@300&display=swap""
          rel=""stylesheet"">
    <link href=""https://fonts.googleapis.com/css2?family=Montserrat:wght@100&family=Playfair+Display&family=Poppins:wght@600&family=Quicksand:wght@300&display=swap""
          rel=""stylesheet"">
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"" rel=""stylesheet""
          integrity=""sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3"" crossorigin=""anonymous"">
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "63615672d9264d9ec0b5bb155f22e9cbfd830d076614", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <title>Fiorello</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63615672d9264d9ec0b5bb155f22e9cbfd830d078532", async() => {
                WriteLiteral(@"
    <!-- navbar start -->
    <section id=""navbar"">
        <nav class=""navbar navbar-light bg-light navbar-expand-lg"" id=""myNavbar"">
            <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#mainNav"" aria-controls=""mainNav""
                    aria-expanded=""false"" aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon""></span>
            </button>

            <a href=""#"" class=""navbar-brand""><img src=""/img/h2-logo-1.png"" width=""200px""");
                BeginWriteAttribute("alt", " alt=\"", 2437, "\"", 2443, 0);
                EndWriteAttribute();
                WriteLiteral(@"></a>
            <div class=""collapse navbar-collapse"" id=""mainNav"">
                <ul class=""navbar-nav ml-auto nav-fill"">

                    <li class=""nav-item dropdown menu1"">
                        <a class=""nav-link"" href=""#"" id=""navbarDropdownMenuLink"" role=""button"" data-bs-toggle=""dropdown""
                           aria-expanded=""false"">
                            HOME
                        </a>
                        <ul class=""dropdown-menu"" aria-labelledby=""navbarDropdownMenuLink"">
                            <li><a class=""dropdown-item"" href=""#"">Main Home</a></li>
                            <li><a class=""dropdown-item"" href=""#"">Grid Home</a></li>
                            <li><a class=""dropdown-item"" href=""#"">Flower Shop</a></li>
                            <li><a class=""dropdown-item"" href=""#"">Animated Slider</a></li>
                            <li><a class=""dropdown-item"" href=""#"">Metro Showcase</a></li>
                            <li><a class=""dropdown-item"" href");
                WriteLiteral(@"=""#"">Carousel Showcase</a></li>
                            <li><a class=""dropdown-item"" href=""#"">Landing</a></li>
                        </ul>
                    </li>
                    <li class=""nav-item dropdown menu2"">
                        <a class=""nav-link "" href=""#"" id=""navbarDropdownMenuLink"">
                            PAGES
                        </a>
                        <ul class=""dropdown-menu"" aria-labelledby=""navbarDropdownMenuLink"">
                            <li><a class=""dropdown-item"" href=""#"">About Us</a></li>
                            <li><a class=""dropdown-item"" href=""#"">FAQ Page</a></li>
                            <li><a class=""dropdown-item"" href=""#"">Contact Us</a></li>
                        </ul>
                    </li>




                    <li class=""nav-item px-4 dropdown mega-menu"">
                        <a class=""nav-link dropdown-toggle"" href=""#"" id=""servicesDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expan");
                WriteLiteral(@"ded=""false"">SHOP</a>
                        <div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""servicesDropdown"">
                            <div class=""d-md-flex align-items-start justify-content-start"">
                                <div>
                                    <div class=""dropdown-header"">Product Types</div>
                                    <a class=""dropdown-item"" href=""#"">Standard Product</a>
                                    <a class=""dropdown-item"" href=""#"">Grouped Product</a>
                                    <a class=""dropdown-item"" href=""#"">Variable Product</a>
                                    <a class=""dropdown-item"" href=""#"">Virtual Product</a>
                                    <a class=""dropdown-item"" href=""#"">External Product</a>
                                    <a class=""dropdown-item"" href=""#"">Downloadable Product</a>
                                    <a class=""dropdown-item"" href=""#"">On Sale Product</a>
                               ");
                WriteLiteral(@"     <a class=""dropdown-item"" href=""#"">Out Of Stock Product</a>
                                    <a class=""dropdown-item"" href=""#"">New Product</a>


                                </div>
                                <div>
                                    <div class=""dropdown-header"">Shop Pages</div>
                                    <a class=""dropdown-item"" href=""#"">My Account</a>
                                    <a class=""dropdown-item"" href=""#"">Cart</a>
                                    <a class=""dropdown-item"" href=""#"">Checkout</a>
                                    <a class=""dropdown-item"" href=""#"">Orders</a>
                                    <a class=""dropdown-item"" href=""#"">Downloads</a>

                                </div>
                                <div>
                                    <div class=""dropdown-header"">Shop Types</div>
                                    <a class=""dropdown-item"" href=""#"">Product List</a>
                                    <");
                WriteLiteral(@"a class=""dropdown-item"" href=""#"">Without Sidebar</a>
                                    <a class=""dropdown-item"" href=""#"">With Category Filter</a>
                                    <a class=""dropdown-item"" href=""#"">With Ordering Filter</a>
                                    <a class=""dropdown-item"" href=""#"">Shop Carousel</a>
                                    <a class=""dropdown-item"" href=""#"">Product Categories</a>
                                    <a class=""dropdown-item"" href=""#"">Single Category</a>
                                </div>

                                <div>
                                    <div class=""dropdown-header"">Shop Layouts</div>
                                    <a class=""dropdown-item"" href=""#"">Two Columns Grid</a>
                                    <a class=""dropdown-item"" href=""#"">Three Columns Grid</a>
                                    <a class=""dropdown-item"" href=""#"">Four Columns Grid</a>
                                    <a class=""dropdown-item");
                WriteLiteral(@""" href=""#"">Four Columns Wide</a>
                                    <a class=""dropdown-item"" href=""#"">Five Columns Wide</a>
                                    <a class=""dropdown-item"" href=""#"">Six Columns Wide</a>
                                </div>
                            </div>
                        </div>
                    </li>








                    <li class=""nav-item dropdown"" id=""myDropdown"">
                        <a class=""nav-link dropdown-toggle"" href=""#"" data-bs-toggle=""dropdown"">PORTFOLIO</a>
                        <ul class=""dropdown-menu"">
                            <li> <a class=""dropdown-item"" href=""#"">Standard</a></li>
                            <li> <a class=""dropdown-item"" href=""#"">Gallery</a></li>
                            <li> <a class=""dropdown-item"" href=""#"">Masonry</a></li>
                            <li>
                                <a class=""dropdown-item"" href=""#""> Portfolio Layouts &gt; </a>
                                <ul cl");
                WriteLiteral(@"ass=""submenu dropdown-menu"">
                                    <li><a class=""dropdown-item"" href=""#"">Two Columns</a></li>
                                    <li><a class=""dropdown-item"" href=""#"">Three Columns</a></li>
                                    <li><a class=""dropdown-item"" href=""#"">Four Columns</a></li>
                                    <li><a class=""dropdown-item"" href=""#"">Four Columns Wide</a></li>
                                    <li><a class=""dropdown-item"" href=""#"">Five Columns Wide</a></li>
                                </ul>
                            </li>
                            <li>
                                <a class=""dropdown-item"" href=""#""> Portfolio Single &gt; </a>
                                <ul class=""submenu portfolio-submenu dropdown-menu"">
                                    <li><a class=""dropdown-item"" href=""#"">Small Images</a></li>
                                    <li><a class=""dropdown-item"" href=""#"">Small Slider</a></li>
                ");
                WriteLiteral(@"                    <li><a class=""dropdown-item"" href=""#"">Big Images</a></li>
                                    <li><a class=""dropdown-item"" href=""#"">Big Slider</a></li>
                                    <li><a class=""dropdown-item"" href=""#"">Gallery</a></li>
                                </ul>
                            </li>
                        </ul>
                    </li>



                    <li class=""nav-item dropdown"" id=""myDropdown"">
                        <a class=""nav-link dropdown-toggle"" href=""#"" data-bs-toggle=""dropdown"">BLOG</a>
                        <ul class=""dropdown-menu"">
                            <li> <a class=""dropdown-item"" href=""#"">Masonry</a></li>
                            <li> <a class=""dropdown-item"" href=""#"">Standard</a></li>
                            <li>
                                <a class=""dropdown-item"" href=""#""> Post Types &gt; </a>
                                <ul class=""submenu blog-submenu dropdown-menu"">
                    ");
                WriteLiteral(@"                <li><a class=""dropdown-item"" href=""#"">Standard</a></li>
                                    <li><a class=""dropdown-item"" href=""#"">Gallery</a></li>
                                    <li><a class=""dropdown-item"" href=""#"">Link</a></li>
                                    <li><a class=""dropdown-item"" href=""#"">Quote</a></li>
                                    <li><a class=""dropdown-item"" href=""#"">Audio</a></li>
                                    <li><a class=""dropdown-item"" href=""#"">Video</a></li>
                                </ul>
                            </li>
                        </ul>
                    </li>



                    <li class=""nav-item dropdown"" id=""myDropdown"">
                        <a class=""nav-link dropdown-toggle"" href=""#"" data-bs-toggle=""dropdown"">ELEMENTS</a>
                        <ul class=""dropdown-menu"">
                            <li>
                                <a class=""dropdown-item"" href=""#""> Classic &gt; </a>
             ");
                WriteLiteral(@"                   <ul class=""submenu elements-submenu dropdown-menu"">
                                    <li><a class=""dropdown-item"" href=""#"">Accordions</a></li>
                                    <li><a class=""dropdown-item"" href=""#"">Tabs</a></li>
                                    <li><a class=""dropdown-item"" href=""#"">Button</a></li>
                                    <li><a class=""dropdown-item"" href=""#"">Video Button</a></li>
                                    <li><a class=""dropdown-item"" href=""#"">Contact Form</a></li>
                                    <li><a class=""dropdown-item"" href=""#"">Video</a></li>
                                </ul>
                            </li>
                            <li>
                                <a class=""dropdown-item"" href=""#""> Infographic &gt; </a>
                                <ul class=""submenu elements-submenu dropdown-menu"">
                                    <li><a class=""dropdown-item"" href=""#"">Blog List</a></li>
                ");
                WriteLiteral(@"                    <li><a class=""dropdown-item"" href=""#"">Counters</a></li>
                                    <li><a class=""dropdown-item"" href=""#"">Countdown</a></li>
                                    <li><a class=""dropdown-item"" href=""#"">Google Maps</a></li>
                                    <li><a class=""dropdown-item"" href=""#"">Progress Bar</a></li>
                                    <li><a class=""dropdown-item"" href=""#"">Pie Charts</a></li>
                                </ul>
                            </li>
                            <li>
                                <a class=""dropdown-item"" href=""#""> Interactive &gt; </a>
                                <ul class=""submenu elements-submenu dropdown-menu"">
                                    <li><a class=""dropdown-item"" href=""#"">Image Gallery</a></li>
                                    <li><a class=""dropdown-item"" href=""#"">Testimonials</a></li>
                                    <li><a class=""dropdown-item"" href=""#"">Team</a></li>");
                WriteLiteral(@"
                                    <li><a class=""dropdown-item"" href=""#"">Banner</a></li>
                                    <li><a class=""dropdown-item"" href=""#"">Shop List</a></li>
                                    <li><a class=""dropdown-item"" href=""#"">Portfolio List</a></li>
                                </ul>
                            </li>
                            <li>
                                <a class=""dropdown-item"" href=""#""> Typography&gt; </a>
                                <ul class=""submenu elements-submenu dropdown-menu"">
                                    <li><a class=""dropdown-item"" href=""#"">Headings</a></li>
                                    <li><a class=""dropdown-item"" href=""#"">Columns</a></li>
                                    <li><a class=""dropdown-item"" href=""#"">Section Title</a></li>
                                    <li><a class=""dropdown-item"" href=""#"">Blockquote</a></li>
                                    <li><a class=""dropdown-item"" href=""#"">Dropc");
                WriteLiteral(@"aps</a></li>
                                    <li><a class=""dropdown-item"" href=""#"">Highlights</a></li>
                                    <li><a class=""dropdown-item"" href=""#"">Separators</a></li>
                                    <li><a class=""dropdown-item"" href=""#"">Custom Font</a></li>

                                </ul>
                            </li>
                            <i class=""fas fa-search""></i>
                        </ul>
                    </li>
                </ul>
            </div>
        </nav>


    </section>
    <!-- navbar end -->
    ");
#nullable restore
#line 243 "C:\Users\user\Desktop\mvc\FrontToBack\FrontToBack\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <!-- footer start -->
    <section id=""footer"">
        <div class=""container footer"">
            <footer class=""row row-cols-5 py-5 my-5 border-top"">

                <div class=""col"">
                    <h5>CUSTOMER SERVICE</h5>
                    <ul class=""nav flex-column"">
                        <li class=""nav-item mb-2""><a href=""#"" class=""nav-link p-0 text-muted"">Help & Contact Us</a></li>
                        <li class=""nav-item mb-2""><a href=""#"" class=""nav-link p-0 text-muted"">Returns & Refunds</a></li>
                        <li class=""nav-item mb-2""><a href=""#"" class=""nav-link p-0 text-muted"">Online Stores</a></li>
                        <li class=""nav-item mb-2""><a href=""#"" class=""nav-link p-0 text-muted"">Terms & Conditions</a></li>
                    </ul>
                </div>

                <div class=""col"">
                    <h5>COMPANY</h5>
                    <ul class=""nav flex-column"">
                        <li class=""nav-item mb-2""><a href=""#"" class");
                WriteLiteral(@"=""nav-link p-0 text-muted"">About Us</a></li>
                        <li class=""nav-item mb-2""><a href=""#"" class=""nav-link p-0 text-muted"">Blog</a></li>
                        <li class=""nav-item mb-2""><a href=""#"" class=""nav-link p-0 text-muted"">Order Tracking</a></li>
                        <li class=""nav-item mb-2""><a href=""#"" class=""nav-link p-0 text-muted"">FAQ Page</a></li>
                        <li class=""nav-item mb-2""><a href=""#"" class=""nav-link p-0 text-muted"">Contact Us</a></li>
                        <li class=""nav-item mb-2""><a href=""#"" class=""nav-link p-0 text-muted"">Login</a></li>
                    </ul>
                </div>

                <div class=""col"">
                    <h5>SOCIAL MEDIA</h5>
                    <ul class=""nav flex-column"">
                        <li class=""nav-item mb-2""><a href=""#"" class=""nav-link p-0 text-muted"">Twitter</a></li>
                        <li class=""nav-item mb-2""><a href=""#"" class=""nav-link p-0 text-muted"">Instagram</a></li>
     ");
                WriteLiteral(@"                   <li class=""nav-item mb-2""><a href=""#"" class=""nav-link p-0 text-muted"">Tumblr</a></li>
                        <li class=""nav-item mb-2""><a href=""#"" class=""nav-link p-0 text-muted"">Pinterest</a></li>
                    </ul>
                </div>

                <div class=""col"">
                    <h5>ARCHIVE</h5>
                    <ul class=""nav flex-column"">
                        <li class=""nav-item mb-2""><a href=""#"" class=""nav-link p-0 text-muted"">Designer Shoes</a></li>
                        <li class=""nav-item mb-2""><a href=""#"" class=""nav-link p-0 text-muted"">Gallery</a></li>
                        <li class=""nav-item mb-2""><a href=""#"" class=""nav-link p-0 text-muted"">Pricing</a></li>
                        <li class=""nav-item mb-2""><a href=""#"" class=""nav-link p-0 text-muted"">Feature Index</a></li>
                        <li class=""nav-item mb-2""><a href=""#"" class=""nav-link p-0 text-muted"">Login</a></li>
                        <li class=""nav-item mb-2""><a href");
                WriteLiteral("=\"#\" class=\"nav-link p-0 text-muted\">Help & Support</a></li>\r\n                    </ul>\r\n                </div>\r\n            </footer>\r\n        </div>\r\n    </section>\r\n    <!-- footer end -->\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.6.0/jquery.js""
        integrity=""sha512-n/4gHW3atM3QqRcbCn6ewmpxcLAHGaDjpEBu4xZd47N0W2oQ+6q7oc3PXstrJYXcbNU1OHdQ1T7pAP+gi5Yu8g==""
        crossorigin=""anonymous"" referrerpolicy=""no-referrer""></script>
<script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js""
        integrity=""sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p"" crossorigin=""anonymous""></script>
<script src=""https://unpkg.com/isotope-layout@3/dist/isotope.pkgd.min.js""></script>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63615672d9264d9ec0b5bb155f22e9cbfd830d0728332", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>\r\n");
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
