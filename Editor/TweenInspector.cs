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
      EditorGUILayout.LabelField("Target", EditorStyles.largeLabel);
      GUILayout.FlexibleSpace();
      EditorGUILayout.LabelField("Time", GUILayout.Width(50));
      EditorGUILayout.LabelField("Duration", GUILayout.Width(50));
      EditorGUILayout.LabelField("Delay", GUILayout.Width(50));
      EditorGUILayout.LabelField("Loops", GUILayout.Width(50));
      EditorGUILayout.LabelField("Direction", GUILayout.Width(50));
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
        EditorGUILayout.LabelField(tweenInstance.target.name, EditorStyles.boldLabel);
        GUILayout.FlexibleSpace();
        EditorGUILayout.LabelField($"{tweenInstance.time:0.00}", GUILayout.Width(50));
        EditorGUILayout.LabelField($"{tweenInstance.duration:0.00}", GUILayout.Width(50));
        EditorGUILayout.LabelField(tweenInstance.delay != null ? $"{tweenInstance.delay:0.00}" : "N/A", GUILayout.Width(50));
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