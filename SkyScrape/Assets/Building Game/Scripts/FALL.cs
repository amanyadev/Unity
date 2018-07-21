using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FALL : MonoBehaviour {

    public Pendulum pend;

    // Use this for initialization
    void Start()
    {

        pend = GetComponent<Pendulum>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            pend.enabled = false;
        }

    }
}
