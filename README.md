﻿# MaltReport

[![NuGet Stats](https://img.shields.io/nuget/v/MaltReport2.svg)](https://www.nuget.org/packages/MaltReport2) 
[![Build status](https://ci.appveyor.com/api/projects/status/w9rc2jbb6v4o4jgk/branch/master?svg=true)](https://ci.appveyor.com/project/oldrev/maltreport/branch/master)

MaltReport is an OpenDocument/OfficeOpenXML powered reporting engine for .NET and Mono, 
it is inspired by the excellent [Relatorio Project](http://relatorio.openhex.org/).

There is a briefly introduction in Chinese: [MaltReport2 中文使用简介](http://www.cnblogs.com/oldrev/p/maltreport2_intro.html)

MaltReport DO NOT REQUIRES MS-Office or LibreOffice to generate document. 
Instead MaltReport manipulates ODT/ODS/XLS/DOC file by itself, so it could be fast & reliable.


The template of your report is just a normal document created with LibreOffice or MS-Word/MS-Excel (ODT/ODS and XLS/DOC are fully supported), 
we can use LibreOffice and MS-Word/Excel as WYSIWYG report development tools.

I do not have too much time working with the document, so to learn the usage of MaltReport please see the Sandwych.Reporting.Demo project.


## Getting Started

### Prerequisites

* Visual Studio 2015: This project is written in C# 5.0 using Microsoft Visual Studio 2015 Community Edition.

### Supported Platform

* .NET Framework 4.6.1
* .NET Standard 2.0

### Installation

MaltReport can be installed from [NuGet](https://www.nuget.org/packages/MaltReport2) or type following commands in the NuGet Console:

```
PM> Install-Package MaltReport2
```

## Demo & Usage:

### Step 1: Organize your data into Context

```csharp
TODO
```

### Step 2: Render your template

```csharp
TODO
```

## License

MaltReport is licensed in the MIT license.

Author: Wei "oldrev" Li <oldrev@gmail.com>

* Copyright (C) 2009 Wei "oldrev" Li
* Copyright (C) 2010-2016 Sandwych Consulting LLC.
* Copyright (C) 2017-TODAY Binary Stars Technologies LLC. & Contributors
