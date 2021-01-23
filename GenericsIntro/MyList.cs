using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        // item - eleman
        T[] items;

        // ctor - consturactor
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item) 
        {
            // temp Array - Geçici dizi
            // geçici dizini elemanı = items ın elemanı aşağıda new yaptığımız an referans numarası alır,
            // önceki referans numarası uçmasın diye geçici diziye tuturuyoruz.

            T[] tempArray = items;

            // dizinin eleman sayısını 1 artırıyor.
            items = new T[items.Length+1];
            // yukarıda new yaptığımız için önceki değerler uçmasın diye tempArray kullanmıştık, aşağıda tekrar bu değerleri geri alıyoruz.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;

        }
    }
}
