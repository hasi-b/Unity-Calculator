using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIScript : MonoBehaviour
{

    Calculation cs;
    [SerializeField] private TextMeshProUGUI tm_input;
    string numbers = "";

    double result = 0;
    string res = "";
    string op = "";
    bool iActive = false;

    public bool isActive = false;
    public GameObject textComplex;

    string firstComplex;
    string SecondComplex;

    private void Awake()
    {
        cs = GameObject.FindGameObjectWithTag("UI").GetComponent<Calculation>();
    }


    // Start is called before the first frame update
    public void OnClickNumber(int val)
    {

        if (!iActive)
        {
            numbers = numbers + $"{val}";
            tm_input.text = numbers;

        }


        else
        {

            numbers = numbers + $"{val}";
            tm_input.text = numbers+"i";



        }




    }




    public void onClickComplex()
    {
        isActive = !isActive;
        clearDisplay();
        if (isActive)
        {
           

            textComplex.SetActive(true);



        }
        else
        {
           
            textComplex.SetActive(false);


        }

    }




    public void clearDisplay()
    {
        numbers = "";
        result = 0;
        tm_input.text = "";
        firstComplex = "";
        SecondComplex = "";
        
    }

    public void OnClickOperators(string val)
    {

        if (!isActive)
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
                Debug.Log("Result: " + result);
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





        else
        {
            iActive = !iActive;
            if (numbers != "")
            {
                firstComplex = numbers;
                tm_input.text = "";
                numbers = "";
            }

            if (val == "+")
            {

                cs.operatorComplex = val;


            }

            if (val == "-")
            {

                cs.operatorComplex = val;
            }
            if (val == "X")
            {
                cs.operatorComplex = val;


            }
            if (val == "/")
            {
                cs.operatorComplex = val;


            }




        }






    }


    public void OnClickSpecialChar(string val)
    {
        if (!isActive && val.Equals("."))
        {
            if (!tm_input.text.Contains("."))
            {
                numbers = numbers + ".";
                tm_input.text = numbers;
            }
        }
        else if(val.Equals("i")&&isActive)
        {
            if (!tm_input.text.Contains("+"))
            {
                
                numbers = numbers + "+";
                tm_input.text = numbers;
            }



            iActive = !iActive;

            


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


        if (!isActive)
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



        else
        {

            
                SecondComplex = numbers;
            
            if(firstComplex!="" && SecondComplex != "")
            {
                double x1 = double.Parse(firstComplex.Substring(0, firstComplex.IndexOf("+")));
                double x2 = double.Parse(SecondComplex.Substring(0, SecondComplex.IndexOf("+")));
                double y1 = double.Parse(firstComplex.Substring(firstComplex.IndexOf("+"), firstComplex.Length-1));
                double y2 = double.Parse(SecondComplex.Substring(SecondComplex.IndexOf("+"), SecondComplex.Length-1));


                string realPart = cs.complexCalculation(x1,x2).ToString();
                string imaginarypart = cs.complexCalculation(y1,y2).ToString();
                tm_input.text = realPart + "+" + imaginarypart + "i";
                 
            }





        }

    }
}
