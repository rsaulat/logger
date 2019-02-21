This project is to demostrate different types of installers that can be created using Visual Studio.

Here are the components of the solution

1. Logger project 
- Is the core package that is used to log datetime information in c:\ProgramData folder
- Logger when compiled gives a .dll
- Logger component has a start and stop methods. when start is called, it starts logging the current date and time into a file in c:\ProgramData folder every 1 second

2. LoggerWindowsApp 
- Is a windows app through which you call Logger (.dll) to log data
- Windows App when compiles give a .exe file
- Windows app has a Start and a Stop button to start and stop the logging
- When the start button is clicked logging starts in c:\ProgramData\BMCLog.txt file until you stop it
- Additionally when windows app is minimized, it becomes a tray icon. Clicking the tray icon restores the windows app. The app continues to run in the background when minimized

3. LoggerWindowsService
- Is a windows service though which you call Logger (.dll) to log data
- When compiled it gives two outputs one is a .exe as output -- this is how a windows service is in Windows
- When the windows service is started it starts logging in c:\ProgramData\BMCLog.txt file until you stop the service manually.

Now there are three Installers to install these apps

4. ExeInstaller
- Installs LoggerWindowsApp as a Windows application on your computer.
- creates a desktop shortcut
- The application is installed in c:\Program files(x86)\BMC folder
- App can be installed by simply going to Add / Remove programs -> search for ExeInstaller and uninstall

5. WinServiceInstaller
- This installs the LoggerWindowsService as a Windows service on your computer
- The application files are installed in c:\Program files(x86)\BMC folder
- The windows service runs under Local System account, is setup to start automatically however you need to start it manually the first time
- The name of the windows service is BMCWindowsService and can be located in the services list 

6. APIPackageInstaller
- This install 'Logger' DLL in c:\Program files(x86)\BMC which can then be used by other programs

The three installer can be clubbed into one installer but that may increase the complexity of the installer package.

