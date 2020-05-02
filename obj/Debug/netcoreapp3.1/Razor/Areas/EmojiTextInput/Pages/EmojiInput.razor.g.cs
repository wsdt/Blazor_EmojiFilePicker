#pragma checksum "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\EmojiPicker\Areas\EmojiTextInput\Pages\EmojiInput.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d74120c36364d379164e71d17164c7658063b3e"
// <auto-generated/>
#pragma warning disable 1591
namespace EmojiPicker.Areas.EmojiTextInput.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\EmojiPicker\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\EmojiPicker\Areas\EmojiTextInput\Pages\EmojiInput.razor"
using EmojiPicker.Areas.EmojiTextInput.Pages;

#line default
#line hidden
#nullable disable
    public partial class EmojiInput : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
    /* Popover styling */
    .popover__wrapper {
        position: relative;
        display: inline-block;
    }

    .popover__content {
        opacity: 0;
        visibility: hidden;
        position: absolute;
        left: -150px;
        transform: translate(0px, -10px);
        transition-delay: 0.5s;
        background-color: #F8F8F8;
        padding: 1.5rem;
        box-shadow: 0 2px 5px 0 rgba(0, 0, 0, 0.26);
        width: auto;
    }

        .popover__content:before {
            position: absolute;
            z-index: -1;
            content: """";
            right: calc(50% - 10px);
            top: -8px;
            border-style: solid;
            border-width: 0 10px 10px 10px;
            border-color: transparent transparent #F8F8F8 transparent;
            transition-duration: 0.3s;
            transition-property: transform;
        }

    .popover__wrapper:hover .popover__content {
        z-index: 10;
        opacity: 1;
        visibility: visible;
        transform: translate(0px, 10px);
        transition: all 0.5s cubic-bezier(0.75, -0.02, 0.2, 0.97);
    }
</style>



");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "input-group mb-3");
            __builder.AddMarkupContent(3, "\r\n");
#nullable restore
#line 49 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\EmojiPicker\Areas\EmojiTextInput\Pages\EmojiInput.razor"
     if (AddonPrepend != null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "input-group-prepend");
            __builder.AddMarkupContent(7, "\r\n            ");
            __builder.OpenElement(8, "span");
            __builder.AddAttribute(9, "class", "input-group-text");
            __builder.AddAttribute(10, "id", "addon-msg");
            __builder.AddContent(11, 
#nullable restore
#line 52 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\EmojiPicker\Areas\EmojiTextInput\Pages\EmojiInput.razor"
                                                           AddonPrepend

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n");
#nullable restore
#line 54 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\EmojiPicker\Areas\EmojiTextInput\Pages\EmojiInput.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(14, "    ");
            __builder.OpenElement(15, "input");
            __builder.AddAttribute(16, "type", "text");
            __builder.AddAttribute(17, "class", "form-control");
            __builder.AddAttribute(18, "placeholder", 
#nullable restore
#line 55 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\EmojiPicker\Areas\EmojiTextInput\Pages\EmojiInput.razor"
                                                          Placeholder

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(19, "aria-label", 
#nullable restore
#line 55 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\EmojiPicker\Areas\EmojiTextInput\Pages\EmojiInput.razor"
                                                                                    Placeholder

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(20, "aria-describedby", "button-emojipicker");
            __builder.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 55 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\EmojiPicker\Areas\EmojiTextInput\Pages\EmojiInput.razor"
                                                                                                                                              Message

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Message = __value, Message));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n\r\n");
#nullable restore
#line 57 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\EmojiPicker\Areas\EmojiTextInput\Pages\EmojiInput.razor"
     if (ShowFilePicker)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(24, "        ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "input-group-append");
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.OpenElement(28, "button");
            __builder.AddAttribute(29, "class", "btn btn-outline-secondary");
            __builder.AddAttribute(30, "type", "button");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 60 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\EmojiPicker\Areas\EmojiTextInput\Pages\EmojiInput.razor"
                                                                              () => IsFilePickerCollapsed ^= true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(32, 
#nullable restore
#line 60 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\EmojiPicker\Areas\EmojiTextInput\Pages\EmojiInput.razor"
                                                                                                                    FileBtnIcon

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
#nullable restore
#line 62 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\EmojiPicker\Areas\EmojiTextInput\Pages\EmojiInput.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(35, "\r\n    ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "input-group-append popover__wrapper");
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.OpenElement(39, "button");
            __builder.AddAttribute(40, "class", "btn btn-outline-secondary");
            __builder.AddAttribute(41, "type", "button");
            __builder.AddAttribute(42, "id", "button-emojipicker");
            __builder.AddContent(43, 
#nullable restore
#line 65 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\EmojiPicker\Areas\EmojiTextInput\Pages\EmojiInput.razor"
                                                                                         SmileyBtnIcon

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n        ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "popover__content");
            __builder.AddMarkupContent(47, "\r\n            ");
            __builder.OpenComponent<EmojiPicker.Areas.EmojiTextInput.Pages.EmojiPanel>(48);
            __builder.AddAttribute(49, "AddEmoji", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 67 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\EmojiPicker\Areas\EmojiTextInput\Pages\EmojiInput.razor"
                                  AddEmoji

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(50, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n");
#nullable restore
#line 71 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\EmojiPicker\Areas\EmojiTextInput\Pages\EmojiInput.razor"
     if (ShowSubmit)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(53, "        ");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "input-group-append");
            __builder.AddMarkupContent(56, "\r\n            ");
            __builder.OpenElement(57, "button");
            __builder.AddAttribute(58, "type", "submit");
            __builder.AddAttribute(59, "class", "btn btn-outline-info text-center");
            __builder.AddAttribute(60, "disabled", 
#nullable restore
#line 74 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\EmojiPicker\Areas\EmojiTextInput\Pages\EmojiInput.razor"
                                                                                      IsSubmitDisabled

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(61, 
#nullable restore
#line 74 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\EmojiPicker\Areas\EmojiTextInput\Pages\EmojiInput.razor"
                                                                                                         SubmitBtnLbl

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n");
#nullable restore
#line 76 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\EmojiPicker\Areas\EmojiTextInput\Pages\EmojiInput.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(64, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n\r\n");
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "style", 
#nullable restore
#line 80 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\EmojiPicker\Areas\EmojiTextInput\Pages\EmojiInput.razor"
              IsFilePickerCollapsed ? "display:none;" : ""

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(68, "\r\n    ");
            __builder.OpenComponent<EmojiPicker.Areas.EmojiTextInput.Pages.FileUploader>(69);
            __builder.AddAttribute(70, "AddImages", new System.Action<System.Collections.Generic.List<System.String>>(
#nullable restore
#line 81 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\EmojiPicker\Areas\EmojiTextInput\Pages\EmojiInput.razor"
                             AddImages

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(71, "FileUploadRoute", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 81 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\EmojiPicker\Areas\EmojiTextInput\Pages\EmojiInput.razor"
                                                          FileUploadRoute

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(72, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 85 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\EmojiPicker\Areas\EmojiTextInput\Pages\EmojiInput.razor"
       
    private string _message;

    [Parameter]
    public string FileUploadRoute { get; set; }

    [Parameter]
    public string Message
    {
        get => _message;
        set
        {
            if (_message == value) return;
            _message = value;
            MessageChanged.InvokeAsync(value);
        }
    }

    [Parameter]
    public EventCallback<string> MessageChanged { get; set; }

    [Parameter]
    public Action<List<string>> AddImages { get; set; }

    [Parameter]
    public string Placeholder { get; set; }

    [Parameter]
    public string AddonPrepend { get; set; }

    [Parameter]
    public bool ShowFilePicker { get; set; } = true;

    [Parameter]
    public bool ShowSubmit { get; set; } = true;

    [Parameter]
    public bool IsSubmitDisabled { get; set; } = false;

    [Parameter]
    public string SubmitBtnLbl { get; set; } = "Send";

    [Parameter]
    public string SmileyBtnIcon { get; set; } = Emoji.Emoji.Smiley; //"&#x1F600";

    [Parameter]
    public string FileBtnIcon { get; set; } = Emoji.Emoji.Open_File_Folder; // "&#128206;";

    protected void AddEmoji(string emoji) => Message += emoji;

    private bool IsFilePickerCollapsed { get; set; } = true;

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
