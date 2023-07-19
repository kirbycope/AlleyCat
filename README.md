![Screenshot](/alley-cat.png)
# AlleyCat

## Getting Started
1. Clone [this](/) repo
1. Open Unity Hub
1. Install the version is stored in [/ProjectSettings/ProjectVersion.txt](/ProjectSettings/ProjectVersion.txt)
    - Ensure the Android and iOS build modules are also installed

## Building the Game

### Android [Dev] Using Unity IDE (Built-in)
1. Open Unity
1. In the top menu, select "File" > "Build Settings"
1. Ensure all desired scenes are in "Scenes to Build"
1. [One Time Setup] Select "Player Settings" button
    - Under "Player > Other Settings", select "ARM64"
1. Select "Build" and enter the file name for the output file

### Android [Dev] Using Unity IDE (Custom MenuItem)
1. Open Unity
1. In the top menu, select "Build" > "Build Android"
    - These methods are stored in [/Assets/Editor/Builder.cs](/Assets/Editor/Builder.cs)
    - The output is saved as `Android/alleycat.apk`

### Android [Dev] Using Command-line
1. Change directory to the root of the repo
1. Run the following command (updating the Unity Version if needed)
    - OSX: `/Applications/Unity/Hub/Editor/2022.3.4f1/Unity.app/Contents/MacOS/Unity -batchmode -nographics -stackTraceLogType Full -quit -logFile build-Android.log -projectPath / -buildTarget Android`
    - Windows: `C:\Program Files\Unity\Hub\Editor\2022.3.4f1\Editor\Unity.exe -batchmode -nographics -stackTraceLogType Full -quit -logFile build-Android.log -projectPath \ -buildTarget Android`

### iOS [Dev] Using Unity IDE (Custom MenuItem)
1. Open Unity
1. In the top menu, select "Build" > "Build iOS"
    - These methods are stored in [/Assets/Editor/Builder.cs](/Assets/Editor/Builder.cs)
    - The output is saved as `iOS/alleycat.ipa`

### iOS [Dev] Using Command-line
1. Change directory to the root of the repo
1. Run the following command (updating the Unity Version if needed)
    - OSX: `/Applications/Unity/Hub/Editor/2022.3.4f1/Unity.app/Contents/MacOS/Unity -batchmode -nographics -stackTraceLogType Full -quit -logFile build-iOS.log -projectPath / -buildTarget iOS`
    - Windows: `C:\Program Files\Unity\Hub\Editor\2022.3.4f1\Editor\Unity.exe -batchmode -nographics -stackTraceLogType Full -quit -logFile build-iOS.log -projectPath \ -buildTarget iOS`
