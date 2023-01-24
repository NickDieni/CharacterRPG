namespace CharacterRPG
{
    internal class Character
    {
        //Because the method that uses this array is static, we also make the array static.
        private static string[] characterClass = { "Warrior", "Wizard", "Priest", "Rouge", "Summoner", "Druid", "Ranger" };
        public static Random random = new Random();
        public string Name { get; set; } = "NoNameYet";
        public string CharacterClass { get; set; }
        public DateTime Birthday { get; set; }
        public Stats Stats { get; set; } = new();


        public Character()
        {
            GetARandomBirthDay();
            Name = RandomNameGenerator(3, 8);
        }

        private string RandomNameGenerator(int v1, int v2)
        {
            //0-5 vowels, 6-end consonant
            char[] letters = { 'a', 'e', 'i', 'o', 'u', 'y', 'b', 'c', 'd', 'f', 'g',
                'h', 'j', 'l', 'm', 'n', 'j', 'p', 'q', 't', 'v', 'w', 'x', 'z', 'r', 's' };

            int length = random.Next(v1, v2 + 1);
            int StartLetter = random.Next(letters.Length);
            bool isVowel = StartLetter < 6 ? true : false;
            string name = letters[StartLetter].ToString().ToUpper();
            for (int i = 0; i < length; i++)
            {
                if (isVowel)
                {
                    name += letters[random.Next(6, letters.Length)];
                    isVowel = false;
                }
                else
                {
                    name += letters[random.Next(0, 6)];
                    isVowel = true;
                }

            }

            return name;
        }

        public TimeSpan GetARandomBirthDay()
        {
            var today = new DateTime(1150);
            DateTime start = new DateTime(1020);
            DateTime end = new DateTime(1120);
            int range = (end - start).Days;
            int days = random.Next(range);
            Birthday = start.AddYears(days);

            var diffOfDates = Birthday - today;
            diffOfDates.ToString();
            return diffOfDates;
        }


        //Static method runs on class and not on object.
        public static string GetCharacterClassRandomly()
        {
            //Random random = new Random();
            int r = random.Next(characterClass.Length);
            string cc = characterClass[r];
            return cc;
        }
    }
}