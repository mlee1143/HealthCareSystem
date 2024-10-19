using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareSystem.Model
{
    public class LabTest
    {
        //public TestType TestType { get: private set;}

        public Visit Visit { get; set; }

        public DateTime? TestDateTime { get; private set; }

        public bool? IsAbnormal { get; private set; }

        public string? Result { get; private set; }

        public LabTest(Visit visit) 
        {
            // Pre-condition checks
            this.Visit = visit;
        }
    }
}
