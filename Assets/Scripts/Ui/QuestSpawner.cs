using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestSpawner : MonoBehaviour
{
    [SerializeField] private bool questReady;
    public Quest[] questArr;
    public GameObject[] questWindowArr;
    public float timeBetweenQuests;
    private void Start()
    {
        questReady = false;
        StartCoroutine(QuestSpawnTimerCo());
    }

    void Update()
    {
        if (questReady)
        {
            if (FindEmptyQuest()<100) //restart timer
            {
                questReady = false;
                int I = FindEmptyQuest();
                int rnd = Random.Range(0, questArr.Length);
                //spawn quest
                questWindowArr[I].SetActive(true);
                questWindowArr[I].GetComponent<QuestSetUp>().quest = questArr[rnd];
                questWindowArr[I].GetComponent<QuestSetUp>().SetUp();
                StartCoroutine(QuestSpawnTimerCo());
                
            }
            else
            {
                questReady = false;
                StartCoroutine(QuestSpawnTimerCo());
            }
        }
    }

    private IEnumerator QuestSpawnTimerCo()
    {
        yield return new WaitForSeconds(timeBetweenQuests);
        questReady = true;
    }

    private int  FindEmptyQuest()
    {
        for (int i = 0; i < questWindowArr.Length; i++)
        {
            QuestSetUp temp = questWindowArr[i].GetComponent<QuestSetUp>();
            if (!temp.isQuestActive) {
                return i;
            }
        }
        return 100; //all full
    }
}
