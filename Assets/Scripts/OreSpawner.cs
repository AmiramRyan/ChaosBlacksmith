using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OreSpawner : MonoBehaviour
{
    public Transform[] oreSpots;
    public GameObject[] oresArray;
    public GameObject[] bagArray;
    [SerializeField] private int nextSpot;

    void Start()
    {
        nextSpot = 0;
        bagArray = new GameObject[oreSpots.Length];
        Setup();
    }

    // Update is called once per frame
    void Update()
    {
        //for debugg
        if (Input.GetKeyDown("d"))
        {
            Setup();
        } 
        //end debugg
    }

    private void Setup()
    {
        do
        {
            int randomOre = Random.Range(0, oresArray.Length);
            GameObject ore = Instantiate(oresArray[randomOre],oreSpots[nextSpot].position,Quaternion.identity) as GameObject;
            ore.GetComponent<GenericOre>().currentPos = ore.transform.position;
            ore.GetComponent<GenericOre>().positionInBag = nextSpot;
            bagArray[nextSpot] = ore;
            nextSpot++;
        }while (nextSpot < oreSpots.Length) ;
    }

    public void FillGaps(int thisOreSpot)
    {
        int randomOre = Random.Range(0, oresArray.Length);
        GameObject ore = Instantiate(oresArray[randomOre], oreSpots[thisOreSpot].position, Quaternion.identity) as GameObject;
        ore.GetComponent<GenericOre>().currentPos = ore.transform.position;
        ore.GetComponent<GenericOre>().positionInBag = thisOreSpot;
        bagArray[thisOreSpot] = ore;
    }
    
}
