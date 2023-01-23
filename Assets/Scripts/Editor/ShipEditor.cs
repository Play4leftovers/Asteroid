using Game_Scripts;
using Scriptable_Objects.Code;
using UnityEditor;
using UnityEngine;

namespace Editor
{
    [CustomEditor(typeof(Ship))]
    public class ShipEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            //base.OnInspectorGUI();
            Ship ship = (Ship)target;
            
            GUILayout.BeginHorizontal();
                GUILayout.Label("Starting Health: ", GUILayout.Width(100));
                ship.shipData.shipStartingHealth = EditorGUILayout.IntField(ship.shipData.shipStartingHealth);
            GUILayout.EndHorizontal();
            
            GUILayout.BeginHorizontal();
                GUILayout.Label("Thrust Force: ", GUILayout.Width(100));
                ship.shipData.shipThrustForce = EditorGUILayout.FloatField(ship.shipData.shipThrustForce);
            GUILayout.EndHorizontal();
            
            GUILayout.BeginHorizontal();
                GUILayout.Label("Rotation Force: ", GUILayout.Width(100));
                ship.shipData.shipRotationForce = EditorGUILayout.FloatField(ship.shipData.shipRotationForce);
            GUILayout.EndHorizontal();
        }
    }
}