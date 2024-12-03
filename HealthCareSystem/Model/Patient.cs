using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareSystem.Model
{
    /// <summary>
    /// Represents a patient in the health care system.
    /// Contains personal information, contact details, and activity status of the patient.
    /// </summary>
    public class Patient
    {
        /// <summary>
        /// Gets or sets the unique identifier for the patient.
        /// </summary>
        public int PatientId { get;  set; }

        /// <summary>
        /// Gets or sets the first name of the patient.
        /// </summary>
        public string Firstname { get;  set; }

        /// <summary>
        /// Gets or sets the middle initial of the patient. This value is optional.
        /// </summary>
        public string? MiddleInitial {  get;  set; }

        /// <summary>
        /// Gets or sets the last name of the patient.
        /// </summary>
        public string Lastname { get;  set; }

        /// <summary>
        /// Gets the full name of the patient, combining first and last names.
        /// </summary>
        public string FullName
        {
            get
            {
                return $"{Firstname} {Lastname} {PatientId}";
            }
        }

        /// <summary>
        /// Gets or sets the birthdate of the patient.
        /// </summary>
        public DateTime Birthdate { get;  set; }

        /// <summary>
        /// Gets or sets the gender of the patient.
        /// </summary>
        public Gender Gender { get;  set; }

        /// <summary>
        /// Gets or sets the address of the patient. This value is optional.
        /// </summary>
        public string? Address { get;  set; }

        /// <summary>
        /// Gets or sets the city where the patient resides. This value is optional.
        /// </summary>
        public string? City { get;  set; }

        /// <summary>
        /// Gets or sets the state where the patient resides. This value is optional.
        /// </summary>
        public States? State { get;  set; }

        /// <summary>
        /// Gets or sets the country where the patient resides. This value is optional.
        /// </summary>
        public string? Country { get;  set; }

        /// <summary>
        /// Gets or sets the ZIP code of the patient's residence. This value is optional.
        /// </summary>
        public int? ZipCode { get;  set; }

        /// <summary>
        /// Gets or sets the phone number of the patient. This value is optional.
        /// </summary>
        public string? PhoneNumber { get;  set; }

        /// <summary>
        /// Gets or sets the activity status of the patient.
        /// </summary>
        public int IsActive { get;  set; }

        /// <summary>
        /// Initializes a new instance of the Patient class with required details.
        /// </summary>
        /// <param name="firstname">The first name of the patient.</param>
        /// <param name="lastname">The last name of the patient.</param>
        /// <param name="birthdate">The birthdate of the patient.</param>
        /// <param name="gender">The gender of the patient.</param>
        /// <param name="isActive">The activity status of the patient (0 for inactive, 1 for active).</param>
        /// <exception cref="ArgumentNullException">Thrown if <paramref name="firstname"/> or <paramref name="lastname"/> is null or empty.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="isActive"/> is not 0 or 1.</exception>
        public Patient(string firstname, string lastname, DateTime birthdate, Gender gender, int isActive)
        {
            if (string.IsNullOrWhiteSpace(firstname))
            {
                throw new ArgumentNullException(nameof(firstname), "Firstname cannot be null or empty.");
            }

            if (string.IsNullOrWhiteSpace(lastname))
            {
                throw new ArgumentNullException(nameof(lastname), "Lastname cannot be null or empty.");
            }

            if (isActive != 0 && isActive != 1)
            {
                throw new ArgumentOutOfRangeException(nameof(isActive), "IsActive must be 0 (inactive) or 1 (active).");
            }

            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Birthdate = birthdate;
            this.Gender = gender;
            this.IsActive = isActive;
        }
    }
}
