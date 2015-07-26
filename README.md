# Clippy [![Build status](https://ci.appveyor.com/api/projects/status/2f5bhe5r3fuo1pfg/branch/master?svg=true)](https://ci.appveyor.com/project/jquintus/clippy/branch/master) [![NuGet version](https://badge.fury.io/nu/MasterDevs.Clippy.svg)](https://www.nuget.org/packages/MasterDevs.Clippy/)

Treat the clipboard like a TextReader

# Usage
To read from the clipboard, simply create a new ClipboardReader

    using (var clippy = new ClipboardReader())
	{
		var clipboard = clippy.ReadToEnd();
	}

