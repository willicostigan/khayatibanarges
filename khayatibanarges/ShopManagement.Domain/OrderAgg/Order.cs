﻿using System.Collections.Generic;
using _0_Framework.Domain;

namespace ShopManagement.Domain.OrderAgg
{
    public class Order : EntityBase
    {
        public long AccountId { get; private set; }
        public double TotalAmount { get; private set; }
        public double DiscountAmount { get; private set; }
        public double PayAmount { get; private set; }
        public bool IsPayed { get; private set; }
        public bool IsCanceled { get; private set; }
        public string IssueTrackingNu { get; private set; }
        public long RefId { get; private set; }
        public List<OrderItem> Items { get; private set; }

        public Order(long accountId, double totalAmount, double discountAmount, double payAmount,
            string issueTrackingNu, List<OrderItem> items)
        {
            AccountId = accountId;
            TotalAmount = totalAmount;
            DiscountAmount = discountAmount;
            PayAmount = payAmount;
            IssueTrackingNu = issueTrackingNu;
            Items = items;
            IsPayed = false;
            IsCanceled = false;
            RefId = 0;
            Items = new List<OrderItem>();
        }

        public void PaymentSucceeded (long refId)
        {
            IsPayed = true;
            if (RefId != 0)
                RefId = refId;
        }

        public void Cancel()
        {
            IsCanceled = true;
        }

        public void SetIssueTrackingNumber(string number)
        {
            IssueTrackingNu = number;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
    }
}