﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Model
{
    internal class PaymentRule : Entity, IPaymentRule
    {
        public IPaymentRuleCatalog PaymentRuleCatalog { get; set; }
        public ReferenceDate ReferenceDate { get; set; }
        // PaymentDate should probably be called "PaymentDaysOffset" as it is the number of days payment is offset from the ReferenceDate
        public int PaymentDate { get; set; }
        public decimal Percentage { get; set; }
        public string Description { get; set; }

        public PaymentRule()
        { }

        public PaymentRule(IPaymentRule iPaymentRule)
        {
            Id = iPaymentRule.Id;
            Deleted = iPaymentRule.Deleted;
            LastUpdated = iPaymentRule.LastUpdated;

            PaymentRuleCatalog = iPaymentRule.PaymentRuleCatalog;
            ReferenceDate = iPaymentRule.ReferenceDate;
            PaymentDate = iPaymentRule.PaymentDate;
            Percentage = iPaymentRule.Percentage;
            Description = iPaymentRule.Description;
        }

        public PaymentRule(IPaymentRuleCatalog iPaymentRuleCatalog)
        {
            PaymentRuleCatalog = iPaymentRuleCatalog;
        }
    }
}
