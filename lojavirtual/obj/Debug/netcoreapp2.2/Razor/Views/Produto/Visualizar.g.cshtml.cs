#pragma checksum "C:\Users\Cleven-PC\Desktop\LojaVirtual\lojavirtual\Views\Produto\Visualizar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "969facd2e0298f59ca501be4271725582c179721"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Visualizar), @"mvc.1.0.view", @"/Views/Produto/Visualizar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Produto/Visualizar.cshtml", typeof(AspNetCore.Views_Produto_Visualizar))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"969facd2e0298f59ca501be4271725582c179721", @"/Views/Produto/Visualizar.cshtml")]
    public class Views_Produto_Visualizar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<lojavirtual.Models.Produto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 46, true);
            WriteLiteral("\r\n\r\n\r\n\r\n<h3>Produto -> Visualizar</h3>\r\n:)\r\n\r\n");
            EndContext();
#line 9 "C:\Users\Cleven-PC\Desktop\LojaVirtual\lojavirtual\Views\Produto\Visualizar.cshtml"
  
    string nome = "Cleven";

#line default
#line hidden
            BeginContext(117, 43, true);
            WriteLiteral("\r\n<h2>Produto</h2>\r\n\r\n<br />\r\n<b>Nome: </b>");
            EndContext();
            BeginContext(161, 10, false);
#line 16 "C:\Users\Cleven-PC\Desktop\LojaVirtual\lojavirtual\Views\Produto\Visualizar.cshtml"
        Write(Model.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(171, 27, true);
            WriteLiteral(" <br />\r\n<b>Descrição: </b>");
            EndContext();
            BeginContext(199, 15, false);
#line 17 "C:\Users\Cleven-PC\Desktop\LojaVirtual\lojavirtual\Views\Produto\Visualizar.cshtml"
             Write(Model.Descricao);

#line default
#line hidden
            EndContext();
            BeginContext(214, 23, true);
            WriteLiteral(" <br />\r\n<b>valor: </b>");
            EndContext();
            BeginContext(238, 25, false);
#line 18 "C:\Users\Cleven-PC\Desktop\LojaVirtual\lojavirtual\Views\Produto\Visualizar.cshtml"
         Write(Model.Valor.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(263, 73, true);
            WriteLiteral(" <br />\r\n\r\n\r\n\r\n<br />\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\nTodos os direitos reservados &copy; ");
            EndContext();
            BeginContext(337, 17, false);
#line 30 "C:\Users\Cleven-PC\Desktop\LojaVirtual\lojavirtual\Views\Produto\Visualizar.cshtml"
                               Write(DateTime.Now.Year);

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<lojavirtual.Models.Produto> Html { get; private set; }
    }
}
#pragma warning restore 1591
