using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class Artiste
    {
        private string _nomArtiste;
        private List<Chanson> chansons;

        public Artiste(string s)
        {
            chansons = new List<Chanson>();
            _nomArtiste = s;
        }

        public void addChanson(Chanson c)
        {
            if(c == null)
            {
                return;
            }
            chansons.Add(c);
        }

        public string NomArtiste
        {
            get { return _nomArtiste; }
            set { _nomArtiste = value; }
        }

        public List<Chanson> Chansons
        {
            get { return chansons; }
        }
    }

    class Chanson
    {
        private string _nomChanson;

        public Chanson(string s)
        {
            _nomChanson = s;
        }

        public string NomChanson
        {
            get { return _nomChanson; }
            set { _nomChanson = value; }
        }
    }
}
