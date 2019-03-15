using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EnterInputCode : MonoBehaviour
{   
    [SerializeField]
    private int _inputLength = 4;
    private int[] _inputNumberList;//Input list for numbers
    private int _index = 0;
    private CodeChecker _numberPad;  // the parent numberpad with the correct code

      private void Start()
    {
        _inputNumberList = new int[_inputLength];
        _numberPad = gameObject.GetComponentInParent<CodeChecker>();
    }


    public void AddNumber(int number)//adds number to the inputlist. If the number goes out of bounds, place zero is replaced with the new number and repeats the cycle
    {
        

        if (_index > _inputNumberList.Length - 1)
        {
            _index = 0;
        }

        _inputNumberList[_index] = number;
        _index++;
        

       
    }




    public void OnMouseDown()//calls the function to compare the input to the correct code
    {
        _numberPad.CompareInputCode(_inputNumberList);
    }

    public int[] getList()
    {
        return _inputNumberList;
    }
}
