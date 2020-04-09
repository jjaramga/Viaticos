﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Viaticos.Common.Models
{
    public class TripDetailResponse
    {
        public int Id { get; set; }

        public ExpenseTypeResponse TypeExpense { get; set; } //Prediction - Match

        public DateTime Date { get; set; }

        public decimal Amount { get; set; }

        public string Description { get; set; }

        public string PicturePath { get; set; }

        
    }
}
