using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursovoy_luc
{
  public  class Lift : IMoveable
    {
        Person[] passengers;
        Floor where_lift;           //ссылка на этаж

        int time_speed;//скорость (за сколько сек между 2 этажами)
        int capasity;//сколько макс человек

       public Lift(Floor where_lift, int time_speed, int capasity)
        {
            this.where_lift = where_lift;
            this.time_speed = time_speed;
            this.capasity = capasity;


        }
        

        //реализация IMoveable
       public void Barkation()
        { }

       public void Trip()
        { }

       public void DeBarkation()
        { }
        //


    }
}
