using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : GameManager
{
    // Start is called before the first frame update
    public override void Start()
    {
        questSpawner.timeBetweenQuests = timeBetweenQuestsLvl1;
        currentLevel = Level.lvl1;
        //do nothing more
    }

    public override void Update()
    {
        //do nothing
    }
}
