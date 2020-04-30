# Blazor_EmojiFilePicker [![HitCount](http://hits.dwyl.com/wsdt/Blazor_EmojiFilePicker.svg)](http://hits.dwyl.com/wsdt/Blazor_EmojiFilePicker) [![Maintenance](https://img.shields.io/badge/Maintained%3F-yes-green.svg)](https://bitbucket.org/lbesson/ansi-colors) [![GitHub license](https://img.shields.io/github/license/wsdt/Blazor_EmojiFilePicker.svg)](https://github.com/wsdt/Blazor_EmojiFilePicker/blob/master/LICENSE) [![Generic badge](https://img.shields.io/badge/Made%20for-Blazor-blueviolet)](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor) 

Bootstrap Text-Input with Smiley- and File-Support for Blazor.
![Regular Input](https://github.com/wsdt/Blazor_EmojiFilePicker/blob/master/docs/img/InputView.PNG "Regular Input")

## Usage
NuGet-Url: [Nuget.org/packages/Blazor_EmojiFilePicker](https://www.nuget.org/packages/Blazor_EmojiFilePicker)

`Install-Package Blazor_EmojiFilePicker`

And add to your Startup.cs-file:
`services.AddEmojiPicker();`

## Features
* Configurable (e.g. submit-btn, file-picker, ... can be deactivated)
* Supports Image-Uploads (support for multiple files simultaneously) and provides a collapsable dropzone
![Dropzone_Images](https://github.com/wsdt/Blazor_EmojiFilePicker/blob/master/docs/img/Dropzone_Smileys.PNG "Dropzone - Images")
* Supports Smileys via simple Popover
![Emoji_Picker](https://github.com/wsdt/Blazor_EmojiFilePicker/blob/master/docs/img/SmileyPicker.png "Emoji Picker")

## Dependencies
* bootstrap (>= 4.4.1)
* Microsoft.Extensions.DependencyInjection (>= 3.1.3)
* Tewr.Blazor.FileReader (>= 1.5.0.20109)
