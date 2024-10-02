using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class TheClock : MonoBehaviour
{
    public GameObject hour;
    public GameObject minute;
    public GameObject second;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        float hourTime = DateTime.Now.Hour;
        float minuteTime = DateTime.Now.Minute;
        float secondTime = DateTime.Now.Second;

        hour.transform.rotation = Quaternion.Euler(-hourTime * 6 + 90f, 0, 0);
        minute.transform.rotation = Quaternion.Euler(-minuteTime * 6 + 90f, 0, 0);
        second.transform.rotation = Quaternion.Euler(-secondTime * 6 + 90f, 0, 0);
    }
}
