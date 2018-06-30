using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class calculadoramanager : MonoBehaviour
{

    [SerializeField] private GameObject visor;
    private int acumulador;
    private int resultado;


	// Use this for initialization
	void Start ()
	{

	    visor.transform.GetChild(1).GetComponent<UILabel>().text = "0";
	    acumulador = 0;
	}

    public void clear()
    {
        visor.transform.GetChild(1).GetComponent<UILabel>().text = "0";
        

    }

    public void numero1()
    {
        var antigovisor = visor.transform.GetChild(1).GetComponent<UILabel>().text;
        visor.transform.GetChild(1).GetComponent<UILabel>().text = antigovisor + "1";
    }

    public void numero2()
    {
        var antigovisor = visor.transform.GetChild(1).GetComponent<UILabel>().text;
        visor.transform.GetChild(1).GetComponent<UILabel>().text = antigovisor + "2";
    }

    public void soma()
    {
        var antigovisor = visor.transform.GetChild(1).GetComponent<UILabel>().text;
        acumulador = Convert.ToInt32(antigovisor) + acumulador;
        clear();


    }

    public void igual()
    {
        visor.transform.GetChild(1).GetComponent<UILabel>().text = acumulador.ToString();
        acumulador = 0;

    }

}
