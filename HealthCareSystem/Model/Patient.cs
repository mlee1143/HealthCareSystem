﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareSystem.Model
{
    public class Patient
    {
        public int PatientId { get;  set; }

        public string Firstname { get;  set; }

        public string? MiddleInitial {  get;  set; }

        public string Lastname { get;  set; }

        public string FullName { get; private set; }

        public DateTime Birthdate { get;  set; }

        public Gender Gender { get;  set; }

        public string? Address { get;  set; }

        public string? City { get;  set; }

        public States? State { get;  set; }

        public string? Country { get;  set; }

        public int? ZipCode { get;  set; }

        public string? PhoneNumber { get;  set; }

        public int IsActive { get;  set; } // bool

        //public Symptom PatientSymptom { get;  set; }

        public Patient(string firstname, string lastname, DateTime birthdate, Gender gender, int isActive)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Birthdate = birthdate;
            this.Gender = gender;
            this.IsActive = isActive;

            this.FullName = firstname + " " + lastname;
        }
    }
}
