using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab0.Models.Data
{
    public sealed class Singleton
    {
        public readonly static Singleton _instance = new Singleton();
        public List<Client> ClientList;
        public readonly static Singleton _instance1 = new Singleton();
        public Client Sort;
        
        private Singleton()
        {
            ClientList = new List<Client>();
            Sort = new Client();
        }
        public static Singleton Instance
        {
            get
            {
                return _instance;
            }
        }
        public static Singleton Instance1
        {
            get
            {
                return _instance1;
            }
        }
    }
}
