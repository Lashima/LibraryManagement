using System.Collections.Generic;
using Library.Data.Models;

namespace Library.Data
{
    public interface IOwnerService
    {
        IEnumerable<Owner> GetAll();
        Owner Get(int id);
        void Add(Owner newBook);
        IEnumerable<CheckoutHistory> GetCheckoutHistory(int patronId);
        IEnumerable<Hold> GetHolds(int patronId);
        IEnumerable<Checkout> GetCheckouts(int id);
    }
}