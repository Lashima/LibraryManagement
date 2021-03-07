using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Library.Data;
using Library.Web.Models.Patron;


namespace LibraryWeb.Controllers
{
    public class OwnerController : Controller
    {
        private readonly IOwnerService _ownerService;

        public OwnerController(IOwnerService ownerService)
        {
            _ownerService = ownerService;
        }

        public IActionResult Index()
        {
            var allPatrons = _ownerService.GetAll();

            var patronModels = allPatrons
                .Select(p => new PatronDetailModel
                {
                    Id = p.Id,
                    LastName = p.LastName ?? "No First Name Provided",
                    FirstName = p.FirstName ?? "No Last Name Provided",
                    LibraryCardId = p.LibraryCard?.Id,
                    OverdueFees = p.LibraryCard?.Fees,
                    HomeLibrary = p.HomeLibraryBranch?.Name
                }).ToList();

            var model = new PatronIndexModel
            {
                Owners = patronModels
            };

            return View(model);
        }

        public IActionResult Detail(int id)
        {
            var patron = _ownerService.Get(id);

            var model = new PatronDetailModel
            {
                Id = patron.Id,
                LastName = patron.LastName ?? "No Last Name Provided",
                FirstName = patron.FirstName ?? "No First Name Provided",
                Address = patron.Address ?? "No Address Provided",
                HomeLibrary = patron.HomeLibraryBranch?.Name ?? "No Home Library",
                MemberSince = patron.LibraryCard?.Created,
                OverdueFees = patron.LibraryCard?.Fees,
                LibraryCardId = patron.LibraryCard?.Id,
                Telephone = string.IsNullOrEmpty(patron.Telephone) ? "No Telephone Number Provided" : patron.Telephone,
                AssetsCheckedOut = _ownerService.GetCheckouts(id).ToList(),
                CheckoutHistory = _ownerService.GetCheckoutHistory(id),
                Holds = _ownerService.GetHolds(id)
            };

            return View(model);
        }
    }
}