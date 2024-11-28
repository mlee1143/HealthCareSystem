using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace HealthCareSystem.Model
{
    public class TestType
    {
        public int TestCode { get; private set; }

        public string? TestName { get; private set; }

        public decimal? Low { get; private set; }

        public decimal? High { get; private set; }

        public string? UnitMeasurement { get; set; }

        public TestType(int testcode, string name, decimal? lowValue, decimal? highValue, string unitMeasurment) 
        {
            // Pre-condition checks
            this.TestCode = testcode;
            this.TestName = name;
            this.Low = lowValue;
            this.High = highValue;
            this.UnitMeasurement = unitMeasurment;
        }
    }
}
