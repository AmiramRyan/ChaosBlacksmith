using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coal : GenericOre
{
    public override void Start()
    {
        spawner = GameObject.FindWithTag("OreSpawner");
        tempManager = GameObject.FindWithTag("TempatureManager");
        SetPosition(currentPos);
        this.GetComponent<SpriteRenderer>().sprite = oreData.oreSprite;
        onTheForge = false;
    }
   
    public override void PutInForge()
    {
        spawner.GetComponent<OreSpawner>().FillGaps(positionInBag);
        tempManager.GetComponent<Tempeture>().ChangeTemp(tempChangeAmount);
        //debug only
        Debug.Log("Im inside the forge now!" + this.gameObject.name);
        Destroy(this.gameObject);
    }
}
