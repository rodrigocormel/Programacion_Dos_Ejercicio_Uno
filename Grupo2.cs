using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grupo2 : MonoBehaviour
{
    void Start()
    {
        numero1();
        numero2();
        numero3();

    }

    void numero1()
    {
        public int n1;
        public int n2;

        if (n1 < n2)
        {
            Debug.Log("n2 es mayor que n1");
        }
        else
        {
            Debug.Log("n1 es mayor que n2");
        }
    }
}
