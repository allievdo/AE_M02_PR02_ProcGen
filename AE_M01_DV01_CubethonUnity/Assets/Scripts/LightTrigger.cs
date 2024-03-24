using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class LightTrigger : MonoBehaviour
{
    Light spotlight;
    // Start is called before the first frame update
    void Start()
    {
        spotlight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            spotlight.enabled = !spotlight.enabled;
        }
    }
}
