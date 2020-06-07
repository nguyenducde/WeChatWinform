using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server.DAL;
namespace Server.BLL
{
   public class BllServer
    {
        private static BllServer instance;
        private DalServer server;
        private BllServer()
        {
            Server = new DalServer();
        }

        public static BllServer Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BllServer();
                }
                return instance;
            }

            private set { instance = value; }
        }
        public DalServer Server
        {
            get
            {
                return server;
            }

            set
            {
                server = value;
            }
        }
    }
}
