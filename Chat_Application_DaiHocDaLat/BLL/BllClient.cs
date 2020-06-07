using Chat_Application_DaiHocDaLat.DAL;
using Chat_Application_DaiHocDaLat.Views;
using MusicLoginScreen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat_Application_DaiHocDaLat.BLL
{
    public class BllClient
    {
        private static BllClient instance;
        private Client client;
        private Login login;
        private MainClient main;

        private BllClient()
        {
            Client = new Client();
        }

        public static BllClient Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BllClient();
                }
                return instance;
            }

            private set { instance = value; }
        }

        public Client Client
        {
            get
            {
                return client;
            }

            set
            {
                client = value;
            }
        }

        public Login Login
        {
            get
            {
                return login;
            }

            set
            {
                login = value;
            }
        }

        public MainClient Main
        {
            get
            {
                return main;
            }

            set
            {
                main = value;
            }
        }

       
       

    }
}
