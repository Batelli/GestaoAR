using System;
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

        EditorGUILayout.BeginVertical();
        EditorGUILayout.LabelField("", GUI.skin.horizontalSlider);
        audinQuestion.subject = (AUDIN_Subject)EditorGUILayout.EnumPopup("Subject", audinQuestion.subject);
        EditorGUILayout.LabelField("", GUI.skin.horizontalSlider);


        for (int i = 0; i < audinQuestion.answers.Count; i++)
        {
            audinQuestion.answers[i] = (string)EditorGUILayout.TextField("Answer", audinQuestion.answers[i]);
            EditorGUILayout.BeginHorizontal();
            audinQuestion.answersKeys[i] = EditorGUILayout.Toggle("Answer Key", audinQuestion.answersKeys[i]);

            //Remove Button
            if (GUILayout.Button("Remove"))
            {
                audinQuestion.answers.RemoveAt(i);
                audinQuestion.answersKeys.RemoveAt(i);
            }

            EditorGUILayout.EndHorizontal();
            EditorGUILayout.LabelField("", GUI.skin.horizontalSlider);
        }

        if (GUILayout.Button("Add New Question"))
        {
            audinQuestion.answers.Add("");
            audinQuestion.answersKeys.Add(true);
        }

        EditorGUILayout.EndVertical();
    }

}
