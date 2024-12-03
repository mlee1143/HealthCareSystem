using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareSystem.Model
{
    /// <summary>
    /// Represents the specialty type of a medical professional in the health care system.
    /// Contains information about the name of the specialty.
    /// </summary>
    public class SpecialtyType
    {
        /// <summary>
        /// Gets or sets the name of the specialty.
        /// </summary>
        public string SpecialtyName { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpecialtyType"/> class with the specified specialty name.
        /// </summary>
        /// <param name="specialtyname">The name of the specialty.</param>
        /// <exception cref="ArgumentNullException">Thrown if <paramref name="specialtyname"/> is null or empty.</exception>
        public SpecialtyType(string specialtyname) 
        {
            this.SpecialtyName = specialtyname;
        }
    }
}
