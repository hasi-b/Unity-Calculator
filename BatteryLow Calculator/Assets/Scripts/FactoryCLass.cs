using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryCLass : MonoBehaviour
{
    // Start is called before the first frame update
    public AbstractOperation GetOperation<T>(string operate, T left, T right)
    {

        switch (operate)
        {
            case "+":
                return new Addition();
            case "-":
                return new Substraction();
            case "*":
                return new Multiplication();
            case "/":
                return new Division();
            default:
                return null;

        }

    }
}
