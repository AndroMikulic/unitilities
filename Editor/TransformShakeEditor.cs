using UnityEditor;

namespace Unitilities
{
    [CustomEditor(typeof(TransformShake))]
    [CanEditMultipleObjects]
    public class TransformShakeEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            EditorGUILayout.HelpBox(
                "Shakes the object.",
                MessageType.Info);

            DrawDefaultInspector();
        }
    }
}