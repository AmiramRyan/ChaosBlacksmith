using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Level
{
    lvl1,
    lvl2,
    lvl3,
    lvl4,
    lvl5
}
public class GameManager : MonoBehaviour
{
    public int questDone;
    [SerializeField] private QuestSpawner questSpawner;
    public bool questChange;
    public Level currentLevel;
    public int timeBetweenQuestsLvl1;
    public int timeBetweenQuestsLvl2;
    public int timeBetweenQuestsLvl3;
    public int timeBetweenQuestsLvl4;
    public int timeBetweenQuestsLvl5;
    void Start()
    {
        questSpawner.timeBetweenQuests = timeBetweenQuestsLvl1;
        currentLevel = Level.lvl1;
    }

    void Update()
    {
        if (questChange)
        {
            questChange = false;
            switch (questDone)
            {
                case 20:
                    currentLevel = Level.lvl5;
                    break;
                case 15:
                    currentLevel = Level.lvl4;
                    break;
                case 10:
                    currentLevel = Level.lvl3;
                    break;
                case 5:
                    currentLevel = Level.lvl2;
                    break;
                default:
                    break;
            }
            switch (currentLevel)
            {
                case Level.lvl2:
                    questSpawner.timeBetweenQuests = timeBetweenQuestsLvl2;
                    break;
                case Level.lvl3:
                    questSpawner.timeBetweenQuests = timeBetweenQuestsLvl3;
                    break;
                case Level.lvl4:
                    questSpawner.timeBetweenQuests = timeBetweenQuestsLvl4;
                    break;
                case Level.lvl5:
                    questSpawner.timeBetweenQuests = timeBetweenQuestsLvl5;
                    break;
                default:
                    break;
            }
        }
    }
}
