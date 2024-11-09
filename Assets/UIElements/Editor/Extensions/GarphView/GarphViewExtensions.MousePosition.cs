using UnityEngine;
using UnityEditor.Experimental.GraphView;
using UnityEngine.UIElements;

namespace Lustie.UIElements
{
    public static partial class GarphViewExtensions
    {
        public static Vector2 GetLocalMousePosition(this GraphView graphView, Vector2 localMousePosition)
        {
            //https://discussions.unity.com/t/how-to-get-the-correct-contextual-menu-mouse-position-on-graph-view-when-i-have-contentdragger-contentzoomer-manipulators/245206#:~:text=var%20position%20%3D%20viewTransform.matrix.inverse.MultiplyPoint(evt.localMousePosition)%3B
            return graphView.viewTransform.matrix.inverse.MultiplyPoint(localMousePosition);
        }

        public static Vector2 GetLocalMousePosition(this GraphView graphView, DropdownMenuAction menuAction)
        {
            return GetLocalMousePosition(graphView, menuAction.eventInfo.localMousePosition);
        }
    }
}