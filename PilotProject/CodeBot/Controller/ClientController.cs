using CodeBot.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CodeBot.Controller
{
   public class ClientController
    {
        public Client Client { get; set; }
        public ClientController(string clientName,double clientAmount)            
        {
            //var amount = new Amount(clientAmount);
            Client = new Client(clientName, clientAmount);      
        }
        public void Save()
        {
            var formatter = new BinaryFormatter();
            using (var fs = new FileStream("clients.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, Client);
            }
        }
        public  void Load()
            {
                var formatter = new BinaryFormatter();
                using (var fs = new FileStream("clients.dat", FileMode.OpenOrCreate))
                {
                    var client = formatter.Deserialize(fs) as Client;
                }
            }
        }
    }

