# skiasharp-repro
 
When using SkiaSharp.Views.WindowsForms, one cannot create SkiaSharp classes (in this case, SKFont) within the constructor without breaking Visual Studio's design mode.

1) Clone repository.
2) Open SkiaSharpRepro.sln in Visual Studio 2022.
3) Right click SkiaSharpReproLib -> Pack.
4) Move generated .nupkg to a local NuGet package source.
5) Right click WindowsFormsApp1 -> Manage NuGet Packages...
6) Install the SkiaSharpReproLib package from the local package source.
7) Drag and drop SkiaSharpReproLib/MyCustomControl from the toolbox onto Form1.

An exception occurs:
```
Failed to create component 'MyCustomControl'.  The error message follows:
'System.DllNotFoundException: Unable to load library 'libSkiaSharp'.
...'
```