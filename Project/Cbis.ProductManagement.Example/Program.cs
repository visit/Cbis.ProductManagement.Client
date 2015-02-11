using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cbis.ProductManagement.Example
{
    using System.IO;

    using Cbis.ProductManagement.Client;
    using Cbis.ProductManagement.Client.Generated;

    using ReferenceName = Cbis.ProductManagement.Client.ReferenceName;

    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length < 3)
            {
                PrintHelp();
                return;
            }

            CbisSupplierManagementClient client = new CbisSupplierManagementClient("InformationSystemManagementEndpoint", args[0], args[1]);

            switch (args[2])
            {
                case "categories":
                    HandleCategories(client);
                    break;

                case "prodlist":
                    HandleProductList(client, args.Skip(3).ToList());
                    break;

                case "reflist":
                    ListReferences(client, args.Skip(3).ToList());
                    break;

                case "addref":
                    AddReference(client, args.Skip(3).ToList());
                    break;

                case "removeref":
                    RemoveReference(client, args.Skip(3).ToList());
                    break;

                case "setcat":
                    SetCategory(client, args.Skip(3).ToList());
                    break;

                default:
                    PrintHelp();
                    break;
            }
        }

        private static void PrintHelp()
        {
            Console.WriteLine(string.Format("Usage: {0} [username] [password] [function] (additional argumuents)", Path.GetFileName(System.Reflection.Assembly.GetEntryAssembly().Location)));
            Console.WriteLine("Actions are:");
            Console.WriteLine("\tcategories\tLists all available categories");
            Console.WriteLine("\tprodlist\tLists products (additional args available)");
            Console.WriteLine("\taddref\tLists all available categories");
            Console.WriteLine("\tremoveref\tLists all available categories");
        }

        private static void AddReference(CbisSupplierManagementClient client, List<string> list)
        {
            if (list.Count != 2)
            {
                Console.WriteLine(string.Format("Usage: {0} [username] [password] addref [subsystem:id (existing ref)] [subsystem:id (ref to add)]", 
                    Path.GetFileName(System.Reflection.Assembly.GetEntryAssembly().Location)));
                return;
            }

            ReferenceName target = new ReferenceName(list[0]);
            ReferenceName newName = new ReferenceName(list[1]);

            client.ModifyProductReferences(
                null,
                target,
                new List<ReferenceName>() { newName },
                new List<ReferenceName>());
        }

        private static void RemoveReference(CbisSupplierManagementClient client, List<string> list)
        {
            if(list.Count != 2)
            {
                Console.WriteLine(string.Format("Usage: {0} [username] [password] removeref [subsystem:id]", Path.GetFileName(System.Reflection.Assembly.GetEntryAssembly().Location)));
                return;
            }

            ReferenceName target = new ReferenceName(list[0]);
            ReferenceName newName = new ReferenceName(list[1]);

            client.ModifyProductReferences(
                null,
                target,
                new List<ReferenceName>() { },
                new List<ReferenceName>() { newName });
        }

        private static void HandleProductList(CbisSupplierManagementClient client, List<string> list)
        {
            int page;
            string orgreference;
            if (list.Count == 0)
            {
                page = 0;
                orgreference = null;
            }
            else if (list.Count == 1)
            {
                if (!int.TryParse(list[0], out page))
                {
                    Console.WriteLine("page argument was not translated to an int");
                    return;
                }
                orgreference = null;
            }
            else if (list.Count == 2)
            {
                orgreference = list[0];
                if (!int.TryParse(list[1], out page))
                {
                    Console.WriteLine("page argument was not translated to an int");
                    return;
                }
            }
            else
            {
                Console.WriteLine(
                    string.Format(
                        "Usage: {0} [username] [password] prodlist (orgreference) (page)",
                        Path.GetFileName(System.Reflection.Assembly.GetEntryAssembly().Location)));
                return;
            }

            var result = client.GetProducts(orgreference != null ? new ReferenceName(orgreference) : null, 20, page);

            foreach (var item in result)
            {
                Console.WriteLine(item.Name);
                foreach (var name in item.ReferenceNames)
                {
                    Console.WriteLine("    " + name.Name);
                }
            }
        }

        private static void ListReferences(CbisSupplierManagementClient client, List<string> list)
        {
            string orgRef;
            string prodRef;

            if (list.Count == 1)
            {
                orgRef = null;
                prodRef = list[0];
            }
            else if (list.Count == 2)
            {
                orgRef = list[0];
                prodRef = list[1];
            }
            else
            {
                Console.WriteLine(
                    string.Format(
                        "Usage: {0} [username] [password] reflist (orgreference) [product reference]",
                        Path.GetFileName(System.Reflection.Assembly.GetEntryAssembly().Location)));
                return;
            }

            var result =
                client.GetProductReferences(
                    orgRef != null ? new OrganizationReference(new ReferenceName(orgRef)) : null,
                    new ReferenceName(prodRef));

            Console.WriteLine(result.Name);
            foreach (var item in result.ReferenceNames)
            {
                Console.WriteLine("    " + item.Name);
            }
        }

        private static void HandleCategories(CbisSupplierManagementClient client)
        {
            var cats = client.GetCategories();

            foreach(var item in cats)
            {
                Console.WriteLine(item.Id + "\t" + item.Name);
            }
        }

        private static void SetCategory(CbisSupplierManagementClient client, List<string> list)
        {
            if (list.Count != 3)
            {
                Console.WriteLine(
                    string.Format(
                        "Usage: {0} [username] [password] setcat [orgreference] [product reference] [categoryId]",
                        Path.GetFileName(System.Reflection.Assembly.GetEntryAssembly().Location)));
                return;
            }

            ReferenceName orgRef = new ReferenceName(list[0]);
            ReferenceName prodRef = new ReferenceName(list[1]);
            int categoryId = int.Parse(list[2]);

            var product = client.GetProduct(orgRef, prodRef);

            client.SetProduct(
                orgRef,
                ((Client.InformationDataString)product.InformationData.First(x => x.AttributeId == 99)).Value,
                categoryId,
                prodRef,
                product.InformationData,
                product.Images, product.Occasions);
        }
    }
}
