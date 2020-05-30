#pragma checksum "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\RealtimeChat_WebAssembly\EmojiPicker\Components\EmojiInput.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d7cb7441b339baf46f83ae18978745ba7c74f40"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Parameter] public string AddonPrepend { get; set; } = "✉";

    /// <summary>If true a btn is shown, to toggle a dropzone for uploading files.</summary>
    [Parameter] public bool ShowFilePicker { get; set; } = true;

    /// <summary>Shows submit button if true.</summary>
    [Parameter] public bool ShowSubmit { get; set; } = true;

    /// <summary>Disables submit button if true.</summary>
    [Parameter] public bool IsSubmitDisabled { get; set; } = false;

    /// <summary>Label for submit button.</summary>
    [Parameter] public string SubmitBtnLbl { get; set; } = "Send";

    /// <summary>HTML-Entity, icon or text for smiley button.</summary>
    [Parameter] public string SmileyBtnIcon { get; set; } = "😃";

    /// <summary>HTML-Entity, icon or text for file button.</summary>
    [Parameter] public string FileBtnIcon { get; set; } = "📂";

    /// <summary>Determines if input-autocomplete is on|off.</summary>
    [Parameter] public string AutoComplete { get; set; } = "on";
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
