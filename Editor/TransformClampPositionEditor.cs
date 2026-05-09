using UnityEditor;

namespace Unitilities
{
    [CustomEditor(typeof(TransformClampPosition))]
    [CanEditMultipleObjects]
    public class TransformClampPositionEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            EditorGUILayout.HelpBox(
                "Clamps the object's position within min and max bounds.",
                MessageType.Info);

            DrawDefaultInspector();
        }
    }
}