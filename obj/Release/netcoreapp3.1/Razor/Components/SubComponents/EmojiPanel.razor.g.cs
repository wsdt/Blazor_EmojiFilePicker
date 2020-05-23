#pragma checksum "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\RealtimeChat_WebAssembly\EmojiPicker\Components\SubComponents\EmojiPanel.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f132a200d48ecf2aef50ba2d0907071a4bd62dc3"
// <auto-generated/>
#pragma warning disable 1591
namespace WSDT.EmojiFilePicker.Sub
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\RealtimeChat_WebAssembly\EmojiPicker\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\RealtimeChat_WebAssembly\EmojiPicker\Components\SubComponents\EmojiPanel.razor"
using WSDT.EmojiFilePicker;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\RealtimeChat_WebAssembly\EmojiPicker\Components\SubComponents\EmojiPanel.razor"
using System.Reflection;

#line default
#line hidden
#nullable disable
    public partial class EmojiPanel : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    .scrollable {\r\n        overflow-y: scroll;\r\n        height: 400px;\r\n        width: 250px;\r\n    }\r\n</style>\r\n\r\n");
            __Blazor.WSDT.EmojiFilePicker.Sub.EmojiPanel.TypeInference.CreateCascadingValue_0(__builder, 1, 2, 
#nullable restore
#line 13 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\RealtimeChat_WebAssembly\EmojiPicker\Components\SubComponents\EmojiPanel.razor"
                       this

#line default
#line hidden
#nullable disable
            , 3, (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "btn-group");
                __builder2.AddAttribute(7, "role", "group");
                __builder2.AddAttribute(8, "style", "margin-bottom:5px;");
                __builder2.AddMarkupContent(9, "\r\n");
#nullable restore
#line 15 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\RealtimeChat_WebAssembly\EmojiPicker\Components\SubComponents\EmojiPanel.razor"
         foreach (EmojiPanelTab tabPage in Pages)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(10, "            ");
                __builder2.OpenElement(11, "button");
                __builder2.AddAttribute(12, "type", "button");
                __builder2.AddAttribute(13, "class", "btn-group" + " " + (
#nullable restore
#line 17 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\RealtimeChat_WebAssembly\EmojiPicker\Components\SubComponents\EmojiPanel.razor"
                                                    GetButtonClass(tabPage)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\RealtimeChat_WebAssembly\EmojiPicker\Components\SubComponents\EmojiPanel.razor"
                               ()=>ActivatePage(tabPage)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(15, "\r\n                ");
                __builder2.AddContent(16, 
#nullable restore
#line 19 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\RealtimeChat_WebAssembly\EmojiPicker\Components\SubComponents\EmojiPanel.razor"
                 tabPage.TabTitle

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(17, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n");
#nullable restore
#line 21 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\RealtimeChat_WebAssembly\EmojiPicker\Components\SubComponents\EmojiPanel.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(19, "    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n    ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "scrollable");
                __builder2.AddMarkupContent(23, "\r\n        ");
                __builder2.AddContent(24, 
#nullable restore
#line 24 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\RealtimeChat_WebAssembly\EmojiPicker\Components\SubComponents\EmojiPanel.razor"
         ChildContent

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(25, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n");
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\RealtimeChat_WebAssembly\EmojiPicker\Components\SubComponents\EmojiPanel.razor"
       
    [Parameter] public RenderFragment ChildContent { get; set; }

    public EmojiPanelTab ActivePage { get; set; }
    List<EmojiPanelTab> Pages = new List<EmojiPanelTab>();

    internal void AddPage(EmojiPanelTab tabPage)
    {
        Pages.Add(tabPage);
        if (Pages.Count == 1) ActivePage = tabPage;
        StateHasChanged();
    }

    string GetButtonClass(EmojiPanelTab page)
    {
        return page == ActivePage ? "btn-dark" : "btn-light";
    }

    void ActivatePage(EmojiPanelTab page)
    {
        ActivePage = page;
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.WSDT.EmojiFilePicker.Sub.EmojiPanel
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
