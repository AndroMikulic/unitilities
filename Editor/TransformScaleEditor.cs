using Unitilities;
using UnityEditor;
namespace Unitilities
{
    [CustomEditor(typeof(TransformScale))]
    public class TransfromScaleEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            EditorGUILayout.HelpBox(
                "Scales the attached Transform between starting and ending scales.",
                MessageType.Info);

            DrawDefaultInspector();
        }
    }
}