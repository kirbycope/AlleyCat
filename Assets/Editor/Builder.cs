using UnityEditor;
using UnityEditor.Build.Reporting;
using UnityEngine;

public class Builder
{
    [MenuItem("Build/Build Android")]
    public static void BuildAndroid() {
        BuildProject("Android/alleycat.apk", BuildTarget.Android);
    }

    [MenuItem("Build/Build iOS")]
    public static void BuildIos() {
        BuildProject("iOS/alleycat.ipa", BuildTarget.iOS);
    }

    [MenuItem("Build/Build WebGL")]
    public static void BuildWebgl() {
        BuildProject("WebGL", BuildTarget.WebGL);
    }

    public static void BuildProject(string path, BuildTarget buildTarget)
    {
        var options = new BuildPlayerOptions
        {
            // Change to scenes from your project
            scenes = new[]
            {
                "Assets/Scenes/SampleScene.unity",
                "Assets/Scenes/Sandbox.unity",
                "Assets/Scenes/Alley.unity",
            },
            target = buildTarget, 
            locationPathName = path,
        };
        BuildReport report = BuildPipeline.BuildPlayer(options);
        BuildSummary summary = report.summary;
        if (summary.result == BuildResult.Succeeded)
        {
            Debug.Log("Build succeeded: " + summary.totalSize + " bytes");
        }
        if (summary.result == BuildResult.Failed)
        {
            Debug.Log("Build failed");
        }
    }
}