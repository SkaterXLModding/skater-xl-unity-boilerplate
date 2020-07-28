using System;
using System.IO;
using UnityEngine;
using UnityEditor;

// using NativeFileBrowser;

public class EditorTools
{
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