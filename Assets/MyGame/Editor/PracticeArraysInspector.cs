using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(PracticeArrays))]
public class PracticeArraysInspector : Editor
{
    public override void OnInspectorGUI()
    {
        PracticeArrays practiceArrays = (PracticeArrays)target;

        if (GUILayout.Button("Execute"))
        {
            practiceArrays.Start();
        }

        base.OnInspectorGUI();
    }
}
