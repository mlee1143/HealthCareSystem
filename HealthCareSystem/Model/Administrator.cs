using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareSystem.Model
{
    public class Administrator
    {
        public int AdministratorId { get; private set; }

        public string Firstname { get; private set; }

        public string Lastname { get; private set; }

        public DateTime Birthdate { get; private set; }

        public Gender Gender { get; private set; }

        public string? Address { get; private set; }

        public string? City { get; private set; }

        public States? State { get; private set; }

        public string? Country { get; private set; }

        public int? ZipCode { get; private set; }

        public string? PhoneNumber { get; private set; }

        public string Username { get; private set; }

        public string Password { get; private set; }

        public Administrator(string firstname, string lastname, DateTime birthdate, Gender gender, string username, string password) 
        {
            // Pre-condition checks
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Birthdate = birthdate;
            this.Gender = gender;
            this.Username = username;
            this.Password = password;
        }

    }
}
