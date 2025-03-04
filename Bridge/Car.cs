namespace Bridge
{
    /// <summary>
    /// Repræsenterer en bil med en nummerplade og en dato.
    /// </summary>
    public class Car
    {
        /// <summary>
        /// Får eller sætter bilens nummerplade.
        /// </summary>
        public string Licenseplate;

        /// <summary>
        /// Får eller sætter bilens dato.
        /// </summary>
        public DateTime Date;

        /// <summary>
        /// Returnerer prisen på bilen.
        /// </summary>
        /// <returns>Prisen på bilen, som er fastsat til 230.</returns>
        public double Price()
        {
            return 230;
        }

        /// <summary>
        /// Returnerer køretøjstypen.
        /// </summary>
        /// <returns>En streng, der repræsenterer køretøjstypen, som er "Car".</returns>
        public string VehicleType()
        {
            return "Car";
        }
    }
}
