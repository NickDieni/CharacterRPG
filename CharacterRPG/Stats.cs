using System.Reflection;

namespace CharacterRPG
{
    internal class Stats
    {
        private Random rnd = new Random();


        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Dconstitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }

        public void GetRolled()
        {
            foreach (var property in this.GetType().GetProperties())
            {
                property.SetValue(this, rnd.Next(3, 19));
                Console.WriteLine(property.Name + ": " + property.GetValue(this));
            }
        }


    }
}
