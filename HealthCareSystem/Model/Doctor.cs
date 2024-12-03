using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareSystem.Model
{
    /// <summary>
    /// Represents a doctor in the health care system.
    /// Contains personal information, contact details, and specialization data for a doctor.
    /// </summary>
    public class Doctor
    {
        /// <summary>
        /// Gets or sets the unique identifier for the doctor.
        /// Must be greater than 0 to be valid.
        /// </summary>
        public int DoctorId { get; set; }

        /// <summary>
        /// Gets or sets the first name of the doctor.
        /// </summary>
        public string Firstname { get; set; }

        /// <summary>
        /// Gets or sets the last name of the doctor.
        /// </summary>
        public string Lastname { get; set; }

        /// <summary>
        /// Gets the full name of the doctor, including their ID.
        /// </summary>
        public string FullName
        {
            get
            {
                return $"{Firstname} {Lastname} Id: {DoctorId}";
            }
        }

        /// <summary>
        /// Gets or sets the birthdate of the doctor.
        /// </summary>
        public DateTime Birthdate { get; set; }

        /// <summary>
        /// Gets or sets the gender of the doctor.
        /// </summary>
        public Gender Gender { get; set; }

        /// <summary>
        /// Gets or sets the address of the doctor.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets the city where the doctor resides.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the state where the doctor resides. This value is optional.
        /// </summary>
        public States? State { get; set; }

        /// <summary>
        /// Gets or sets the country where the doctor resides. This value is optional.
        /// </summary>
        public string? Country { get; set; }

        /// <summary>
        /// Gets or sets the ZIP code of the doctor's residence. This value is optional.
        /// </summary>
        public int? ZipCode { get; set; }

        /// <summary>
        /// Gets or sets the phone number of the doctor. This value is optional.
        /// </summary>
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the specialty type of the doctor.
        /// </summary>
        public SpecialtyType DoctorSpecialtyType { get; set; }

        /// <summary>
        /// Initializes a new instance of the Doctor class with the specified ID, first name, and last name.
        /// </summary>
        /// <param name="doctorId">The unique identifier for the doctor. Must be greater than 0.</param>
        /// <param name="firstname">The first name of the doctor.</param>
        /// <param name="lastname">The last name of the doctor.</param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="doctorId"/> is less than or equal to 0.</exception>
        /// <exception cref="ArgumentNullException">Thrown if <paramref name="firstname"/> or <paramref name="lastname"/> is null.</exception>
        public Doctor(int doctorId, string firstname, string lastname)
        {
            if (doctorId <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(doctorId), "Doctor ID must be greater than 0.");
            }

            this.DoctorId = doctorId;
            this.Firstname = firstname ?? throw new ArgumentNullException(nameof(firstname), $"{nameof(firstname)} cannot be null");
            this.Lastname = lastname ?? throw new ArgumentNullException(nameof(lastname), $"{nameof(lastname)} cannot be null");
        }
    }
}
