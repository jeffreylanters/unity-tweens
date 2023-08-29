#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;
using Tweens.Core;

namespace Tweens.Editor {
  internal class TweensEditorWindow : EditorWindow {
    Vector2 scrollPosition;
    string searchQuery;
    bool showDirection;
    bool showIsPaused;
    bool showPingPongInterval;
    bool showRepeatInterval;
    bool showLoops;

    [MenuItem("Window/Analysis/Tweens", false, 1000)]
    internal static void ShowWindow() {
      var window = GetWindow<TweensEditorWindow>("Tweens");
      window.showDirection = EditorPrefs.GetBool("Tweens.Editor.TweensEditorWindow.showDirection", false);
      window.showIsPaused = EditorPrefs.GetBool("Tweens.Editor.TweensEditorWindow.showIsPaused", false);
      window.showPingPongInterval = EditorPrefs.GetBool("Tweens.Editor.TweensEditorWindow.showPingPongInterval", false);
      window.showRepeatInterval = EditorPrefs.GetBool("Tweens.Editor.TweensEditorWindow.showRepeatInterval", false);
      window.showLoops = EditorPrefs.GetBool("Tweens.Editor.TweensEditorWindow.showLoops", false);
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
      if (GUILayout.Button(EditorGUIUtility.IconContent("d_SceneViewVisibility@2x"), EditorStyles.toolbarDropDown)) {
        var menu = new GenericMenu();
        menu.AddItem(new GUIContent("Show Direction"), showDirection, () => EditorPrefs.SetBool("Tweens.Editor.TweensEditorWindow.showDirection", showDirection = !showDirection));
        menu.AddItem(new GUIContent("Show Paused"), showIsPaused, () => EditorPrefs.SetBool("Tweens.Editor.TweensEditorWindow.showIsPaused", showIsPaused = !showIsPaused));
        menu.AddItem(new GUIContent("Show PingPongInterval"), showPingPongInterval, () => EditorPrefs.SetBool("Tweens.Editor.TweensEditorWindow.showPingPongInterval", showPingPongInterval = !showPingPongInterval));
        menu.AddItem(new GUIContent("Show RepeatInterval"), showRepeatInterval, () => EditorPrefs.SetBool("Tweens.Editor.TweensEditorWindow.showRepeatInterval", showRepeatInterval = !showRepeatInterval));
        menu.ShowAsContext();
      }
      EditorGUILayout.EndHorizontal();
      scrollPosition = EditorGUILayout.BeginScrollView(scrollPosition);
      EditorGUILayout.BeginHorizontal();
      GUILayout.Space(10);
      EditorGUILayout.LabelField("Target", EditorStyles.miniBoldLabel);
      GUILayout.FlexibleSpace();
      EditorGUILayout.LabelField("Time", EditorStyles.miniLabel, GUILayout.Width(50));
      EditorGUILayout.LabelField("Duration", EditorStyles.miniLabel, GUILayout.Width(50));
      EditorGUILayout.LabelField("Halt", EditorStyles.miniLabel, GUILayout.Width(50));
      if (showLoops) {
        EditorGUILayout.LabelField("Loops", EditorStyles.miniLabel, GUILayout.Width(50));
      }
      if (showDirection) {
        EditorGUILayout.LabelField("Direction", EditorStyles.miniLabel, GUILayout.Width(50));
      }
      if (showIsPaused) {
        EditorGUILayout.LabelField("Paused", EditorStyles.miniLabel, GUILayout.Width(50));
      }
      if (showPingPongInterval) {
        EditorGUILayout.LabelField("PingPong", EditorStyles.miniLabel, GUILayout.Width(50));
      }
      if (showRepeatInterval) {
        EditorGUILayout.LabelField("Repeat", EditorStyles.miniLabel, GUILayout.Width(50));
      }
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
        if (GUILayout.Button($"{tweenInstance.target.name} ({tweenInstance.@tweenTypeName})", EditorStyles.linkLabel)) {
          EditorGUIUtility.PingObject(tweenInstance.target);
        }
        GUILayout.FlexibleSpace();
        EditorGUILayout.LabelField($"{tweenInstance.time:0.00}t", GUILayout.Width(50));
        EditorGUILayout.LabelField($"{tweenInstance.duration:0.00}s", GUILayout.Width(50));
        EditorGUILayout.LabelField(tweenInstance.haltTime != null ? $"{tweenInstance.haltTime:0.00}s" : "-", GUILayout.Width(50));
        if (showLoops) {
          EditorGUILayout.LabelField(tweenInstance.loops != null ? $"{tweenInstance.loops}" : "-", GUILayout.Width(50));
        }
        if (showDirection) {
          EditorGUILayout.LabelField(tweenInstance.isForwards ? "Forwards" : "Backwards", GUILayout.Width(50));
        }
        if (showIsPaused) {
          EditorGUILayout.LabelField(tweenInstance.isPaused ? "Paused" : "Playing", GUILayout.Width(50));
        }
        if (showPingPongInterval) {
          EditorGUILayout.LabelField(tweenInstance.pingPongInterval != null ? $"{tweenInstance.pingPongInterval:0.00}s" : "-", GUILayout.Width(50));
        }
        if (showRepeatInterval) {
          EditorGUILayout.LabelField(tweenInstance.repeatInterval != null ? $"{tweenInstance.repeatInterval:0.00}s" : "-", GUILayout.Width(50));
        }
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