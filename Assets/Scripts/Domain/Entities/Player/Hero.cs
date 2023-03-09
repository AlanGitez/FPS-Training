

public class Hero
{
    public int id { get; private set; }
    public float currentHealt { get; private set; }
    public float strength { get; private set; }
    public float level { get; private set; }
    public float experience { get; private set; }
    public float money { get; private set; }
    public Weapon currentWeapon { get; private set; }



    public Hero(int id, float currentHealt, float strength, Weapon currentWeapon)
    {
        this.id = id;
        this.currentHealt = currentHealt;
        this.strength = currentWeapon.shootPower;
    }
}
