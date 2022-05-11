using System;
using System.Collections.Generic;
using GraphShape.Algorithms.Layout;

namespace net.adamec.lib.common.dmn.engine.simulator.controls.dmngraph.algorithm
{
    /// <summary>
    /// DMN DI layout algorithm parameters.
    /// </summary>
    public class DmnDiLayoutParameters : LayoutParametersBase
    {
        /// <summary>
        /// X offset for the bounding box for <see cref="DmnShape"/> without position.
        /// </summary>
        private int xOffset;

        /// <summary>
        /// X offset for the bounding box for <see cref="DmnShape"/> without position.
        /// </summary>
        public int XOffset
        {
            get => xOffset;
            set
            {
                if (xOffset == value)
                    return;

                xOffset = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Y offset for the bounding box for <see cref="DmnShape"/> without position.
        /// </summary>
        private int yOffset;

        /// <summary>
        /// Y offset for the bounding box for <see cref="DmnShape"/> without position.
        /// </summary>
        public int YOffset
        {
            get => yOffset;
            set
            {
                if (yOffset == value)
                    return;

                yOffset = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Width of the bounding box for <see cref="DmnShape"/> without position.
        /// </summary>
        private int width = 1000;

        /// <summary>
        /// Width of the bounding box for <see cref="DmnShape"/> without position.
        /// </summary>
        /// <remarks>
        /// Either <see cref="Width"/> or <see cref="Height"/> should be set (>0).
        /// If <see cref="Width"/> is set, the vertices without position will be placed in flow Left-to-Right until width is reached and then Top-to-Bottom
        /// If <see cref="Height"/> is set, the vertices without position will be placed in flow Top-to-Bottom until height is reached and then Left-to-Right
        /// If both <see cref="Width"/> and <see cref="Height"/> are set (>0), width (LtR+TtB) has priority
        /// If none of <see cref="Width"/> and <see cref="Height"/> are set (>0), LtR will be used without the width limit (single line)
        /// </remarks>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Value is negative.</exception>
        public int Width
        {
            get => width;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(value), $"{nameof(Width)} must be positive or 0.");

                if (width == value)
                    return;

                width = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Height of the bounding box for <see cref="DmnShape"/> without position.
        /// </summary>
        private int height;

        /// <summary>
        /// Height of the bounding box for <see cref="DmnShape"/> without position.
        /// </summary>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Value is negative.</exception>
        public int Height
        {
            get => height;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(value), $"{nameof(Height)} must be positive or 0.");

                if (height == value)
                    return;

                height = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Vertical spacing between the positioned vertices  
        /// </summary>
        private int verticalSpacing = 10;
        /// <summary>
        /// Vertical spacing between the positioned vertices  
        /// </summary>
        public int VerticalSpacing
        {
            get => verticalSpacing;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(value), $"{nameof(VerticalSpacing)} must be positive or 0.");

                if (verticalSpacing == value)
                    return;

                verticalSpacing = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Horizontal spacing between the positioned vertices  
        /// </summary>
        private int horizontalSpacing = 10;
        /// <summary>
        /// Horizontal spacing between the positioned vertices  
        /// </summary>
        public int HorizontalSpacing
        {
            get => horizontalSpacing;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(value), $"{nameof(HorizontalSpacing)} must be positive or 0.");

                if (horizontalSpacing == value)
                    return;

                horizontalSpacing = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Returns the properties to be compared when checking the equality or parameter sets
        /// </summary>
        /// <returns>Properties to compare</returns>
        protected override IEnumerable<object> GetEqualityElements()
        {
            foreach (var element in base.GetEqualityElements())
            {
                yield return element!;
            }

            yield return xOffset;
            yield return yOffset;
            yield return width;
            yield return height;
        }
    }
}
