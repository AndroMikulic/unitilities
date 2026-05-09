using UnityEditor;
using UnityEngine;

namespace Unitilities
{
    [CustomEditor(typeof(TransformSmoothLookAt))]
    [CanEditMultipleObjects]
    public class TransformSmoothLookAtEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            EditorGUILayout.HelpBox(
                "Smoothly looks at a given transform.",
                MessageType.Info);

            DrawDefaultInspector();

            var t = (TransformSmoothLookAt)target;

            EditorGUILayout.Space();
            EditorGUILayout.LabelField("State", EditorStyles.boldLabel);

            EditorGUI.BeginDisabledGroup(true);
            EditorGUILayout.Toggle(
                new GUIContent("Looking Directly At Target", "Is the object currently aligned with the target direction."),
                GetLookingDirectlyAtTarget(t)
            );
            EditorGUI.EndDisabledGroup();
        }

        private bool GetLookingDirectlyAtTarget(TransformSmoothLookAt t)
        {
            var field = typeof(TransformSmoothLookAt)
                .GetField("lookingDirectlyAtTarget",
                    System.Reflection.BindingFlags.NonPublic |
                    System.Reflection.BindingFlags.Instance);

            return (bool)field.GetValue(t);
        }
    }
}