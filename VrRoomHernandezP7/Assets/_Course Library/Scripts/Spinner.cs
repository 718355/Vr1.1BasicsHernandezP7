using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    public GameObject reticle;
    public int speed = 3;
    public bool increasing = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 funny = new Vector3(0, 1, 0);
        reticle.transform.Rotate(funny * Time.deltaTime * speed);
        
        
    
    }

    private void FixedUpdate()
    {
        if (reticle.transform.localScale.x >= 1f)
        {
            increasing = false;

        }
        else if (reticle.transform.localScale.x <= 0.8f)
        {
            increasing = true;

        }
        if (increasing)
        {
            reticle.transform.localScale = new Vector3(reticle.transform.localScale.x + 0.01f, 1, reticle.transform.localScale.x + 0.01f) * Time.deltaTime;
        }
        else if (!increasing)
        {
            reticle.transform.localScale = new Vector3(reticle.transform.localScale.x - 0.01f, 1, reticle.transform.localScale.x - 0.01f) * Time.deltaTime;
        }
    }
}
