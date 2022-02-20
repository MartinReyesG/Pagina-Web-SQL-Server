using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proyecto_WebServer.MODELO;
//using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data;

namespace Proyecto_WebServer.DAO
{
    public class DAOLibro
    {
        string parametrosConexion =
                 //"server=127.0.0.1;uid=root;pwd=martin12345;database=Libreria";
                 //"server=127.0.0.1;uid=root;pwd=root;database=Libreria";   
                 // "SERVER=HP-PAVILION;DATABASE=Libreria;Integrated security=true";

                 //"SERVER=HP-PAVILION;Initial Catalog=Libreria;Integrated security=true;" +
                 //   "TrustServerCertificate=False;" +
                 //   "Persist Security Info=False;MultipleActiveResultSets =False;Connection Timeout=30;";
                 "server=localhost;database=Libreria;uid=sa;pwd=root";

        //"Server=HP-PAVILION;" +
        //"DATABASE=Libreria;Persist Security Info=False;" +
        //"User ID=sa;Password=root;MultipleActiveResultSets =False;" +
        //"Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public List<Libro> lstLibros()
        {


            //MySqlConnection conexion = new MySqlConnection();
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = parametrosConexion;

            try
            {
                conexion.Open();
                //MySqlCommand consulta = new MySqlCommand(
                SqlCommand consulta = new SqlCommand(
                    @"SELECT ID, ISBN, Titulo, NumeroEdicion, AnioPublicacion, Autores, Pais, Sinopsis, 
                        Carrera, Materia
                        FROM Libros;") ;
                
                consulta.Connection = conexion;
                //MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta);
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta);

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
            //MySqlConnection conexion = new MySqlConnection();
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = parametrosConexion;
            conexion.Open();

            string consulta = @"INSERT INTO libros
                (ISBN, Titulo, NumeroEdicion, AnioPublicacion, Autores, Pais, Sinopsis, Carrera, Materia) VALUES
                (@ISBN, @Titulo, @NumeroEdicion, @AnioPublicacion, @Autores, @Pais, @Sinopsis, @Carrera, @Materia);";

            //MySqlCommand comando = new MySqlCommand(consulta, conexion);
            SqlCommand comando = new SqlCommand(consulta, conexion);

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


        public bool eliminar(int indice)
        {
            // MySqlConnection conexion = new MySqlConnection();
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = parametrosConexion;
            conexion.Open();

            string consulta = @"delete from libros
                                    where id=@indice;";

            //MySqlCommand comando = new MySqlCommand(consulta, conexion);
            SqlCommand comando = new SqlCommand(consulta, conexion);

            comando.Parameters.AddWithValue("@indice", indice);

            comando.ExecuteNonQuery();
            conexion.Close();
            conexion.Dispose();
            return true;
        }

        public bool modificar(Libro obj)
        {
            // MySqlConnection conexion = new MySqlConnection();
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = parametrosConexion;
            conexion.Open();

            string consulta = @"update libros 
                    set ISBN=@ISBN,Titulo=@Titulo,NumeroEdicion=@NumeroEdicion
		            ,AnioPublicacion=@AnioPublicacion,Autores=@Autores,Pais=@Pais
                    ,Sinopsis=@Sinopsis,Carrera=@Carrera
                    ,Materia=@Materia
		            where id=@id;";

            // MySqlCommand comando = new MySqlCommand(consulta, conexion);
            SqlCommand comando = new SqlCommand(consulta, conexion);

            comando.Parameters.AddWithValue("@id", obj.ID);
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