using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareSystem.Model
{
    public class FieldValidator
    {
        public bool Flag {  get; set; }

        public FieldValidator() 
        {
            Flag = false;
        }



        public void ValidateName(string name)
        {
            name = name.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {

            }
        }
    }
}
