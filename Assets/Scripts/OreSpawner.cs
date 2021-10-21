using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OreSpawner : MonoBehaviour
{
    public Transform[] oreSpots;
    public GameObject[] oresArray;
    public GameObject[] bagArray;
    [SerializeField] private List<GameObject> currentBagList;
    [SerializeField] private int nextSpot;
    public GameObject soundManager;

    void Start()
    {
        nextSpot = 0;
        bagArray = new GameObject[oreSpots.Length];
        FirstSetup();
    }

    private void FirstSetup()
    {
        for (int i = 0; i < 3; i++)
        {
            GameObject ore = Instantiate(oresArray[4], oreSpots[nextSpot].position, Quaternion.identity) as GameObject;
            ore.GetComponent<GenericOre>().currentPos = ore.transform.position;
            ore.GetComponent<GenericOre>().positionInBag = nextSpot;
            bagArray[i] = ore;
            nextSpot++;
        }
        do
        {
            int randomOre = Random.Range(0, oresArray.Length);
            GameObject ore = Instantiate(oresArray[randomOre], oreSpots[nextSpot].position, Quaternion.identity) as GameObject;
            ore.GetComponent<GenericOre>().currentPos = ore.transform.position;
            ore.GetComponent<GenericOre>().positionInBag = nextSpot;
            //currentBagList.Add(ore);
            bagArray[nextSpot] = ore;
            nextSpot++;
        } while (nextSpot < oreSpots.Length);
    }

    public void FillGaps(int thisOreSpot)
    {
        int randomOre = Random.Range(0, oresArray.Length);
        GameObject ore = Instantiate(oresArray[randomOre], oreSpots[thisOreSpot].position, Quaternion.identity) as GameObject;
        ore.GetComponent<GenericOre>().currentPos = ore.transform.position;
        ore.GetComponent<GenericOre>().positionInBag = thisOreSpot;
        bagArray[thisOreSpot] = ore;
    }

    #region Shop packs

    public void SpawnCoal()
    {
        soundManager.GetComponent<SoundManager>().click.Play();
        ClearBag();
        nextSpot = 0;
        for(int i = 0; i < 5; i++)
        {
            GameObject ore = Instantiate(oresArray[4], oreSpots[nextSpot].position, Quaternion.identity) as GameObject;
            ore.GetComponent<GenericOre>().currentPos = ore.transform.position;
            ore.GetComponent<GenericOre>().positionInBag = nextSpot;
            bagArray[i] = ore;
            nextSpot++;
        }
        do
        {
            int randomOre = Random.Range(0, oresArray.Length);
            GameObject ore = Instantiate(oresArray[randomOre], oreSpots[nextSpot].position, Quaternion.identity) as GameObject;
            ore.GetComponent<GenericOre>().currentPos = ore.transform.position;
            ore.GetComponent<GenericOre>().positionInBag = nextSpot;
            //currentBagList.Add(ore);
            bagArray[nextSpot] = ore;
            nextSpot++;
        } while (nextSpot < oreSpots.Length);
    }
    public void SpawnGold()
    {
        ClearBag();
        soundManager.GetComponent<SoundManager>().click.Play();
        nextSpot = 0;
        for (int i = 0; i < 5; i++)
        {
            GameObject ore = Instantiate(oresArray[0], oreSpots[nextSpot].position, Quaternion.identity) as GameObject;
            ore.GetComponent<GenericOre>().currentPos = ore.transform.position;
            ore.GetComponent<GenericOre>().positionInBag = nextSpot;
            bagArray[i] = ore;
            nextSpot++;
        }
        do
        {
            int randomOre = Random.Range(0, oresArray.Length);
            GameObject ore = Instantiate(oresArray[randomOre], oreSpots[nextSpot].position, Quaternion.identity) as GameObject;
            ore.GetComponent<GenericOre>().currentPos = ore.transform.position;
            ore.GetComponent<GenericOre>().positionInBag = nextSpot;
            //currentBagList.Add(ore);
            bagArray[nextSpot] = ore;
            nextSpot++;
        } while (nextSpot < oreSpots.Length);
    }
    public void SpawnCopper()
    {
        ClearBag();
        soundManager.GetComponent<SoundManager>().click.Play();
        nextSpot = 0;
        for (int i = 0; i < 5; i++)
        {
            GameObject ore = Instantiate(oresArray[1], oreSpots[nextSpot].position, Quaternion.identity) as GameObject;
            ore.GetComponent<GenericOre>().currentPos = ore.transform.position;
            ore.GetComponent<GenericOre>().positionInBag = nextSpot;
            bagArray[i] = ore;
            nextSpot++;
        }
        do
        {
            int randomOre = Random.Range(0, oresArray.Length);
            GameObject ore = Instantiate(oresArray[randomOre], oreSpots[nextSpot].position, Quaternion.identity) as GameObject;
            ore.GetComponent<GenericOre>().currentPos = ore.transform.position;
            ore.GetComponent<GenericOre>().positionInBag = nextSpot;
            //currentBagList.Add(ore);
            bagArray[nextSpot] = ore;
            nextSpot++;
        } while (nextSpot < oreSpots.Length);
    }
    public void SpawnNickle()
    {
        ClearBag();
        soundManager.GetComponent<SoundManager>().click.Play();
        nextSpot = 0;
        for (int i = 0; i < 5; i++)
        {
            GameObject ore = Instantiate(oresArray[3], oreSpots[nextSpot].position, Quaternion.identity) as GameObject;
            ore.GetComponent<GenericOre>().currentPos = ore.transform.position;
            ore.GetComponent<GenericOre>().positionInBag = nextSpot;
            bagArray[i] = ore;
            nextSpot++;
        }
        do
        {
            int randomOre = Random.Range(0, oresArray.Length);
            GameObject ore = Instantiate(oresArray[randomOre], oreSpots[nextSpot].position, Quaternion.identity) as GameObject;
            ore.GetComponent<GenericOre>().currentPos = ore.transform.position;
            ore.GetComponent<GenericOre>().positionInBag = nextSpot;
            //currentBagList.Add(ore);
            bagArray[nextSpot] = ore;
            nextSpot++;
        } while (nextSpot < oreSpots.Length);
    }
    public void SpawnIron()
    {
        ClearBag();
        soundManager.GetComponent<SoundManager>().click.Play();
        nextSpot = 0;
        for (int i = 0; i < 5; i++)
        {
            GameObject ore = Instantiate(oresArray[2], oreSpots[nextSpot].position, Quaternion.identity) as GameObject;
            ore.GetComponent<GenericOre>().currentPos = ore.transform.position;
            ore.GetComponent<GenericOre>().positionInBag = nextSpot;
            bagArray[i] = ore;
            nextSpot++;
        }
        do
        {
            int randomOre = Random.Range(0, oresArray.Length);
            GameObject ore = Instantiate(oresArray[randomOre], oreSpots[nextSpot].position, Quaternion.identity) as GameObject;
            ore.GetComponent<GenericOre>().currentPos = ore.transform.position;
            ore.GetComponent<GenericOre>().positionInBag = nextSpot;
            //currentBagList.Add(ore);
            bagArray[nextSpot] = ore;
            nextSpot++;
        } while (nextSpot < oreSpots.Length);
    }

    #endregion

    private void ClearBag()
    {
        for(int i = bagArray.Length-1; i>= 0; i--)
        {
            Debug.Log(i);
            Destroy(bagArray[i]);
        }
    }
}
