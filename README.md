[![Build status](https://ci.appveyor.com/api/projects/status/hs63uymamjh9p34u?svg=true)](https://ci.appveyor.com/project/Dirkster99/mrulib)
[![Release](https://img.shields.io/github/release/Dirkster99/MRULib.svg)](https://github.com/Dirkster99/MRULib/releases/latest)
[![NuGet](https://img.shields.io/nuget/dt/Dirkster.MRULib.svg)](http://nuget.org/packages/Dirkster.MRULib)
<h1><img src="https://github.com/Dirkster99/MRULib/blob/master/ProjectIcon.png?raw=true" height="64"/>&nbsp;Overview</h1>
The MRUib project supplies MVVM/WPF controls that manage a Most Recently Used list of files. 

## Details and Demo Applications
This library Implements a WPF/MVVM Control libray (with backend) that manages a Most Recently Used list of files:
- with saving/loading settings from to XML
- List can be grouped by last access (Pinned, Today, Yesterday, Last Week)
- A recently documents menu entry sorted by last access (without grouping is also supported)
- Pinned entries can be moved up and don in the list
- List entries can be removed based on their age (e.g. Remove all entries older than 1 week)
- Support for Light/Black theming is build in

There is a demo application and unit test project to demonstrate usage of the control
and document each feature, such as, the ability to configure a minimum and maximum value
that can be used to keep the resulting number of list entries within defined bounds.

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

This library is the third attempt on the subject. See Codeplex to find the last version of this library:
http://mrulist.codeplex.com/
