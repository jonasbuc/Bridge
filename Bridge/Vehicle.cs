namespace Bridge
{
    /// <summary>
    /// Repræsenterer et køretøj med en nummerplade og en dato.
    /// </summary>
    public abstract class Vehicle
    {
        /// <summary>
        /// Får eller sætter køretøjets nummerplade.
        /// </summary>
        public string Licenseplate { get; set; }

        /// <summary>
        /// Får eller sætter køretøjets dato.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Returnerer prisen på køretøjet.
        /// </summary>
        /// <returns>Prisen på køretøjet.</returns>
        public abstract double Price();

        /// <summary>
        /// Returnerer køretøjstypen.
        /// </summary>
        /// <returns>En streng, der repræsenterer køretøjstypen.</returns>
        public abstract string VehicleType();
    }
}