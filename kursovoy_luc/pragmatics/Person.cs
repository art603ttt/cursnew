using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursovoy_luc
{
   public class Person : IMoveable
    {

        //Переменные обозначеные в задании
        int t_prs;              //Среднее время прихода к лифту
        int t_pos;              //Среднее время посадки
        int tog;                //Максимальное время ожидания лифта

        //Собственные переменные
        Floor start_floor;      //cсылка на этаж ,на котором появляется жилец
        int target_floor;       //номер этажа,на который стремится жилец   
        bool IsInQueue = false; //в очереди к лифту?

        public Person(Floor start_floor)
        {
            this.start_floor = start_floor;

        }

        //ожидание жильцом лифта в очереди
        void  Waiting()
        { }

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
