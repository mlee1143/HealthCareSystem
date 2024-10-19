using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareSystem.Model
{
    public class Symptom
    {
        public string Description { get; private set; }

        public Symptom(string description) 
        {
            this.Description = description;
        }
    }
}
