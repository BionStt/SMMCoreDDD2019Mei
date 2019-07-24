using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using SmmCoreDDD2019.Domain.Entities;

namespace SmmCoreDDD2019.CommandStack.AccountingDataAccountDB.CreateAccountingDataAccount
{
    public class CreateAccountingDataAccountCommand:IRequest
    {
        // public AccountingDataAccount[] AccountingDataAccounts { get; set; }
        // public int NoUrutAccountId { get; set; }
        // public int Lft { get; set; }
        //  public int Rgt { get; set; }
        public string Parent { get; set; }
        //  public int Depth { get; set; }
      
        public string KodeAccount { get; set; }
      
        public string Account { get; set; }
   
        public int NormalPos { get; set; }
    
        public string Kelompok { get; set; }
    
        public int AccountingDataMataUangId { get; set; }

    }
}
