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

        public string TestName { get; set; }

        public int PatientID { get; set; }

        public int NurseID { get; set; }

        public int DoctorID { get; set; }

        public DateTime AppointmentDateTime { get; set; }

        public DateTime? TestDateTime { get; set; }

        public bool? IsAbnormal { get; set; }

        public string? Result { get; set; }

        public LabTest(int testCode, int patientId, int doctorId, int nurseId, DateTime appointmentDateTime, DateTime? testDateTime, bool? isAbnormal, string? result) 
        {
            // Pre-condition checks
            this.TestCode = testCode;
            this.PatientID = patientId;
            this.DoctorID = doctorId;
            this.NurseID = nurseId;
            this.AppointmentDateTime = appointmentDateTime;
            this.TestDateTime = testDateTime;
            this.IsAbnormal = isAbnormal;
            this.Result = result;
        }
    }
}
