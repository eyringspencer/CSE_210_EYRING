using Avalonia.Automation.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBudgetAppWithUI.Models;


public class UtilitiesEnvelope : EssentialExpenseEnvelope
{
    //PROPERTIES

    public decimal ProjectedBill { get; set; } = 0.0m;

    public decimal DiscrepancyAmount => ProjectedBill - AmountDue;



    //CONSTRUCTOR
    public UtilitiesEnvelope(string name, decimal amountAllocated, DateTime dueDate, decimal amountDue, decimal projectedBill) : base(name, amountAllocated, dueDate, amountDue)
    {
        ProjectedBill = projectedBill;
    }

    //METHODS
}
