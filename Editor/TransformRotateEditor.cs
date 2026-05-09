using UnityEditor;

namespace Unitilities
{
    [CustomEditor(typeof(TransformRotate))]
    [CanEditMultipleObjects]
    public class TransformRotateEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            EditorGUILayout.HelpBox(
                "Rotates the attached Transform over time.",
                MessageType.Info);

            DrawDefaultInspector();
        }
    }
}