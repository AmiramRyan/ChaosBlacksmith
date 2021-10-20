using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GenericDrag : MonoBehaviour
{
    
    [SerializeField] private bool onTheForge;
    [SerializeField] GameObject spawner;
    [SerializeField] Ore oreData;

    private void Start()
    {
        spawner = GameObject.FindWithTag("OreSpanwer");
        //SetPosition(oreData.startPos);
        onTheForge = false;
    }
    private void OnMouseDrag()
    {
         Vector3 mousPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousPos.z = 0;
        transform.position = mousPos;
    }

    private void OnMouseUp()
    {
        if (onTheForge)
        {
            PutInForge();
        }
        else
        {
            //transform.position = startPos;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Forge") && other.isTrigger)
        {
            onTheForge = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Forge") && other.isTrigger)
        {
            onTheForge = false;
        }
    }
    private void PutInForge()
    {
        //spawner.GetComponent<OreSpawner>().FillGaps(oreData.positionInBag);
        //debug only
        Debug.Log("Im inside the forge now!" + this.gameObject.name);
        Destroy(this.gameObject);
    }

    public void SetPosition(Vector3 position)
    {
        transform.position = position;
    }
}
