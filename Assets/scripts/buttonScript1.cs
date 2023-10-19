using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonScript1 : MonoBehaviour
{
    public GameObject obj;
    void Start()
    {
        obj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        obj.SetActive(true);
    }

    
}

