using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursovoy_luc
{
   public class Person
    {
        Floor start_floor;  //cсылка на этаж ,на котором инициализируется жилец
        int target_floor;
        int speed_to_lift;
        bool IsInQueue = false;

        public Person(Floor start_floor)
        {
            this.start_floor = start_floor;

        }
        void person_go_to_queue() { }

    }
}
