using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public OreSpawner oreSpawner;
    public MoneyManager moneyManager;

    public float coalPackCost;
    public float copperPackCost;
    public float nicklePackCost;
    public float ironPackCost;
    public float goldPackCost;

    public void CoalPack()
    {
        if (moneyManager.money.runTimeValueScore >= coalPackCost)
        {
            moneyManager.AddMoney(-coalPackCost);
            oreSpawner.SpawnCoal();
        }
    }
    public void CopperPack()
    {
        if (moneyManager.money.runTimeValueScore >= copperPackCost)
        {
            moneyManager.AddMoney(-copperPackCost);
            oreSpawner.SpawnCopper();
        }
    }
    public void nicklePack()
    {
        if (moneyManager.money.runTimeValueScore >= nicklePackCost)
        {
            moneyManager.AddMoney(-nicklePackCost);
            oreSpawner.SpawnNickle();
        }
    }
    public void ironPack()
    {
        if (moneyManager.money.runTimeValueScore >= ironPackCost)
        {
            moneyManager.AddMoney(-ironPackCost);
            oreSpawner.SpawnIron();
        }
    }

    public void GoldPack()
    {
        if (moneyManager.money.runTimeValueScore >= goldPackCost)
        {
            moneyManager.AddMoney(-goldPackCost);
            oreSpawner.SpawnGold();
        }
    }
}
