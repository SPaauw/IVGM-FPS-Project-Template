using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_core : MonoBehaviour
{
    public float rotationSpeed = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0f, (rotationSpeed * Time.deltaTime), 0f);
    }
}
