using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculation : MonoBehaviour
{

    public bool isActive=false;
    public GameObject UI;
   
    public string operatorComplex;
    
    

    // Start is called before the first frame update
    


    public double complexCalculation(double x,double y)
    {

        double n;
        FactoryCLass fc = new FactoryCLass();
        AbstractOperation absOperation = fc.GetOperation(operatorComplex);//choosing the type of  instance to create of the abstract class
        n = absOperation.Operate(x,y);

        return n;
        


    }


   
    
}
