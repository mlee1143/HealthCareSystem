using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace HealthCareSystem.Model
{
    /// <summary>
    /// Represents a type of medical test in the health care system.
    /// Contains information about the test, including code, name, normal range, and unit of measurement.
    /// </summary>
    public class TestType
    {
        /// <summary>
        /// Gets the unique code for the test type.
        /// </summary>
        public int TestCode { get; private set; }

        /// <summary>
        /// Gets the name of the test. This value can be null.
        /// </summary>
        public string? TestName { get; private set; }

        /// <summary>
        /// Gets the lower bound of the normal range for the test result. This value can be null.
        /// </summary>
        public decimal? Low { get; private set; }

        /// <summary>
        /// Gets the upper bound of the normal range for the test result. This value can be null.
        /// </summary>
        public decimal? High { get; private set; }

        /// <summary>
        /// Gets or sets the unit of measurement for the test result. This value can be null.
        /// </summary>
        public string? UnitMeasurement { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestType"/> class with the specified details.
        /// </summary>
        /// <param name="testcode">The unique code for the test type.</param>
        /// <param name="name">The name of the test. This value can be null.</param>
        /// <param name="lowValue">The lower bound of the normal range. This value can be null.</param>
        /// <param name="highValue">The upper bound of the normal range. This value can be null.</param>
        /// <param name="unitMeasurement">The unit of measurement for the test result. This value can be null.</param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="testcode"/> is less than or equal to 0.</exception>
        /// <exception cref="ArgumentException">Thrown if <paramref name="lowValue"/> is greater than <paramref name="highValue"/>.</exception>
        public TestType(int testcode, string name, decimal? lowValue, decimal? highValue, string unitMeasurment) 
        {
            if (testcode <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(testcode), "Test code must be greater than 0.");
            }

            this.TestCode = testcode;
            this.TestName = name;
            this.Low = lowValue;
            this.High = highValue;
            this.UnitMeasurement = unitMeasurment;
        }
    }
}
