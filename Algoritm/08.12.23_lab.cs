using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {
            OsnovnoySostav Ivan = new OsnovnoySostav("Ivan", 22416, new string[] { "Oleg: 150 000", "Dmitriy: 200 000" });
            OsnovnoySostav Nikita = new OsnovnoySostav("Nikita", 22417, new string[] { "Gleb: 1 000 000", "Bleb: 10 000", "Maksim: 500 000"});
            OsnovnoySostav Artem = new OsnovnoySostav("Artem", 22418, new string[] { "Jora: 25 000"});
            OsnovnoySostav[] osn = {Ivan, Nikita, Artem};

            VspomogSostav Anton = new VspomogSostav("Anton", 22419, 25000);
            VspomogSostav Leon = new VspomogSostav("Leon", 22420, 25000);
            VspomogSostav Maksim = new VspomogSostav("Maksim", 22421, 27000);
            VspomogSostav Andrey = new VspomogSostav("Andrey", 22422, 15000);
            VspomogSostav Sergey = new VspomogSostav("Sergey", 22423, 27000);
            VspomogSostav[] vspom = { Anton, Leon, Maksim, Andrey, Sergey};

            foreach (OsnovnoySostav sotrudnik in osn)
                Console.WriteLine("Сотрудник {0} (id: {1}) выдал {2} кредитов", sotrudnik.name, sotrudnik.id, sotrudnik.credits.Length);

            int[] zarplat = new int[vspom.Length];
            for (int i = 0; i < zarplat.Length; i++)
                zarplat[i] = vspom[i].oklad;
            for (int i = 0; i < zarplat.Length; i++)
            {
                bool flag = true;
                int k = 0;
                for (int j = 0; j < vspom.Length; j++)
                    if (zarplat[i] == vspom[j].oklad)
                        k++;
                for (int l = 0; l < i; l++)
                    if (zarplat[i] == zarplat[l])
                        flag = false;
                    if (flag)
                        Console.WriteLine("Сотрудников с зарплатой {0}: {1}", zarplat[i], k);
            }
            

        }
    }
    class Sotrudnik
    {
        public string name;
        public int id;
        public Sotrudnik(string name, int id)
        {
            this.name = name;
            this.id = id;
        }
    }

    class OsnovnoySostav: Sotrudnik
    {
        public string[] credits;
        public OsnovnoySostav(string name, int id, string[] credits): base(name, id)
        {
            this.credits = credits;
        }
    }

    class VspomogSostav : Sotrudnik
    {
        public int oklad;
        public VspomogSostav(string name, int id, int oklad): base(name, id)
        {
            this.oklad = oklad;
        }
    }
}
