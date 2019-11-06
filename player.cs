public class Player
{
    public string Name {get; private set;}
    public Weapon CurrentWeapon {get; private set;}

    public Player(string playerName)
    {
        Name = playerName;
        CurrentWeapon = new Sword();
    }

    public void Attack()
    {
        if(CurrentWeapon != null)
        {
            CurrentWeapon.Attack();
        }
    }
}