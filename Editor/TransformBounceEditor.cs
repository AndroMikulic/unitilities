using UnityEditor;

namespace Unitilities
{
    [CustomEditor(typeof(TransformBounce))]
    public class TransformBounceEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            EditorGUILayout.HelpBox(
                "Bounces the transfrom (ping-pong) from it's current position to the target position.",
                MessageType.Info);

            DrawDefaultInspector();
        }
    }
}