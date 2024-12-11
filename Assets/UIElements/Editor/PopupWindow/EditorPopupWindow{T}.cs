using System;
using UnityEngine;
using UnityEditor;
using UnityEngine.UIElements;

namespace Lustie.UIElements
{
    public class EditorPopupWindow<TData> : EditorPopupWindow
    {
        protected TData userData;
    }
}