#pragma checksum "C:\Users\HD\Projetos\Udemy\Projeto01\Site01\Views\Home\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1960ca11df4d57904c74b5981f992f91eec53c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Login), @"mvc.1.0.view", @"/Views/Home/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Login.cshtml", typeof(AspNetCore.Views_Home_Login))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1960ca11df4d57904c74b5981f992f91eec53c7", @"/Views/Home/Login.cshtml")]
    public class Views_Home_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Site01.Models.Palavra>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\HD\Projetos\Udemy\Projeto01\Site01\Views\Home\Login.cshtml"
  
    Layout = "~/Views/NovaPasta/_Layout.cshtml";

#line default
#line hidden
#line 5 "C:\Users\HD\Projetos\Udemy\Projeto01\Site01\Views\Home\Login.cshtml"
  
    ViewBag.Title = "Login - Cadastrar";

#line default
#line hidden
            BeginContext(136, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 9 "C:\Users\HD\Projetos\Udemy\Projeto01\Site01\Views\Home\Login.cshtml"
 if (TempData["MensagemErro"] != null)
{

#line default
#line hidden
            BeginContext(181, 59, true);
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\">\r\n        ");
            EndContext();
            BeginContext(241, 24, false);
#line 12 "C:\Users\HD\Projetos\Udemy\Projeto01\Site01\Views\Home\Login.cshtml"
   Write(TempData["MensagemErro"]);

#line default
#line hidden
            EndContext();
            BeginContext(265, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 14 "C:\Users\HD\Projetos\Udemy\Projeto01\Site01\Views\Home\Login.cshtml"
}

#line default
#line hidden
            BeginContext(282, 157, true);
            WriteLiteral("\r\n<form method=\"post\" action=\"/home/login\">\r\n  <div class=\"form-group\">\r\n        <label for=\"email\">E-mail</label>\r\n        <input type=\"text\" name = \"email\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 439, "\"", 447, 0);
            EndWriteAttribute();
            BeginContext(448, 76, true);
            WriteLiteral(" class=\"form-control\" id=\"email\" placeholder=\"Digite o seu email\">\r\n        ");
            EndContext();
            BeginContext(525, 31, false);
#line 20 "C:\Users\HD\Projetos\Udemy\Projeto01\Site01\Views\Home\Login.cshtml"
   Write(Html.ValidationMessage("email"));

#line default
#line hidden
            EndContext();
            BeginContext(556, 129, true);
            WriteLiteral(" \r\n    </div>\r\n     <div class=\"form-group\">\r\n        <label for=\"senha\">Senha</label>\r\n        <input type=\"text\" name = \"senha\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 685, "\"", 693, 0);
            EndWriteAttribute();
            BeginContext(694, 76, true);
            WriteLiteral(" class=\"form-control\" id=\"senha\" placeholder=\"Digite o sua senha\">\r\n        ");
            EndContext();
            BeginContext(771, 31, false);
#line 25 "C:\Users\HD\Projetos\Udemy\Projeto01\Site01\Views\Home\Login.cshtml"
   Write(Html.ValidationMessage("senha"));

#line default
#line hidden
            EndContext();
            BeginContext(802, 93, true);
            WriteLiteral(" \r\n    </div>\r\n\r\n    <button type=\"submit\" class=\"btn btn-primary\">Enviar</button>\r\n</form>\r\n");
            EndContext();
            BeginContext(896, 16, false);
#line 30 "C:\Users\HD\Projetos\Udemy\Projeto01\Site01\Views\Home\Login.cshtml"
Write(ViewBag.Mensagem);

#line default
#line hidden
            EndContext();
            BeginContext(912, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Site01.Models.Palavra> Html { get; private set; }
    }
}
#pragma warning restore 1591
