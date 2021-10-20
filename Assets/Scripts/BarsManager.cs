using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarsManager : MonoBehaviour
{
    public int numberOfGold;
    public int numberOfIron;
    public int numberOfCopper;
    public int numberOfNickle;
    [SerializeField] private Text goldNumUi;
    [SerializeField] private Text ironNumUi;
    [SerializeField] private Text copperNumUi;
    [SerializeField] private Text nickleNumUi;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        goldNumUi.text = "X " + numberOfGold;
        ironNumUi.text = "X " + numberOfIron;
        copperNumUi.text = "X " + numberOfCopper;
        nickleNumUi.text = "X " + numberOfNickle;
    }

    public void AddBar(string name)
    {
        switch (name)
        {
            case "Gold":
                numberOfGold++;
                break;
            case "Iron":
                numberOfIron++;
                break;
            case "Nickle":
                numberOfNickle++;
                break;
            case "Copper":
                numberOfCopper++;
                break;
            default:
                break;
        }
    }

}
