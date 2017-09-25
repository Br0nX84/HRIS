using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HRIS_SOFTWARE
{
    class Grade
    {
        public int Id { get; private set; }

        public String grade{ get; private set; }

        public Double amount { get; private set; }

        private Grade(int id, String g, Double a)
        {
            Id = id;
            grade = g;
            amount = a;
        }

        public static List<Grade> GetGrade()
        {
            List<Grade> grade = new List<Grade>();
            String query = "select * from grade";
            MySqlCommand cmd = new MySqlCommand(query,Connection.dbConn);
            Connection.dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                int id = (int)reader["idgrade"];
                String gr = reader["grade"].ToString();
                double amount = (double)reader["amount"];

                Grade gra = new Grade(id, gr, amount);
                grade.Add(gra);
            }
            Connection.dbConn.Close();
            return grade;
        }
         
    }
}
