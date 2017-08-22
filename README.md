

[![Release](https://img.shields.io/github/release/Dirkster99/MRULib.svg)](https://github.com/Dirkster99/MRULib/releases/latest)
[![NuGet](https://img.shields.io/nuget/dt/Dirkster.MRULib.svg)](http://nuget.org/packages/Dirkster.MRULib)
<h1><img src="https://github.com/Dirkster99/Docu/blob/master/MRULib/ProjectIcon.png" height="64"/>&nbsp;Overview</h1>
The MRUib project supplies MVVM/WPF controls that manage a Most Recently Used list of files. 

## Demo Application
The repository contains a demo application and unit tests to make sure that requirements and API's are clear and working as expected.

## Theming

Load *Light* or *Dark* brush resources in you resource dictionary to take advantage of existing definitions.

```XAML
    <ResourceDictionary.MergedDictionaries>
        <ResourceDictionary Source="/MRULib;component/Themes/DarkBrushes.xaml" />
    </ResourceDictionary.MergedDictionaries>
```

```XAML
    <ResourceDictionary.MergedDictionaries>
        <ResourceDictionary Source="/MRULib;component/Themes/LightBrushes.xaml" />
    </ResourceDictionary.MergedDictionaries>
```

These definitions do not theme all controls used within this library. You should use a standard theming library, such as:
- [MahApps.Metro](https://github.com/MahApps/MahApps.Metro),
- [MLib](https://github.com/Dirkster99/MLib), or
- [MUI](https://github.com/firstfloorsoftware/mui)

to also theme standard elements, such as, button and textblock etc.
