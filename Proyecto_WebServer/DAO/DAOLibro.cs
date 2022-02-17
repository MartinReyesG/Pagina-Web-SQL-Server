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
        public bool Insertar(Libro obj)
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = "server=127.0.0.1;uid=root;pwd=root;database=Libreria";
            conexion.Open();

            string consulta = "insert into libros " +
                "(ISBN, Titulo, NumeroEdicion, AnioPublicacion, Autores, Pais, Sinopsis, Carrera, Materia) values" +
                "(@ISBN, @Titulo, @NumeroEdicion, @AnioPublicacion, @Autores, @Pais, @Sinopsis, @Carrera, @Materia)";
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