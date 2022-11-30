using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIScript : MonoBehaviour
{


    [SerializeField] private TextMeshProUGUI tm_input;
    string numbers = "";

    double result = 0;
    string res = "";
    string op = "";

    
    
    


   
    // Start is called before the first frame update
    public void OnClickNumber(int val)
    {
        numbers = numbers + $"{val}";
        tm_input.text = numbers;



    }


    public void clearDisplay()
    {
        numbers = "";
        result = 0;
        tm_input.text = "";
        
    }

    public void OnClickOperators(string val)
    {
        if (tm_input.text == "error")
        {
            numbers = "";
            result = 0;
            tm_input.text = "";
        }

        if (val == "+")
        {
            result = double.Parse(tm_input.text);
            numbers = "";
            res = $"{result}";
            tm_input.text = res;
            op = val;
            

        }

        if (val == "-")
        {

            result = double.Parse(tm_input.text);
            Debug.Log("Result: "+result);
                numbers = "";
                res = $"{result}";
                tm_input.text = res;
                op = val;
        }
        if (val == "X")
        {
            result = double.Parse(tm_input.text);
            numbers = "";
            res = $"{result}";
            tm_input.text = res;
            op = val;


        }
        if (val == "/")
        {
            result = double.Parse(tm_input.text);
            numbers = "";
            res = $"{result}";
            tm_input.text = res;
            op = val;


        }

    }


    public void OnClickDot()
    {
        if (!tm_input.text.Contains("."))
        {
            numbers = numbers + ".";
            tm_input.text = numbers;
        }
        
    }

   /* public void onClickNeg()
    {
        result = double.Parse(tm_input.text)*-1;
        numbers = "";
        res = $"{result}";
        tm_input.text = res;

    }*/


    public void onClickEqual()
    {
        if (op == "+")
        {
            result = result + double.Parse(numbers);
            numbers = "";
            res = $"{result}";
            tm_input.text = res;
        }
        else if (op == "-")
        {
            result = result - (double.Parse(numbers));
            numbers = "";
            res = $"{result}";
            tm_input.text = res;
        }
        else if (op == "X")
        {
            result = result * (double.Parse(numbers));
            numbers = "";
            res = $"{result}";
            tm_input.text = res;
        }
        else if (op == "/")
        {
            if (double.Parse(numbers) != 0)
            {
                result = result / (double.Parse(numbers));
                numbers = "";
                res = $"{result}";
                tm_input.text = res;
            }
            else
            {
                tm_input.text = "error";
            }
        }
    }
}
