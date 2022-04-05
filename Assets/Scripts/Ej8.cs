using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej8 : MonoBehaviour
{
    // Start is called before the first frame update
    public int dia;
    void Start()
    {
     switch (dia) {
            case 1:
                Debug.Log("Domingo");
                break;
            case 2:
                Debug.Log("Lunes");
                break;
            case 3:
                Debug.Log("Martes");
                break;
            case 4:
                Debug.Log("Miércoles");
                break;
            case 5:
                Debug.Log("Jueves");
                break;
            case 6:
                Debug.Log("Viernes");
                break;
            case 7:
                Debug.Log("Sábado");
                break;
            default:
                Debug.Log("El día ingresado no es válido");
                break;
        }   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
