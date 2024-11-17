using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareSystem.Model
{
    public class LabTest
    {
        public int TestCode {  get; set; }

        public int PatientID { get; set; }

        public int NurseID { get; set; }

        public int DoctorID { get; set; }

        public DateTime AppointmentDateTime { get; set; }

        public int Low {  get; set; }

        public int High { get; set; }

        public int UnirMeasurement { get; set; }

        public DateTime? TestDateTime { get; private set; }

        public bool? IsAbnormal { get; private set; }

        public string? Result { get; private set; }

        public LabTest(int testCode, int patientId, int doctorId, int nurseId, DateTime appointmentDateTime, int low, int high, String unit, DateTime testDateTime, bool normality, string result) 
        {
            // Pre-condition checks
            this.TestCode = testCode;
            this.PatientID = patientId;
            this.DoctorID = doctorId; 
            this.NurseID = nurseId; 
            this.AppointmentDateTime = appointmentDateTime;
            this.Low = low;
            this.High = high;
            this.TestDateTime = testDateTime;
            this.IsAbnormal = normality;
            this.Result = result;
        }
    }
}
