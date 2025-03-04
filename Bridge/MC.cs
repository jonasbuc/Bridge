namespace Bridge
{
    /// <summary>
    /// Repræsenterer en motorcykel.
    /// </summary>
    public class MC : Vehicle
    {
        /// <summary>
        /// Returnerer prisen på motorcyklen.
        /// </summary>
        /// <returns>Prisen på motorcyklen, som er fastsat til 120.</returns>
        public override double Price()
        {
            return 120;
        }

        /// <summary>
        /// Returnerer køretøjstypen.
        /// </summary>
        /// <returns>En streng, der repræsenterer køretøjstypen, som er "MC".</returns>
        public override string VehicleType()
        {
            return "MC";
        }
    }
}
