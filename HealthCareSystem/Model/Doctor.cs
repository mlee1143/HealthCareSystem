using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareSystem.Model
{
    public class Doctor
    {
        public int DoctorId { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public DateTime Birthdate { get; set; }

        public Gender Gender { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public States? State { get; set; }

        public string? Country { get; set; }

        public int? ZipCode { get; set; }

        public string? PhoneNumber { get; set; }

        public SpecialtyType DoctorSpecialtyType { get; set; }

        public Doctor(int doctorId, string firstname, string lastname)
        {
            this.DoctorId = doctorId;
            this.Firstname = firstname;
            this.Lastname = lastname;
        }
    }
}
