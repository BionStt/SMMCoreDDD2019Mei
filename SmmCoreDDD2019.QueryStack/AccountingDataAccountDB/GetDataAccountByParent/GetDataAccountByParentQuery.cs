using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using SmmCoreDDD2019.Application.ViewModels.AccountingDataAccount;
using SmmCoreDDD2019.Domain.Entities;
namespace SmmCoreDDD2019.QueryStack.AccountingDataAccountDB.GetDataAccountByParent
{
    public class GetDataAccountByParentQuery : IRequest<List<AccountingDataAccount>>
    {
        
    }
}
