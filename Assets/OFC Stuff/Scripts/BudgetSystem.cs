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
            budget = budget - 1000;
            budgetTxt.text = "Budget: " + budget;
        }
        else if (tag == "500")
        {
            budget = budget - 500;
            budgetTxt.text = "Budget: " + budget;
        }
        else if (tag == "250")
        {
            budget = budget - 250;
            budgetTxt.text = "Budget: " + budget;
        }
    }


}
