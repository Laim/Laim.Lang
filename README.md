# Laim.Lang
Basic language translation library for .NET.  This was created for a very specific purpose, however I have decided to upload it here in case anyone needs it for a proof of concept project, I wouldn't recommend using this in production as it's only ever been tested in proof of concept applications. 

[![License](http://img.shields.io/:license-mit-blue.svg?style=flat-square)](http://badges.mit-license.org)
## Installation

Add `Laim.Lang.dll` as a reference to your .NET application.

## Usage

```cs
Laim.Lang.LanguagePicker.Language = "en_gb";
Laim.Lang.LanguagePicker.LanguageFileFormat = ".lang";
Laim.Lang.LanguagePicker.LanguageFileName = "Language-";
Laim.Lang.LanguagePicker.LanguageLocation = Application.StartupPath + "\\Languages\\";

lblApplicationName.Text = Laim.Lang.Translator.Translate("ApplicationName");
```

The node `ApplicationName` in this case is what you would name the node in the language file, it would then return the translated value. 

There is a working Example application available in the repo.

## File Layout
The language files use the XML Standard for formatting, a basic example of a Language file is below.

```xml
<?xml version="1.0" encoding="utf-8"?>
<Language>
  <ApplicationName>Example Application</ApplicationName>
  <LanguageLabel>Language:</LanguageLabel>
  <RefreshButton>Refresh</RefreshButton>
</Language>
```

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.

## Support
If you need any assistance please log an issue or contact me on social media.

- [Website](https://laim.scot)
- [Twitter](https://twitter.com/lyeuhm)
