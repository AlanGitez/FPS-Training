using UnityEngine;

public class Enemy 
{
    public int id { get; private set; }
    public float currentHealt { get; private set; }
    public float strength { get; private set; }
    public float maxDropsExperience { get; private set; }
    public float maxDropsMoney { get; private set; }
    public bool isDead { get; private set; }

    public Enemy(int id, float currentHealt, float strength)
    {
        this.id = id;
        this.currentHealt = currentHealt;
        this.strength = strength;
    }

    //public DamageData receiveDamageFrom(Hero hero) {

    //    var damage = hero.strength;

    //    if (!isDead) { 
    //        currentHealt -= damage;

    //        if (currentHealt <= 0) {
    //            currentHealt = 0;

    //            concedeRewardsTo(hero);

    //            isDead = true;
    //        }
    //    }


    //    return new DamageData(hero.id, id, damage, currentHealt);
    //}

    //public RewardsData concedeRewardsTo(Hero hero) {

    //    var randomExperience = Random.Range(1, maxDropsExperience);
    //    var randomMoney = Random.Range(1, maxDropsMoney); 

    //    return new RewardsData(hero.id, randomExperience, randomMoney);
    //}
}
