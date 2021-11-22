using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ArrayListUyg
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            
            
            do
            {
                string o1;
                Console.WriteLine("Menu\n");
                Console.WriteLine("1-Değer Ekle");
                Console.WriteLine("2-Değer Listele");
                Console.WriteLine("3-Değer Ara");
                Console.WriteLine("4-Değer Düzenle");
                Console.WriteLine("5-Değer Sil");
                Console.WriteLine("6-Uygulama Çıkış");
                int secim = Convert.ToInt32(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Eklemek istediğiniz değeri giriniz :");
                        arrayList.Add(Console.ReadLine());
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Değerler :");
                        for (int i = 0; i < arrayList.Count; i++)
                        {
                            Console.WriteLine((i+1)+".değer :"+arrayList[i]);
                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("Aramak istediğiniz değeri giriniz :");
                        o1 = Console.ReadLine();
                        if (arrayList.Contains(o1))
                        {
                            Console.WriteLine("Aradığınız değer listede var indexi :"+arrayList.IndexOf(o1));
                        }
                        else
                        {
                            Console.WriteLine("Aradığınız değer listede yok.");
                        }
                        break;
                    case 4:
                        Console.Clear();
                        for (int i = 0; i <arrayList.Count ; i++)
                        {
                            Console.WriteLine((i+1) +"."+arrayList[i]);
                        }
                        Console.WriteLine("Değiştirmek istediğinz değerin indexini giriniz.");
                        int index = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Değiştirmek istediğiniz değeri giriniz.");
                        arrayList[index - 1] = Console.ReadLine();
                        Console.WriteLine("Değiştirildi.");
                        break;
                    case 5:
                        Console.Clear();
                        for (int i = 0; i < arrayList.Count; i++)
                        {
                            Console.WriteLine((i + 1) + "." + arrayList[i]);
                        }
                        Console.WriteLine("Silmek istediğinz değerin indexini giriniz.");
                        int index2 = Convert.ToInt32(Console.ReadLine());
                        arrayList.RemoveAt(index2 - 1);
                        break;
                    case 6:
                        Console.WriteLine("iyi günler");
                        Thread.Sleep(2000);
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Girdiğiniz değeri kontrol ediniz");
                        break;
                }

            } while (true);

        }
    }
}
