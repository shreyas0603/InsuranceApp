﻿namespace InsuranceDay1.Models
{
    public class CommisionWithdrawal
    {
        public int Id { get; set; }
        public DateTime RequestDate { get; } = DateTime.Now;
        //public bool IsPaid {get; set;} 
        public double WithdrawalAmount { get; set; }
        public double TotalWithdrawalAmount { get; set; }
        public bool IsApproved { get; set; }

    }
}
