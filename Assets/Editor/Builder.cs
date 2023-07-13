// https://docs.unity.com/embeddedlinux/en/manual/how-to-build-using-cli#Build_script
// https://fadhilnoer.medium.com/automating-unity-builds-part-1-ba0c60e8d06b
// https://docs.unity3d.com/ScriptReference/BuildPipeline.BuildPlayer.html
using UnityEditor;
using UnityEditor.Build.Reporting;
using UnityEngine;

public class Builder
{
    [MenuItem("Build/Build Android")]
    public static void BuildAndroid() {
        BuildProject("../", "Android");
    }

    [MenuItem("Build/Build iOS")]
    public static void BuildIos() {
        BuildProject("../", "iOS");
    }

    public static void BuildProject(string path, BuildTarget buildTarget)
    {
        var options = new BuildPlayerOptions
        {
            scenes = ActiveScenePaths.ToArray(), 
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