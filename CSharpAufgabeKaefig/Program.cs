using System;

namespace CSharpAufgabeKaefig
{
    class Program
    {
        static void Main(string[] args)
        {
            Monkey monkey = new Monkey("chichi");
            Monkey monkey1 = new Monkey("chacha");


            Tiger tiger = new Tiger("lion");
            Tiger tiger1 = new Tiger("lionTiger");

            Cage<Monkey> monkeyCage = new Cage<Monkey>();
            Cage<Tiger> tigerCage = new Cage<Tiger>();

            monkeyCage.AddAnimal(monkey);
            monkeyCage.AddAnimal(monkey1);
            monkeyCage.RemoveAnimal(monkey);

            tigerCage.AddAnimal(tiger);
            tigerCage.AddAnimal(tiger1);
            tigerCage.RemoveAnimal(tiger);
        }
    }
}
