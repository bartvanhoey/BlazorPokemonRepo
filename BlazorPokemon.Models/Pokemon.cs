using System;

namespace BlazorPokemon.Models
{
    public class Pokemon
    {
        private string _photoPath;
        public Pokemon()
        {

        }

        public Pokemon(int id, string name, string type1, string type2, int total, int hP, int attack, int defense, int speedAttack, int speedDefense, int speed, int generation, bool legendary)
        {
            Id = id;
            Name = name;
            Type1 = type1;
            Type2 = type2;
            Total = total;
            HP = hP;
            Attack = attack;
            Defense = defense;
            SpeedAttack = speedAttack;
            SpeedDefense = speedDefense;
            Speed = speed;
            Generation = generation;
            Legendary = legendary;
        }

        public int PokemondId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type1 { get; set; }
        public string Type2 { get; set; }
        public int Total { get; set; }
        public int HP { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int SpeedAttack { get; set; }
        public int SpeedDefense { get; set; }
        public int Speed { get; set; }
        public int Generation { get; set; }
        public bool Legendary { get; set; }
        public string PhotoPath
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_photoPath))
                {
                    return "images/" + Name.ToLowerInvariant() + ".png";
                }
                return _photoPath;

            }

            set { _photoPath = value; }
        }
    }
}
