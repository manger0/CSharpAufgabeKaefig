using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAufgabeKaefig
{
    class Cage <T>
    {
        List<T> Animals = new List<T>();

        public void AddAnimal(T NewAnimal)
        {
            Animals.Add(NewAnimal);
        }

        public void RemoveAnimal(T AnimalToRemove)
        {
            Animals.Remove(AnimalToRemove);
        }
    }
}
