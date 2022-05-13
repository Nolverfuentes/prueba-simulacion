using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prueba_simulacion
{
    public class Album
    {
        public string Titulo { get; set; }
        public string Artista { get; set; }
        public List<Cancion> ListaCanciones { get; set; }
        public DateTime Fechapublicacion { get; set; }
    }
}