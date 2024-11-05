using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareSystem.Model
{
    public class Visit
    {
        public Appointment Appointment { get; private set; }

        public Nurse? Nurse { get;  set; }

        public double Weight { get; private set; }

        public double Height { get; private set; }

        public string BloodPressure { get;  set; }

        public string? Pulse { get;  set; }

        public double? Temperature { get;  set; }

        public string? InitialDiagnosis { get;  set; }

        public string? FinalDiagnosis { get;  set; }

        public string? SymptomsDescription { get;  set; }

        public Visit(Appointment appointment, double weight, double height, string bloodPressure)
        {
            this.Appointment = appointment;
            this.Weight = weight;
            this.Height = height;
            this.BloodPressure = bloodPressure;
        } 
        

        

    }
}
