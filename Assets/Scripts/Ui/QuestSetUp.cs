using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuestSetUp : MonoBehaviour
{
    public Quest quest;
    public Text title;
    public GameObject barImageAndReq;
    public Transform reqParent;
    public bool isQuestActive;
    public GameObject barManger;
    public List<GameObject> thisQuestReq;
    public GameObject scoreManger;
    public Slider timeSlider;
    private float timeLimit;
    private float timeLimitSec;
    public GameObject moneyManager;


    private void Update()
    {
        timeLimitSec -= Time.deltaTime;
        timeSlider.value = timeLimitSec / timeLimit;
        if(timeLimitSec <= 0)
        {
            //lose stuff
            this.GetComponent<Image>().color = Color.red;
            StartCoroutine(LoseCo());
        }
    }

    public void SetUp()
    {
        isQuestActive = true;
        title.text = quest.title;
        for (int i = 0; i < quest.barsReqArr.Count; i++)
        {
            GameObject temp = Instantiate(barImageAndReq, reqParent, true) as GameObject;
            temp.GetComponentInChildren<Text>().text = "" + quest.barsReqArr[i].requierdNum;
            temp.GetComponentInChildren<Text>().color = quest.barsReqArr[i].textColor;
            temp.GetComponentInChildren<Image>().sprite = quest.barsReqArr[i].barImg;
            timeLimit = quest.timeLimit;
            timeLimitSec = timeLimit;

            thisQuestReq.Add(temp);
        }
    }

    public void CheckQuestStatus()
    {
        if (CheckReq())
        {
            CompleateQuest();
            //remove old req
            isQuestActive = false;
            this.gameObject.SetActive(false);
        }
    }

    public bool CheckReq()
    {
        for (int i = 0; i < quest.barsReqArr.Count; i++)
        {
            switch (quest.barsReqArr[i].barName)
            {
                case "Gold":
                    if (barManger.GetComponent<BarsManager>().numberOfGold < quest.barsReqArr[i].requierdNum)
                    {
                        return false;
                    }
                    break;
                case "Iron":
                    if (barManger.GetComponent<BarsManager>().numberOfIron < quest.barsReqArr[i].requierdNum)
                    {
                        return false;
                    }
                    break;
                case "Nickle":
                    if (barManger.GetComponent<BarsManager>().numberOfNickle < quest.barsReqArr[i].requierdNum)
                    {
                        return false;
                    }
                    break;
                case "Copper":
                    if (barManger.GetComponent<BarsManager>().numberOfCopper < quest.barsReqArr[i].requierdNum)
                    {
                        return false;
                    }
                    break;
                default:
                    break;
            }
        }
        return true;
    }

    public void CompleateQuest()
    {
        for (int i = 0; i < quest.barsReqArr.Count; i++)
        {
            switch (quest.barsReqArr[i].barName)
            {
                case "Gold":
                    barManger.GetComponent<BarsManager>().RemoveBar("Gold", quest.barsReqArr[i].requierdNum);
                    break;
                case "Iron":
                    barManger.GetComponent<BarsManager>().RemoveBar("Iron", quest.barsReqArr[i].requierdNum);
                    break;
                case "Nickle":
                    barManger.GetComponent<BarsManager>().RemoveBar("Nickle", quest.barsReqArr[i].requierdNum);
                    break;
                case "Copper":
                    barManger.GetComponent<BarsManager>().RemoveBar("Copper", quest.barsReqArr[i].requierdNum);
                    break;
                default:
                    break;
            }
            Destroy(thisQuestReq[i]);
        }
        thisQuestReq.Clear();
        //add score
        scoreManger.GetComponent<ScoreManager>().AddScore(quest.worth);
        moneyManager.GetComponent<MoneyManager>().AddMoney(quest.moneyWorth);
    }

    public IEnumerator LoseCo()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("MainMenu");
    }
}
