﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomSounds : MonoBehaviour
{
	public GameObject Sounds;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int i = Random.Range(0, 10000);
		if(i == 5){
			Sounds.SetActive(true);
			Destroy(this.gameObject);
		}
    }
}
