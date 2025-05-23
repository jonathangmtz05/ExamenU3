﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace ExamenU2
{
    internal class Datos
    {
        String cadenaConexion = "Data Source = DESKTOP-BC8T7I8;" + "integrated security=true; initial catalog=Tienda; encrypt=false";
        SqlConnection conexion;

        private SqlConnection abrirConexion()
        {
            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open(); // abrir conexion a bd
                return conexion;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eror al abrir conexion: " + ex.Message);
                return null;
            }
        }

        public bool prueba()
        {
            try
            {
                abrirConexion();
                return true;
            }
            catch (Exception ex)
            {

                Console.WriteLine("Eror al abrir conexion: " + ex.Message);
                return false;
            }

        }

        public DataSet consulta(string consulta)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(consulta, abrirConexion());
                da.Fill(ds);

                return ds;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        public bool comando(string consulta)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(consulta, abrirConexion());
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
    }
}
