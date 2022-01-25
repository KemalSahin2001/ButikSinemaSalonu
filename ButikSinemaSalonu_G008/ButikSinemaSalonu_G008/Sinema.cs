using System;
using System.Collections.Generic;
using System.Text;

namespace ButikSinemaSalonu_G008
{
    class Sinema
    {
        public string FilmAdi { get; }
        public int Kapasite { get; }
        private float _YarimBiletFiyati;
        public float YarimBiletFiyati
        {
            get
            {
                return _YarimBiletFiyati;
            }
            set
            {
                _YarimBiletFiyati = value;
                if (_YarimBiletFiyati > 90)
                {
                    _YarimBiletFiyati = 90;
                }
                else if (_YarimBiletFiyati < 10)
                {
                    _YarimBiletFiyati = 10;
                }
            }
        }
        private float _TamBiletFiyati;
        public float TamBiletFiyati 
        {
            get
            {
                return _TamBiletFiyati;

            }
            set
            {
                _TamBiletFiyati = value;
                if (_TamBiletFiyati > 100)
                {
                    _TamBiletFiyati = 100;
                }
                else if (_TamBiletFiyati < 15)
                {
                    _TamBiletFiyati = 15;
                }
            }

        }
        public int ToplamTamBiletAdedi { get; private set; }
        public int ToplamYarimBiletAdedi { get; private set; }

        public float Ciro
        { 
            get
            {
                return (this.ToplamYarimBiletAdedi * this.YarimBiletFiyati) +
                                (this.ToplamTamBiletAdedi * this.TamBiletFiyati);
            } 
        }
        public int BosGoltuk
        { 
            get 
            { 
                return this.Kapasite - this.ToplamTamBiletAdedi - this.ToplamYarimBiletAdedi;
            } 
        }


        public Sinema(string filmAdi, int kapasite, float tamBiletFiyati, float yarimBiletFiyati)
        {
            this.FilmAdi = filmAdi;
            this.Kapasite = kapasite;
            this.TamBiletFiyati = tamBiletFiyati;
            this.YarimBiletFiyati = yarimBiletFiyati;
        }


        public bool BiletSat(int tamBiletAdedi, int yarimBiletAdedi)
        {
            if (this.BosKoltuk() >= (tamBiletAdedi + yarimBiletAdedi))
            {
                this.ToplamTamBiletAdedi += tamBiletAdedi;
                this.ToplamYarimBiletAdedi += yarimBiletAdedi;
;
                return true;
            }
            else
            {
                return false;
            }
        }

        public int BosKoltuk()
        {
            return this.Kapasite - this.ToplamTamBiletAdedi - this.ToplamYarimBiletAdedi;
        }

        public bool BiletIade(int tamBiletAdedi, int yarimBiletAdedi)
        {
            if (tamBiletAdedi <= this.ToplamTamBiletAdedi && yarimBiletAdedi <= this.ToplamYarimBiletAdedi)
            {
                this.ToplamTamBiletAdedi -= tamBiletAdedi;
                this.ToplamYarimBiletAdedi -= yarimBiletAdedi;
                

                return true;
            }
            else
            {
                return false;
            }
        }





















    }
}
