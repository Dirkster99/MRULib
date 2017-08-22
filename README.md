[![Build status](https://ci.appveyor.com/api/projects/status/ie3dx7fa4vujwhgs?svg=true)](https://ci.appveyor.com/project/Dirkster99/dropdownbuttonlib)
[![Release](https://img.shields.io/github/release/Dirkster99/DropDownButtonLib.svg)](https://github.com/Dirkster99/DropDownButtonLib/releases/latest)
[![NuGet](https://img.shields.io/nuget/dt/Dirkster.DropDownButtonLib.svg)](http://nuget.org/packages/Dirkster.DropDownButtonLib)
<h1><img src="https://github.com/Dirkster99/Docu/blob/master/DropDownButtonLib/DropDownButtonLibLogo.png" height="64"/>&nbsp;Overview</h1>
The DropDownButtonLib project supplies MVVM/WPF drop down controls that are based on a button. 

There are sample screenshot on the Codeplex site from were this project is migrated from:
https://dropdownbuttonlib.codeplex.com/

This project is based on the drop down control contained in the
Extended WPF Toolkit™ Community Edition:https://wpftoolkit.codeplex.com/ from Xceed.
It includes some bugfixes to the original implementation and extends the original controls with a:

- DropDownButton, SplitButton
with:
- DropDownItemsButton, SplitItemsButton

controls. The original implementation (DropDownButton, SplitButton) can be used to drop down and interact with single drop down items, while the extended controls (DropDownItemsButton, SplittItemsButton) are based on an ItemsControl and can thus be with multiple drop down items (in a similar fashion as a standard WPF ComboBox or ListBox control).

## DropDownButton
<img src="https://github.com/Dirkster99/Docu/blob/master/DropDownButtonLib/DropDownButton.png"/>
The DropDown button shows a drop down element that gives users a way of editing something and confirming it with Cancel or OK (this works similar to a dialog but in a drop down scenario).

## SplitButton
<img src="https://github.com/Dirkster99/Docu/blob/master/DropDownButtonLib/SplitButton.png"/>
The Split button has a drop down section and a button.
The drop down element gives you a way of editing/selecting in a similar scenario as in the DropDownButton shown above, while the button itself can be used like a shortcut that refers to the last selected element.

## DropDownItemsButton
<img src="https://github.com/Dirkster99/Docu/blob/master/DropDownButtonLib/DropDownItemsButton.png"/>
The DropDown button shows a drop down element which can be used to select one element out of many. This could also be implemented with the DropDownButton control but it is much easier with this control since it already contains an ItemsControl inside the drop down element.

## SplitItemsButton
<img src="https://github.com/Dirkster99/Docu/blob/master/DropDownButtonLib/SplitItemsButton.png"/>
The Split button has a drop down section and a button.
The drop down element gives you a way of selecting from among many elements while the button itself can be used like a shortcut that refers to the last selected element.

## Demo Application
<img src="https://github.com/Dirkster99/Docu/blob/master/DropDownButtonLib/MainTestWindow.png"/>
This is a screenshot of the MainWindow of the included Test Application. The complete implementation is MVVM compliant and all controls are fully themeable (look-less controls).

## Theming

Load *Light* or *Dark* brush resources in you resource dictionary to take advantage of existing definitions.

```XAML
    <ResourceDictionary.MergedDictionaries>
        <ResourceDictionary Source="/DropDownButtonLib;component/Themes/MetroDark.xaml" />
    </ResourceDictionary.MergedDictionaries>
```

```XAML
    <ResourceDictionary.MergedDictionaries>
        <ResourceDictionary Source="/DropDownButtonLib;component/Themes/MetroLight.xaml" />
    </ResourceDictionary.MergedDictionaries>
```

These definitions do not theme all controls used within this library. You should use a standard theming library, such as:
- [MahApps.Metro](https://github.com/MahApps/MahApps.Metro),
- [MLib](https://github.com/Dirkster99/MLib), or
- [MUI](https://github.com/firstfloorsoftware/mui)

to also theme standard elements, such as, button and textblock etc.
