using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Thompson_Lillian
{
    class Game : IGenre
    {
        //
        public string Esrb { get; set; }

        public string Genre { get; set; }//

        public string Title { get; set; }

        public Movies(string esrbParam, string genreParam, string titleParam)
        {
            Esrb = esrbParam;
            Genre = genreParam;
            Title = titleParam;
        }
        /// <summary>
        /// 
        /// </summary>
        public void PlayMovie()
        {
            string value = $"{Title} is starting, BE QUIET!!");
            Console.WriteLine(value)
        }


       

        public void PlayGame()
        {
            Console.WriteLine($"{Title} os starting! GAME ON!!")
        }

        public string Describe()
        {
            return $"{Title} is a {Genre} game, rated {Esrb}!";
        }


    }
}
