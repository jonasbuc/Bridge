namespace Bridge
{
    /// <summary>
    /// Repræsenterer en bil.
    /// </summary>
    public class Car : Vehicle
    {
        /// <summary>
        /// Returnerer prisen på bilen.
        /// </summary>
        /// <returns>Prisen på bilen, som er fastsat til 230.</returns>
        public override double Price()
        {
            return 230;
        }

        /// <summary>
        /// Returnerer køretøjstypen.
        /// </summary>
        /// <returns>En streng, der repræsenterer køretøjstypen, som er "Car".</returns>
        public override string VehicleType()
        {
            return "Car";
        }
    }
}
