namespace EntityLayer
{
    public class EntityOgrenci
    {
        private int id;
        private string ad;
        private string soyad;
        private string numara;
        private string bakiye;
        private string fotograf;
        private string sifre;

        public string Sifre
        {
            get { return sifre; }
            set { sifre = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }

        public string Soyad
        {
            get { return soyad; }
            set { soyad = value; }
        }


        public string Numara
        {
            get { return numara; }
            set { numara = value; }
        }

        public string Bakiye
        {
            get { return bakiye; }
            set { bakiye = value; }
        }

        public string Fotograf
        {
            get { return fotograf; }
            set { fotograf = value; }
        }
    }
}
