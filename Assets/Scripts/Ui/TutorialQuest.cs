using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum quest 
{
    quest0,
    quest1,
    quest2
}

public class TutorialQuest : QuestSpawner
{
    int I;
    private quest currentQuest;
    public Tempeture tempManager;
    private bool quest0Done = false;
    private bool quest1Done = false;
    private bool quest2Done = false;
    public override void Start()
    {
        questReady = false;
        I = 0;
    }
    public override void Update()
    {
        if (questReady)
        {
            questReady = false;
            //spawn quest
            questWindowArr[0].SetActive(true);
            questWindowArr[0].GetComponent<QuestSetUp>().quest = questArr[I];
            questWindowArr[0].GetComponent<QuestSetUp>().SetUp();
            I++;
        }
    }
}
