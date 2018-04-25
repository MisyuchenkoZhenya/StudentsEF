using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Students.context.TPC;
using Students.context.TPH;
using Students.context.TPT;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ContextTPC db = new ContextTPC())
            {
                db.Database.Initialize(false);
                db.SaveChanges();
            }

            using (ContextTPH db = new ContextTPH())
            {
                db.Database.Initialize(false);
                db.SaveChanges();
            }

            using (ContextTPT db = new ContextTPT())
            {
                db.Database.Initialize(false);
                db.SaveChanges();
            }
        }
    }
}
