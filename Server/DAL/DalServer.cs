using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.DAL
{
   public class DalServer
    {
        public int DisplayTotalClient()
        {
            
            string query = "select * from Account where role=0";
         DataTable  data = DataProvider.Instance.ExecuteQuery(query);
            return data.Rows.Count; ;
        }
        public DataTable FindNameRoom(String nameRoom)
        {
            DataTable data = new DataTable();
            string query = String.Format("select * from Room where NameRoom=N'{0}'",nameRoom);
            data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        //Chat offline
        public void insertMessage(String myName, String RecipientName, string mess)
        {
            String query = String.Format("insert into Message Values(N'{0}',N'{1}',N'{2}')", myName, RecipientName, mess);
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
