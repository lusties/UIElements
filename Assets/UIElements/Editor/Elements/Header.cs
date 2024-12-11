using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

namespace Lustie.UIElements
{
    public class Header : VisualElement
    {
        private Label titleLabel;

        public string title
        {
            get => titleLabel.text;
            set => titleLabel.text = value;
        }

        public Color backgroundColor
        {
            get => style.backgroundColor.value;
            set => this.BgColor(value);
        }
        
        public Header() : this("Title", Color.black)
        {
            
        }
        
        public Header(string title) : this(title, Color.black)
        {
            
        }

        public Header(string title, Color backgroundColor)
        {
            this.BgColor(backgroundColor)
                .Height(30)
                .FlexDirection(FlexDirection.Row);
            
            //Title
            titleLabel = new Label()
                .AlignSelf(Align.Center);
            this.title = title;

            //Context menu
            Button headerContextMenu = new Button()
                .Position(Position.Absolute)
                .Right(2)
                .AlignSelf(Align.Center)
                .Size(20)
                .BgImage(UnityEditor.EditorGUIUtility.IconContent("_Menu").image)
                //.BgColor(Color.black)
                .BordersWidth(0);
            
            
            
            //headerContextMenu.text = "⋮";
            
            hierarchy.Add(titleLabel);
            hierarchy.Add(headerContextMenu);
        }
        
        public new class UxmlFactory : UxmlFactory<Header, UxmlTraits> { }

    }
}