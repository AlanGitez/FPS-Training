

public class DamageData
{
    public readonly int atackerId;
    public readonly int opponentId;
    public readonly float damage;
    public readonly float currentHealt;


    public DamageData(int atackerId, int opponentId, float damage, float currentHealt)
    {
        this.atackerId = atackerId;
        this.opponentId = opponentId;
        this.damage = damage;
        this.currentHealt = currentHealt;
    }
}
