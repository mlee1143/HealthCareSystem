using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareSystem.Model
{
    public class Patient
    {
        public int PatientId { get; private set; }

        public string Firstname { get; private set; }

        public string? MiddleInitial {  get; private set; }

        public string Lastname { get; private set; }

        public DateTime Birthdate { get; private set; }

        public Gender Gender { get; private set; }

        public string? Address { get; private set; }

        public string? City { get; private set; }

        public States? State { get; private set; } //ENUM || string

        public string? Country { get; private set; }

        public int? ZipCode { get; private set; }

        public string? PhoneNumber { get; private set; }

        public bool IsActive { get; private set; }

        public Symptom PatientSymptom { get; private set; }

        public Patient(string firstname, string lastname, DateTime birthdate, Gender gender, bool isActive, Symptom symptom)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Birthdate = birthdate;


            this.IsActive = isActive;

            this.PatientSymptom = symptom;

        }
    }
}
