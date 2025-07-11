﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfabet
{
/*Задание 2
Создайте класс Алфавит. Он должен содержать буквы
английского алфавита. Реализуйте поддержку итератора.
Протестируйте возможность использования foreach для
класса алфавита*/
    internal class EnglishAlphabet: IEnumerable<char>, IDisposable//интерфейсы которые входят в IEnumerable
    {
        private readonly SortedSet<char> Letters;

        public EnglishAlphabet()
        {
            Letters = new SortedSet<char>();
            for (char letter = 'A'; letter <= 'Z'; letter++)
            {
                Letters.Add(letter);
            }
            for (char letter = 'a'; letter <= 'z'; letter++)
            {
                Letters.Add(letter);
            }
        }

        public IEnumerator<char> GetEnumerator()
        {
            foreach (var letter in Letters)
            {
                yield return letter;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        protected virtual void Dispose(bool disposing)
        {
            //empty, nothing to clean up
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
