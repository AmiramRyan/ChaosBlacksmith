using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyManager : MonoBehaviour
{
    public ScoreValue money;
    public Text moneyText;
    void Update()
    {
        moneyText.text = money.runTimeValueScore + "G";
    }
    public void AddMoney(float amount)
    {
        money.runTimeValueScore += amount;
    }
}
