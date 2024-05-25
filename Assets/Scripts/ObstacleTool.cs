
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
using System.Linq;
using System.Collections.Generic;
using System;
public class ObstacleTool : EditorWindow
{

    public List<String> obstructed = new List<string>();

    [MenuItem("Window/Obstacle Tool")]
    public static void ShowWindow()
    {
        GetWindow<ObstacleTool>("Obstacle Tool");
    }

    private void OnGUI()
    {
        GUILayout.Label("Grid", EditorStyles.label);
        for(int x = 0; x < 10; x++){
            GUILayout.BeginHorizontal();
            for(int y = 0; y < 10; y++){
            GUILayout.BeginVertical();
            if(GUILayout.Toggle(false,$"{x},{y}","button")){
                obstructed.Add($"{x},{y}");
                
            }
            
            GUILayout.EndVertical();
            }
                    GUILayout.EndHorizontal();
        }

    }

    public void Update(){
        foreach(var name in obstructed){
        var cube = GameObject.Find("/name");
        }
    }
}
