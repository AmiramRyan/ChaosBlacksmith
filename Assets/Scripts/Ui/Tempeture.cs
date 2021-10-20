using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tempeture : MonoBehaviour
{
    [SerializeField]  private int maxTemp;
    [SerializeField] private Text tempText;
    public int currentTemp;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateTempBarUi();
    }

    public void ChangeTemp(int amount)
    {
        currentTemp += amount;
        if(currentTemp < 0)
        {
            currentTemp = 0;
        }
        else if (currentTemp > maxTemp)
        {
            currentTemp = maxTemp;
        }
    }

    private void UpdateTempBarUi()
    {
        tempText.text = "" + currentTemp;
    }
}
