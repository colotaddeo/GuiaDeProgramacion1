﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej7 : MonoBehaviour
{
    // Start is called before the first frame update
    public int num1;
    public int num2;
    public int num3;

    void Start()
    {
        if (num1 == num2 && num1 == num3)
        {
            Debug.Log("Los números son iguales");

        }
        else if (num1 > num2 && num1 > num3) {
            Debug.Log("El mayor número es num1");
        }
        else if(num2 > num1 && num2 > num3)
        {
            Debug.Log("El mayor número es num2");
        }
        else
        {
            Debug.Log("El mayor número es num3");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
