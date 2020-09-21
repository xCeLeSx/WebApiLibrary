using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsLibrary.Models
{
    class Borrow
    {
        public int BorrowId { get; set; }
        public int? BookId { get; set; }
        public int? UserId { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public Boolean Return { get; set; }

    }
}
