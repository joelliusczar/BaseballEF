using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BaseballEF
{
    class Program
    {
        static void Main(string[] args)
        {
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions() {IsolationLevel = IsolationLevel.Serializable }))
            {
                BaseballDBEntities1 entities = BaseballDBEntities1.GetNew();
                League l = entities.Leagues.First();

                scope.Complete();
            }
                
        }
    }
}
