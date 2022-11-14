using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private double sum( double firstNumber,double SecondNumber)
    {
        return firstNumber + SecondNumber;
    }
    private double substract(double firstNumber, double SecondNumber)
    {
        return firstNumber - SecondNumber;
    }
    private double multiply(double firstNumber, double SecondNumber)
    {
        return firstNumber * SecondNumber;
    }
    private double divide(double firstNumber, double SecondNumber)
    {
        return firstNumber / SecondNumber;
    }

}
