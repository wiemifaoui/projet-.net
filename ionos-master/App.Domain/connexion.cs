using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
 
namespace App.Domain
{
    public class connexion
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-QHH23T6\SQLEXPRESS;Integrated Security=True");


        public void ouvrieConex()
        {
            if (cnx.State == ConnectionState.Closed)
                cnx.Open();
        }


        public void FermerConex()
        {

            if (cnx.State == ConnectionState.Open)
                cnx.Close();

        }


































































































    }
}

