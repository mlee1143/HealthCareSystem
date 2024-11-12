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

        public int? NurseID { get;  set; }

        public double Weight { get; private set; }

        public double Height { get; private set; }

        public int BloodPressure { get;  set; }

        public int? Pulse { get;  set; }

        public double? Temperature { get;  set; }

        public string? InitialDiagnosis { get;  set; }

        public string? FinalDiagnosis { get;  set; }

        public string SymptomsDescription { get;  set; }

        public Visit(Appointment appointment, double weight, double height, int bloodPressure, string symptomsDescription)
        {
            this.Appointment = appointment;
            this.Weight = weight;
            this.Height = height;
            this.BloodPressure = bloodPressure;
            this.SymptomsDescription = symptomsDescription;
        } 
        

        

    }
}
