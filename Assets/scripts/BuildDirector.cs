using UnityEditor;
using System.Collections;

public class BuildDirector {

    static void PerformBuild()
    {
        string localPath = "";
        string[] scenes = { "Assets/main.unity" };
        BuildPipeline.BuildPlayer(scenes,localPath,BuildTarget.StandaloneWindows,BuildOptions.None);
    }


}
