using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace kursovoy_luc
{
    public class Floor
    {
              Building this_house;                        //ссылка на дом
      public  Person[] floor_dwellers=new Person[0];      //жильцы на этаже
              int number_of_floor;                        //номер этажа
      public  Queue<Person> ochered=new Queue<Person>();  //очередь к лифту


       public Floor(Building this_house, int kolvo_persons,int number_of_floor)
        {
            this.number_of_floor = number_of_floor;

            Array.Resize(ref floor_dwellers, kolvo_persons);

            //инициализируем жильцов
            for(int i=0;i<kolvo_persons;i++)
            {
                floor_dwellers[i] = new Person(this);

            }
        }

        //метод убирает жильца из массива и добавляет в очередь к лифту
        void add_person_in_queue_lift(int number_floor)
        {


        }







    }
}
