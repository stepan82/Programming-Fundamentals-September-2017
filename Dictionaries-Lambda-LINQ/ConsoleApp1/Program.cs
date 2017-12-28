using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            var emailsData = new Dictionary<string, string>();
            while (true)
            {
                string name = Console.ReadLine();

                if (name == "stop")
                {
                    break;
                }

                string email = Console.ReadLine();

                emailsData.Add(name, email);
            }
           
            foreach (var item in emailsData.ToList())
            {
                if (item.Value.EndsWith(".uk") || 
                    item.Value.EndsWith(".us"))
                {
                    emailsData.Remove(item.Key);
                }
            }
            foreach (var record in emailsData)
            {
                Console.WriteLine("{0} -> {1}", record.Key, record.Value);
            }
        }
    }
}
