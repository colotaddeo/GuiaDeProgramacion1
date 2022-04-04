 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej6 : MonoBehaviour
{
    // Start is called before the first frame update
    public int num1;
    void Start()
    {
        if (num1 < 0){
            Debug.Log("Error 404");
        }
        else if (num1 % 2 == 0)
        {
            Debug.Log("Es par");
        }
        else {
            Debug.Log("Es impar");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
