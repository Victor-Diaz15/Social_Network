#pragma checksum "C:\Users\rubi\Desktop\Academico\5to_Cuatrimestre\Materias\Programacion3\Social_Network\Social_Network\Views\Friend\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4146b807ac29d682d1178eb7035ce58f42ae647"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Friend_Index), @"mvc.1.0.view", @"/Views/Friend/Index.cshtml")]
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
#line 1 "C:\Users\rubi\Desktop\Academico\5to_Cuatrimestre\Materias\Programacion3\Social_Network\Social_Network\Views\_ViewImports.cshtml"
using Social_Network;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rubi\Desktop\Academico\5to_Cuatrimestre\Materias\Programacion3\Social_Network\Social_Network\Views\_ViewImports.cshtml"
using Social_Network.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\rubi\Desktop\Academico\5to_Cuatrimestre\Materias\Programacion3\Social_Network\Social_Network\Views\Friend\Index.cshtml"
using Social_Network.Core.Application.ViewModels.Friend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rubi\Desktop\Academico\5to_Cuatrimestre\Materias\Programacion3\Social_Network\Social_Network\Views\Friend\Index.cshtml"
using Social_Network.Core.Application.ViewModels.Publication;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4146b807ac29d682d1178eb7035ce58f42ae647", @"/Views/Friend/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38d2e719e97cf6a530431fb3f9bc154fa4133301", @"/Views/_ViewImports.cshtml")]
    public class Views_Friend_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FriendViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Friend", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddFriend", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn w-100 btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Comment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteFriend", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger w-100 mx-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\rubi\Desktop\Academico\5to_Cuatrimestre\Materias\Programacion3\Social_Network\Social_Network\Views\Friend\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row justify-content-center\">\r\n    <h1 class=\"text-center\">Amigos</h1>\r\n    <div class=\"row justify-content-end my-3\">\r\n        <div class=\"col-md-4\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4146b807ac29d682d1178eb7035ce58f42ae6476824", async() => {
                WriteLiteral("Agregar amigo");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"col-md-8 mt-6\">\r\n");
#nullable restore
#line 17 "C:\Users\rubi\Desktop\Academico\5to_Cuatrimestre\Materias\Programacion3\Social_Network\Social_Network\Views\Friend\Index.cshtml"
         if (ViewBag.PostsFriends.Count == 0 || ViewBag.PostsFriends.Count == null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"my-3\">\r\n            <h3 class=\"text-center\">Tus amigos no tienen publicaciones</h3>\r\n        </div>\r\n");
#nullable restore
#line 22 "C:\Users\rubi\Desktop\Academico\5to_Cuatrimestre\Materias\Programacion3\Social_Network\Social_Network\Views\Friend\Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-8\">\r\n                <h3 class=\"text-center\">Publicaciones de tus amigos</h3>\r\n            </div>\r\n");
#nullable restore
#line 28 "C:\Users\rubi\Desktop\Academico\5to_Cuatrimestre\Materias\Programacion3\Social_Network\Social_Network\Views\Friend\Index.cshtml"
             foreach (PublicationViewModel item in ViewBag.PostsFriends)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""card d-flex @*flex-md-row*@ mb-4 box-shadow h-md-250"">
                    <div class=""card-title d-flex justify-content-between m-3"">
                        <div class=""d-flex gap-2 align-items-start"">
                            <img");
            BeginWriteAttribute("src", " src=\"", 1274, "\"", 1298, 1);
#nullable restore
#line 33 "C:\Users\rubi\Desktop\Academico\5to_Cuatrimestre\Materias\Programacion3\Social_Network\Social_Network\Views\Friend\Index.cshtml"
WriteAttributeValue("", 1280, item.PhotoUserUrl, 1280, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"...\" class=\"rounded-circle\" style=\"width: 40px; height: 40px;\">\r\n                            <strong class=\"d-inline-block mb-2 text-dark h5\">");
#nullable restore
#line 34 "C:\Users\rubi\Desktop\Academico\5to_Cuatrimestre\Materias\Programacion3\Social_Network\Social_Network\Views\Friend\Index.cshtml"
                                                                        Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong>
                        </div>
                    </div>
                    <!--Descripcion del Post-->
                    <div class=""card-body p-3 d-flex justify-content-center align-items-center"">

                        <div>
                            <!--Imagen del Post-->
                            <img class=""card-img-right flex-auto d-none d-md-block""");
            BeginWriteAttribute("src", " src=\"", 1847, "\"", 1878, 1);
#nullable restore
#line 42 "C:\Users\rubi\Desktop\Academico\5to_Cuatrimestre\Materias\Programacion3\Social_Network\Social_Network\Views\Friend\Index.cshtml"
WriteAttributeValue("", 1853, item.PhotoPublicationUrl, 1853, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""width: 564px; height: 434px;"" data-holder-rendered=""true"">
                        </div>
                    </div>
                    <div class=""row mx-5"">
                        <div class=""d-flex gap-2 align-items-start"">
                            <img");
            BeginWriteAttribute("src", " src=\"", 2153, "\"", 2177, 1);
#nullable restore
#line 47 "C:\Users\rubi\Desktop\Academico\5to_Cuatrimestre\Materias\Programacion3\Social_Network\Social_Network\Views\Friend\Index.cshtml"
WriteAttributeValue("", 2159, item.PhotoUserUrl, 2159, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"...\" class=\"rounded-circle\" style=\"width: 40px; height: 40px;\">\r\n                            <strong class=\"text-dark h5\"><strong>");
#nullable restore
#line 48 "C:\Users\rubi\Desktop\Academico\5to_Cuatrimestre\Materias\Programacion3\Social_Network\Social_Network\Views\Friend\Index.cshtml"
                                                            Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></strong>\r\n                            <p class=\"card-text text-wrap mb-auto\">");
#nullable restore
#line 49 "C:\Users\rubi\Desktop\Academico\5to_Cuatrimestre\Materias\Programacion3\Social_Network\Social_Network\Views\Friend\Index.cshtml"
                                                              Write(item.PublicationContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                        <div class=\"my-3 d-flex align-items-center justify-content-between\">\r\n                            <p class=\"text-muted\">");
#nullable restore
#line 52 "C:\Users\rubi\Desktop\Academico\5to_Cuatrimestre\Materias\Programacion3\Social_Network\Social_Network\Views\Friend\Index.cshtml"
                                             Write(item.Created);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4146b807ac29d682d1178eb7035ce58f42ae64713683", async() => {
                WriteLiteral("Ver comentarios");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "C:\Users\rubi\Desktop\Academico\5to_Cuatrimestre\Materias\Programacion3\Social_Network\Social_Network\Views\Friend\Index.cshtml"
                                                                             WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 57 "C:\Users\rubi\Desktop\Academico\5to_Cuatrimestre\Materias\Programacion3\Social_Network\Social_Network\Views\Friend\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\rubi\Desktop\Academico\5to_Cuatrimestre\Materias\Programacion3\Social_Network\Social_Network\Views\Friend\Index.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div class=\"col-md-4 mt-6\">\r\n");
#nullable restore
#line 61 "C:\Users\rubi\Desktop\Academico\5to_Cuatrimestre\Materias\Programacion3\Social_Network\Social_Network\Views\Friend\Index.cshtml"
         if (Model.Count == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h2 class=\"text-center fw-bold\">No Tienes Amigos</h2>\r\n");
#nullable restore
#line 64 "C:\Users\rubi\Desktop\Academico\5to_Cuatrimestre\Materias\Programacion3\Social_Network\Social_Network\Views\Friend\Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h3 class=\"text-center\">Listado de amigos</h3>\r\n");
#nullable restore
#line 68 "C:\Users\rubi\Desktop\Academico\5to_Cuatrimestre\Materias\Programacion3\Social_Network\Social_Network\Views\Friend\Index.cshtml"
             foreach (FriendViewModel item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""card d-flex @*flex-md-row*@ mb-4 box-shadow h-md-250"">
                    <div class=""card-body d-flex flex-column justify-content-center align-items-center mx-2"">
                        <p class=""card-text""><strong>Nombre: </strong>");
#nullable restore
#line 72 "C:\Users\rubi\Desktop\Academico\5to_Cuatrimestre\Materias\Programacion3\Social_Network\Social_Network\Views\Friend\Index.cshtml"
                                                                 Write(item.FriendFirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"card-text\"><strong>Apellido: </strong>");
#nullable restore
#line 73 "C:\Users\rubi\Desktop\Academico\5to_Cuatrimestre\Materias\Programacion3\Social_Network\Social_Network\Views\Friend\Index.cshtml"
                                                                   Write(item.FriendLastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"card-text\"><strong>Nombre de usuario: </strong>");
#nullable restore
#line 74 "C:\Users\rubi\Desktop\Academico\5to_Cuatrimestre\Materias\Programacion3\Social_Network\Social_Network\Views\Friend\Index.cshtml"
                                                                            Write(item.FriendUserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                    <div class=\"d-flex my-2 w-100 align-items-center\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4146b807ac29d682d1178eb7035ce58f42ae64719450", async() => {
                WriteLiteral("Eliminar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 77 "C:\Users\rubi\Desktop\Academico\5to_Cuatrimestre\Materias\Programacion3\Social_Network\Social_Network\Views\Friend\Index.cshtml"
                                                                               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 80 "C:\Users\rubi\Desktop\Academico\5to_Cuatrimestre\Materias\Programacion3\Social_Network\Social_Network\Views\Friend\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "C:\Users\rubi\Desktop\Academico\5to_Cuatrimestre\Materias\Programacion3\Social_Network\Social_Network\Views\Friend\Index.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FriendViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
