namespace Bridge
{
    /// <summary>
    /// Repræsenterer et køretøj med en nummerplade og en dato.
    /// </summary>
    public abstract class Vehicle
    {
        private string licenseplate;

        /// <summary>
        /// Får eller sætter køretøjets nummerplade.
        /// </summary>
        /// <exception cref="ArgumentException">Kastes, hvis nummerpladen er længere end 7 tegn.</exception>
        public string Licenseplate
        {
            get => licenseplate;
            set
            {
                if (value.Length > 7)
                {
                    throw new ArgumentException("Nummerpladen må ikke være længere end 7 tegn.");
                }
                licenseplate = value;
            }
        }

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
