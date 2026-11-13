using UnityEditor;
using UnityEngine;
public static class ApexAndroidBuild {
 public static void Build() {
  ApexSceneBuilder.Generate();
  System.IO.Directory.CreateDirectory("Build");
  PlayerSettings.productName="Los Santos Apex V";
  PlayerSettings.companyName="GameX";
  PlayerSettings.SetApplicationIdentifier(BuildTargetGroup.Android,"com.gamex.lossantosapexv");
  var options=new BuildPlayerOptions {
   scenes=new[]{"Assets/Scenes/ApexCity.unity"},
   locationPathName="Build/LosSantosApexV.apk",
   target=BuildTarget.Android,
   options=BuildOptions.None
  };
  var result=BuildPipeline.BuildPlayer(options);
  if(result.summary.result!=UnityEditor.Build.Reporting.BuildResult.Succeeded)
   throw new System.Exception("Android APK build failed: "+result.summary.result);
 }
}