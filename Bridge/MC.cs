namespace Bridge
{
    /// <summary>
    /// Repræsenterer en motorcykel.
    /// </summary>
    public class MC : Vehicle
    {
        /// <summary>
        /// Angiver, om en Brobizz bruges.
        /// </summary>
        public bool IsBrobizzUsed { get; set; }

        /// <summary>
        /// Returnerer prisen på motorcyklen.
        /// </summary>
        /// <returns>Prisen på motorcyklen, som er fastsat til 120, med en 10% rabat, hvis en Brobizz bruges.</returns>
        public override double Price()
        {
            double price = 120;
            if (IsBrobizzUsed)
            {
                price *= 0.9; // Apply 10% discount
            }
            return price;
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
