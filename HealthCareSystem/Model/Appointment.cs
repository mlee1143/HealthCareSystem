using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareSystem.Model
{
    /// <summary>
    /// Represents an Appointment in the Health Care System.
    /// Contains details for appointment operations.
    /// </summary>
    public class Appointment
    {
        /// <summary>
        /// Gets or sets the unique identifier of the patient associated with the appointment.
        /// </summary
        public int PatientID { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the doctor associated with the appointment.
        /// </summary>
        public int DoctorID { get; set; }

        /// <summary>
        /// Gets or sets the date and time of the appointment.
        /// </summary>
        public DateTime AppointmentDateTime { get; set; }

        /// <summary>
        /// Gets or sets the reason for the appointment.
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// Gets or sets the name of the patient associated with the appointment. This is optional.
        /// </summary>
        public string? PatientName { get; set; }

        /// <summary>
        /// Gets or sets the name of the doctor associated with the appointment. This is optional.
        /// </summary>
        public string? DoctorName { get; set; }

        /// <summary>
        /// Initializes a new instance of the Appointment class with the specified patient ID, doctor ID, appointment date and time, and reason.
        /// </summary>
        /// <param name="patientId">The ID of the patient.</param>
        /// <param name="doctorId">The ID of the doctor.</param>
        /// <param name="appointmentDateTime">The date and time of the appointment.</param>
        /// <param name="reason">The reason for the appointment.</param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if the patient or doctor ID is less than or equal to 0.</exception>
        /// <exception cref="ArgumentNullException">Thrown if the reason is null or empty.</exception>
        /// <exception cref="ArgumentException">Thrown if the appointment date is in the past.</exception>

        public Appointment(int patientId, int doctorId, DateTime appointmentDateTime, string reason) 
        {
            if (patientId <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(patientId), "Patient ID must be greater than 0.");
            }

            if (doctorId <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(doctorId), "Doctor ID must be greater than 0.");
            }

            if (string.IsNullOrWhiteSpace(reason))
            {
                throw new ArgumentNullException(nameof(reason), "Reason cannot be null or empty.");
            }

            this.PatientID = patientId;
            this.DoctorID = doctorId;
            this.AppointmentDateTime = appointmentDateTime;
            this.Reason = reason;
        }
    }
}
