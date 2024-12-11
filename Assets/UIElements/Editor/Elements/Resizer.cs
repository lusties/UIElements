using System;
using UnityEngine.UIElements;
using UnityEditor.Experimental.GraphView;

namespace Lustie.UIElements
{
    public class Resizer : ResizableElement
    {
        public Resizer(ResizeDirection direction) : base()
        {
            
            var rightResizer = this.Q("right");
            var leftResizer = this.Q("left");
            var middleResizer = this.Q("middle");

            if (!direction.HasFlag(ResizeDirection.Left))
            {
                hierarchy.Remove(leftResizer);
            }
            else
            {
                RemoveSideResizer(leftResizer, "left");
            }
            
            if (!direction.HasFlag(ResizeDirection.Right))
            {
                hierarchy.Remove(rightResizer);
            }
            else
            {
                RemoveSideResizer(rightResizer, "right");
            }
            
            bool topResize = direction.HasFlag(ResizeDirection.Top);
            bool bottomResize = direction.HasFlag(ResizeDirection.Bottom);

            if (!topResize)
            {
                var topResizer = middleResizer.Q("top-resize");
                middleResizer.hierarchy.Remove(topResizer);
            }

            if (!bottomResize)
            {
                var bottomResizer = middleResizer.Q("bottom-resize");
                middleResizer.hierarchy.Remove(bottomResizer);
            }
            
            if (!topResize && !bottomResize)
            {
                hierarchy.Remove(middleResizer);
            }
        }
        
        /// <summary>
        /// Remove resizer in left and right side
        /// </summary>
        /// <param name="resizerParent">Resizer parent</param>
        /// <param name="side">left or right</param>
        private void RemoveSideResizer(VisualElement resizerParent, string side)
        {
            var topSideResizer = resizerParent.Q($"top-{side}-resize");
            var bottomSideResizer = resizerParent.Q($"bottom-{side}-resize");

            resizerParent.hierarchy.Remove(topSideResizer);
            resizerParent.hierarchy.Remove(bottomSideResizer);

            resizerParent
                .Position(Position.Relative)
                .Size(width: 8, height: null);
            //.FlexGrow(1);

            switch (side)
            {
                case "left":
                    resizerParent
                        .MarginRight(-4);
                    break;
                case "right":
                    resizerParent
                        .Left(100, LengthUnit.Percent)
                        .MarginLeft(-4);
                    break;
            }
        }
    }

    [Flags]
    public enum ResizeDirection : byte
    {
        Left = 1,
        Top = 2,
        Right = 4,
        Bottom = 8
    }
}