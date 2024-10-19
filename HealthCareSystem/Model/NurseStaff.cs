using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareSystem.Model
{
    public class NurseStaff
    {
        private IList<Nurse> nursingStaff;

        public IList<Nurse> NursingStaff => nursingStaff;

        public Nurse this[int i] => this.nursingStaff[i];

        public NurseStaff() 
        {
            this.nursingStaff = new List<Nurse>();
        }

    }
}
