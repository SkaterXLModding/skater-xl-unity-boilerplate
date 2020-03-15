using System;
using System.IO;
using UnityEngine;
using UnityEditor;

// using NativeFileBrowser;

public class EditorTools
{
    // Build Asset Bundles
    [MenuItem("SkaterXL/AssetBundles/Build AssetBundles")]
    static void BuildAssetBundles()
    {
        string bundleDirectory = "Assets/AssetBundles";
        if (!Directory.Exists(bundleDirectory))
        {
            Directory.CreateDirectory(bundleDirectory);
        }

        BuildPipeline.BuildAssetBundles(bundleDirectory, BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows);
    }

    // Capture screenshot for sharing
    [MenuItem("SkaterXL/Take Screenshot")]
    static void CaptureScreengrab()
    {
        // string path = FileBrowser.SaveFilePanel("Save Screenshot", "", "", ".png");
		string path = EditorUtility.SaveFilePanel("Save Screenshot", "", "", ".png");
		Debug.Log(path);

        if (!string.IsNullOrEmpty(path))
        {
            UnityEngine.ScreenCapture.CaptureScreenshot(path);
        }
    }
}
