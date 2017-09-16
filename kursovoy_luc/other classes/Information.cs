using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursovoy_luc
{
   public class Information
    {
        Form1 main_form;//ссылка на форму

        Simulator sim;//ссылка на симуляцию ---------можно сразу на дом???

        public Information(Simulator sim, Form1 main_form)
        {
            this.sim = sim;
            this.main_form = main_form;



        }


       public void refresh()
        {

            draw();
            txt_info();


        }


        void draw()
        { }



        void txt_info()
        {
            main_form.textBox1.Text = (sim.house.all_floors[0].floor_dwellers.Length).ToString();
            main_form.textBox2.Text = (sim.house.all_floors[1].floor_dwellers.Length).ToString();
            main_form.textBox3.Text = (sim.house.all_floors[2].floor_dwellers.Length).ToString();
            main_form.textBox4.Text = (sim.house.all_floors[3].floor_dwellers.Length).ToString();
            main_form.textBox5.Text = (sim.house.all_floors[4].floor_dwellers.Length).ToString();




        }




    }
}
