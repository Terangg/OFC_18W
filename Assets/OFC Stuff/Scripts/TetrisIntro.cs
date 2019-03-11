using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TetrisIntro : MonoBehaviour {

    public Text mainTxt;
    public GameObject sunSlide;
    public GameObject directionBtns;
    public GameObject hint1;
    public GameObject hint2;
    public GameObject hint3;


    public float waitTime = 3f;

    private int trialNum = 0;

	// Use this for initialization
	void Start () {
        sunSlide.SetActive(false);
        directionBtns.SetActive(false);
        hint1.SetActive(false);
        hint2.SetActive(false);
        hint3.SetActive(false);

        StartCoroutine(startTutorial(waitTime));
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private IEnumerator startTutorial(float time)
    {
        mainTxt.text = "";
        yield return new WaitForSeconds(1f);
        mainTxt.text = "Solar panels need to face the most direct sunlight.";
        yield return new WaitForSeconds(time);

        mainTxt.text = "The slider below will show you the sun's path throughout the day.";        
        yield return new WaitForSeconds(time);
        sunSlide.SetActive(true);

        mainTxt.text = "Which way should the solar panels face in order to get the most sunlight?";
        yield return new WaitForSeconds(time);
        directionBtns.SetActive(true);

    }

    public void chooseSouth()
    {
        directionBtns.SetActive(false);
        mainTxt.text = "Right! Most of the sunlight is from south!";
        StartCoroutine(choseSouth(waitTime));
    }

    public void chooseNotSouth()
    {
        mainTxt.text = "Mmm, not quite. Here's a hint";
        trialNum++;
        StartCoroutine(choseNotSouth(waitTime));
    }

    private IEnumerator choseSouth(float time)
    {
        sunSlide.SetActive(false);
        yield return new WaitForSeconds(time);
        mainTxt.text = "";
        // hint 1 
        hint1.SetActive(true);
        yield return new WaitForSeconds(time);
        hint1.SetActive(false);
        // hint 2
        hint2.SetActive(true);
        yield return new WaitForSeconds(time);
        hint2.SetActive(false);
        // hint 3
        hint3.SetActive(true);
        mainTxt.text = "Therefore, the most direct sunlight comes from the South!";
        yield return new WaitForSeconds(time);
        hint3.SetActive(false);
    }

    private IEnumerator choseNotSouth(float time)
    {
        directionBtns.SetActive(false);
        yield return new WaitForSeconds(time);

        // show hint 1
        if (trialNum == 1)
        {
            // slider & txt off 
            mainTxt.text = "";
            sunSlide.SetActive(false); 

            hint1.SetActive(true);
            yield return new WaitForSeconds(time);
            hint1.SetActive(false);

            // slider & txt off 
            mainTxt.text = "Try again, which way should the solar panels face?";
            sunSlide.SetActive(true);
        }
        if (trialNum == 2)
        {
            // slider & txt off 
            mainTxt.text = "";
            sunSlide.SetActive(false);

            hint2.SetActive(true);
            yield return new WaitForSeconds(time);
            hint2.SetActive(false);

            // slider & txt off 
            mainTxt.text = "Try again, which way should the solar panels face?";
            sunSlide.SetActive(true);
        }
        if (trialNum == 3)
        {
            // slider & txt off 
            mainTxt.text = "";
            sunSlide.SetActive(false);

            hint3.SetActive(true);
            yield return new WaitForSeconds(time);
            hint3.SetActive(false);

            // slider & txt off 
            mainTxt.text = "Try again, which way should the solar panels face?";
            sunSlide.SetActive(true);
        }

        directionBtns.SetActive(true);
    }
}
