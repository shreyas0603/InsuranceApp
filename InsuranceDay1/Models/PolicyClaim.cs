﻿using System.ComponentModel.DataAnnotations.Schema;

namespace InsuranceDay1.Models
{
    public class PolicyClaim
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public InsurancePlan InsurancePlan { get; set; }
        [ForeignKey("InsurancePlan")]
        public int InsurancePlanId { get;set; }
        public DateTime WithdrawalDate { get; } = DateTime.Now;
        public string BankName { get; set; }
        public double WithdrawalAmount { get; set; }

    }
}
