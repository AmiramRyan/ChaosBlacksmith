using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class Quest : ScriptableObject
{
    public string title;
    public List<QuestBar> barsReqArr;
    public int worth;
    public float timeLimit;
    public float moneyWorth;
}
