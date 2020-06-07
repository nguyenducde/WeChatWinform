using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.DAL
{
    public class DalAccount
    {
        private static DalAccount instance;

        private DalAccount() { }

        public static DalAccount Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DalAccount();
                }
                return instance;
            }

            private set { instance = value; }
            }

        public bool Login(string name, string password, int role)
        {
            object data = DataProvider.Instance.ExecuteScalar("exec [Login] @name , @password , @role");
            return (int)data == 1;
        }

        public void Logout(string name)
        {
            DataProvider.Instance.ExecuteNonQuery("exec [Logout] @loginName", new object[] { name });
        }
        public void clientOnline()
        {
            string query = "select * from Account where role=0 and status=1";
            DataProvider.Instance.ExecuteNonQuery(query);


        }
        public int  totalClient()
        {
        
            string query = "select * from Account where role=0 and status=0";
          DataTable result= DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count;

        }


    }



    } 
