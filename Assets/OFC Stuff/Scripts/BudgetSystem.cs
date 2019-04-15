using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BudgetSystem : MonoBehaviour
{

    public Text budgetTxt;

    int budget = 3000;

    // Start is called before the first frame update
    void Start()
    {
        budgetTxt.text = "Budget: " + budget;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateBudget(string tag)
    {
        if(tag == "1000") {
            Debug.Log(budget + " - 1000");
            budget = budget - 1000;
            budgetTxt.text = "Budget: " + budget;
        }
        else if (tag == "500")
        {
            Debug.Log(budget + " - 500");
            budget = budget - 500;
            budgetTxt.text = "Budget: " + budget;
        }
        else if (tag == "250")
        {
            Debug.Log(budget + " - 250");
            budget = budget - 250;
            budgetTxt.text = "Budget: " + budget;
        }
    }

    public bool ifBudgetNotZero(string tag)
    {
        if (tag == "1000")
        {
            if ((budget - 1000) < 0)
            { return false; }
            else { return true; }
        }
        else if (tag == "500")
        {
            if ((budget - 500) < 0)
            { return false; }
            else { return true; }
        }
        else if (tag == "250")
        {
            if ((budget - 250) < 0)
            { return false; }
            else { return true; }
        }
        else { return false; }
    }


}
