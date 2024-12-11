using System;
using UnityEngine;
using UnityEditor;
using UnityEngine.UIElements;

namespace Lustie.UIElements
{
    public class EditorPopupWindow : EditorWindow
    {
        public enum EditorWorld
        {
            Gui,
            Screen
        }

        public static void Show<T>(Vector2 position, EditorWorld editorPos = EditorWorld.Screen)
            where T : EditorPopupWindow
        {
            Vector2 screenPos = editorPos switch
            {
                EditorWorld.Gui => GUIUtility.GUIToScreenPoint(position),
                EditorWorld.Screen => position,
                _ => position
            };

            T window = ScriptableObject.CreateInstance<T>();
            window.position = new Rect(screenPos, window.GetWindowSize());
            window.ShowPopup();
        }
        
        public static void Show<T>(Vector2 position, Vector2 additionalSpace, EditorWorld editorPos = EditorWorld.Screen)
            where T : EditorPopupWindow
        {
            Show<T>((position + additionalSpace), editorPos);
        }
        
        protected virtual Vector2 GetWindowSize() => new Vector2(250, 140);

        protected virtual void CreateGUI()
        {
            var label = new Label("Lustie!");
            rootVisualElement.Add(label);

            var button = new Button();
            button.text = "Close!";
            button.clicked += () => this.Close();
            rootVisualElement.Add(button);
        }

        protected virtual void OnLostFocus()
        {
            this.Close();
        }
    }
}