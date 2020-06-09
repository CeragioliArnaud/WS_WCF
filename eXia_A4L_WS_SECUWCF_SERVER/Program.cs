using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M0_SVR
{
    class Program
    {
        private static System.ServiceModel.ServiceHost host;

        static void Main(string[] args)
        {
            headup();
            ini_serv();

            Console.ReadKey();
        }

        static void headup()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("**====================================**");
            Console.WriteLine("**      Server WCF eXia A4 GRP 1      **");
            Console.WriteLine("**====================================**\n\n");
        }

        static void ini_serv()
        {
            int i;

            host = new System.ServiceModel.ServiceHost(typeof(
               eXia_A4L_WS_SECUWCF_MIDDLEWARE.SCV.SVC));

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Server init...keep waiting!");

            try
            {
                host.Open();
                Console.WriteLine("<--Serveur open-->\n");

                for (i = 0; i < host.Description.Endpoints.Count; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Description du service {0}", i);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Adresse : " + host.Description.Endpoints[i].Address);
                    Console.WriteLine("Binding : " + host.Description.Endpoints[i].Binding);
                    Console.WriteLine("Contract Type : " + host.Description.Endpoints[i].Contract.ContractType);
                    Console.WriteLine("Contract Name : " + host.Description.Endpoints[i].Contract.Name);
                    Console.WriteLine("Uri : " + host.Description.Endpoints[i].ListenUri.Host);
                }

                host.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.WriteLine("<--Fin de l'initialisation-->");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n" + host.State.ToString());
            }
        }

    }
}
