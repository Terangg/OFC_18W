using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BudgetSystem : MonoBehaviour
{

    public Text budgetTxt;
    public Text subtractBudgetTxt;

    int budget = 90000;

    // Start is called before the first frame update
    void Start()
    {
        budgetTxt.text = "Budget: " + budget;
        subtractBudgetTxt.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator UpdateBudget(string tag)
    {
        if(tag == "12000") {
            
            budget = budget - 12000;
            budgetTxt.text = "Budget: " + budget;
            subtractBudgetTxt.text = " -$12000"; 
        }
        else if (tag == "3000")
        {
            
            budget = budget - 3000;
            budgetTxt.text = "Budget: " + budget;
            subtractBudgetTxt.text = " -$3000";
        }
       
        else
        {
            
            budgetTxt.text = "Budget: " + budget;
        }
        
        yield return new WaitForSeconds(0.7f);
        subtractBudgetTxt.text = "";
    }

    public bool ifBudgetNotZero(string tag)
    {
        if (tag == "12000")
        {
            if ((budget - 12000) < 0)
            { return false; }
            else { return true; }
        }
        else if (tag == "3000")
        {
            if ((budget - 3000) < 0)
            { return false; }
            else { return true; }
        }
        
        else { return false; }
    }

    
    public IEnumerator NoMoney(){
        subtractBudgetTxt.text = "You have no more money. Want to donate power to the grid?" + 
            " This will earn you electricity credits.";
        yield return new WaitForSeconds(3f);
        

    }
        


}
