# Blazor_EmojiFilePicker [![HitCount](http://hits.dwyl.com/wsdt/Blazor_EmojiFilePicker.svg)](http://hits.dwyl.com/wsdt/Blazor_EmojiFilePicker) [![Maintenance](https://img.shields.io/badge/Maintained%3F-yes-green.svg)](https://bitbucket.org/lbesson/ansi-colors) [![GitHub license](https://img.shields.io/github/license/wsdt/Blazor_EmojiFilePicker.svg)](https://github.com/wsdt/Blazor_EmojiFilePicker/blob/master/LICENSE) [![Generic badge](https://img.shields.io/badge/Made%20for-Blazor-blueviolet)](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor) [![Donate](https://img.shields.io/badge/Donate-Pay%20me%20a%20coffee-3cf)](https://github.com/wsdt/Global/wiki/Donation) [![saythanks](https://img.shields.io/badge/say-thanks-ff69b4.svg)](https://saythanks.io/to/kevin.riedl.privat%40gmail.com) [![Codacy Badge](https://api.codacy.com/project/badge/Grade/4b858f0c655241faa186027bcc650b89)](https://app.codacy.com/manual/wsdt/Blazor_EmojiFilePicker?utm_source=github.com&utm_medium=referral&utm_content=wsdt/Blazor_EmojiFilePicker&utm_campaign=Badge_Grade_Dashboard)

Bootstrap Text-Input with Smiley- and File-Support for Blazor. **Full customizable!**
![Regular Input](https://github.com/wsdt/Blazor_EmojiFilePicker/blob/master/docs/img/InputView.PNG "Regular Input")

## Example projects 
* [WSDT/RealtimeChat_WebAssembly](https://github.com/wsdt/RealtimeChat_WebAssembly)

## Usage ![Nuget](https://img.shields.io/nuget/v/wsdt.blazor.emojifileinput?style=plastic) ![Nuget](https://img.shields.io/nuget/dt/WSDT.Blazor.EmojiFileInput)
NuGet-Url: [Nuget.org/packages/WSDT.Blazor.EmojiFileInput](https://www.nuget.org/packages/wsdt.blazor.emojifileinput/)

1. `Install-Package WSDT.Blazor.EmojiFileInput`

2. And add to your **Startup.cs**-file:
```csharp
using EmojiPicker;
services.AddEmojiPicker();
```

3. Add the component to your **.razor-View**:
```cshtml
@using WSDT.EmojiFilePicker
<EmojiInput />
```

4. Add parameters and have fun :-)
<table>
<thead>
<tr>
<th>Attribute</th>
<th>Type</th>
<th>Example</th>
<th>Usage</th>
</tr>
</thead>
<tbody>
<tr>
  <td>@bind-Message</td>
<td>string</td>
<td>
  
  ```csharp 
  ChatMsg
  ```
  </td>
<td>Binds value of input-field to your outer model for validation, form-submission, ...</td>
</tr>
<tr>
  <td>MessageChanged</td>
<td>EventCallback<string></td>
<td>
  
  ```csharp 
  null
  ```
  </td>
<td>Overwrite default onMessageChanged-Callback. Basically just needed for binding.</td>
</tr>
<tr>
  <td>AddFiles</td>
<td>Action<List<string>></td>
<td>
  
```csharp
public void AddFiles(List<string> imgs)
    {
        foreach (string i in imgs) {
            AddToMsg($"<img src='{i}'/>");
        }

        ChatService.Send();
        StateHasChanged();
    }
```
</td>
<td>Receive the links to uploaded files as List. Files are uploaded to the provided FileUploadRoute. In case you expect images to be uploaded you could e.g. add them to your view.
</td>
</tr>
<tr>
<td>FileUploadRoute</td>
<td>string</td>
<td>
  
  ```csharp 
  "/api/v1/file_upload"
  ```
  </td>
<td>Defines the local route to save uploaded files.</td>
</tr>
<tr>
<td>CancellationToken</td>
<td>CancellationToken</td>
<td>
  
  ```csharp 
  new CancellationTokenSource().Token
  ```
  </td>
<td>Optional cancellation token for file upload route.</td>
</tr>
<tr>
<td>Placeholder</td>
<td>string</td>
<td>
  
  ```csharp 
  "Message"
  ```
  </td>
<td>Defines the placeholder for your text-input.</td>
</tr>
<tr>
<td>AutoComplete</td>
<td>string</td>
<td>
  
  ```csharp 
  "on" | "off"
  ```
  </td>
<td>Defines whether HTML autocompletion is enabled.</td>
</tr>
<tr>
<td>AddonPrepend</td>
<td>string</td>
<td>
  
  ```csharp  
  EmojiList.Envelope
  ``` 
  or 
  ```csharp 
  "✉"
  ```
  </td>
<td>Defines the Prepend-Addon for the bootstrap input.</td>
</tr>
<tr>
<td>ShowFilePicker</td>
<td>bool</td>
<td>
  
  ```csharp 
  true
  ```
  </td>
<td>Should file-picker-Button and Dropzone be enabled?</td>
</tr>
<tr>
<td>ShowClearBtn</td>
<td>bool</td>
<td> 
  
  ```csharp 
  true
  ```
  </td>
<td>Displays a regular clear-Btn.</td>
</tr>
<tr>
<td>ClearBtnLbl</td>
<td>string</td>
<td> 
  
  ```csharp 
  "Reset"
  ```
  </td>
<td>Label to show on the clear-button.</td>
</tr>
<tr>
<td>ShowSubmit</td>
<td>bool</td>
<td> 
  
  ```csharp 
  true
  ```
  </td>
<td>Displays a regular submit-Btn. No callback is required as this component is not nested by a form.</td>
</tr>
<tr>
<td>IsSubmitDisabled</td>
<td>bool</td>
<td>
  
  ```cshtml 
  @(!ChatService.IsConnected())
  ```
  </td>
<td>If Submit-Btn is shown, then this property en- or disables the button.</td>
</tr>
<tr>
<td>SubmitBtnLbl</td>
<td>string</td>
<td> 
  
  ```csharp 
  "Send"
  ```
  </td>
<td>Sets the Submit-Label, if the button is shown.</td>
</tr>
<tr>
<td>SmileyBtnIcon</td>
<td>string</td>
<td>
  
  ```csharp 
  EmojiList.Smiley
  ``` 
  or 
  ```csharp 
  "😁"
  ```
  </td>
<td>Defines the smiley-button icon.</td>
</tr>
<tr>
<td>FileBtnIcon</td>
<td>string</td>
<td>
  
  ```csharp 
  EmojiList.Open_File_Folder
  ``` 
  or 
  ```csharp 
  "📎"
  ```
  </td>
<td>Defines the file-button icon.</td>
</tr>

<tr>
<td>CustomSymbols</td>
<td>List&lt;string&gt;</td>
<td>
  
  ```csharp 
  new List<string>()
    {
        "⺀", "⽥", "⽨", "⽣", "㣕"
    }
  ```
  </td>
<td>Add custom symbols to create a new tab at the end of the emoji picker.</td>
</tr>

<tr>
<td>ShowPreview</td>
<td>bool</td>
<td>
  
  ```csharp 
    true
  ```
  </td>
<td>Will show a markdown & html live-preview of the inputted message, if true.</td>
</tr>

<tr>
<td>StyleBtnClearContainer</td>
<td>string</td>
<td>
  
  ```css
  width: 100px;
  ```
  </td>
<td>Defines the css-style(s) the clear-btn container.</td>
</tr>

<tr>
<td>StyleBtnClear</td>
<td>string</td>
<td>
  
  ```css
  color: #ff0000;
  ```
  </td>
<td>Defines the css-style(s) for the clear-btn.</td>
</tr>

<tr>
<td>StylePreviewContainer</td>
<td>string</td>
<td>
  
  ```css
  color: #ff0000;
  ```
  </td>
<td>Defines the css-style(s) for the message-preview container.</td>
</tr>

<tr>
<td>ClassEmojiTabBtnActive</td>
<td>string</td>
<td>
  
  ```css
  btn-dark
  ```
  </td>
<td>Defines the css-class(es) for the active tab-button within the emoji-panel.</td>
</tr>
<tr>
<td>ClassEmojiTabBtnInActive</td>
<td>string</td>
<td>
  
  ```css
  btn-light
  ```
  </td>
<td>Defines the css-class(es) for the inactive tab-buttons within the emoji-panel.</td>
</tr>
<tr>
<td>StyleTextInputContainer</td>
<td>string</td>
<td>
  
  ```css
  display:inline-block;width:50px;
  ```
  </td>
<td>Defines inline-style for the surrounding div of our text-input.</td>
</tr>
<tr>
<td>StyleTextInput</td>
<td>string</td>
<td>
  
  ```css 
  background-color:#555; 
  ```
  </td>
<td>Defines inline-style of our text-input.</td>
</tr>
<tr>
<td>StyleFileBtnContainer</td>
<td>string</td>
<td>
  
  ```css 
  width:100px;
  ```
  </td>
<td>Defines inline-style of the surrounding div of the file-button.</td>
</tr>
<tr>
<td>StyleFileBtn</td>
<td>string</td>
<td>
  
  ```css 
  color:#fff;
  ```
  </td>
<td>Defines inline-style of our file-button.</td>
</tr>
<tr>
<td>StyleDropzone</td>
<td>string</td>
<td>
  
  ```css 
  background-color:#cc3f00;
  ```
  </td>
<td>Defines inline-style of our file-dropzone.</td>
</tr>
<tr>
<td>StyleEmojiBtnContainer</td>
<td>string</td>
<td>
  
  ```css 
  width:25px;
  ```
  </td>
<td>Defines inline-style of the surrounding div of our emoji-button.</td>
</tr>
<tr>
<td>StyleEmojiBtn</td>
<td>string</td>
<td>
  
  ```css 
  font-size:18px;
  ```
  </td>
<td>Defines inline-style of our emoji-button.</td>
</tr>
<tr>
<td>StyleEmojiPopoverContainer</td>
<td>string</td>
<td>
  
  ```css 
  font-size:18px;
  ```
  </td>
<td>Defines inline-style of the surrounding div of our smiley-popover.</td>
</tr>
<tr>
<td>StyleBtnSubmitContainer</td>
<td>string</td>
<td>
  
  ```css 
  display:inline;text-align:justify;
  ```
  </td>
<td>Defines inline-style of the surrounding div of our submit-button.</td>
</tr>
<tr>
<td>StyleBtnSubmit</td>
<td>string</td>
<td>
  
  ```css 
  font-size:10px;
  ```
  </td>
<td>Defines inline-style of our submit-button.</td>
</tr>
</tbody>
</table>


## Features
* Configurable (e.g. submit-btn, file-picker, ... can be deactivated)
* Supports File-Uploads (support for multiple files simultaneously) and provides a collapsable dropzone

![Dropzone_Images](https://github.com/wsdt/Blazor_EmojiFilePicker/blob/master/docs/img/Dropzone_Smileys.PNG "Dropzone - Images")

* Supports Smileys via simple Popover

![Emoji_Picker](https://github.com/wsdt/Blazor_EmojiFilePicker/blob/master/docs/img/SmileyPicker.png "Emoji Picker")

## Dependencies
* bootstrap (>= 4.4.1)
* Microsoft.Extensions.DependencyInjection (>= 3.1.3)
* Tewr.Blazor.FileReader (>= 1.5.0.20109)


## Contribution [![Open Source Love svg2](https://badges.frapsoft.com/os/v2/open-source.svg?v=103)](https://github.com/ellerbrock/open-source-badges/) [![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen.svg?style=flat-square)](http://makeapullrequest.com)

This project is licensed under GNU V3, so contributions/pull-requests are welcome. All contributors get listed here. 

**Contributors** 
- Kevin Riedl ([WSDT](https://github.com/wsdt))
