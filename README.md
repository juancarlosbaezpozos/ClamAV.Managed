# Managed Bindings for ClamAV

## License Information

This project is licensed under the terms of the GNU General Public License,
version 2. You can find a full copy of the license text in GPLv2.txt.

## Notices

This program is distributed in the hope that it will be useful, but WITHOUT 
ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS 
FOR A PARTICULAR PURPOSE.

While the public version of this library is still in early development, the
type names and class interfaces are subject to change.

## Prerequisites

To use ClamAV.Managed, P/Invoke must be able to locate libclamav, either in 
your binary's execution directory or at some location in your system's library
search path.

You can obtain ClamAV binaries compiled for Windows at
http://oss.netfarm.it/clamav/. At the moment, only the Win32 version is
supported, but the Win64 version may work.

ClamAV.Managed should also work under Mono on Linux or Mac OS X, although this 
is not yet a supported configuration.

For file scanning to work, you need to download ClamAV databases from 
http://www.clamav.net, either to a folder named `db` in your application's 
working directory, or an arbitrary location specified in your program.

## Getting Started

### ClamAV.Managed Library

To get started using ClamAV.Managed in your project, you need to add a 
reference to ClamAV.Managed.dll.

libclamav must be either in your application's binary directory, or some other 
system path where it may be located. It is recommended that you bundle 
libclamav with your application, in compliance with the GNU GPL.

You need to obtain ClamAV databases. By default, ClamAV looks for databases in 
a folder called `db` in the current working directory. You can specify an 
arbitrary location from which to load virus databases as an argument to the 
ClamEngine.LoadDatabase method.

You can find a list of ClamAV database mirrors at
http://www.clamav.net/mirrors.html. Databases will be named main.cvd, daily.cvd,
bytecode.cvd, safebrowsing.cvd in the root directory of the mirror. More
information about obtaining ClamAV databases can be found on the ClamAV website.

### ClamAV.Managed.PowerShell Cmdlets

To use the cmdlets provided by ClamAV.Managed.PowerShell, use the `New-ClamEngine`
cmdlet.

1. Use `Import-Module` to load the ClamAV.Managed.PowerShell library. Assume
   we have created a directory C:\ClamAV-Managed\, containing ClamAV.Managed.dll,
   ClamAV.Managed.PowerShell.dll, libclamav.dll and a subdirectory containing
   definitions datases called `db`. We're now ready to proceed.
   ```Import-Module C:\ClamAV-Managed\ClamAV.Managed.PowerShell.dll```
2. Create an instance of the ClamAV engine.
   ```PS C:\> $eng = New-ClamEngine -WithDatabase C:\ClamAV-Managed\db```
3. If you didn't provide a `-WithDatabase` parameter to `New-ClamEngine`, use
   `Import-ClamDatabase` to load a definitions database.
   ```PS C:\> Import-ClamDatabase -Engine $eng -Path C:\ClamAV-Managed\db```
4. To scan a file:
   ```PS C:\> Invoke-ClamScanFile -Engine $eng -Path C:\File.exe```
5. To scan a directory:
   ```PS C:\> Invoke-ClamScanDirectory -Engine $eng -Path C:\Directory\```

`Import-ClamDatabase` will, by default, look for databases in the `db` subdirectory
of the directory containing the ClamAV.Managed.PowerShell dynamic library.
However, you may specify a path manually with the `-DatabasePath` parameter.

## Samples

Refer to the project ClamAV.Managed.Samples.Gui to see an example of
ClamAV.Managed in action. To run the sample, you need to obtain libclamav, as 
described above, and download virus databases to a folder named `db` in the 
binary directory.
