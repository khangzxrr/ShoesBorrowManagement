﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesBorrowManagement.Objects
{
    public class BorrowedShoe
    {
        [DisplayName("ID")]
        [Browsable(false)]
        public long idShoe {get;set;}
        [DisplayName("Tên giày")]
        public string shoeName {get;set;}
        [DisplayName("Ngày mượn")]
        public DateTime date { get;set;}

        public BorrowedShoe(long idShoe, string shoeName, DateTime date)
        {
            this.idShoe = idShoe;
            this.shoeName = shoeName;
            this.date = date;
        }
    }
}
