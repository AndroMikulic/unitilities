using Unitilities;
using UnityEditor;

namespace Unitilities
{
    [CustomEditor(typeof(TransformDetector))]
    public class TransformDetectorEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            EditorGUILayout.HelpBox(
                "Invokes a Unity event when the attached Transform moves, rotates or scales.",
                MessageType.Info);

            DrawDefaultInspector();
        }
    }
}