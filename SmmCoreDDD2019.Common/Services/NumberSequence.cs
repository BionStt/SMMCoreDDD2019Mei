using SmmCoreDDD2019.Common.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Common.Services
{
    public class NumberSequence : INumberSequence
    {
        private readonly AppIdentityDbContext _context;

        public NumberSequence(AppIdentityDbContext context)
        {
            _context = context;
        }

        public string GetNumberSequence(string module)
        {
            string result = "";
            try
            {
                int counter = 0;

                Common.Identity.NumberSequence numberSequence = _context.NumberSequence
                    .Where(x => x.Module.Equals(module))
                    .FirstOrDefault();

                if (numberSequence == null)
                {
                    numberSequence = new Common.Identity.NumberSequence();
                    numberSequence.Module = module;
                    Interlocked.Increment(ref counter);
                    numberSequence.LastNumber = counter;
                    numberSequence.NumberSequenceName = module;
                    numberSequence.Prefix = module;

                    _context.Add(numberSequence);
                    _context.SaveChanges();
                }
                else
                {
                    counter = numberSequence.LastNumber;

                    Interlocked.Increment(ref counter);
                    numberSequence.LastNumber = counter;

                    _context.Update(numberSequence);
                    _context.SaveChanges();
                }

                result = counter.ToString().PadLeft(5, '0') + "#" + numberSequence.Prefix;
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }
    }
}
