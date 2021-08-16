BUILDLet UWP UI Class Library
=============================

Introduction
------------

This project provides UI class library for UWP (Universal Windows Platform).

Getting Started
---------------

This project is provided as the following NuGet Package(s).

- [BUILDLet.UWP.Controls](https://www.nuget.org/packages/BUILDLet.UWP.Controls/)

Please refer to the help document ([BUILDLet.UWP.Controls.chm](./BUILDLet.UWP.Controls.Documentation/Help/BUILDLet.UWP.Controls.chm)) for the change history and API references.

Build and Test
--------------

This project (Visual Studio Solution) is built and tested on Visual Studio.

Remarks
-------

- The followings are added to **References** of **SHFB project** (*BUILDLet.UWP.Controls.Documentation*) to work *SHFB* (21.4.9.0) correctly.
  - *C:\Program Files (x86)\Windows Kits\10\References\10.0.19041.0\Windows.Foundation.UniversalApiContract\10.0.0.0\Windows.Foundation.UniversalApiContract.winmd*
  - *C:\Program Files (x86)\Windows Kits\10\UnionMetadata\10.0.19041.0\Windows.winmd*
  - *C:\Program Files (x86)\Windows Kits\10\References\10.0.19041.0\Windows.Foundation.FoundationContract\4.0.0.0\Windows.Foundation.FoundationContract.winmd*

- Namespace of *BUILDLet.UWP.Controls.BUILDLet_WUP_Controls_XamlTypeInfo*, which is automatically generated, is manually removed from **Namespace Summaries** of **SHFB project** (*BUILDLet.UWP.Controls.Documentation*).

- XML manufest of this Nuget Package (*BUILDLet.UWP.Controls.nuspec*) is manually updated.

License
-------

This project is licensed under the [MIT](https://opensource.org/licenses/MIT) License.
