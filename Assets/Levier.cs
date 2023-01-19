using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Levier : MonoBehaviour
{
    TimelineManager timelineManager;
    Carrousel manege;
    Canvas ui;

    // Start is called before the first frame update
    void Start()
    {
        timelineManager = GameObject.Find("TimelineManager").GetComponent<TimelineManager>();
        manege = GameObject.Find("SM.carrousel").GetComponent<Carrousel>();
        ui = GameObject.Find("uilevier").GetComponent<Canvas>();
        ui.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        ControlerManege();
        ui.enabled = true;
    }

    private void OnTriggerExit(Collider other)
    {
        ui.enabled = false;
    }

    private void ControlerManege()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            manege.directionRotation = 1;
            timelineManager.VoyagerDansLeTemps("passe1");
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            manege.directionRotation = -1;
            timelineManager.VoyagerDansLeTemps("present");
        }
    }

}
