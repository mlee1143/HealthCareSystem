using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareSystem.Model
{
    public class Nurse
    {
        public int NurseId { get; set; }

        public string Firstname { get; private set; }

        public string Lastname { get; private set; }

        public DateTime Birthdate { get; private set; }
        
        public Gender Gender { get; private set; }

        public string? Address { get; private set; }

        public string City { get; private set; }

        public States State { get; private set; }

        public string Country { get; private set; } // enum?

        public int ZipCode { get; private set; }

        public string PhoneNumber { get; private set; }

        public string Username { get; private set; }

        public string Password { get; private set; }

        public Nurse(string? firstname, string? lastname, Gender? gender, string? address, string? city, string? country, int zipcode, string? phoneNumber, string? username, string? password)
        {
            this.Firstname = firstname ?? throw new ArgumentNullException(nameof(firstname), $"{nameof(firstname)} cannot be null");
            //this.BirthDate = birthdate ?? throw new ArgumentNullException(nameof(birthdate), $"{nameof(birthdate)} cannot be null");
            this.Lastname = lastname ?? throw new ArgumentNullException(nameof(lastname), $"{nameof(lastname)} cannot be null");
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
