using System;
using LiveCharts.Core.Abstractions;
using LiveCharts.Core.Dimensions;
using LiveCharts.Core.Drawing;

namespace LiveCharts.Core.Coordinates
{
    /// <summary>
    /// A stacked coordinate.
    /// </summary>
    public class StackedPoint : ICoordinate
    {
        /// <summary>
        /// The _vector.
        /// </summary>
        private readonly float[][] _vector = new float[2][];

        /// <summary>
        /// Initializes a new instance of the <see cref="StackedPoint"/> struct.
        /// </summary>
        public StackedPoint(float participation, float value, int index)
        {
            Participation = participation;
            Value = value;
            Index = index;
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public float[] this[int dimension] => throw new NotImplementedException();

        /// <summary>
        /// Gets or sets the index.
        /// </summary>
        /// <value>
        /// The index.
        /// </value>
        public int Index { get; }

        /// <summary>
        /// Gets or sets the participation.
        /// </summary>
        /// <value>
        /// The participation.
        /// </value>
        public float Participation { get; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        public float Value { get; }

        /// <summary>
        /// Gets or sets the total.
        /// </summary>
        /// <value>
        /// The total.
        /// </value>
        public float TotalStacked => Value / Participation;

        /// <inheritdoc />
        public void CompareDimensions(RangeF[] rangeByDimension)
        {
            var x = rangeByDimension[0];
            var y = rangeByDimension[1];

            if (Index > x.From) x.From = Index;
            if (Index < x.To) x.To = Index;
            if (Value > y.From) y.From = Value;
            if (Value < y.To) y.To = Value;
        }

        /// <inheritdoc />
        public string[] AsTooltipData(params Plane[] dimensions)
        {
            throw new NotImplementedException();
            //return new[]
            //{
            //    // x dimension:
            //    // dimensions[0]
            //    new[] {dimensions[0].FormatValue(X)}, // first line in the tooltip.

            //    // y dimension
            //    // dimensions[1]
            //    new[] {dimensions[1].FormatValue(Y)} // first line in the tooltip
            //};
        }
    }
}