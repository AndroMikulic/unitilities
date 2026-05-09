using UnityEditor;
using UnityEngine;
namespace Unitilities
{
    [CustomEditor(typeof(TransformSmoothFollow))]
    [CanEditMultipleObjects]
    public class TransformSmoothFollowEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            EditorGUILayout.HelpBox(
                "Smoothly follows a given transform.",
                MessageType.Info);

            DrawDefaultInspector();
            var t = (TransformSmoothFollow)target;
            EditorGUILayout.Space();
            EditorGUILayout.LabelField("State", EditorStyles.boldLabel);

            EditorGUI.BeginDisabledGroup(true);
            EditorGUILayout.Toggle(new GUIContent("At Target Location", "Is the target on location"), GetLookingDirectlyAtTarget(t));
            EditorGUI.EndDisabledGroup();
        }

        private bool GetLookingDirectlyAtTarget(TransformSmoothFollow t)
        {
            var field = typeof(TransformSmoothFollow)
                .GetField("atTargetLocation",
                    System.Reflection.BindingFlags.NonPublic |
                    System.Reflection.BindingFlags.Instance);

            return (bool)field.GetValue(t);
        }
    }
}