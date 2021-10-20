using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericOre : MonoBehaviour
{
    public bool onTheForge;
    public GameObject spawner;
    public GameObject tempManager;
    public GameObject barManager;
    public int tempChangeAmount;
    public Ore oreData;
    public Vector3 currentPos;
    public int positionInBag;

    public virtual void Start()
    {
        spawner = GameObject.FindWithTag("OreSpawner");
        tempManager = GameObject.FindWithTag("TemperatureManager");
        barManager = GameObject.FindWithTag("BarsManager");
        SetPosition(currentPos);
        this.GetComponent<SpriteRenderer>().sprite = oreData.oreSprite;
        onTheForge = false;
    }

    #region Drag N Drop
    public virtual void OnMouseDrag()
    {
        Vector3 mousPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousPos.z = 0;
        transform.position = mousPos;
    }

    public virtual void OnMouseUp()
    {
        if (onTheForge)
        {
            PutInForge();
        }
        else
        {
            transform.position = currentPos;
        }
    }

    /*private void OnTriggerStay2D(Collider2D other) IF I WANNA ADD HIGHLIGHTS
    {
        if (other.CompareTag("Forge") && other.isTrigger)
        {
            Debug.Log("ImONNNN");
        }
    }*/

    public virtual void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Forge") && other.isTrigger)
        {
            onTheForge = true;
        }
    }

    public virtual void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Forge") && other.isTrigger)
        {
            onTheForge = false;
        }
    }

    #endregion
    public virtual void PutInForge()
    {
        if (tempManager.GetComponent<Tempeture>().currentTemp >= oreData.meltingPoint)
        {
            spawner.GetComponent<OreSpawner>().FillGaps(positionInBag);
            tempManager.GetComponent<Tempeture>().ChangeTemp(tempChangeAmount);
            barManager.GetComponent<BarsManager>().AddBar(oreData.name);
            Destroy(this.gameObject);
        }
        else
        {
            //ore ruinend somehow
            spawner.GetComponent<OreSpawner>().FillGaps(positionInBag);
            tempManager.GetComponent<Tempeture>().ChangeTemp(tempChangeAmount);
            //debug only
            Debug.Log("Ruined! " + this.gameObject.name);
            Destroy(this.gameObject);
        }
    }

    public void SetPosition(Vector3 position)
    {
        transform.position = position;
    }
}
