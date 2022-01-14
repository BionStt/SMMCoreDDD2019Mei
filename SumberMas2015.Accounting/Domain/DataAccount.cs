using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Accounting.Domain
{
    public class DataAccount
    {
        private DataAccount(string parent, string kodeAccount, string account, int? normalPos, string kelompok)
        {
            Parent = parent;
            KodeAccount = kodeAccount;
            Account = account;
            NormalPos = normalPos;
            Kelompok = kelompok;
        }

        protected DataAccount()
        {

        }
        public Guid DataAccountId { get; private set; }
        public int NoUrutId { get; set; }


        public int? Lft { get; private set; }
        public int? Rgt { get; private set; }
        public int? Depth { get; private set; }

        public string Parent { get; private set; }
        public string KodeAccount { get; private set; }
        public string Account { get; private set; }
        public int? NormalPos { get; private set; }
        public string Kelompok { get; private set; }
        public string Aktif { get; private set; }
        // public string Alias {get;set;} //utk bhs inggris ?
        //  public int? DataMataUangId { get; set; }

        public static DataAccount CreateDataAccount(string parent, string kodeAccount, string account, int? normalPos, string kelompok)
        {
            return new DataAccount(parent, kodeAccount, account, normalPos, kelompok);
        }
    }
}
