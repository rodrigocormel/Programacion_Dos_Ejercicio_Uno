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

    void numero2()
    {
        int mes;
        mes = random.range(1, 12);
        switch (mes)
        {
            case 1:
                Debug.Log("Enero");
                break;
            case 2:
                Debug.Log("Febrero");
                break;
            case 3:
                Debug.Log("Marzo");
                break;
            case 4:
                Debug.Log("Abril");
                break;
            case 5:
                Debug.Log("Mayo");
                break;
            case 6:
                Debug.Log("Junio");
                break;
            case 7:
                Debug.Log("Julio");
                break;
            case 8:
                Debug.Log("Agosto");
                break;
            case 9:
                Debug.Log("Septiembre");
                break;
            case 10:
                Debug.Log("Octubre");
                break;
            case 11:
                Debug.Log("Noviembre");
                break;
            case 12:
                Debug.Log("Diciembre");
                break;
        }
    }

    void numero3()
    {
        int n;
        n = 3;

        for (int i = 1; i <= n; i++)
        {
            Debug.Log(i);
        }
    }


    void numero5()
    {
        int[] umma = new int[10];
        int[] dois = new int[10];
        int a = 9;

        for (int b = 0; b < 10; b++)
        {
            umma[b] = int(random(20));
            dois[a] = umma[b];
            a = a - 1;
        }

        Debug.log(umma);
        Debug.log("");
        Debug.log(dois);
    }

    static void Numero9(string[] meta)
    {
        int umma = 3;
        int dois = 7;
        int resultado = Sumar(umma, dois);
    Debug.log("El resultado es: " + resultado);
    }

    static int Sumar(int a, int b)
    {
        return a + b;
    }

    static int Number11(int a, int b)
    {
        int resultadito = a * b;
        return resultadito;
    }

    static void Mientras(string[] abc)
    {
        int cont = 2;
        while (cont <=6)
        {
            cont++;
        }
    }
    static void Lista(string[] lista)
    {
        List<int> numeros = new List<int>();
        numeros.Add(1);
        numeros.Add(2);
        numeros.Add(3);
        numeros.Add(4);
        numeros.Add(5);
    }
    static void Parametro(string[] para)
    {
        int resultado = Sumar(10, 6);
    }
}
