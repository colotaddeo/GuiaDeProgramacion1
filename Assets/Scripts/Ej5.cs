﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej5 : MonoBehaviour
{
    // Start is called before the first frame update
    public int num1;
    public int num2;
    int resultado;
    void Start()
    {
        resultado = num1 / num2;
        Debug.Log(num1 + " / " + num2 + " = " + resultado); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
