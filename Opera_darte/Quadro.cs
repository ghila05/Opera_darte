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
                return _altezza;
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
                return _prezzoOff;
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
        
        //costruttori

        public Quadro(string id, string artista, float altezza, float lung, float prezzoOff, float prezzoTras)
        {
            if (String.IsNullOrEmpty(id))
            {
                throw new Exception("id invalido");
            }
            Id = id;
            Artista = artista;
            Altezza = altezza;
            Lunghezza = lung;
            PrezzoOff = prezzoOff;
            PrezzoTras = prezzoTras;


        }

        public Quadro() : this("idvuoto", "n/a",0,0,0,0)
        {

        }
        //costruttore copia per la clone
        protected Quadro(Quadro other) : this (other.Id, other.Artista, other.Altezza, other.Lunghezza, other.PrezzoOff, other.PrezzoTras)
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


    }
}
