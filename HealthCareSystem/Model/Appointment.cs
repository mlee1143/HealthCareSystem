using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareSystem.Model
{
    public class Appointment
    {
        public int PatientID { get; set; }

        public int DoctorID { get; set; }

        public DateTime AppointmentDateTime { get; set; }

        public string? Reason { get; set; }

        public Appointment(int patientId, int doctorId, DateTime appointmentDateTime, string reason) 
        {
            // Pre-condition checks
            this.PatientID = patientId;
            this.DoctorID = doctorId;
            this.AppointmentDateTime = appointmentDateTime;
            this.Reason = reason;
        }
    }
}
