using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursovoy_luc
{
    public partial class Form1 : Form
    {
        Simulator house_simulation;
        Information data_information;


        Form_ruchnoy_vvod VVOD;

        public Form1()
        {
            InitializeComponent();
        }

        //создать среду
        private void button_create_Click(object sender, EventArgs e)
        {
            house_simulation = new Simulator();
            data_information = new Information(house_simulation, this);

            data_information.refresh();

        }


        //начать
        private void button_start_Click(object sender, EventArgs e)
        {
            Random m = new Random();

           // house_simulation.Start_simulation




        }


        //Событие - Ручной ввод
        private void toolStripMenuItem_ruchnoy_Click(object sender, EventArgs e)
        {
            VVOD = new Form_ruchnoy_vvod();
            VVOD.ShowDialog();
        }
    }
}
