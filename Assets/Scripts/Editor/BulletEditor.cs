using Scriptable_Objects.Code;
using UnityEditor;

namespace Editor
{
    [CustomEditor(typeof(BulletData))]
    public class BulletEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
        }
    }
}