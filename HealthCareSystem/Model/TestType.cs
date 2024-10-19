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

        public TestType(int testcode) 
        {
            // Pre-condition checks
            this.TestCode = testcode;
        }
    }
}
