﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D target)
    {
        if(target.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            Debug.Log("target.gameObject.tag == 'Player' is True ");
        }
    }









}//class
