using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using TravelProject_DataAccess.Entities;

namespace TravelProject_DataAccess.Tables
{
    public class Managers
    {

        SqlConnection conn;
        public Managers(SqlConnection conn)
        {
            this.conn = conn;
        }
        public bool insert(Manager mngr) 
        {
            string query = string.Format("insert into Managers values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", mngr.name,mngr.phoneNumber,mngr.gender,mngr.managerType,mngr.username,mngr.password,mngr.address);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int r= cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0)
                return true;
            return false;
        }
        public bool checkUsername(string username)
        {
            string query = string.Format("select Name from Managers where Username='{0}' ", username);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                return true;
            }
            conn.Close();
            return false;
        }
        public bool update(Manager mngr)
        {
            string query = string.Format("Update Managers set Name='{0}' , Phone_Number='{1}' , Address='{2}' where Username='{3}'",mngr.name,mngr.phoneNumber,mngr.address,mngr.username);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int r=cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;

        }
        public void delete() { }
        public List<Manager> getAllManagers() 
        {
            string query = "select * from Managers";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Manager> data = new List<Manager>();
            while(reader.Read())
            {
                Manager mngr = new Manager();
                mngr.id = reader.GetInt32(reader.GetOrdinal("ID"));
                mngr.name = reader.GetString(reader.GetOrdinal("Name"));
                mngr.phoneNumber = reader.GetString(reader.GetOrdinal("Phone_Number"));
                mngr.gender = reader.GetString(reader.GetOrdinal("Gender"));
                mngr.managerType = reader.GetString(reader.GetOrdinal("Manager_Type"));
                mngr.username = reader.GetString(reader.GetOrdinal("Username"));
                mngr.password = reader.GetString(reader.GetOrdinal("Password"));
                data.Add(mngr);          
            }
            conn.Close();
            return data;
        }

        public Manager GetManager(string username)
        {
            string query = string.Format("select * from Managers where Username='{0}' ", username);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Manager mngr = new Manager();

            while (reader.Read())
            {
                
                mngr.name = reader.GetString(reader.GetOrdinal("Name"));
                mngr.phoneNumber = reader.GetString(reader.GetOrdinal("Phone_Number"));                            
                mngr.address= reader.GetString(reader.GetOrdinal("Address"));
            }
            conn.Close();
            return mngr;

        }


        public void search() { }


        public bool checkLogIn(string username,string password)
        {
            string query = string.Format("select Name from Managers where Username='{0}' and Password='{1}'", username, password);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                return true;
            }
            conn.Close();
            return false;

        }

    }
}
