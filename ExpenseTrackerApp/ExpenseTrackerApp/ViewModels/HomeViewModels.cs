using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using ExpenseTrackerApp.Interfaces;

namespace ExpenseTrackerApp.ViewModels
{
        public class HomeViewModel
        {
            private readonly IExpenseService _service;

            public int TotalExpenses => _service.GetAllExpenses().Count;
            public decimal TotalAmount => _service.GetAllExpenses().Sum(x => x.Amount);

            public HomeViewModel(IExpenseService service)
            {
                _service = service;
            }
        }
 }
