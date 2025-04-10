using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript: MonoBehaviour
{
    public string GustoHelado;
    public float CantHelado;

    // Start is called before the first frame update
    void Start()

    {
        if (CantHelado < 250 || CantHelado > 3000)
        {
            Debug.Log("Cant helado no valida");
            return;
        }
        if (GustoHelado != "CHO" && GustoHelado != "DDL" && GustoHelado != "FRU")
        {
            Debug.Log("Sabor de helado no disponible");
        }
        else if (GustoHelado == "CHO" || GustoHelado == "DDL")
        {
            CantHelado = CantHelado * 0.5f;
            Debug.Log("El precio del helado de " + GustoHelado + " tiene un precio de " + CantHelado);
        }
        else if (GustoHelado == "FRU")
        {
            CantHelado = CantHelado * 0.5f;
            CantHelado = CantHelado * 0.9f;
            Debug.Log("El precio del helado de " + GustoHelado + " tiene un precio de " + CantHelado);
        }
        else
        {
            return;
        }




    }
    // Update is called once per frame

    void Update()
    {


    }
}

