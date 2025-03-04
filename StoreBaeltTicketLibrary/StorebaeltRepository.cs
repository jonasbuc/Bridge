using Bridge;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StoreBaeltTicketLibrary
{
    /// <summary>
    /// Repository for managing tickets at Storebæltbroen.
    /// </summary>
    public class StorebaeltRepository : IStorebaeltRepository
    {
        private static List<Vehicle> tickets = new List<Vehicle>();

        /// <summary>
        /// Adds a new ticket to the repository.
        /// </summary>
        /// <param name="ticket">The ticket to add.</param>
        public void AddTicket(Vehicle ticket)
        {
            tickets.Add(ticket);
        }

        /// <summary>
        /// Gets all tickets from the repository.
        /// </summary>
        /// <returns>A list of all tickets.</returns>
        public List<Vehicle> GetAllTickets()
        {
            return new List<Vehicle>(tickets);
        }

        /// <summary>
        /// Gets all tickets for a specified license plate.
        /// </summary>
        /// <param name="licensePlate">The license plate to search for.</param>
        /// <returns>A list of tickets for the specified license plate.</returns>
        public List<Vehicle> GetTicketsByLicensePlate(string licensePlate)
        {
            return tickets.Where(t => t.Licenseplate == licensePlate).ToList();
        }
    }
}
