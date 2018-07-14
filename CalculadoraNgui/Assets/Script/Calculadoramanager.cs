using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculadoramanager : MonoBehaviour
{

    [SerializeField] private GameObject visor;
    [SerializeField] private GameObject visor_1;
    private int Acumulador;
    private readonly int Resultado;
    private bool estaSomando;
    
    


    // Use this for initialization
   
    







    void Start ()
	{

	    visor.transform.GetChild(1).GetComponent<UILabel>().text = "0";
	    visor_1.transform.GetChild(1).GetComponent<UILabel>().text = "";
        Acumulador = 0;

        
    }

    // Function Caldulator


        

    public void Clear()
    {
        visor.transform.GetChild(1).GetComponent<UILabel>().text = "";
        
    }


    public void Clearall()
    {
        visor.transform.GetChild(1).GetComponent<UILabel>().text = "0";
        visor_1.transform.GetChild(1).GetComponent<UILabel>().text = "";
        Acumulador = 0;

    }

    public void Soma()
    {
        estaSomando = true;
        var antigovisor = visor.transform.GetChild(1).GetComponent<UILabel>().text;
        Acumulador = Convert.ToInt32(antigovisor) + Acumulador;
        Clear();



        visor_1.transform.GetChild(1).GetComponent<UILabel>().text = "V" + antigovisor + "A" + Acumulador;
        


    }

    public void Subtrair()

    {
        var antigovisor = visor.transform.GetChild(1).GetComponent<UILabel>().text;
        Acumulador = Convert.ToInt32(antigovisor) - Acumulador;
        Clear();

        visor_1.transform.GetChild(1).GetComponent<UILabel>().text = "V" + antigovisor + "A" + Acumulador;
    }


    public void Igual()
    {
        //Ou seja, o ultimo botao foi a soma
        if (estaSomando = true)
        {
            Soma();
            estaSomando = false;
            ///Após ser colocado como somado,
            /// ele são do modo estaSomando
        }

        visor.transform.GetChild(1).GetComponent<UILabel>().text = Acumulador.ToString();

    }

    

    // Numbers


    public void Numero1()
    {
        var antigovisor = visor.transform.GetChild(1).GetComponent<UILabel>().text;
        visor.transform.GetChild(1).GetComponent<UILabel>().text = antigovisor + "1";
    }


    public void Numero2()
    {
        var antigovisor = visor.transform.GetChild(1).GetComponent<UILabel>().text;
        visor.transform.GetChild(1).GetComponent<UILabel>().text = antigovisor + "2";
    }

    public void Numero3()
    {
        var antigovisor = visor.transform.GetChild(1).GetComponent<UILabel>().text;
        visor.transform.GetChild(1).GetComponent<UILabel>().text = antigovisor + "3";

    }


    public void Numero4()
    {
        var antigovisor = visor.transform.GetChild(1).GetComponent<UILabel>().text;
        visor.transform.GetChild(1).GetComponent<UILabel>().text = antigovisor + "4";

    }

    public void Numero5()
    {
        var antigovisor = visor.transform.GetChild(1).GetComponent<UILabel>().text;
        visor.transform.GetChild(1).GetComponent<UILabel>().text = antigovisor + "5";

    }

    public void Numero6()
    {
        var antigovisor = visor.transform.GetChild(1).GetComponent<UILabel>().text;
        visor.transform.GetChild(1).GetComponent<UILabel>().text = antigovisor + "6";

    }

    public void Numero7()
    {
        var antigovisor = visor.transform.GetChild(1).GetComponent<UILabel>().text;
        visor.transform.GetChild(1).GetComponent<UILabel>().text = antigovisor + "7";
        
    }

    public void Numero8()
    {
        var antigovisor = visor.transform.GetChild(1).GetComponent<UILabel>().text;
        visor.transform.GetChild(1).GetComponent<UILabel>().text = antigovisor + "8";

    }

    public void Numero9()
    {
        var antigovisor = visor.transform.GetChild(1).GetComponent<UILabel>().text;
        visor.transform.GetChild(1).GetComponent<UILabel>().text = antigovisor + "9";

    }

    public void Numero0()
    {
        var antigovisor = visor.transform.GetChild(1).GetComponent<UILabel>().text;
        visor.transform.GetChild(1).GetComponent<UILabel>().text = antigovisor + "0";

    }

    
       
}
