
public class Gun : Weapon
{
    public override int maxBullets { get; set; } 
    public override int currentBullets { get; set; }
    protected override float rateOfFire { get; set; } = 0.5f;
    protected override float reloadTime { get; set; } = 1.5f;
    protected override float recoil { get; set; } = 3f;
    public override int shootPower { get; set; } = 10;



    protected override void reload()
    {
        // falta implementar la cantidad de cargadores que tiene
        if (currentBullets < maxBullets) { 
        
            currentBullets = maxBullets;
        }
    }

    protected override void shoot()
    {
        if (currentBullets > 0) { 

            currentBullets--;
        }
    }
}
