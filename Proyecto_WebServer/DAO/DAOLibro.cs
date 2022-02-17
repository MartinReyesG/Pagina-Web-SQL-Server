using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proyecto_WebServer.MODELO;
using MySql.Data.MySqlClient;
using System.Data;

namespace Proyecto_WebServer.DAO
{
    public class DAOLibro
    {
        string parametrosConexion =
                   "server=127.0.0.1;uid=root;pwd=martin12345;database=Libreria";
        //         "server=127.0.0.1;uid=root;pwd=root;database=Libreria";
        public List<Libro> lstLibros()
        {
           

            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = parametrosConexion;

            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand(
                    @"SELECT ID, ISBN, Titulo, NumeroEdicion, AnioPublicacion, Autores, Pais, Sinopsis, 
                        Carrera, Materia
                        FROM Libros;") ;
                
                consulta.Connection = conexion;
                MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta);

                DataTable resultado = new DataTable();
                DataSet ds = new DataSet(); 
                adaptador.Fill(ds, "libros");

                List<Libro> libros = new List<Libro>();
                foreach (DataRow dr in ds.Tables["Libros"].Rows)
                {
                    Libro obj = new Libro();
                    obj.ID = Convert.ToInt32(dr[0]);
                    obj.ISBN = dr[1].ToString();
                    obj.Titulo = dr[2].ToString();
                    obj.NumeroEdicion = Convert.ToInt32(dr[3]);
                    obj.AnioPublicacion = Convert.ToInt32(dr[4]);
                    obj.Autores = dr[5].ToString();
                    obj.Pais = dr[6].ToString();
                    obj.Sinopsis = dr[7].ToString();
                    obj.Carrera = dr[8].ToString();
                    obj.Materia = dr[9].ToString();

                    libros.Add(obj);
                }

                return libros;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();
            }
        }


        public bool Insertar(Libro obj)
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = parametrosConexion;
            conexion.Open();

            string consulta = @"INSERT INTO libros
                (ISBN, Titulo, NumeroEdicion, AnioPublicacion, Autores, Pais, Sinopsis, Carrera, Materia) VALUES
                (@ISBN, @Titulo, @NumeroEdicion, @AnioPublicacion, @Autores, @Pais, @Sinopsis, @Carrera, @Materia);";

            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            comando.Parameters.AddWithValue("@ISBN", obj.ISBN);
            comando.Parameters.AddWithValue("@Titulo", obj.Titulo);
            comando.Parameters.AddWithValue("@NumeroEdicion", obj.NumeroEdicion);
            comando.Parameters.AddWithValue("@AnioPublicacion", obj.AnioPublicacion);
            comando.Parameters.AddWithValue("@Autores", obj.Autores);
            comando.Parameters.AddWithValue("@Pais", obj.Pais);
            comando.Parameters.AddWithValue("@Sinopsis", obj.Sinopsis);
            comando.Parameters.AddWithValue("@Carrera", obj.Carrera);
            comando.Parameters.AddWithValue("@Materia", obj.Materia);

            comando.ExecuteNonQuery();
            conexion.Close();
            conexion.Dispose();
            return true;
        }
    }
}