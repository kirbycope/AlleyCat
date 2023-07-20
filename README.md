![Screenshot](/alley-cat.png)
# Alley Cat
> Alley Cat is a video game created by Bill Williams and published by Synapse Software for the Atari 8-bit family in 1983. - [Source](https://en.wikipedia.org/wiki/Alley_Cat_(video_game))

## Getting Started
1. Clone [this](/) repo
1. Open Unity Hub
1. Install the version is stored in [/ProjectSettings/ProjectVersion.txt](/ProjectSettings/ProjectVersion.txt)
    - Ensure the Android, iOS, and WebGL build modules are also installed

## Build Android

### Android [Dev] Using Unity IDE (Built-in)
1. Open Unity
1. In the top menu, select "File" > "Build Settings"
1. Ensure all desired scenes are in "Scenes to Build"
1. Select "Android"
1. Select "Switch Target"
1. [One Time Setup] Select "Player Settings" button
    - Under "Player > Other Settings", select "ARM64"
1. Select "Build" and enter the file name for the output file

### Android [Dev] Using Unity IDE (Custom MenuItem)
1. Open Unity
1. In the top menu, select "Build" > "Build Android"
    - These methods are stored in [/Assets/Editor/Builder.cs](/Assets/Editor/Builder.cs)
    - The output is saved as `/Android/alleycat.apk`

### Android [Dev] Using Command-line
1. Change directory to the root of the repo
1. Run the following command (updating the Unity Version if needed)
    - OSX: `/Applications/Unity/Hub/Editor/2022.3.4f1/Unity.app/Contents/MacOS/Unity -batchmode -nographics -stackTraceLogType Full -quit -logFile build-Android.log -projectPath / -buildTarget Android`
    - Windows: `C:\Program Files\Unity\Hub\Editor\2022.3.4f1\Editor\Unity.exe -batchmode -nographics -stackTraceLogType Full -quit -logFile build-Android.log -projectPath \ -buildTarget Android`

### Android [Dev] Using GitHub Actions
1. Navigate to [Actions](https://github.com/kirbycope/AlleyCat/actions)
1. Select "GameCI Android"
1. Select "Run workflow"

## Build iOS

### Android [Dev] Using Unity IDE (Built-in)
1. Open Unity
1. In the top menu, select "File" > "Build Settings"
1. Ensure all desired scenes are in "Scenes to Build"
1. Select "iOS"
1. Select "Switch Target"
1. Select "Build" and enter the file name for the output file

### iOS [Dev] Using Unity IDE (Custom MenuItem)
1. Open Unity
1. In the top menu, select "Build" > "Build iOS"
    - These methods are stored in [/Assets/Editor/Builder.cs](/Assets/Editor/Builder.cs)
    - The output is saved as `/iOS/alleycat.ipa`

### iOS [Dev] Using Command-line
1. Change directory to the root of the repo
1. Run the following command (updating the Unity Version if needed)
    - OSX: `/Applications/Unity/Hub/Editor/2022.3.4f1/Unity.app/Contents/MacOS/Unity -batchmode -nographics -stackTraceLogType Full -quit -logFile build-iOS.log -projectPath / -buildTarget iOS`
    - Windows: `C:\Program Files\Unity\Hub\Editor\2022.3.4f1\Editor\Unity.exe -batchmode -nographics -stackTraceLogType Full -quit -logFile build-iOS.log -projectPath \ -buildTarget iOS`

### iOS [Dev] Using GitHub Actions
1. Navigate to [Actions](https://github.com/kirbycope/AlleyCat/actions)
1. Select "GameCI iOS"
1. Select "Run workflow"

## Build WebGL

### WebGL [Dev] Using Unity IDE (Built-in)
1. Open Unity
1. In the top menu, select "File" > "Build Settings"
1. Ensure all desired scenes are in "Scenes to Build"
1. Select "WebGL"
1. Select "Switch Target"
1. [One Time Setup] Select "Player Settings" button
    - Under "Publishing Settings" > "Compression Format", select "Disabled"
        - This is to work with GitHub Pages (below)
1. Select "Build" and enter the name for the output directory

### WebGL [Dev] Using Unity IDE (Custom MenuItem)
1. Open Unity
1. In the top menu, select "Build" > "Build WebGL"
    - These methods are stored in [/Assets/Editor/Builder.cs](/Assets/Editor/Builder.cs)
    - The output is saved in `/WebGL`

### WebGL [Dev] Using Command-line
1. Change directory to the root of the repo
1. Run the following command (updating the Unity Version if needed)
    - OSX: `/Applications/Unity/Hub/Editor/2022.3.4f1/Unity.app/Contents/MacOS/Unity -batchmode -nographics -stackTraceLogType Full -quit -logFile build-WebGL.log -projectPath / -buildTarget WebGL`
    - Windows: `C:\Program Files\Unity\Hub\Editor\2022.3.4f1\Editor\Unity.exe -batchmode -nographics -stackTraceLogType Full -quit -logFile build-WebGL.log -projectPath \ -buildTarget WebGL`

### WebGL [Dev] Using GitHub Actions
1. Navigate to [Actions](https://github.com/kirbycope/AlleyCat/actions)
1. Select "GameCI WebGL"
1. Select "Run workflow"

## Deploy WebGL
1. Delete the contents of the [docs](/docs) directory
1. From the build artifact, copy the `index.html`, `/Build`, and `/TemplateData` to the `/docs` directory
1. Commit and push the changes
1. The built-in [GitHub Pages Action](https://github.com/kirbycope/AlleyCat/actions/workflows/pages/pages-build-deployment) will update the page
    - This was setup by going to "Settings" > "Pages" and pointing it to the `/docs` repo
