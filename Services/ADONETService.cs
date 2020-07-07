using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ADONETService
    {

        private string GetConnectionString ()
        {
            return "Server=DESKTOP-905EBVU\\MSSQLSERVERNEW;Database=SecondExamSQL;Trusted_Connection=True;";
        }
        public IEnumerable<PersonEntity> GetAllNames()
        {
            List<PersonEntity> persons = new List<PersonEntity>();

            using (SqlConnection con = new SqlConnection( GetConnectionString()))
            {
                SqlCommand cmd = new SqlCommand("GetNames", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    var person = new PersonEntity();

                    person.FamilyName = sdr["FamilyName"].ToString();
                    person.FirstName = sdr["FirstName"].ToString();
                    persons.Add(person);
                }
                con.Close();
            }
            return persons;
        }
        public int AddName(PersonEntity personEntity)
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                SqlCommand cmd = new SqlCommand("AddNames", con);
                cmd.CommandType = CommandType.StoredProcedure;
                var person = new PersonEntity();
                cmd.Parameters.AddWithValue("@FamilyName" , personEntity.FamilyName);
                cmd.Parameters.AddWithValue("@FirstName", personEntity.FirstName);
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                con.Close();

                return rowsAffected;
            }
        }
        public int EditName(PersonEntity personEntity)
        {
            SqlConnection con = new SqlConnection(GetConnectionString());
            SqlCommand com = new SqlCommand("EditPerson", con);

            com.CommandType = CommandType.StoredProcedure;
            /*com.Parameters.AddWithValue("@FamilyName", person.FamilyName);*/
            var person = new PersonEntity();
            com.Parameters.AddWithValue ("@PersonID", personEntity.PersonID);
            com.Parameters.AddWithValue ( "@FamilyName", personEntity.FamilyName);
            com.Parameters.AddWithValue ( "@FirstName", personEntity.FirstName);
            con.Open();
            int rowsAffected = com.ExecuteNonQuery();
            con.Close();
            return rowsAffected;
        }
        public int DeleteName(int personID)
        {
            SqlConnection con = new SqlConnection(GetConnectionString());
            SqlCommand com = new SqlCommand("DeletePersonById", con);

            com.CommandType = CommandType.StoredProcedure;
            /*com.Parameters.AddWithValue("@FamilyName", person.FamilyName);
            com.Parameters.AddWithValue("@FirstName", person.FirstName);*/
            com.Parameters.AddWithValue("@PersonID", personID);
            con.Open();
            int rowsAffected = com.ExecuteNonQuery();
            con.Close();
            return rowsAffected;
        }

    }
}