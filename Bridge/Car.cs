namespace Bridge
{
    /// <summary>
    /// Repræsenterer en bil.
    /// </summary>
    public class Car : Vehicle
    {
        /// <summary>
        /// Angiver, om en Brobizz bruges.
        /// </summary>
        public bool IsBrobizzUsed { get; set; }

        /// <summary>
        /// Returnerer prisen på bilen.
        /// </summary>
        /// <returns>Prisen på bilen, som er fastsat til 230, med en 10% rabat, hvis en Brobizz bruges.</returns>
        public override double Price()
        {
            double price = 230;
            if (IsBrobizzUsed)
            {
                price *= 0.9; // Giver 10% discount
            }
            return price;
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

