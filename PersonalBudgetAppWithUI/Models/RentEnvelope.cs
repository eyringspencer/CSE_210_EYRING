using PersonalBudgetAppWithUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBudgetAppWithUI.Models;

public class RentEnvelope : EssentialExpenseEnvelope
{ 

    ///<summary>
    ///This is one of the child classes of EssentialExpenseEnvelope. It will be used to represent rent payments.
    /// </summary>
    

    //PROPERTIES



    //CONSTRUCTOR

    public RentEnvelope(string name, decimal amountAllocated, DateTime dueDate, decimal amountDue) 
        : base(name, amountAllocated, dueDate, amountDue)
    {
     
    }

    //METHODS

}
