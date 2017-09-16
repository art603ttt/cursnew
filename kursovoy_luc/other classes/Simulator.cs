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
   public class Simulator
    {
       public Building house;

       public Simulator()
        {
            house = new Building(5,3);


        }



     /* public  void Start_simulation(Random m,Timer t)
        {
            bool help1 = true;
            bool help2 = true;

            //выбираем этаж
            int number_floor=0; 
            int what_floor=0;

            while (help1)//исключаем пустые этажи
            {
                number_floor = m.Next(-20, 4);

                if(house.all_floors[number_floor].floor_dwellers.Length!=0)
                {

                    help1 = false;
                }


                while (help2)//исключаем совпадение этажей
                {
                    //выбираем на какой этаж поедет
                    what_floor = m.Next(0, 4);

                    
                    if (what_floor != number_floor)
                    {
                        help2 = false;

                    }

                }
            }

            if(number_floor>=0)
            {house.all_floors[number_floor].add_person_in_queue_lift()







            }



        }*/

        
        


    }
}
