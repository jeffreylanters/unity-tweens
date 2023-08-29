#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;
using Tweens.Core;

namespace Tweens.Editor {
  internal class TweenInspector : EditorWindow {
    Vector2 scrollPosition;
    string searchQuery;

    [MenuItem("Window/Analysis/Tween Inspector", false, 1000)]
    internal static void ShowWindow() {
      GetWindow<TweenInspector>("Tween Inspector");
    }

    void OnGUI() {
      EditorGUILayout.BeginHorizontal(EditorStyles.toolbar);
      if (GUILayout.Button("Cancel all", EditorStyles.toolbarButton)) {
        if (Application.isPlaying) {
          for (var i = TweenEngine.instances.Count - 1; i >= 0; i--) {
            var tweenInstance = TweenEngine.instances[i];
            tweenInstance.Cancel();
          }
        }
      }
      GUILayout.FlexibleSpace();
      searchQuery = EditorGUILayout.TextField(searchQuery, EditorStyles.toolbarSearchField);
      EditorGUILayout.EndHorizontal();
      scrollPosition = EditorGUILayout.BeginScrollView(scrollPosition);
      EditorGUILayout.BeginHorizontal();
      GUILayout.Space(10);
      EditorGUILayout.LabelField("Target", EditorStyles.miniBoldLabel);
      GUILayout.FlexibleSpace();
      EditorGUILayout.LabelField("Time", EditorStyles.miniBoldLabel, GUILayout.Width(50));
      EditorGUILayout.LabelField("Duration", EditorStyles.miniBoldLabel, GUILayout.Width(50));
      EditorGUILayout.LabelField("Halt", EditorStyles.miniBoldLabel, GUILayout.Width(50));
      EditorGUILayout.LabelField("Loops", EditorStyles.miniBoldLabel, GUILayout.Width(50));
      EditorGUILayout.LabelField("Direction", EditorStyles.miniBoldLabel, GUILayout.Width(50));
      GUILayout.Space(10);
      EditorGUILayout.EndHorizontal();
      if (!Application.isPlaying || TweenEngine.instances.Count == 0) {
        GUILayout.Space(20);
        GUILayout.Label("No tweens running", EditorStyles.centeredGreyMiniLabel);
        EditorGUILayout.EndScrollView();
        return;
      }
      for (var i = TweenEngine.instances.Count - 1; i >= 0; i--) {
        var tweenInstance = TweenEngine.instances[i];
        if (tweenInstance.isDecommissioned) {
          continue;
        }
        if (!string.IsNullOrEmpty(searchQuery) && !tweenInstance.target.name.Contains(searchQuery)) {
          continue;
        }
        EditorGUILayout.BeginHorizontal();
        GUILayout.Space(10);
        if (GUILayout.Button(tweenInstance.target.name, EditorStyles.linkLabel)) {
          EditorGUIUtility.PingObject(tweenInstance.target);
        }
        GUILayout.FlexibleSpace();
        EditorGUILayout.LabelField($"{tweenInstance.time:0.00}t", GUILayout.Width(50));
        EditorGUILayout.LabelField($"{tweenInstance.duration:0.00}s", GUILayout.Width(50));
        EditorGUILayout.LabelField(tweenInstance.haltTime != null ? $"{tweenInstance.haltTime:0.00}" : "N/A", GUILayout.Width(50));
        EditorGUILayout.LabelField(tweenInstance.loops != null ? $"{tweenInstance.loops}" : "N/A", GUILayout.Width(50));
        EditorGUILayout.LabelField(tweenInstance.isForwards ? "Forwards" : "Backwards", GUILayout.Width(50));
        GUILayout.Space(10);
        EditorGUILayout.EndHorizontal();
      }
      EditorGUILayout.EndScrollView();
    }

    void Update() {
      if (!EditorApplication.isPlaying || EditorApplication.isPaused) {
        return;
      }
      Repaint();
    }
  }
}
#endif