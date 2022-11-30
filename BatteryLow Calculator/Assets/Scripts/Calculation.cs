using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {


        int n;
        FactoryCLass fc = new FactoryCLass();
        AbstractOperation absOperation = fc.GetOperation("+");
        n = absOperation.Operate(5, 6);
        Debug.Log("Value of n: " + n);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
