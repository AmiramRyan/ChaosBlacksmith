using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tempeture : MonoBehaviour
{
    [SerializeField]  private float maxTemp;
    [SerializeField] private Text tempText;
    [SerializeField] private Slider tempSlider;
    [SerializeField] private float burnOutRate;
    public float currentTemp;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateTempBarUi();
        if (currentTemp > 0)
        {
            currentTemp -= Time.deltaTime * burnOutRate;
        }
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
        tempText.text = Mathf.Floor(currentTemp) + "C";
        tempSlider.value = currentTemp / maxTemp;
    }
}
