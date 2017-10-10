using Movie_Renta_Web_App.Models;
using System.Collections.Generic;

namespace Movie_Renta_Web_App.ViewModels
{
    public class CustomerFroViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}