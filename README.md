ReSharper Live Templates Macros
===============================

Important
---------

This is an update to support ReSharper 2022.3 or later of my previous [ReSharperExtensions](https://github.com/joaroyen/ReSharperExtensions) project for ReSharper 8.2 and earlier. Due to changes in distribution of ReSharper platform, I've created a new and simpler project going forward. The name of the macros are the same, and your current templates should work.

What this project contains
--------------------------

This project contains Live Templates and macros for [JetBrains ReSharper](http://www.jetbrains.com/resharper/). The following macros are available:

* **ValidIdentifierMacro**: Replaces invalid identifier characters with underscores as you type
* **CapitalizedWordsIdentifierMacro**: Same as ValidIdentifierMacro but capitalizes the first letter in each word 
* **DomainAndUsernameMacro**: Returns your domain and username in the form of Domain\Username

The Live Template Example contains one template with the **mstm** shortcut (MicroSoft Test Method).It allows
you to write test method names as sentences with spaces, and the macro will replace the spaces with underscores as you
type. It also allows you to select an MSTest category and assigns the current user as the owner of the test in a format
compatible with TFS.

There may be an issue accessing this macro directly, but you will probably want to modify this yourself anyways. You can copy this template to your own configuration using the "ReSharper -> Manage Options..." menu.

See [http://www.joaroyen.com/2010/08/resharpers-live-templates-can-do.html](http://www.joaroyen.com/2010/08/resharpers-live-templates-can-do.html) for more information.

Installation instructions
-------------------------

* Open ReSharper -> Extension manager
* Search for JoarOyen
* Select "JoarOyen.ReSharper.LiveTemplates"


Remarks
-------

* Main is updated to support ReSharper 2022.3 or later. JetBrains have added plugin migration to ReSharper 2023.1 and updates to existing plugins are only required to support breaking API changes in ReSharper.
* Support .NET Framework 4.7.2. 
* Support for previous versions are available from separate branches for the respective ReSharper platform wave.
* The test project is using NUnit from ReSharper SDK, but uses NuGet for NSubstitute.
