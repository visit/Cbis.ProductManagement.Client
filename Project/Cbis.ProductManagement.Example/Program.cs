using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cbis.ProductManagement.Example
{
    using System.IO;

    using Cbis.ProductManagement.Client;

    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine(string.Format("Usage: {0} [username] [password]", Path.GetFileName(System.Reflection.Assembly.GetEntryAssembly().Location)));
                return;
            }

            CbisSupplierManagementClient client = new CbisSupplierManagementClient("InformationSystemManagementEndpoint", args[0], args[1]);

            var cats = client.GetCategories();

            foreach (var item in cats)
            {
                Console.WriteLine(item.Id + "\t" + item.Name);
            }
        }
    }
}
