﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployersList:IComparable<Employers>
{
    /*
Для хранения данных сотрудников используйте класс List<T>.
Приложение должно предоставлять такую функциональность:
Добавление сотрудников
Удаление сотрудников
Изменение информации о сотрудниках
Поиск сотрудников по параметрам
Сортировка сотрудников по параметрам*/
    internal class EmployersList
    {
        List<Employers> employers;
        public EmployersList()
        {
            employers = new List<Employers>();
        }
        public EmployersList(List<Employers> employers)
        {
            this.employers = employers ?? new List<Employers>();
        }
        public void AddEmployer(Employers employer)
        {
            employers.Add(employer);
        }
        public void RemoveEmployer(Employers employer)
        {
            employers.Remove(employer);
        }
        public void UpdateEmployer(int index, Employers employer)
        {
            try
            {

            if (index < 0 || index >= employers.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Индекс вне списка сотрудников");
            }
            employers[index] = employer;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public List<Employers> SearchBy(Func<Employers, bool> predicate)
        {
            return employers.Where(predicate).ToList();
        }

        //тут можно сделать меню что бы передавать нужный предикат и поменять каждый на приватный, но я не сделала это
        //public MenuSearch()
        //{
        //    Console.WriteLine("");
        //}

        public List<Employers> SortBy(Func<Employers, object> keySelector)
        {
            return employers.OrderBy(keySelector).ToList();
        }

    }
}
