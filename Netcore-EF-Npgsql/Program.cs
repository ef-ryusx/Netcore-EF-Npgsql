using System;
using System.Linq;
using Database.NpgsqlEF;

namespace Netcore_EF_Npgsql
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var context = new DatabaseContext())
            {
                var __ = context.Members.ToList();

            }
        }
    }
}
