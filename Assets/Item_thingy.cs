using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_thingy : MonoBehaviour
{
    public Inventory_thing Inventory;
    public GameObject thing;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider colision)
    { Inventory.Additem();
        this.gameObject.SetActive(false);
    }
}
