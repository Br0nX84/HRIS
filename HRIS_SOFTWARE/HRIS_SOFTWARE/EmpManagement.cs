using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HRIS_SOFTWARE
{
    class EmpManagement
    {
        public int Id { get; private set; }

        public String Empname { get; private set; }

        public String Position { get; private set; }

        public String AccountNo { get; private set; }

        public String Salary { get; private set; }

        private EmpManagement(int id, String e, String p, String a, String s)
        {
            Id = id;
            Empname = e;
            Position = p;
            AccountNo = a;
            Salary = s;
        }

        public static List<EmpManagement> GetSearch(string i, string l, string f)
        {
            List<EmpManagement> emp = new List<EmpManagement>();

            String query = String.Format("select * from emp_details where external_id like '%{0}%' AND lastname like '{1}%' AND firstname like '{2}%'",i,l,f);

            MySqlCommand cmd = new MySqlCommand(query, Connection.dbConn);

            Connection.dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int id = (int)reader["emp_id"];
                String account = reader["external_id"].ToString();
                String empname = reader["lastname"].ToString() + ", " + reader["firstname"].ToString() + ' ' + reader["middlename"].ToString();
                String position = reader["position"].ToString();
                String salary = string.Format("{0:#,###,###.##}", reader["salary"].ToString());

                EmpManagement employee = new EmpManagement(id, empname, position, account, salary);
                emp.Add(employee);
            }

            Connection.dbConn.Close();
            return emp;
        }

        public static List<EmpManagement> GetEmployee()
        {
            List<EmpManagement> emp = new List<EmpManagement>();

            String query = "select * from emp_details";

            MySqlCommand cmd = new MySqlCommand(query, Connection.dbConn);

            Connection.dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                int id = (int)reader["emp_id"];
                String account = reader["external_id"].ToString();
                String empname = reader["lastname"].ToString() + ", " + reader["firstname"].ToString() + ' ' + reader["middlename"].ToString();
                String position = reader["position"].ToString();
                String salary =  string.Format("{0:#,###,###.##}", reader["salary"].ToString());

                EmpManagement employee = new EmpManagement(id, empname, position, account, salary);
                emp.Add(employee);
            }

            Connection.dbConn.Close();
            return emp;
        }
    }
}
