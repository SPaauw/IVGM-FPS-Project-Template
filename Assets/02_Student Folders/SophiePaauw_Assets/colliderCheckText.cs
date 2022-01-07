using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class colliderCheckText : MonoBehaviour
{
    GameObject displayText;
    public string DisplayedString;
    public string SecondDisplayString;
    private bool triggered = false;
    public GameObject collisionobj;
    public GameObject Manager;
    

    // Start is called before the first frame update
    void Start()
    {
        
        GameObject[] templist = GameObject.FindGameObjectsWithTag("Interact text");
        if (templist.Length != 0)
            displayText = templist[0];
        else
            displayText = null;
        if (displayText == null){
            Debug.Log("WARNING: Prefab with \"Display text\" tag missing");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (triggered && Input.GetKeyDown(KeyCode.F)){
            displayText.GetComponent<TextMeshProUGUI>().text = SecondDisplayString;
        }
    }

    private void OnTriggerEnter(Collider collision) {

        if (gameObject.GetComponent<colliderCheckText>().enabled == true )
        {
            displayText.GetComponent<TextMeshProUGUI>().text = DisplayedString;
            //Debug.Log("true");
            triggered = true;
        }
    }

    private void OnTriggerExit(Collider collision){
        displayText.GetComponent<TextMeshProUGUI>().text = "";
        triggered = false;
    }
}
