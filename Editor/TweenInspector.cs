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
      LabelRow("Target", "Time", "Duration", "Delay", "Loops", "Direction");
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
        LabelRow(
          tweenInstance.target.name,
          $"{tweenInstance.time:0.00}",
          $"{tweenInstance.duration:0.00}",
          tweenInstance.delay != null ? $"{tweenInstance.delay:0.00}" : "N/A",
          tweenInstance.loops != null ? $"{tweenInstance.loops}" : "N/A",
          tweenInstance.isForwards ? "Forwards" : "Backwards"
        );
      }
      EditorGUILayout.EndScrollView();
    }

    void Update() {
      if (!EditorApplication.isPlaying || EditorApplication.isPaused) {
        return;
      }
      Repaint();
    }

    void LabelRow(params string[] labels) {
      EditorGUILayout.BeginHorizontal();
      for (int i = 0; i < labels.Length; i++) {
        var label = labels[i];
        EditorGUILayout.LabelField(label, i == 0 ? EditorStyles.boldLabel : EditorStyles.label, GUILayout.Width(i == 0 ? 100 : 50));
      }
      EditorGUILayout.EndHorizontal();
    }
  }
}