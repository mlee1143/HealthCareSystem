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

        public string? Firstname { get; private set; }

        public string? Lastname { get; private set; }

        public DateTime Birthdate { get; private set; }
        
        public Gender Gender { get; private set; }

        public string Address { get; private set; }

        public string City { get; private set; }

        public State State { get; private set; } //ENUM || string

        public string? Country { get; private set; }

        public int ZipCode { get; private set; }

        public string? PhoneNumber { get; private set; }

        public string? Username { get; private set; }

        public string? Password { get; private set; }

        public Nurse(string? firstname, string? lastname, string? username, string? password)
        {
            // Pre-condition checks
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Username = username;
            this.Password = password;
        }




    }
}
