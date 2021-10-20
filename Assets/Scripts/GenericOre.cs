using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericOre : MonoBehaviour
{
    [SerializeField] private bool onTheForge;
    [SerializeField] GameObject spawner;
    public Ore oreData;
    public Vector3 currentPos;
    public int positionInBag;

    private void Start()
    {
        spawner = GameObject.FindWithTag("OreSpawner");
        SetPosition(currentPos);
        this.GetComponent<SpriteRenderer>().sprite = oreData.oreSprite;
        onTheForge = false;
    }
    #region Drag N Drop
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
            transform.position = currentPos;
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

    #endregion
    private void PutInForge()
    {
        spawner.GetComponent<OreSpawner>().FillGaps(positionInBag);
        //debug only
        Debug.Log("Im inside the forge now!" + this.gameObject.name);
        Destroy(this.gameObject);
    }

    public void SetPosition(Vector3 position)
    {
        transform.position = position;
    }
}
