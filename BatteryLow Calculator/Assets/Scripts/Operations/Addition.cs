using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addition : AbstractOperation
{
    public override T Operate<T>(T left, T right)
    {

        dynamic dleft = left;
        dynamic dright = right;

        return dleft + dright;


    }
}
