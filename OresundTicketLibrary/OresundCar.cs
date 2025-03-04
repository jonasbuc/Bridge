using Bridge;

namespace OresundTicketLibrary
{
    /// <summary>
    /// Repræsenterer en bil, der kører over Øresundsbroen.
    /// </summary>
    public class OresundCar : Vehicle
    {
        /// <summary>
        /// Angiver, om en Brobizz bruges.
        /// </summary>
        public bool IsBrobizzUsed { get; set; }

        /// <summary>
        /// Returnerer prisen på bilen.
        /// </summary>
        /// <returns>Prisen på bilen, som er fastsat til 460, eller 178, hvis en Brobizz bruges.</returns>
        public override double Price()
        {
            return IsBrobizzUsed ? 178 : 460;
        }

        /// <summary>
        /// Returnerer køretøjstypen.
        /// </summary>
        /// <returns>En streng, der repræsenterer køretøjstypen, som er "Oresund car".</returns>
        public override string VehicleType()
        {
            return "Oresund car";
        }
    }
}
