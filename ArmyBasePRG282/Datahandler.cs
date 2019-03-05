using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;
using System.Data;

namespace ArmyBasePRG282
{
    class Datahandler
    {

        SqlConnection conn = new SqlConnection("Data Source=ASPIRE-E1-510-S;Initial Catalog=dbArmy;Integrated Security=True");
       public List<Plane> GetPlanes()
        { List<Plane> thislist = new List<Plane>();
            
            string commandtext = "SELECT * From tblPlanes";
            SqlCommand cmd = new SqlCommand(commandtext, conn);

            SqlDataReader rdr = null;
            try
            {

             conn.Open();  
               rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                 thislist.Add(new Plane(rdr[0].ToString(),int.Parse(rdr[1].ToString()),int.Parse(rdr[2].ToString()),int.Parse(rdr[3].ToString()),int.Parse(rdr[4].ToString()),int.Parse(rdr[5].ToString()),int.Parse(rdr[6].ToString()),int.Parse(rdr[7].ToString()),int.Parse(rdr[8].ToString()),int.Parse(rdr[9].ToString()),int.Parse(rdr[10].ToString())));
                }
            }
            finally
            {
                if (rdr != null)
                {
                    rdr.Close();
                }
                if(conn != null)
{
                    conn.Close();
}                               
            }
            return thislist;
        }
        public List<Obstacle> GetObstacles()
{
            List<Obstacle> thislist = new List<Obstacle>();
             string commandtext = "SELECT * From tblObstacles";
            SqlCommand cmd = new SqlCommand(commandtext, conn);
            
            SqlDataReader rdr = null;
            try
            {
             conn.Open();  
               rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                 thislist.Add(new Obstacle(rdr[0].ToString(),int.Parse(rdr[1].ToString()),int.Parse(rdr[2].ToString()),int.Parse(rdr[3].ToString())));
                }
            }
            finally
            {
                if(rdr != null)
                {
                    rdr.Close();
                }
                       if(conn != null)
{
                    conn.Close();
}               
            }
            return thislist;
}
        public List<EnemyBuilding> GetBuildings()
{
                    List<EnemyBuilding> thislist = new List<EnemyBuilding>();
             string commandtext = "SELECT * From tblBuildings";
            SqlCommand cmd = new SqlCommand(commandtext, conn);
            
            SqlDataReader rdr = null;
            try
            {
             conn.Open();  
               rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                 thislist.Add(new EnemyBuilding(rdr[0].ToString(),int.Parse(rdr[1].ToString()),int.Parse(rdr[2].ToString())));
                }
            }
            finally
            {
                if(rdr != null)
                {
                    rdr.Close();
                }
                       if(conn != null)
{
                    conn.Close();
}               
            }
            return thislist;
}               
}
   }
   
