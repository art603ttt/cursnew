using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursovoy_luc
{
     public class Building
    {
       public Floor[] all_floors=new Floor[0];
       public Lift[] all_lifts=new Lift[0];

      public  Building(int kolvo_floors,int kolvo_lifts)
        {
            Array.Resize(ref all_floors, kolvo_floors);

            for (int i=0;i<kolvo_floors;i++)
            {
                all_floors[i] = new Floor(this,4,i+1);

            }


            //для 1 лифта - тест
            Array.Resize(ref all_lifts, 1);
            all_lifts[0]=new Lift(all_floors[0], 5, 3);



            /* Array.Resize(ref all_lifts, kolvo_lifts);
             for (int i = 0; i < kolvo_lifts; i++)
             {
                 all_lifts[i] = new Lift(all_floors[0],5,3);

             }*/

        }


    }
}
