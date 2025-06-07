using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseWpf.Houses
{
    public class House//Prototype
    {
        public int idHouse { get; set; }
        public string typeOfHouse { get; set; }
        public int dwellingPlace { get; set; }
        public string typeOfEngineeringStructures { get; set; }
        public string typeOfSanitaryStructures { get; set; }
        public string typeOfFrame { get; set; }
        public string typeOfRoof { get; set; }
        public string town { get; set; }
        public string street { get; set; }
        public int numberOfHouse { get; set; }

        public House(List<string> str)
        {
            idHouse = Int32.Parse(str[0]);
            typeOfHouse = str[1];
            dwellingPlace = Int32.Parse(str[2]);
            town = str[3];
            street = str[4];
            numberOfHouse = Int32.Parse(str[5]);
        }
        public House()
        {
            idHouse = 1111;
            typeOfHouse = "Standart type";
            dwellingPlace = 100;
            typeOfEngineeringStructures = "Standart";
            typeOfSanitaryStructures = "Standart";
            typeOfFrame = "Standart";
            typeOfRoof = "Standart";
            town = "Standart town";
            street = "Standart street";
            numberOfHouse = 1111;
        }

        public House Clone()
        {
            return (House)this.MemberwiseClone();
        }
    }
}
