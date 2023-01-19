using Scriptable_Objects.Code;
using UnityEditor;

namespace Editor
{
    [CustomEditor(typeof(ShipData))]
    public class ShipEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
        }
    }
}