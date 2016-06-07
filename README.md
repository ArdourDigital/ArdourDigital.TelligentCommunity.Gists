# Github Gist embedding for Telligent Community

![Build Status](https://ardourdigital.visualstudio.com/_apis/public/build/definitions/8b5ba8e6-4059-46da-8ac1-e2bcf922c889/7/badge)

Github Gist Embedding plugin for Telligent Community.

[Github gists](https://gist.github.com/) allow code snippets to be managed and shared with others. This plugin allows them to be embedded within content in a Telligent Community site.

## Supported Versions
This plugin should work with the following versions of Telligent Community
- Telligent Community 9.x
- Telligent Community 8.x
- Telligent Community 7.x

## Installation

You can install the plugin by [downloading the latest version](https://github.com/ArdourDigital/ArdourDigital.TelligentCommunity.Gists/releases/latest) and adding it to your sites `bin` folder, or if you are using Visual Studio you can use nuget:

```
Install-Package ArdourDigital.TelligentCommunity.Gists
```

The plugin can then be enabled by logging in as an administrator, and going to `Administration` > `Extensions` and finding `Ardour Digital - GitHub Gist File Viewer`, check the `Enabled` check box, and `Save`.

## Usage

When creating content in Telligent Community using the Rich Text Editor, Insert an `Image/Video/File` using the menu (the menu differs slightly between versions of Telligent Community).

Ensure you have selected `Web (URL)` (this is `YouTube or Web (URL)` in earlier versions) from the dropdown for `From` and then enter the URL of the GitHub Gist as the `URL`, and click `OK`.

![Example Insert URL form](https://raw.githubusercontent.com/ArdourDigital/ArdourDigital.TelligentCommunity.Gists/master/Assets/GistInsert.PNG)

## Styling

If you are using the default social theme you may see extra lines when viewing Gists on your community, this can be removed by adding the following CSS to your site:

```
.content-fragment .content > .content .gist table th, 
.content-fragment .content > .content .gist table td { border-bottom: none; }
```

The simplest way to do this is by adding it to the `Custom Style Sheet` field for the theme, as an administrator:
- Go to homepage > Click the Pencil in the top right > `Manage Site Theme` > `Edit this Theme` > `Custom Styles` (Telligent Community 9.x)
- `Control Panel` > `Site Administration` > `Site Content` > `Site Theme` > `Custom Styles` (Telligent Community 8.x and lower)