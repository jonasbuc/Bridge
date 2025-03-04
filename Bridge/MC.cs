using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    /// <summary>
    /// Repræsenterer en motorcykel med en nummerplade og en dato.
    /// </summary>
    public class MC
    {
        /// <summary>
        /// Får eller sætter motorcyklens nummerplade.
        /// </summary>
        public string Licenseplate;

        /// <summary>
        /// Får eller sætter motorcyklens dato.
        /// </summary>
        public DateTime date;

        /// <summary>
        /// Returnerer prisen på motorcyklen.
        /// </summary>
        /// <returns>Prisen på motorcyklen, som er fastsat til 120.</returns>
        public double Price()
        {
            return 120;
        }

        /// <summary>
        /// Returnerer køretøjstypen.
        /// </summary>
        /// <returns>En streng, der repræsenterer køretøjstypen, som er "MC".</returns>
        public string vihicleType()
        {
            return "MC";
        }
    }
}
