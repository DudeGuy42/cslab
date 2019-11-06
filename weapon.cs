public abstract class Weapon 
{
    public string Name {get; private set;}
    public Weapon(string name)
    {
        this.Name = name;
    }

    public abstract void Attack();
}