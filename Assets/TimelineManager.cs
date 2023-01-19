using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimelineManager : MonoBehaviour
{
    GetChildren present;
    GetChildren passe1;

    // Start is called before the first frame update
    void Start()
    {
        present = GameObject.Find("PRESENT").GetComponent<GetChildren>();
        passe1 = GameObject.Find("PASSE1").GetComponent<GetChildren>();
        passe1.disableChildren();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void VoyagerDansLeTemps(string timeline)
    {
        if (timeline == "present")
        {
            present.enableChildren();
            passe1.disableChildren();
        }
        if (timeline == "passe1" || timeline == "passe")
        {
            passe1.enableChildren();
            present.disableChildren();
        }
    }
}
