using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzeriaProgram {
    public partial class Form1 : Form {
        private List<Pizza> pizzak = new List<Pizza>();

        public Form1()
        {
            InitializeComponent();

            tabControl.Appearance = TabAppearance.FlatButtons;
            tabControl.ItemSize = new Size(0, 1);
            tabControl.SizeMode = TabSizeMode.Fixed;
        }

        private void btnAdatBeolvas_Click(object sender, EventArgs e)
        {
            FileDialog dialog = new OpenFileDialog();
            DialogResult res = dialog.ShowDialog();
            if (res != DialogResult.OK)
                return;

            using (StreamReader sr = new StreamReader(dialog.FileName))
            {
                while (!sr.EndOfStream)
                {
                    try
                    {
                        string[] line = sr.ReadLine().Split(';');
                        pizzak.Add(new Pizza(line[0], int.Parse(line[1]), int.Parse(line[2])));
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Hiba a megnyitott fájlban: " + exception.Message, "Hiba");
                        return;
                    }
                }
            }

            for (int i = 0; i < pizzak.Count; i++)
            {
                int top = i * 30 - panelPizzak.AutoScrollPosition.Y;

                PizzaControl control = new PizzaControl(pizzak[i]);
                control.Top = top;

                panelPizzak.Controls.Add(control);
            }

            tabControl.SelectedIndex = 1;
        }

        private void btnTorol_Click(object sender, EventArgs e)
        {
            foreach (PizzaControl control in panelPizzak.Controls)
            {
                control.Clear();
            }
            tbFizetendo.Clear();
        }

        private void btnSzamol_Click(object sender, EventArgs e)
        {
            int osszeg = 0;
            foreach (PizzaControl control in panelPizzak.Controls)
            {
                if(!control.Checked)
                    continue;

                osszeg += control.Ar * control.Darab;
            }

            tbFizetendo.Text = osszeg.ToString();
        }

        private void btnBezar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}