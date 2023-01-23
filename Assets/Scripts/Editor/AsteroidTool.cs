using System;
using Scriptable_Objects.Code;
using UnityEditor;

namespace Editor
{
    public class AsteroidTool : EditorWindow
    {
        [MenuItem("Tools/Asteroid")]
        public static void OpenAsteroid() => GetWindow<AsteroidTool>();

        private void OnEnable() => SceneView.duringSceneGui += DuringSceneGUI;
        private void OnDisable() => SceneView.duringSceneGui -= DuringSceneGUI;

        private ShipEditor _shipEditor;
        private AsteroidEditor _asteroidEditor;
        private BulletEditor _bulletEditor;

        void DuringSceneGUI(SceneView sceneView) {
            
        }
    }
}