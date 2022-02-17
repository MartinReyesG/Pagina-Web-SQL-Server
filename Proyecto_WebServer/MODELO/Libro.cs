﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_WebServer.MODELO
{
    public class Libro
    {
        public string ISBN { get; set; }
        public string Titulo { get; set; }
        public int NumeroEdicion { get; set; }
        public int AnioPublicacion { get; set; }
        public string Autores { get; set; }
        public string Pais { get; set; }
        public string Sinopsis { get; set; }
        public string Carrera { get; set; }
        public string Materia { get; set; }
    }
}