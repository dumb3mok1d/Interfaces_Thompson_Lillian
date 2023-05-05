using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Thompson_Lillian
{
    class Movies : IGenre
    {

        public string Esrb { get; set; }

        public string Genre { get; set; }

        public string Title { get; set; }

        public string Describe()
        {
            return $"{Title} is a {Genre} move, rater {Esrb}";
        }

    }
}
