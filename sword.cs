using System;
public class Sword: Weapon {
    public Sword(): base("Sword of Doomdom")
    {
        
    }

    public override void Attack()
    {
        Console.WriteLine($"You attack with {this.Name}");
    }
}