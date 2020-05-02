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
<td><pre lang="csharp"> ChatMsg </pre></td>
<td>Binds value of input-field to your outer model for validation, form-submission, ...</td>
</tr>
<tr>
<td>MessageChanged</td>
<td>EventCallback<string></td>
<td><code>csharp null</code></td>
<td>Overwrite default onMessageChanged-Callback. Basically just needed for binding.</td>
</tr>
<tr>
<td>AddFiles</td>
<td>Action<List<string>&gt;</td>
<td><code>csharp public void AddFiles(List&lt;string&gt; imgUris)     {         foreach (string imgUri in imgUris) AddToMsg($&quot;&lt;img src=&#39;{imgUri}&#39; alt=&#39;Image&#39; class=&#39;resizedImg&#39; /&gt;&quot;);           ChatService.Send();         StateHasChanged();     }</code></td>
<td>Receive the links to uploaded files as List. Files are uploaded to the provided FileUploadRoute. In case you expect images to be uploaded you could e.g. add them to your view.</td>
</tr>
<tr>
<td>FileUploadRoute</td>
<td>string</td>
<td><code>csharp &quot;/api/v1/file_upload&quot;</code></td>
<td>Defines the local route to save uploaded files.</td>
</tr>
<tr>
<td>Placeholder</td>
<td>string</td>
<td><code>csharp &quot;Message&quot;</code></td>
<td>Defines the placeholder for your text-input.</td>
</tr>
<tr>
<td>AddonPrepend</td>
<td>string</td>
<td><code>csharp  EmojiList.Envelope</code> or <code>csharp  &quot;✉&quot;</code></td>
<td>Defines the Prepend-Addon for the bootstrap input.</td>
</tr>
<tr>
<td>ShowFilePicker</td>
<td>bool</td>
<td><code>csharp true</code></td>
<td>Should file-picker-Button and Dropzone be enabled?</td>
</tr>
<tr>
<td>ShowSubmit</td>
<td>bool</td>
<td><code>csharp true</code></td>
<td>Displays a regular submit-Btn. No callback is required as this component is not nested by a form.</td>
</tr>
<tr>
<td>IsSubmitDisabled</td>
<td>bool</td>
<td><code>cshtml @(!ChatService.IsConnected())</code></td>
<td>If Submit-Btn is shown, then this property en- or disables the button.</td>
</tr>
<tr>
<td>SubmitBtnLbl</td>
<td>string</td>
<td><code>csharp &quot;Send&quot;</code></td>
<td>Sets the Submit-Label, if the button is shown.</td>
</tr>
<tr>
<td>SmileyBtnIcon</td>
<td>string</td>
<td><code>csharp EmojiList.Smiley</code>or <code>csharp &quot;😁&quot;</code></td>
<td>Defines the smiley-button icon.</td>
</tr>
<tr>
<td>FileBtnIcon</td>
<td>string</td>
<td><code>csharp EmojiList.Open_File_Folder</code> or <code>csharp &quot;📎&quot;</code></td>
<td>Defines the file-button icon.</td>
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

**Contributors** [![saythanks](https://img.shields.io/badge/say-thanks-ff69b4.svg)](https://saythanks.io/to/kennethreitz)
- Kevin Riedl ([WSDT](https://github.com/wsdt))
