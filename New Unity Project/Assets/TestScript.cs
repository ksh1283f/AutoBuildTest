using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class TestScript : MonoBehaviour
{
    List<int> numList = new List<int>();
	
	void Start ()
    {
        Debug.Log("Start");
        Debug.Log("Stat2");

        int i = 0;
        int j = 1;
        int k = 3;

        numList.Add(i);
        numList.Add(j);
        numList.Add(k);
    }
	
	
}
