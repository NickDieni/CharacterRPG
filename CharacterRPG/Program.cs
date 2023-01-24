using CharacterRPG;
using System.Security.Cryptography.X509Certificates;

Character firstChar = new Character();
//firstChar.Name = "EtEllerAndet";

//The method is static, so it runs on the class and not the object
firstChar.CharacterClass = Character.GetCharacterClassRandomly();
firstChar.Stats.Dexterity = 1;


Console.WriteLine($"Name: {firstChar.Name}\nClass: {firstChar.CharacterClass}\nAge: {firstChar.GetARandomBirthDay}");
firstChar.Stats.GetRolled();
Console.WriteLine();
Console.WriteLine("Do you want to reroll press R, Press X to exit");
string tast = Convert.ToString(Console.ReadKey().KeyChar).ToLower();
if (tast == "r")
{
    bool roll = true;
    while (roll = true)
    {
        Console.Clear();
        Console.WriteLine($"Name: {firstChar.Name}\nClass: {firstChar.CharacterClass}");
        firstChar.Stats.GetRolled();
        Console.WriteLine();
        Console.WriteLine("Do you want to reroll press R, Press X to exit");
        tast = Convert.ToString(Console.ReadKey().KeyChar).ToLower();
        if (tast == "x") break;
        Console.Clear();
    }
    
}
