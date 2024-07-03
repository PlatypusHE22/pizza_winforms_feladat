using System.Windows.Forms;

namespace PizzeriaProgram {
    public partial class PizzaControl : UserControl {
        private Pizza pizza;

        public Pizza Pizza => pizza;

        public bool Checked => cbKivalaszt.Checked;
        public int Darab => (int)numDarab.Value;
        public int Ar
        {
            get
            {
                if (rbKicsi.Checked)
                    return pizza.ArKicsi;
                if (rbNagy.Checked)
                    return pizza.ArNagy;

                return 0;
            }
        }

        public PizzaControl(Pizza pizza)
        {
            InitializeComponent();

            this.pizza = pizza;
            cbKivalaszt.Text = pizza.Nev;
            rbKicsi.Text = pizza.ArKicsi.ToString();
            rbNagy.Text = pizza.ArNagy.ToString();
        }

        public void Clear()
        {
            cbKivalaszt.Checked = false;
            rbKicsi.Checked = false;
            rbNagy.Checked = false;
            numDarab.Value = 0;
        }
    }
}