using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TetrisIntro : MonoBehaviour {

    public Text mainTxt;
    public GameObject sunSlide;
    public GameObject selectRoofs;
    public float waitTime = 3f;

	// Use this for initialization
	void Start () {
        sunSlide.SetActive(false);
        selectRoofs.SetActive(false);
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

        mainTxt.text = "Select the roof that receives the most sunlight throughout the day.";
        yield return new WaitForSeconds(time);
        selectRoofs.SetActive(true);

    }
}
