﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoRSample
{
    /// <summary>
    /// 采购单类，充当请求类
    /// </summary>
    public class PurchaseRequest
    {
        private double amount;          //采购金额
        private int number;                 //采购单编号
        private string purpose;             //采购目的

        public PurchaseRequest(double amount ,int number ,string purpose)
        {
            this.amount = amount;
            this.number = number;
            this.purpose = purpose;
        }

        public double Amount { get; set; }
        public int Number { get; set; }
        public string Purpose { get; set; }

    }
}
