using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_N2
{
    internal class Armazenar
    {
        public string[] musica;
        public string[] artista;
        public string[] album;
        public string[] conjunto;

        public Armazenar(string musica, string artista, string album)
        {
            this.musica[100] = musica;
            this.artista[100] = artista;
            this.album[100] = album;
        }

        public string Conjunto(string musica, string artista, string album)
        {
            for (int i = 0; i < musica.Length; i++)
            {
              
                


            }
        }



    }



}
