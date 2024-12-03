using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareSystem.Model
{
    /// <summary>
    /// Represents a medical visit in the health care system.
    /// Contains information about the patient's visit, including vital signs, diagnoses, and symptoms.
    /// </summary>
    public class Visit
    {
        /// <summary>
        /// Gets the appointment details associated with the visit.
        /// </summary>
        public Appointment Appointment { get; private set; }

        /// <summary>
        /// Gets or sets the ID of the nurse who attended the visit. This value is optional.
        /// </summary>
        public int? NurseID { get;  set; }

        /// <summary>
        /// Gets the weight of the patient during the visit, in kilograms.
        /// </summary>
        public double Weight { get; private set; }

        /// <summary>
        /// Gets the height of the patient during the visit, in centimeters.
        /// </summary>
        public double Height { get; private set; }

        /// <summary>
        /// Gets or sets the blood pressure reading of the patient during the visit.
        /// </summary>
        public string BloodPressure { get;  set; }

        /// <summary>
        /// Gets or sets the pulse rate of the patient during the visit. This value is optional.
        /// </summary>
        public int? Pulse { get;  set; }

        /// <summary>
        /// Gets or sets the body temperature of the patient during the visit. This value is optional.
        /// </summary>
        public double? Temperature { get;  set; }

        /// <summary>
        /// Gets or sets the initial diagnosis for the patient during the visit. This value is optional.
        /// </summary>
        public string? InitialDiagnosis { get;  set; }

        /// <summary>
        /// Gets or sets the final diagnosis for the patient after the visit. This value is optional.
        /// </summary>
        public string? FinalDiagnosis { get;  set; }

        /// <summary>
        /// Gets or sets the description of the symptoms reported by the patient during the visit.
        /// </summary>
        public string SymptomsDescription { get;  set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="Visit"/> class with required details.
        /// </summary>
        /// <param name="appointment">The appointment details associated with the visit.</param>
        /// <param name="weight">The weight of the patient during the visit, in kilograms.</param>
        /// <param name="height">The height of the patient during the visit, in centimeters.</param>
        /// <param name="bloodPressure">The blood pressure reading of the patient during the visit.</param>
        /// <param name="symptomsDescription">The description of the symptoms reported by the patient.</param>
        public Visit(Appointment appointment, double weight, double height, string bloodPressure, string symptomsDescription)
        {
            this.Appointment = appointment;
            this.Weight = weight;
            this.Height = height;
            this.BloodPressure = bloodPressure;
            this.SymptomsDescription = symptomsDescription;
        }
    }
}
