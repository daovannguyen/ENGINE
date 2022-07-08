using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AddColider : MonoBehaviour
{
    public GameObject gameObject;

    // Start is called before the first frame update
    void Start()
    {
        for (int i= 0; i < 1000; i++)
        {
            try
            {
                GameObject a = gameObject.transform.GetChild(i).gameObject;
                a.AddComponent<BoxCollider>();
            }
            catch (Exception e)
            {
                Debug.Log(e.Message);
            }
        } 
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
