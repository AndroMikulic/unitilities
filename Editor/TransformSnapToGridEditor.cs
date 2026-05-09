using UnityEditor;

namespace Unitilities
{
    [CustomEditor(typeof(TransformSnapToGrid))]
    [CanEditMultipleObjects]
    public class TransformSnapToGridEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            EditorGUILayout.HelpBox(
                "Snaps the object to the coordinate grid. Does so in LATE UPDATE!.",
                MessageType.Info);

            DrawDefaultInspector();
        }
    }
}