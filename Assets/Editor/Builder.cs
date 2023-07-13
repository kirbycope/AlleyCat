//https://docs.unity.com/embeddedlinux/en/manual/how-to-build-using-cli#Build_script
using UnityEditor;
using UnityEditor.Build.Reporting;
using UnityEngine;

// https://fadhilnoer.medium.com/automating-unity-builds-part-1-ba0c60e8d06b
public class Builder
{
    public static void BuildProject(string path, BuildTarget buildTarget)
    {
        var options = new BuildPlayerOptions
        {
            scenes = ActiveScenePaths.ToArray(), 
            target = buildTarget, 
            locationPathName = path,
        };

        BuildPipeline.BuildPlayer(options);
    }
}