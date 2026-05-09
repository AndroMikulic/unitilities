using UnityEditor;

namespace Unitilities
{
    [CustomEditor(typeof(TransformClampScale))]
    [CanEditMultipleObjects]
    public class TransformClampScaleEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            EditorGUILayout.HelpBox(
                "Clamps the object's scale within min and max bounds. Processed in LateUpdate().",
                MessageType.Info);

            DrawDefaultInspector();
        }
    }
}