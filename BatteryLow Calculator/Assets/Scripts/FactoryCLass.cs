using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryCLass 
{
    // Start is called before the first frame update
    public AbstractOperation GetOperation(string operate)
    {

        var operations = new Dictionary<string, AbstractOperation>();
        

        operations.Add("+", new Addition());
        operations.Add("-", new Substraction());
        operations.Add("*", new Multiplication());
        operations.Add("/", new Division());

        return operations[operate];




       

    }
}
