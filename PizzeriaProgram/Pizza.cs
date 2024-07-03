namespace PizzeriaProgram {
    public class Pizza {
        private string nev;
        private int arKicsi;
        private int arNagy;

        public string Nev => nev;
        public int ArKicsi => arKicsi;
        public int ArNagy => arNagy;

        public Pizza(string nev, int arKicsi, int arNagy)
        {
            this.nev = nev;
            this.arKicsi = arKicsi;
            this.arNagy = arNagy;
        }

        public override string ToString()
        {
            return nev;
        }
    }
}