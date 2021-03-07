using System.Collections.Generic;

namespace Library.Web.Models.Patron
{
    public class PatronIndexModel
    {
        public IEnumerable<PatronDetailModel> Owners { get; set; }
    }
}