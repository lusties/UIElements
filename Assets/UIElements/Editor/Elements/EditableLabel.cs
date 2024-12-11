using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace Lustie.UIElements
{
    public class EditableLabel : VisualElement
    {
        private Label label;
        private TextField textField;
        
        public string text
        {
            get => textField.text;
            set
            {
                label.text = value;
                textField.SetValueWithoutNotify(value);
            }
        }

        public int maxLength
        {
            get => textField.maxLength;
            set => textField.maxLength = value;
        }

        public bool isPasswordField
        {
            get => textField.isPasswordField;
            set => textField.isPasswordField = value;
        }

        public bool isDelayed
        {
            get => textField.isDelayed;
            set => textField.isDelayed = value;
        }

        public bool multiline
        {
            get => textField.multiline;
            set => textField.multiline = value;
        }
        
        public EditableLabel()
        {
            label = new Label()
                .Margin(3, 2, 1, 1)
                .Padding(0)
                .FlexGrow(1);

            textField = new TextField()
                .Margin(0)
                .Padding(0)
                .FlexGrow(1)
                .Display(false);

            label.RegisterCallback<ClickEvent>(evt =>
            {
                ShowTextField();
            });

            textField.RegisterCallback<FocusOutEvent>(evt =>
            {
                ShowLabel();
            });

            hierarchy.Add(label);
            hierarchy.Add(textField);
        }

        public void EditText()
        {
            ShowTextField();
        }

        public void ToggeEdit()
        {
            
        }

        private void ShowLabel()
        {
            this.text = textField.text;
            label.Display(true);
            textField.Display(false);
            label.Focus();
        }

        private void ShowTextField()
        {
            label.Display(false);
            textField.Display(true);
            textField.Focus();
        }

        public enum MouseType
        {
            Right,
            Left,
            Middle
        }
        
        public new class UxmlFactory : UxmlFactory<EditableLabel, EditableLabel.UxmlTraits>
        {
        }

        public new class UxmlTraits : VisualElement.UxmlTraits
        {
            private UxmlStringAttributeDescription m_text;
            private UxmlIntAttributeDescription m_maxLength;
            private UxmlBoolAttributeDescription m_password;
            private UxmlBoolAttributeDescription m_delayed;
            private UxmlBoolAttributeDescription m_multiline;

            public override IEnumerable<UxmlChildElementDescription> uxmlChildElementsDescription
            {
                get { yield return new UxmlChildElementDescription(typeof(VisualElement)); }
            }

            public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
            {
                var editableLabel = (EditableLabel)ve;
                var textField = editableLabel.textField;

                editableLabel.text = m_text.GetValueFromBag(bag, cc);
                editableLabel.maxLength = m_maxLength.GetValueFromBag(bag, cc);
                editableLabel.isPasswordField = m_password.GetValueFromBag(bag, cc);
                editableLabel.isDelayed = m_delayed.GetValueFromBag(bag, cc);
                editableLabel.multiline = m_multiline.GetValueFromBag(bag, cc);

                base.Init(editableLabel, bag, cc);
            }

            public UxmlTraits()
            {
                m_text = new UxmlStringAttributeDescription { name = "text", defaultValue = "Label"};
                m_maxLength = new UxmlIntAttributeDescription { name = "max-length", defaultValue = -1};
                m_password = new UxmlBoolAttributeDescription { name = "is-password-field", defaultValue = false};
                m_delayed = new UxmlBoolAttributeDescription { name = "is-delayed", defaultValue = false};
                m_multiline = new UxmlBoolAttributeDescription { name = "multiline", defaultValue = false};
            }
        }
    }
}