using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

[CustomEditor(typeof(gridManager))]
public class gridEditor : Editor
{
    public override void OnInspectorGUI()
    {
        //Called whenever the inspector is drawn for this object.
        DrawDefaultInspector();

      gridManager gridConnard = (gridManager) target;

        if (GUILayout.Button("build my grid"))
        {
            gridConnard.GenerateGrid ();
        }
        //add everthing the button would do.
    }
}
 // donc le griConnard est la "target" du gridManager 