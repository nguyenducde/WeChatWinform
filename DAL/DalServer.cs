﻿using Chat_Application_DaiHocDaLat.DAL;
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
        public bool Login(string name, string password)
        {
            String query = "select * from Account where name=N'" + name + "' and password=N'" + password + "'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }
        public void insertUser(String name, string pass)
        {
            string query = String.Format("insert into Account values (N'{0}',N'{1}',0,0)", name, pass);
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public bool checkUser(String name)
        {
            String query = String.Format("select * from Account where name=N'{0}'", name);
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }
        public void setStatusOnline(String name)
        {
            string query = "Update Account set status=1 where name=N'" + name + "'";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public void setStatusOffline(String name)
        {
            string query = "Update Account set status=0 where name=N'" + name + "'";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public DataTable DisplayClientOffline()
        {
            DataTable data = new DataTable();
            string query = "select name from Account where role=0";
            data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        //Chat room
        public void insertRoom(String nameRoom)
        {
            String query = String.Format("insert into Room values (N'{0}',N'')", nameRoom);
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public void insertClientRoom(String nameRoom, String nameClient)
        {
            String query = String.Format("insert into Room values (N'{0}',N'{1}')", nameRoom, nameClient);
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public DataTable DisPlayNameRoom()
        {
            DataTable data = new DataTable();
            string query = "select NameRoom from Room";
            data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public DataTable DisPlayMemberRoom()
        {
            DataTable data = new DataTable();
            string query = "select name from Room";
            data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public bool checkClientNameRoom(String nameRoom, String nameClient)
        {
            String query = String.Format("select * from Room where NameRoom=N'{0}' and name=N'{1}'", nameRoom, nameClient);
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }
        public bool FindNameRooms(String nameRoom)
        {
            String query = String.Format("select * from Room where NameRoom=N'{0}'", nameRoom);
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }

    }
}
