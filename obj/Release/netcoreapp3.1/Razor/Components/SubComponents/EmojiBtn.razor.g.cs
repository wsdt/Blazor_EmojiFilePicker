#pragma checksum "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\RealtimeChat_WebAssembly\EmojiPicker\Components\SubComponents\EmojiBtn.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef0158c78cfd8a75d3e38129b35bbee100774a61"
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
    public partial class EmojiBtn : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
    .smiley-btn {
        cursor: pointer;
        padding: 5px;
        border-radius: 10px;
    }

        .smiley-btn:hover {
            background-color: #ccc;
        }

        .smiley-btn:active {
            background-color: #aaa;
        }
</style>

");
            __builder.OpenElement(1, "span");
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\RealtimeChat_WebAssembly\EmojiPicker\Components\SubComponents\EmojiBtn.razor"
                  () => AddEmoji.InvokeAsync(Emoji)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "class", "smiley-btn");
            __builder.AddContent(4, 
#nullable restore
#line 19 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\RealtimeChat_WebAssembly\EmojiPicker\Components\SubComponents\EmojiBtn.razor"
                                                                          Emoji

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\RealtimeChat_WebAssembly\EmojiPicker\Components\SubComponents\EmojiBtn.razor"
       
    [Parameter]
    public EventCallback<string> AddEmoji { get; set; }

    [Parameter]
    public string Emoji { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
