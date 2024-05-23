using System;
using System.IO;

using UnityEditor;
using UnityEditor.Callbacks;

public class BuildScript
{
    [PostProcessBuild]
    public static void OnPostprocessBuild(BuildTarget target, string pathToBuiltProject)
    {
        string buildName = Path.GetFileNameWithoutExtension(pathToBuiltProject);
        string buildPath = Path.GetDirectoryName(pathToBuiltProject);
        buildPath = Path.Combine(buildPath, buildName + "_Data", "StreamingAssets");

        string buildInfo = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"); // "o" für ISO

        File.WriteAllText(Path.Combine(buildPath, "BuildInfo.txt"), buildInfo);
    }
}
