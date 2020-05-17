#pragma checksum "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\RealtimeChat_WebAssembly\EmojiPicker\Components\EmojiInput.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b152898dfc5cce201fc8af660b9c337d87e4f44"
// <auto-generated/>
#pragma warning disable 1591
namespace WSDT.EmojiFilePicker
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
#line 2 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\RealtimeChat_WebAssembly\EmojiPicker\Components\EmojiInput.razor"
using WSDT.EmojiFilePicker.Sub;

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
            __builder.AddAttribute(3, "style", 
#nullable restore
#line 49 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\RealtimeChat_WebAssembly\EmojiPicker\Components\EmojiInput.razor"
                                      StyleTextInputContainer

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(4, "\r\n");
#nullable restore
#line 50 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\RealtimeChat_WebAssembly\EmojiPicker\Components\EmojiInput.razor"
     if (AddonPrepend != null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "input-group-prepend");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "span");
            __builder.AddAttribute(10, "class", "input-group-text");
            __builder.AddAttribute(11, "id", "addon-msg");
            __builder.AddContent(12, 
#nullable restore
#line 53 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\RealtimeChat_WebAssembly\EmojiPicker\Components\EmojiInput.razor"
                                                           AddonPrepend

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
#nullable restore
#line 55 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\RealtimeChat_WebAssembly\EmojiPicker\Components\EmojiInput.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(15, "    ");
            __builder.OpenElement(16, "input");
            __builder.AddAttribute(17, "type", "text");
            __builder.AddAttribute(18, "class", "form-control");
            __builder.AddAttribute(19, "style", 
#nullable restore
#line 56 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\RealtimeChat_WebAssembly\EmojiPicker\Components\EmojiInput.razor"
                                                    StyleTextInput

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(20, "placeholder", 
#nullable restore
#line 56 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\RealtimeChat_WebAssembly\EmojiPicker\Components\EmojiInput.razor"
                                                                                  Placeholder

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(21, "aria-label", 
#nullable restore
#line 56 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\RealtimeChat_WebAssembly\EmojiPicker\Components\EmojiInput.razor"
                                                                                                            Placeholder

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(22, "aria-describedby", "button-emojipicker");
            __builder.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 56 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\RealtimeChat_WebAssembly\EmojiPicker\Components\EmojiInput.razor"
                                                                                                                                                                      Message

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Message = __value, Message));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n\r\n");
#nullable restore
#line 58 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\RealtimeChat_WebAssembly\EmojiPicker\Components\EmojiInput.razor"
     if (ShowFilePicker)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(26, "        ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "input-group-append");
            __builder.AddAttribute(29, "style", 
#nullable restore
#line 60 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\RealtimeChat_WebAssembly\EmojiPicker\Components\EmojiInput.razor"
                                                StyleFileBtnContainer

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.OpenElement(31, "button");
            __builder.AddAttribute(32, "class", "btn btn-outline-secondary");
            __builder.AddAttribute(33, "style", 
#nullable restore
#line 61 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\RealtimeChat_WebAssembly\EmojiPicker\Components\EmojiInput.razor"
                                                              StyleFileBtn

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(34, "type", "button");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 61 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\RealtimeChat_WebAssembly\EmojiPicker\Components\EmojiInput.razor"
                                                                                                    () => IsFilePickerCollapsed ^= true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(36, 
#nullable restore
#line 61 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\RealtimeChat_WebAssembly\EmojiPicker\Components\EmojiInput.razor"
                                                                                                                                          FileBtnIcon

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n");
#nullable restore
#line 63 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\RealtimeChat_WebAssembly\EmojiPicker\Components\EmojiInput.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(39, "\r\n    ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "input-group-append popover__wrapper");
            __builder.AddAttribute(42, "style", 
#nullable restore
#line 65 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\RealtimeChat_WebAssembly\EmojiPicker\Components\EmojiInput.razor"
                                                             StyleEmojiBtnContainer

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(43, "\r\n        ");
            __builder.OpenElement(44, "button");
            __builder.AddAttribute(45, "class", "btn btn-outline-secondary");
            __builder.AddAttribute(46, "style", 
#nullable restore
#line 66 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\RealtimeChat_WebAssembly\EmojiPicker\Components\EmojiInput.razor"
                                                          StyleEmojiBtn

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(47, "type", "button");
            __builder.AddAttribute(48, "id", "button-emojipicker");
            __builder.AddContent(49, 
#nullable restore
#line 66 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\RealtimeChat_WebAssembly\EmojiPicker\Components\EmojiInput.razor"
                                                                                                                SmileyBtnIcon

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n        ");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "popover__content");
            __builder.AddAttribute(53, "style", 
#nullable restore
#line 67 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\RealtimeChat_WebAssembly\EmojiPicker\Components\EmojiInput.razor"
                                              StyleEmojiPopoverContainer

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(54, "\r\n            ");
            __builder.OpenComponent<WSDT.EmojiFilePicker.Sub.EmojiPanel>(55);
            __builder.AddAttribute(56, "AddEmoji", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 68 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\RealtimeChat_WebAssembly\EmojiPicker\Components\EmojiInput.razor"
                                  AddEmoji

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(57, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n");
#nullable restore
#line 71 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\RealtimeChat_WebAssembly\EmojiPicker\Components\EmojiInput.razor"
     if (ShowSubmit)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(60, "        ");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "input-group-append");
            __builder.AddAttribute(63, "style", 
#nullable restore
#line 73 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\RealtimeChat_WebAssembly\EmojiPicker\Components\EmojiInput.razor"
                                                StyleBtnSubmitContainer

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(64, "\r\n            ");
            __builder.OpenElement(65, "button");
            __builder.AddAttribute(66, "type", "submit");
            __builder.AddAttribute(67, "class", "btn btn-outline-info text-center");
            __builder.AddAttribute(68, "style", 
#nullable restore
#line 74 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\RealtimeChat_WebAssembly\EmojiPicker\Components\EmojiInput.razor"
                                                                                   StyleBtnSubmit

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(69, "disabled", 
#nullable restore
#line 74 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\RealtimeChat_WebAssembly\EmojiPicker\Components\EmojiInput.razor"
                                                                                                              IsSubmitDisabled

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(70, 
#nullable restore
#line 74 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\RealtimeChat_WebAssembly\EmojiPicker\Components\EmojiInput.razor"
                                                                                                                                 SubmitBtnLbl

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n");
#nullable restore
#line 76 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\RealtimeChat_WebAssembly\EmojiPicker\Components\EmojiInput.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(73, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n\r\n");
            __builder.OpenElement(75, "div");
            __builder.AddAttribute(76, "style", (
#nullable restore
#line 80 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\RealtimeChat_WebAssembly\EmojiPicker\Components\EmojiInput.razor"
             StyleDropzone

#line default
#line hidden
#nullable disable
            ) + " " + (
#nullable restore
#line 80 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\RealtimeChat_WebAssembly\EmojiPicker\Components\EmojiInput.razor"
                             IsFilePickerCollapsed ? "display:none;" : ""

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(77, "\r\n    ");
            __builder.OpenComponent<WSDT.EmojiFilePicker.Sub.FileUploader>(78);
            __builder.AddAttribute(79, "AddFiles", new System.Action<System.Collections.Generic.List<System.String>>(
#nullable restore
#line 81 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\RealtimeChat_WebAssembly\EmojiPicker\Components\EmojiInput.razor"
                            AddFiles

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(80, "FileUploadRoute", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 81 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\RealtimeChat_WebAssembly\EmojiPicker\Components\EmojiInput.razor"
                                                        FileUploadRoute

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(81, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 85 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\RealtimeChat_WebAssembly\EmojiPicker\Components\EmojiInput.razor"
       
    #region fields
    private string _message;
    #endregion

    #region properties
    [Parameter] public string StyleTextInputContainer { get; set; } = "";
    [Parameter] public string StyleTextInput { get; set; } = "";
    [Parameter] public string StyleFileBtnContainer { get; set; } = "";
    [Parameter] public string StyleFileBtn { get; set; } = "";
    [Parameter] public string StyleDropzone { get; set; } = "";
    [Parameter] public string StyleEmojiBtnContainer { get; set; } = "";
    [Parameter] public string StyleEmojiBtn { get; set; } = "";
    [Parameter] public string StyleEmojiPopoverContainer { get; set; } = "";
    [Parameter] public string StyleBtnSubmitContainer { get; set; } = "";
    [Parameter] public string StyleBtnSubmit { get; set; } = "";

    /// <summary>Web-Url the uploaded files will be sent to.</summary>
    [Parameter] public string FileUploadRoute { get; set; } = "/";
    
    /// <summary>Text-input value. Mainly used to bind internal value.</summary>
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

    /// <summary>´Callback for OnMessageChanged. Mainly used internally.</summary>
    [Parameter] public EventCallback<string> MessageChanged { get; set; }
    
    /// <summary>Function to be called when files are uploaded.</summary>
    [Parameter] public Action<List<string>> AddFiles { get; set; } = (List<string> filesSrc) => Console.WriteLine("EmojiInput: You way want to add an AddImages()-Callback.");
    
    /// <summary>Placeholder for text input</summary>
    [Parameter] public string Placeholder { get; set; } = "Your message";
    
    /// <summary>HTML-Entity, icon or text for bootstrap add-on prepend (input-field).</summary>
    [Parameter] public string AddonPrepend { get; set; } = EmojiList.Envelope;

    /// <summary>If true a btn is shown, to toggle a dropzone for uploading files.</summary>
    [Parameter] public bool ShowFilePicker { get; set; } = true;
    
    /// <summary>Shows submit button if true.</summary>
    [Parameter] public bool ShowSubmit { get; set; } = true;

    /// <summary>Disables submit button if true.</summary>
    [Parameter] public bool IsSubmitDisabled { get; set; } = false;
    
    /// <summary>Label for submit button.</summary>
    [Parameter] public string SubmitBtnLbl { get; set; } = "Send";
    
    /// <summary>HTML-Entity, icon or text for smiley button.</summary>
    [Parameter] public string SmileyBtnIcon { get; set; } = EmojiList.Smiley; //"&#x1F600";

    /// <summary>HTML-Entity, icon or text for file button.</summary>
    [Parameter] public string FileBtnIcon { get; set; } = EmojiList.Open_File_Folder; // "&#128206;";
    #endregion

    #region methods
    protected void AddEmoji(string emoji) => Message += emoji;
    private bool IsFilePickerCollapsed { get; set; } = true;
    #endregion

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
