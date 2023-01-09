using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opera_darte
{
    public class Quadro
    {
        //attributi 
        private string _id, _artista;
        private float _altezza, _lung;
        private float _prezzoOff, _prezzoTras;
        bool _richiediTras = false;




        //set e get 
        public string Id
        {
            get 
            { 
                return _id; 
            }
            set
            {
                _id = value;
            }
            
        }
        public string Artista
        {
            get
            {
                return _artista;
            }
            set
            {
                if(value != "")
                {
                    _artista = value;
                }

            }
        }
        public float Altezza
        {
            get
            {
                return _altezza;    
            }
            set
            {
                if(value > 0)
                {
                    _altezza = value;
                }
            }
        }
        public float Lunghezza
        {
            get
            {
                return _lung;
            }
            set
            {
                if (value > 0)
                {
                    _lung = value;
                }
            }
        }

        public float PrezzoOff
        {
            get
            {
                return _prezzoOff;
            }
            set
            {
                if(value > 0)
                {
                    _prezzoOff = value;
                }
            }
        }

        public float PrezzoTras
        {
            get
            {
                return _prezzoTras;
            }
            set
            {
                if(value > 0)
                {
                    _prezzoTras = value;
                }
            }
        }

        public bool RichiediTras
        {
            get
            {
                return _richiediTras;
            }
            set
            {
                _richiediTras = value; 
            }
        }

        //generazione id
        private static Random random = new Random();

        public static string RandomString(int length = 5)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }


        //costruttori



        public Quadro(string artista, float altezza, float lung, float prezzoOff, float prezzoTras)
        {

            Id = RandomString();
            Artista = artista;
            Altezza = altezza;
            Lunghezza = lung;
            PrezzoOff = prezzoOff;
            PrezzoTras = prezzoTras;


        }

        public Quadro() : this("n/a",0,0,0,0)
        {

        }
        //costruttore copia per la clone
        protected Quadro(Quadro other) : this (other.Artista, other.Altezza, other.Lunghezza, other.PrezzoOff, other.PrezzoTras)
        {

        }

        //clone
        public Quadro Clone()
        {
            return new Quadro(this);
        }

        //equals
        public bool Equals(Quadro q)
        {
            if (q == null) return false;

            if(this == q) return true;

            return(this.Id == q.Id);
        }

        //Tostring
        public override string ToString()
        {
            return "Quadro:" + Id + ";" + Artista + ";" + Altezza + ";" + Lunghezza + ";" + PrezzoOff + ";" + PrezzoTras;
        }


        //funzioni

        public void ModDati (float altezza, float lunghezza, float prezzoOff, float prezzoTras)
        {

            Altezza = altezza;
            Lunghezza = lunghezza;
            PrezzoOff = prezzoOff;
            PrezzoTras = prezzoTras;
        }

        public void Offerta(float offerta)
        {
            if (offerta > PrezzoOff)
            {
                PrezzoOff = offerta;
            }
            else
            {
                throw new Exception("l'offerta base è:" + Convert.ToString(PrezzoOff));
            }

        }

        public void Trasporto()
        {
            RichiediTras = true;
        }

        public string Ultimaoff()
        {
            return Convert.ToString(PrezzoOff);
        }

        public string Prezzofin()
        {
            float fine;
            fine = PrezzoOff + PrezzoTras;
            return Convert.ToString(fine);

        }


        public Quadro Confronta(Quadro q, Quadro b)
        {
            if (q == null || b == null)
            {
                throw new Exception("uno dei due quadri è nullo");
            }

            if (q.PrezzoOff == b.PrezzoOff)
            {
                throw new Exception("i due quadri hamno lo stesso prezzo");
            }

            if (q.PrezzoOff > b.PrezzoOff)
            {
                return q;
            }

            return b;

        }

    }
}
