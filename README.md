# Blazor_EmojiFilePicker [![HitCount](http://hits.dwyl.com/wsdt/Blazor_EmojiFilePicker.svg)](http://hits.dwyl.com/wsdt/Blazor_EmojiFilePicker) [![Maintenance](https://img.shields.io/badge/Maintained%3F-yes-green.svg)](https://bitbucket.org/lbesson/ansi-colors) [![GitHub license](https://img.shields.io/github/license/wsdt/Blazor_EmojiFilePicker.svg)](https://github.com/wsdt/Blazor_EmojiFilePicker/blob/master/LICENSE) [![Generic badge](https://img.shields.io/badge/Made%20for-Blazor-blueviolet)](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor) 

Bootstrap Text-Input with Smiley- and File-Support for Blazor.
![Regular Input](https://github.com/wsdt/Blazor_EmojiFilePicker/blob/master/docs/img/InputView.PNG "Regular Input")

## Usage
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
| Attribute        | Type                  | Example                                                                                                                                                                                                                                      | Usage                                                                                                                                                                           |
|------------------|-----------------------|----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| @bind-Message    | string                | ```csharp ChatMsg```                                                                                                                                                                                                                         | Binds value of input-field to your outer model for validation, form-submission, ...                                                                                             |
| MessageChanged   | EventCallback<string> | ```csharp null```                                                                                                                                                                                                                            | Overwrite default onMessageChanged-Callback. Basically just needed for binding.                                                                                                 |
| AddFiles         | Action<List<string>>  | ```csharp public void AddFiles(List<string> imgUris)     {         foreach (string imgUri in imgUris) AddToMsg($"<img src='{imgUri}' alt='Image' class='resizedImg' />");           ChatService.Send();         StateHasChanged();     } ``` | Receive the links to uploaded files as List. Files are uploaded to the provided FileUploadRoute. In case you expect images to be uploaded you could e.g. add them to your view. |
| FileUploadRoute  | string                | ```csharp "/api/v1/file_upload"```                                                                                                                                                                                                           | Defines the local route to save uploaded files.                                                                                                                                 |
| Placeholder      | string                | ```csharp "Message"```                                                                                                                                                                                                                       | Defines the placeholder for your text-input.                                                                                                                                    |
| AddonPrepend     | string                | ```csharp EmojiList.Envelope``` or ```csharp "✉"```                                                                                                                                                                                          | Defines the Prepend-Addon for the bootstrap input.                                                                                                                              |
| ShowFilePicker   | bool                  | ```csharp true```                                                                                                                                                                                                                            | Should file-picker-Button and Dropzone be enabled?                                                                                                                              |
| ShowSubmit       | bool                  | ```csharp true```                                                                                                                                                                                                                            | Displays a regular submit-Btn. No callback is required as this component is not nested by a form.                                                                               |
| IsSubmitDisabled | bool                  | ```cshtml @(!ChatService.IsConnected())```                                                                                                                                                                                                   | If Submit-Btn is shown, then this property en- or disables the button.                                                                                                          |
| SubmitBtnLbl     | string                | ```csharp "Send"```                                                                                                                                                                                                                          | Sets the Submit-Label, if the button is shown.                                                                                                                                  |
| SmileyBtnIcon    | string                | ```csharp EmojiList.Smiley```or ```csharp "😁"```                                                                                                                                                                                             | Defines the smiley-button icon.                                                                                                                                                 |
| FileBtnIcon      | string                | ```csharp EmojiList.Open_File_Folder``` or ```csharp "📎"```                                                                                                                                                                                  | Defines the file-button icon.                                                                                                                                                   |

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

**Contributors** [![saythanks](https://img.shields.io/badge/say-thanks-ff69b4.svg)](https://saythanks.io/to/kennethreitz)
- Kevin Riedl ([WSDT](https://github.com/wsdt))
