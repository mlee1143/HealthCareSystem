using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareSystem.Model
{
    public class SpecialtyType
    {
        public string SpecialtyName { get; set; }

        public SpecialtyType(string specialtyname) 
        {
            this.SpecialtyName = specialtyname;
        }
    }
}
