using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareSystem.Model
{
    /// <summary>
    /// Represents an Administrator in the Health Care System.
    /// Contains personal and authentication details for administrative operations.
    /// </summary>
    public class Administrator
    {
        /// <summary>
        /// Gets or sets the unique identifier for the administrator.
        /// </summary>
        public int AdministratorId { get; set; }

        /// <summary>
        /// Gets the first name of the administrator. This value is read-only.
        /// </summary
        public string Firstname { get; private set; }

        /// <summary>
        /// Gets the last name of the administrator. This value is read-only.
        /// </summary>
        public string Lastname { get; private set; }

        /// <summary>
        /// Gets the birthdate of the administrator. This value is read-only.
        /// </summary>
        public DateTime Birthdate { get; private set; }

        /// <summary>
        /// Gets the gender of the administrator. This value is read-only and optional.
        /// </summary>
        public Gender? Gender { get; private set; }

        /// <summary>
        /// Gets the address of the administrator. This value is read-only and optional.
        /// </summary>
        public string? Address { get; private set; }

        /// <summary>
        /// Gets the city of the administrator. This value is read-only and optional.
        /// </summary>
        public string? City { get; private set; }

        /// <summary>
        /// Gets the state of the administrator. This value is read-only and optional.
        /// </summary>
        public States? State { get; private set; }

        /// <summary>
        /// Gets the country of the administrator. This value is read-only and optional.
        /// </summary>
        public string? Country { get; private set; }

        /// <summary>
        /// Gets the ZIP code of the administrator. This value is read-only and optional.
        /// </summary>
        public int? ZipCode { get; private set; }

        /// <summary>
        /// Gets the phone number of the administrator. This value is read-only and optional.
        /// </summary>
        public string? PhoneNumber { get; private set; }

        /// <summary>
        /// Gets the username used by the administrator for authentication. This value is read-only.
        /// </summary>
        public string Username { get; private set; }

        /// <summary>
        /// Gets the password used by the administrator for authentication. This value is read-only.
        /// </summary>
        public string Password { get; private set; }

        /// <summary>
        /// Initializes a new instance of the Administrator class with required details.
        /// Validates input and throws exceptions for invalid data.
        /// </summary>
        /// <param name="firstname">The first name of the administrator.</param>
        /// <param name="lastname">The last name of the administrator.</param>
        /// <param name="birthdate">The birthdate of the administrator.</param>
        /// <param name="gender">The gender of the administrator (optional).</param>
        /// <param name="address">The address of the administrator (optional).</param>
        /// <param name="city">The city of the administrator (optional).</param>
        /// <param name="country">The country of the administrator (optional).</param>
        /// <param name="zipcode">The ZIP code of the administrator.</param>
        /// <param name="phoneNumber">The phone number of the administrator.</param>
        /// <param name="username">The username for the administrator's account.</param>
        /// <param name="password">The password for the administrator's account.</param>
        /// <exception cref="ArgumentNullException">Thrown if required fields are null.</exception>
        public Administrator(string? firstname, string? lastname, DateTime birthdate, Gender? gender, string? address, string? city, string? country, int zipcode, string? phoneNumber, string? username, string? password) 
        {
            this.Firstname = firstname ?? throw new ArgumentNullException(nameof(firstname), $"{nameof(firstname)} cannot be null");
            this.Lastname = lastname ?? throw new ArgumentNullException(nameof(lastname), $"{nameof(lastname)} cannot be null");
            this.Birthdate = birthdate;
            this.Gender = gender ?? throw new ArgumentNullException(nameof(gender), $"{nameof(lastname)} cannot be null");
            this.Address = address ?? throw new ArgumentNullException(nameof(address), $"{nameof(address)} cannot be null");
            this.City = city ?? throw new ArgumentNullException(nameof(city), $"{nameof(city)} cannot be null");
            this.Country = country ?? throw new ArgumentNullException(nameof(country), $"{nameof(country)} cannot be null");
            if (zipcode < 0 && zipcode > 99999)
            {
                throw new ArgumentOutOfRangeException(nameof(zipcode), $" {nameof(zipcode)} cannot be negative and cannot be greater than 5 digits.");
            }
            this.ZipCode = zipcode;
            this.PhoneNumber = phoneNumber ?? throw new ArgumentNullException(nameof(phoneNumber), $"{nameof(phoneNumber)} cannot be null");
            this.Username = username ?? throw new ArgumentNullException(nameof(username), $"{nameof(username)} cannot be null");
            this.Password = password ?? throw new ArgumentNullException(nameof(password), $"{nameof(password)} cannot be null");
        }

    }
}
