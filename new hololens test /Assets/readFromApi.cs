using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class readFromApi : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
         string text = File.ReadAllText("example.txt");
         Console.WriteLine(text);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
