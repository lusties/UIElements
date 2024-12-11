using UnityEngine;
using UnityEngine.UIElements;

namespace Lustie.UIElements
{
    internal class FoldoutHeader : VisualElement, INotifyValueChanged<bool>
    {
        public VisualElement headerContainer { get; protected set; }
        public VisualElement headerIcon { get; protected set; }
        public Label headerTitle { get; protected set; }

        private Toggle m_Toggle;

        public string text
        {
            get => headerTitle.text;
            set
            {
                headerTitle.text = value;
            }
        }

        public Texture2D icon
        {
            get => headerIcon.style.backgroundImage.value.texture;
            set
            {
                headerIcon.BgImage(value);
            }
        }
        
        public bool value
        {
            get => this.m_Value;
            set
            {
                if (this.m_Value == value)
                    return;
                this.SetValueWithoutNotify(value);
            }
        }
        
        private bool m_Value;

        public FoldoutHeader()
        {
            // Header Content Container
            headerContainer = new VisualElement
            {
                name = "header-content-container"
            }
            .FlexGrow(1)
            .FlexDirection(FlexDirection.Row)
            .MarginLeft(25);
            
            CreateHeaderContent();
            CreateFouldout();
            
            //Build Hierarchy
            
            headerContainer.hierarchy.Add(headerIcon);
            headerContainer.hierarchy.Add(headerTitle);
            
            hierarchy.Add(headerContainer);
            hierarchy.Add(m_Toggle);
        }
        
        private void CreateHeaderContent()
        {
            // Header Icon
            headerIcon = new VisualElement
            {
                name = "script-icon"
            }
            .Size(16, 16)
            .BgImage(null)
            .Margin(5)
            .AlignSelf(Align.Center)
            .JustifyContent(Justify.Center)
            .TextAlign(TextAnchor.MiddleLeft);

            // Header Title
            headerTitle = new Label("FiniState")
            {
                name = "script-name"
            }
            .FontSize(14)
            .FontStyle(FontStyle.Bold)
            .AlignSelf(Align.Center)
            .MarginLeft(0)
            .Color(Color.white);
        }

        private void CreateFouldout()
        {
            m_Toggle = new Toggle()
                .Size(100, 100, LengthUnit.Percent)
                .AlignSelf(Align.Center)
                .Position(Position.Absolute)
                .Margin(0)
                .Left(5);   
            
            m_Toggle.AddToClassList("unity-base-field--no-label");
            m_Toggle.AddToClassList("unity-foldout__toggle");
        }

        public void SetValueWithoutNotify(bool newValue)
        {
            this.m_Value = newValue;
            m_Toggle.SetValueWithoutNotify(newValue);
        }
        
        public new class UxmlFactory : UxmlFactory<FoldoutHeader, UxmlTraits>
        {
        }
    }
}