using Game_Scripts;
using Scriptable_Objects.Code;
using UnityEditor;
using UnityEngine;

namespace Editor
{
    [CustomEditor(typeof(Spawner))]
    public class AsteroidEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            //base.OnInspectorGUI();

            Spawner spawner = (Spawner)target;
            
            GUILayout.BeginHorizontal();
                spawner.spawnData.asteroidMaxAmountEnabled = GUILayout.Toggle(spawner.spawnData.asteroidMaxAmountEnabled, "Asteroid Limit", GUILayout.Width(110));
                spawner.spawnData.asteroidMaxAmount = EditorGUILayout.IntField(spawner.spawnData.asteroidMaxAmount);
            GUILayout.EndHorizontal();
            
            GUILayout.BeginHorizontal();
                GUILayout.Label("Score Value: ", GUILayout.Width(110));
                spawner.spawnData.asteroidScoreValue = EditorGUILayout.IntField((int)spawner.spawnData.asteroidScoreValue);
            GUILayout.EndHorizontal();
            
            GUILayout.BeginHorizontal();
                GUILayout.Label("Asteroid Speed: ", GUILayout.Width(110));
                spawner.spawnData.asteroidSpeed = EditorGUILayout.FloatField(spawner.spawnData.asteroidSpeed);
            GUILayout.EndHorizontal();
                
            GUILayout.BeginHorizontal();
                GUILayout.Label("Firing Angle: ", GUILayout.Width(110));
                spawner.spawnData.asteroidFiringAngle = EditorGUILayout.FloatField(spawner.spawnData.asteroidFiringAngle);
            GUILayout.EndHorizontal();
            
            GUILayout.BeginHorizontal();
                GUILayout.Label("Spawn Rate: ", GUILayout.Width(110));
                spawner.spawnData.asteroidSpawnRate = EditorGUILayout.FloatField(spawner.spawnData.asteroidSpawnRate);
            GUILayout.EndHorizontal();
            
            GUILayout.BeginHorizontal();
                GUILayout.Label("Spawn Distance: ", GUILayout.Width(110));
                spawner.spawnData.asteroidSpawnDistance = EditorGUILayout.FloatField(spawner.spawnData.asteroidSpawnDistance);
            GUILayout.EndHorizontal();
            
            GUILayout.BeginHorizontal();
                GUILayout.Label("Base Mass: ", GUILayout.Width(110));
                spawner.spawnData.asteroidMass = EditorGUILayout.FloatField(spawner.spawnData.asteroidMass);
            GUILayout.EndHorizontal();
            
            GUILayout.BeginHorizontal();
                GUILayout.Label("Mass Multiplier", GUILayout.Width(110));
            GUILayout.EndHorizontal();
            
            GUILayout.BeginHorizontal();
                GUILayout.Label("Minimum: ", GUILayout.Width(60));
                spawner.spawnData.asteroidMassMultiplierMinimum = EditorGUILayout.FloatField(spawner.spawnData.asteroidMassMultiplierMinimum, GUILayout.Width(100));
                GUILayout.Label("Maximum: ", GUILayout.Width(60));
                spawner.spawnData.asteroidMassMultiplierMaximum = EditorGUILayout.FloatField(spawner.spawnData.asteroidMassMultiplierMaximum, GUILayout.Width(100));
            GUILayout.EndHorizontal();
        }
    }
}