# Clippy [![Build status](https://ci.appveyor.com/api/projects/status/2f5bhe5r3fuo1pfg/branch/master?svg=true)](https://ci.appveyor.com/project/jquintus/clippy/branch/master) [![NuGet version](https://badge.fury.io/nu/MasterDevs.Clippy.svg)](https://www.nuget.org/packages/MasterDevs.Clippy/)

Treat the clipboard like a TextReader and TextWriter

# Installation

    PM> Install-Package MasterDevs.Clippy

# Usage
We use `System.Windows.Clipboard` to read and write to the clipboard.
Since this is an OLE object it needs to be accessed from a STAThread.
If you are in a WPF application, you shouldn't need to worry about this.
If you are in a console application, you will need to make sure that you are using a STAThread.
The easiest way is to decorate your startup method with the `STAThreadAttribute` like so:

    [STAThread]
    private static int Main(string[] args)
    {
        // ...
    }

## Reading from the clipboard
To read from the clipboard, simply create a new `ClipboardReader`

    using (var clippy = new ClipboardReader())
	{
		var clipboardText = clippy.ReadToEnd();
	}

## Writing to the clipboard
To write to the clipboard, simply create a `ClipboardWriter`

    using (var clippy = new ClipboardWriter())
	{
		clippy.Write("Hello World");
	}
