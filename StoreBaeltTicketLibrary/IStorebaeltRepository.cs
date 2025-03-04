using Bridge;
using System.Collections.Generic;

namespace StoreBaeltTicketLibrary
{
    /// <summary>
    /// Interface for the Storebælt repository.
    /// </summary>
    public interface IStorebaeltRepository
    {
        void AddTicket(Vehicle ticket);
        List<Vehicle> GetAllTickets();
        List<Vehicle> GetTicketsByLicensePlate(string licensePlate);
    }
}
