using Scriptable_Objects.Code;
using UnityEditor;

namespace Editor
{
    [CustomEditor(typeof(AsteroidData))]
    public class AsteroidEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
        }
    }
}