using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareSystem.Model
{
    public class Appointment
    {
        public Patient Patient { get; set; }

        public Doctor Doctor { get; set; }

        public DateTime AppointmentDateTime { get; set; }

        public string? Reason { get; set; }

        public Appointment(Patient patient, Doctor doctor, DateTime appointmentDateTime) 
        {
            // Pre-condition checks
            this.Patient = patient;
            this.Doctor = doctor;
            this.AppointmentDateTime = appointmentDateTime;
        }
    }
}
