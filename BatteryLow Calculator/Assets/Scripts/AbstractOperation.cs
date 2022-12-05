using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractOperation 
{
    // Start is called before the first frame update
    public abstract T Operate<T>(T left, T right);

}






