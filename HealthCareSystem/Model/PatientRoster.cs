using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareSystem.Model
{
    public class PatientRoster
    {
        private IList<Patient> patientRoster;

        public IList<Patient> PatientsRoster => patientRoster;

        public Patient this[int i] => this.patientRoster[i];

        public PatientRoster()
        {
            this.patientRoster = new List<Patient>();
        }
    }
}
