#pragma checksum "C:\Users\Phygitalmind\Desktop\PersonalWebSite\Views\Home\Iletisim.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4de17d7b2fe8ff3b7267e20e716ba4cb0161a240"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Iletisim), @"mvc.1.0.view", @"/Views/Home/Iletisim.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4de17d7b2fe8ff3b7267e20e716ba4cb0161a240", @"/Views/Home/Iletisim.cshtml")]
    public class Views_Home_Iletisim : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Phygitalmind\Desktop\PersonalWebSite\Views\Home\Iletisim.cshtml"
  
    ViewData["Title"] = "İletişim";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""slider-item overlay"" data-stellar-background-ratio=""0.5""
     style=""background-image: url('/Content/images/hero_2.jpg');"">
    <div class=""container"">
        <div class=""row slider-text align-items-center justify-content-center text-center"">
            <div class=""col-lg-12 col-sm-12"">
                <h1 class=""mb-4"" data-aos=""fade-up"" data-aos-delay="""">Contact Us</h1>
                <p class=""custom-breadcrumbs"" data-aos=""fade-up"" data-aos-delay=""100""><a href=""index.html"">Home</a> <span class=""mx-3"">/</span> Contact</p>
            </div>
        </div>
    </div>
</div>

<div class=""section"">
    <div class=""container"">
        <div class=""row mb-5"">
            <div class=""col-12 contact-form-contact-info"">
                <div class=""row"">
                    <div class=""col-lg-4"" data-aos=""fade-up"" data-aos-delay="""">
                        <p class=""d-flex"">
                            <span class=""ion-ios-location icon mr-5""></span>
                            <sp");
            WriteLiteral(@"an>Kartal / İstanbul</span>
                        </p>
                    </div>
                    <div class=""col-lg-4"" data-aos=""fade-up"" data-aos-delay=""100"">
                        <p class=""d-flex"">
                            <span class=""ion-ios-telephone icon mr-5""></span>
                            <span>+90 (541) 723 01 93</span>
                        </p>
                    </div>
                    <div class=""col-lg-4"" data-aos=""fade-up"" data-aos-delay=""200"">
                        <p class=""d-flex"">
                            <span class=""ion-android-mail icon mr-5""></span>
                            <span>infoyaprakyildirim@gmail.com</span>
                        </p>
                    </div>
                </div>
            </div>
        </div>

        <div class=""row mt-5"">
            <div id=""back"" class=""mb-md-5 text-center"">
");
#nullable restore
#line 47 "C:\Users\Phygitalmind\Desktop\PersonalWebSite\Views\Home\Iletisim.cshtml"
                 if (ViewBag.Succes != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h5 class=\"text-success\">");
#nullable restore
#line 49 "C:\Users\Phygitalmind\Desktop\PersonalWebSite\Views\Home\Iletisim.cshtml"
                                        Write(ViewBag.Succes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 50 "C:\Users\Phygitalmind\Desktop\PersonalWebSite\Views\Home\Iletisim.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\Phygitalmind\Desktop\PersonalWebSite\Views\Home\Iletisim.cshtml"
                 if (ViewBag.Error != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h5 class=\"text-danger\">");
#nullable restore
#line 53 "C:\Users\Phygitalmind\Desktop\PersonalWebSite\Views\Home\Iletisim.cshtml"
                                       Write(ViewBag.Error);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 54 "C:\Users\Phygitalmind\Desktop\PersonalWebSite\Views\Home\Iletisim.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>

            <div class=""col-12 mb-5 order-2"">
                <form action=""/Home/Iletisim"" method=""post"">
                    <div class=""row"">
                        <div class=""col-md-6 form-group"">
                            <label for=""name"">Adınız</label>
                            <input type=""text"" name=""Adi"" required class=""form-control "">
                        </div>
                        <div class=""col-md-6 form-group"">
                            <label for=""soyadi"">Soyadınız</label>
                            <input type=""text"" name=""Soyadi"" required class=""form-control "">
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-12 form-group"">

                        </div>
                    </div>

                    <div class=""row"">
                        <div class=""col-md-6 form-group"">
                            <label for=""email"">Email</label>
       ");
            WriteLiteral(@"                     <input type=""email"" name=""Email"" required class=""form-control "">
                        </div>
                        <div class=""col-md-6 form-group"">
                            <label for=""phone"">Telefon</label>
                            <input type=""text"" name=""Telefon"" required class=""form-control "">
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-12 form-group"">

                        </div>
                    </div>

                    <div class=""row"">
                        <div class=""col-md-12 form-group"">
                            <label for=""about"">Konu</label>
                            <input type=""text"" name=""Konu"" required class=""form-control"">
                        </div>
                    </div>

                    <div class=""row"">
                        <div class=""col-md-12 form-group"">
                            <label for=""message"">Mes");
            WriteLiteral(@"aj</label>
                            <textarea name=""Mesaj"" required class=""form-control "" cols=""30"" rows=""8""></textarea>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-6 form-group"">
                            <input type=""submit"" value=""Gönder"" class=""btn btn-outline-black px-3 py-3"">
                        </div>
                    </div>
                </form>
            </div>


        </div>


    </div>
</div>

<div class=""section bg-light block-11"">
    <div class=""container"">
        <div class=""row justify-content-center mb-5"">
            <div class=""col-md-8 text-center"">
                <h2 class=""mb-4 section-title"">Testimonial</h2>
            </div>
        </div>
        <div class=""nonloop-block-11 owl-carousel"">
            <div class=""item"">
                <div class=""block-33 h-100"">
                    <div class=""vcard d-flex mb-3"">
                        <");
            WriteLiteral(@"div class=""image align-self-center""><img src=""/Content/images/person_1.jpg"" alt=""Person here""></div>
                        <div class=""name-text align-self-center"">
                            <h2 class=""heading"">Carl Smith</h2>
                            <span class=""meta"">Customer Corp.</span>
                        </div>
                    </div>
                    <div class=""text"">
                        <blockquote>
                            <p>
                                &rdquo; Lorem ipsum dolor sit amet consectetur adipisicing elit. Quaerat qui, ipsum debitis id
                                reprehenderit ut soluta possimus consectetur asperiores totam veniam quasi molestiae. Animi doloribus
                                accusamus eius ex laudantium vitae? &ldquo;
                            </p>
                        </blockquote>
                    </div>
                </div>
            </div>

            <div class=""item"">
                <div class=""bl");
            WriteLiteral(@"ock-33 h-100"">
                    <div class=""vcard d-flex mb-3"">
                        <div class=""image align-self-center""><img src=""/Content/images/person_2.jpg"" alt=""Person here""></div>
                        <div class=""name-text align-self-center"">
                            <h2 class=""heading"">Craig Darren</h2>
                            <span class=""meta"">Customer Corp.</span>
                        </div>
                    </div>
                    <div class=""text"">
                        <blockquote>
                            <p>
                                &rdquo; Lorem, ipsum dolor sit amet consectetur adipisicing elit. At, ut enim error molestias maxime
                                deserunt voluptate doloribus nihil nesciunt id perferendis, doloremque earum architecto ab incidunt
                                sunt
                                corrupti. Consequuntur qui ullam voluptates sapiente quod esse eum. &ldquo;
                            </p>
     ");
            WriteLiteral(@"                   </blockquote>
                    </div>
                </div>
            </div>

            <div class=""item"">
                <div class=""block-33 h-100"">
                    <div class=""vcard d-flex mb-3"">
                        <div class=""image align-self-center""><img src=""/Content/images/person_1.jpg"" alt=""Person here""></div>
                        <div class=""name-text align-self-center"">
                            <h2 class=""heading"">John Smith</h2>
                            <span class=""meta"">Customer Corp.</span>
                        </div>
                    </div>
                    <div class=""text"">
                        <blockquote>
                            <p>
                                &rdquo; Lorem ipsum dolor sit amet, consectetur adipisicing elit. Pariatur, ab? Asperiores dolore
                                blanditiis quis sapiente soluta aliquid officiis. &ldquo;
                            </p>
                        </blo");
            WriteLiteral(@"ckquote>
                    </div>
                </div>
            </div>

            <div class=""item"">
                <div class=""block-33 h-100"">
                    <div class=""vcard d-flex mb-3"">
                        <div class=""image align-self-center""><img src=""/Content/images/person_2.jpg"" alt=""Person here""></div>
                        <div class=""name-text align-self-center"">
                            <h2 class=""heading"">John Smith</h2>
                            <span class=""meta"">Customer Corp.</span>
                        </div>
                    </div>
                    <div class=""text"">
                        <blockquote>
                            <p>
                                &rdquo; Lorem ipsum dolor sit amet, consectetur adipisicing elit. At, accusamus? Porro fugit culpa
                                consequuntur dolorum. &ldquo;
                            </p>
                        </blockquote>
                    </div>
             ");
            WriteLiteral("   </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        setInterval(function () {\r\n            $(\"#back\").fadeOut(2000);\r\n        }, 8000);\r\n    </script>\r\n");
            }
            );
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
