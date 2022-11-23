using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operations : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


class Addition : AbstractOperation
{

    public override T Operate<T>(T left, T right)
    {

        dynamic dleft = left;
        dynamic dright = right;

        return dleft + dright;


    }
}

class Substraction : AbstractOperation
{

    public override T Operate<T>(T left, T right)
    {

        dynamic dleft = left;
        dynamic dright = right;

        return dleft - dright;


    }


}


class Multiplication : AbstractOperation
{

    public override T Operate<T>(T left, T right)
    {

        dynamic dleft = left;
        dynamic dright = right;

        return dleft * dright;


    }


}

class Division : AbstractOperation
{

    public override T Operate<T>(T left, T right)
    {

        dynamic dleft = left;
        dynamic dright = right;

        return dleft / dright;


    }


}



