using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployersList
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

        public List<Employers> Search


    }
}
