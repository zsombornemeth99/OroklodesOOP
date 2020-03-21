using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OroklodesOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Console.WriteLine("Hello 13S a Digitális világban!");

            Fajl f1 = new Fajl("kep.jpg", 3211); //3,2 Mb kép
            Fajl f2 = new Fajl("recept.doc", 800);

            Console.WriteLine(f1);
            Console.WriteLine(f2);

            HatterTarolo hdd = new HatterTarolo(20000000); //20GB
            hdd.hozzaad(f1);
            hdd.hozzaad(f2);

            Console.WriteLine(hdd.maximalisKapacitas());
            Console.WriteLine(hdd.foglaltKapacitas());
            Console.WriteLine(hdd.szabadKapacitas());

            Console.WriteLine();
            Console.WriteLine(hdd);

            Floppy floppy = new Floppy();
            floppy.hozzaad(f1);
            floppy.hozzaad(f2);

            //floppy.atBillent();
            Console.WriteLine("írásvédett állapot!!!!");

            Console.WriteLine(floppy);
            floppy.format();
            Console.WriteLine(floppy);

            DVDRW dvdrw = new DVDRW(); 

            Szamitogep szg = new Szamitogep();
            szg.Felcsatol('A', floppy);
            szg.Felcsatol('E', dvdrw);
            szg.Felcsatol('C', hdd);

            Console.WriteLine(szg);



            Console.ReadKey();
        }
    }
}
