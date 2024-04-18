using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(AudinQuestion))]
public class AudinQuestionEditor : Editor
{
    AudinQuestion audinQuestion;

    public override void OnInspectorGUI()
    {
        audinQuestion = (AudinQuestion)target;
        EditorUtility.SetDirty(target);

        DrawDefaultInspector();

    }

}
