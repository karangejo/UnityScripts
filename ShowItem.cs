using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class ShowItem : MonoBehaviour
{
    // get the text to be displayed and initialize some GameObject variables needed
    public string text;
    private GameObject menu;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        // get a reference to the player and the menu to be displayed from the child game objects
        player = GameObject.FindGameObjectWithTag("Player");
        menu = transform.Find("ItemDisplay").gameObject;
        menu.SetActive(false);
        // set the menu to be inactive on startup
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        // set the menu to be active and to follow the player
        menu.SetActive(true);
    }

    void OnTriggerExit(Collider other)
    {
        // set the menu to be inactive
        menu.SetActive(false);
    }
}
