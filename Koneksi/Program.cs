using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //

namespace Koneksi
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Connecting();
        }
        public void Connecting()
        {
            using (
                SqlConnection con = new SqlConnection("data source=LAPTOP-EED9RP81\\ERDAWYNE;database=ProdiTI;User ID=sa;Password=erda123")
            )
            {
                con.Open();
                Console.WriteLine("Berhasil terhubung ke database");
            }
        }
    }
}