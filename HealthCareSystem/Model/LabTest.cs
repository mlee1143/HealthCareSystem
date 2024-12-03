using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareSystem.Model
{
    /// <summary>
    /// Represents a lab test conducted for a patient in the healthcare system.
    /// Contains information about the test, associated medical staff, and results.
    /// </summary>
    public class LabTest
    {
        /// <summary>
        /// Gets or sets the unique code for the lab test.
        /// </summary>
        public int TestCode {  get; set; }

        /// <summary>
        /// Gets or sets the name of the lab test.
        /// </summary>
        public string TestName { get; set; }

        /// <summary>
        /// Gets or sets the ID of the patient associated with the test.
        /// </summary>
        public int PatientID { get; set; }

        /// <summary>
        /// Gets or sets the ID of the nurse who assisted with the test.
        /// </summary>
        public int NurseID { get; set; }

        /// <summary>
        /// Gets or sets the ID of the doctor who requested the test.
        /// </summary>
        public int DoctorID { get; set; }

        /// <summary>
        /// Gets or sets the appointment date and time associated with the test.
        /// </summary>
        public DateTime AppointmentDateTime { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the test was conducted. This value is optional.
        /// </summary>
        public DateTime? TestDateTime { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the test result is abnormal. This value is optional.
        /// </summary>
        public bool? IsAbnormal { get; set; }

        /// <summary>
        /// Gets or sets the result of the test. This value is optional.
        /// </summary>
        public string? Result { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabTest"/> class with the specified test information.
        /// </summary>
        /// <param name="testCode">The unique code for the lab test.</param>
        /// <param name="patientId">The ID of the patient associated with the test.</param>
        /// <param name="doctorId">The ID of the doctor who requested the test.</param>
        /// <param name="nurseId">The ID of the nurse who assisted with the test.</param>
        /// <param name="appointmentDateTime">The date and time of the associated appointment.</param>
        /// <param name="testDateTime">The date and time when the test was conducted. This value can be null.</param>
        /// <param name="isAbnormal">Indicates whether the test result is abnormal. This value can be null.</param>
        /// <param name="result">The result of the test. This value can be null.</param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if any of the IDs or the test code is less than or equal to 0.</exception>
        public LabTest(int testCode, int patientId, int doctorId, int nurseId, DateTime appointmentDateTime, DateTime? testDateTime, bool? isAbnormal, string? result) 
        {
            if (testCode <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(testCode), "Test code must be greater than 0.");
            }

            if (patientId <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(patientId), "Patient ID must be greater than 0.");
            }

            if (doctorId <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(doctorId), "Doctor ID must be greater than 0.");
            }

            if (nurseId <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(nurseId), "Nurse ID must be greater than 0.");
            }

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
