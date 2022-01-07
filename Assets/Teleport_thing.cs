using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport_thing : MonoBehaviour
{
    public Inventory_thing Inventory;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Inventory.Itemcount == 3)
        {
            transform.GetChild(0).gameObject.GetComponent<MeshRenderer>().enabled = true;
            transform.GetChild(0).gameObject.GetComponent<MeshCollider>().enabled = true;
            transform.GetChild(1).gameObject.SetActive(true);
            transform.GetChild(2).gameObject.SetActive(true);
            transform.GetChild(3).gameObject.SetActive(true);
        }

    }
}
