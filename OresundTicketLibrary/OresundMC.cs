using Bridge;

namespace OresundTicketLibrary
{
    /// <summary>
    /// Repræsenterer en motorcykel, der kører over Øresundsbroen.
    /// </summary>
    public class OresundMC : Vehicle
    {
        /// <summary>
        /// Angiver, om en Brobizz bruges.
        /// </summary>
        public bool IsBrobizzUsed { get; set; }

        /// <summary>
        /// Returnerer prisen på motorcyklen.
        /// </summary>
        /// <returns>Prisen på motorcyklen, som er fastsat til 235, eller 92, hvis en Brobizz bruges.</returns>
        public override double Price()
        {
            return IsBrobizzUsed ? 92 : 235;
        }

        /// <summary>
        /// Returnerer køretøjstypen.
        /// </summary>
        /// <returns>En streng, der repræsenterer køretøjstypen, som er "Oresund MC".</returns>
        public override string VehicleType()
        {
            return "Oresund MC";
        }
    }
}
