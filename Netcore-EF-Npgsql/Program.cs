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
				Console.WriteLine($"Id:{__[0].Id}, Name:{__[0].Name}"); // Id:1, Name:test1
				Console.WriteLine($"Id:{__[1].Id}, Name:{__[1].Name}"); // Id:2, Name:test2
			}
        }
    }
}
