using Game_Scripts;
using Scriptable_Objects.Code;
using UnityEditor;
using UnityEngine;

namespace Editor
{
    [CustomEditor(typeof(Bullet))]
    public class BulletEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            Bullet bullet = (Bullet)target;
            GUILayout.BeginHorizontal();
                GUILayout.Label("Bullet Speed: ", GUILayout.Width(100));
                bullet.bulletData.bulletSpeed = EditorGUILayout.FloatField(bullet.bulletData.bulletSpeed);
            GUILayout.EndHorizontal();
            
            GUILayout.BeginHorizontal();
                GUILayout.Label("Bullet Penetration: ", GUILayout.Width(100));
                bullet.bulletData.bulletHealth = EditorGUILayout.IntSlider(bullet.bulletData.bulletHealth, 1, 10);
            GUILayout.EndHorizontal();
        }
    }
}