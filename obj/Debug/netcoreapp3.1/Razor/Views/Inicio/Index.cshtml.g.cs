#pragma checksum "C:\Users\PERSONAL\Desktop\progra1-lab\zapateria\PrograProject2020\Views\Inicio\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f9775f7f697fc27d9d7aebe9a51fcf10a94bb8d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inicio_Index), @"mvc.1.0.view", @"/Views/Inicio/Index.cshtml")]
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
#line 1 "C:\Users\PERSONAL\Desktop\progra1-lab\zapateria\PrograProject2020\Views\_ViewImports.cshtml"
using PrograProject2020;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PERSONAL\Desktop\progra1-lab\zapateria\PrograProject2020\Views\_ViewImports.cshtml"
using PrograProject2020.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f9775f7f697fc27d9d7aebe9a51fcf10a94bb8d", @"/Views/Inicio/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50353f6e8a8b0f2397fd02a3b1953416648462a7", @"/Views/_ViewImports.cshtml")]
    public class Views_Inicio_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f9775f7f697fc27d9d7aebe9a51fcf10a94bb8d3306", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>Document</title>\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f9775f7f697fc27d9d7aebe9a51fcf10a94bb8d4417", async() => {
                WriteLiteral(@"
 <nav class=""nav nav-pills nav-justified; nav justify-content-center"">
  <a class=""nav-item nav-link active"" href=""#"">Hombres</a>
  <a class=""nav-item nav-link"" href=""#"">Mujeres</a>
  <a class=""nav-item nav-link"" href=""#"">Niños</a>
  
</nav>
     
     <div  id=""carouselExampleCaptions"" class=""carousel slide"" data-ride=""carousel"">
        <ol class=""carousel-indicators"">
          <li data-target=""#carouselExampleCaptions"" data-slide-to=""0"" class=""active""></li>
          <li data-target=""#carouselExampleCaptions"" data-slide-to=""1""></li>
          <li data-target=""#carouselExampleCaptions"" data-slide-to=""2""></li>
        </ol>
        <div   class=""carousel-inner"" >
          <div class=""carousel-item active"">
            <img src=""https://flexi.shoes/blog/wp-content/uploads/sites/7/2018/11/zapatos-para-trabajar-de-hombre.jpg"" height=""750px"" class=""d-block w-100"" style=""margin-top: 0ex; ""  alt=""..."">
            <div class=""carousel-caption d-none d-md-block"">                
              <");
                WriteLiteral(@"h3 style=""color: black;"">Solo aqui, podrás encontrarlos</h3>
              <p style=""color: black;"">Los ultimos modelos de la temporada</p>
            </div>
          </div>
          <div class=""carousel-item"">
            <img src=""https://www.raymusgo.com/uploads/3/8/2/0/38202603/ray-musgo-zenit-vino-grande-web_orig.jpg""  height=""750px"" class=""d-block w-100"" alt=""..."">
            <div class=""carousel-caption d-none d-md-block"">
              <h5 style=""color: black;"" >Los modelos mas elegantes en Calzado para damas</h5>
              <p style=""color: black"";>Modelos para todo tipo de ocacion solo aquí</p>
            </div>
          </div>
          <div class=""carousel-item"">
            <img src=""https://e00-telva.uecdn.es/assets/multimedia/imagenes/2019/09/06/15677586968970.jpg"" height=""750px"" class=""d-block w-100"" alt=""..."">
            <div class=""carousel-caption d-none d-md-block"">
              <h5 style=""color: black;"">Zapatos para niños</h5>
              <p style=""color: black");
                WriteLiteral(@";"">Contamos con la mejor variedad en zapatos para niños de todas las edades</p>
            </div>
          </div>
        </div>
        <a class=""carousel-control-prev"" href=""#carouselExampleCaptions"" role=""button"" data-slide=""prev"">
          <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
          <span class=""sr-only"">Previous</span>
        </a>
        <a class=""carousel-control-next"" href=""#carouselExampleCaptions"" role=""button"" data-slide=""next"">
          <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
          <span class=""sr-only"">Next</span>
        </a>
      </div>





      
      <div class=""container"">
  <div class=""row"">
    <div class=""col-sm"">
      <div id=""carouselExampleSlidesOnly"" class=""carousel slide"" data-ride=""carousel"">
  <div class=""carousel-inner"">
    <div class=""carousel-item active"">
      <img class=""d-block w-100"" src=""https://i.pinimg.com/originals/c2/67/a2/c267a259f83538ac73eaab35ba8e5cad.jpg"" alt=""Firs");
                WriteLiteral(@"t slide"">
    </div>
    <div class=""carousel-item"">
      <img class=""d-block w-100"" src=""https://passarelape.vteximg.com.br/arquivos/ids/1034714/bannermob-medias-dic20.gif?v=637424375409700000"" alt=""Second slide"">
    </div>
    
  </div>
</div>
    </div>
    <div class=""col-sm"">
     <div id=""carouselExampleSlidesOnly"" class=""carousel slide"" data-ride=""carousel"">
  <div class=""carousel-inner"">
    <div class=""carousel-item active"">
      <img class=""d-block w-100"" src=""..."" alt=""First slide"">
    </div>
    <div class=""carousel-item"">
      <img class=""d-block w-100"" src=""..."" alt=""Second slide"">
    </div>
    <div class=""carousel-item"">
      <img class=""d-block w-100"" src=""..."" alt=""Third slide"">
    </div>
  </div>
</div>
    </div>
    
  </div>
</div>













      <h1><p style=""position:relative;left:400px;"" class=""text-danger"">Nuestros Empleados del mes </p></h1>
    <br>
     <div class=""container"" style=""position:relative;left:100px"">
  <div class=");
                WriteLiteral(@"""row"">
    
    <div class=""col-sm"" s>
      <img src=""https://yt3.ggpht.com/ytc/AAUvwngdhY_xfAwbZeKIgiHT-zL6n71LIOG5wh-I_rQ3GA=s900-c-k-c0x00ffffff-no-rj"" alt=""..."" class=""rounded-circle"" style=""height: 250px; width: 250px;"">
      <p>Faraon Love shady</p>
      <h5>Empleado destacado gracias a su <br> gran desempeño en el area de <br> atencion al cliente</h5>
      
    </div>
    <div class=""col-sm-"">
     <img src="" https://rytmusapp.com/wp-content/uploads/2019/08/michael-jackson-1080x675.jpg"" alt=""..."" class=""rounded-circle"" style=""height: 250px; width: 250px;"">
     <p>Michael Berrocal</p>
     <h5>Empleado destacado gracias a su <br> gran desempeño en el area de <br> atencion al cliente</h5>
    </div>
  </div>

<br><br><br>
<div class=""container"">
    <h2 style=""position:relative;left:300px "">Nuestras Marcas</h2>
    <br><br>
  <div class=""row"">
    <div class=""col-sm"">
      <img src=""https://www.logaster.com.es/blog/wp-content/uploads/sites/4/2019/03/0008_h_street-shoes-logo_13.");
                WriteLiteral(@"png"" style=""height:100px; width=100px;"" alt=""..."" class=""rounded"">
    </div>
    <div class=""col-sm"">
      <img src=""https://www.logaster.com.es/blog/wp-content/uploads/sites/4/2019/03/0008_t_nike-logo.png"" style=""height:100px; width=100px;"" alt=""..."" class=""rounded"">
    </div>
    <div class=""col-sm"">
      <img src=""https://www.logaster.com.es/blog/wp-content/uploads/sites/4/2019/03/0008_t_modini-shoes-logo_9.png"" style=""height:100px; width=1000px;"" alt=""..."" class=""rounded"">
    </div>
    <div class=""col-sm"">
      One of three columns
    </div>
    <div class=""col-sm"">
     Hola
    </div>
  </div>
</div>








</div>
      </div>
    </div>
  </div>
    
");
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
            WriteLiteral("\r\n</html>");
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
