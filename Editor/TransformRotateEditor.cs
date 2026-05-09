using Unitilities;
using UnityEditor;

namespace Unitilities
{
    [CustomEditor(typeof(TransformRotate))]
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