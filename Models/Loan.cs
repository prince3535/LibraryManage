﻿namespace LibraryManage.Models
{
    public class Loan
    {
        public int LoanId { get; set; }
        public int  BookId { get; set; }
        public int MemberId { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime ReturnDate { get; set; }

    }
}
