using System.Collections.Generic;
using System.Linq;
using Library.Data;
using Library.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Service
{
    public class OwnerService : IOwnerService
    {
        private readonly LibraryDbContext _context;

        public OwnerService(LibraryDbContext context)
        {
            _context = context;
        }

        public void Add(Owner newOwner)
        {
            _context.Add(newOwner);
            _context.SaveChanges();
        }

        public Owner Get(int id)
        {
            return _context.Owners
                .Include(a => a.LibraryCard)
                .Include(a => a.HomeLibraryBranch)
                .FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Owner> GetAll()
        {
            return _context.Owners
                .Include(a => a.LibraryCard)
                .Include(a => a.HomeLibraryBranch);
          
        }

        public IEnumerable<CheckoutHistory> GetCheckoutHistory(int patronId)
        {
            var cardId = _context.Owners
                .Include(a => a.LibraryCard)
                .FirstOrDefault(a => a.Id == patronId)?
                .LibraryCard.Id;

            return _context.CheckoutHistories
                .Include(a => a.LibraryCard)
                .Include(a => a.LibraryAsset)
                .Where(a => a.LibraryCard.Id == cardId)
                .OrderByDescending(a => a.CheckedOut);
        }

        public IEnumerable<Checkout> GetCheckouts(int id)
        {
            var patronCardId = Get(id).LibraryCard.Id;
            return _context.Checkouts
                .Include(a => a.LibraryCard)
                .Include(a => a.LibraryAsset)
                .Where(v => v.LibraryCard.Id == patronCardId);
        }

        public IEnumerable<Hold> GetHolds(int patronId)
        {
            var cardId = _context.Owners
                .Include(a => a.LibraryCard)
                .FirstOrDefault(a => a.Id == patronId)?
                .LibraryCard.Id;

            return _context.Holds
                .Include(a => a.LibraryCard)
                .Include(a => a.LibraryAsset)
                .Where(a => a.LibraryCard.Id == cardId)
                .OrderByDescending(a => a.HoldPlaced);
        }
    }
}