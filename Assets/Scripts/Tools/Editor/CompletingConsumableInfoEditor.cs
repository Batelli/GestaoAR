using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(CompletingConsumableInfo))]
public class CompletingConsumableInfoEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        CompletingConsumableInfo myScript = (CompletingConsumableInfo)target;

        


        /*
        if (GUILayout.Button("Rename"))
        {
            for (int i = 0; i < myScript.targets.Length; i++)
            {
                string path = AssetDatabase.GetAssetPath(myScript.targets[i]);
                AssetDatabase.RenameAsset(path, "C1" + (myScript.startIndex + i).ToString("000"));
            }
        }
        */

        if (GUILayout.Button("Load Data"))
        {
            myScript.StartCoroutine(myScript.LoadDurables());
        }
    }
}
