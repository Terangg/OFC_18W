using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class object_clicker : MonoBehaviour {

    Ray ray;
    RaycastHit hit;

    public GameObject houseTwoBox;
    public GameObject houseTwoSel;

    public GameObject bgHouseOne;
    public GameObject bgHouseOneSel;

    public GameObject bgHouseTwo;
    public GameObject bgHouseTwoSel;

    public GameObject bgHouseThree;
    public GameObject bgHouseThreeSel;

    public GameObject bgHouseFour;
    public GameObject bgHouseFourSel;

    public GameObject bgHouseFive;
    public GameObject bgHouseFiveSel;

    private bool loadedClick = false;
    private int selectedHouse = 0;

    public GameObject startButton;

    private void Start()
    {

        startButton.SetActive(false);

        houseTwoBox.SetActive(false);
        bgHouseOne.SetActive(false);
        bgHouseTwo.SetActive(false);
        bgHouseThree.SetActive(false);
        bgHouseFour.SetActive(false);
        bgHouseFive.SetActive(false);

        houseTwoSel.SetActive(false);
        bgHouseOneSel.SetActive(false);
        bgHouseTwoSel.SetActive(false);
        bgHouseThreeSel.SetActive(false);
        bgHouseFourSel.SetActive(false);
        bgHouseFiveSel.SetActive(false);

    }

    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        interacterHouse("house2", houseTwoBox, houseTwoSel);
        interacterHouse("bgHouseOne", bgHouseOne, bgHouseOneSel);
        interacterHouse("bgHouseTwo", bgHouseTwo, bgHouseTwoSel);
        interacterHouse("bgHouseThree", bgHouseThree, bgHouseThreeSel);
        interacterHouse("bgHouseFour", bgHouseFour, bgHouseFourSel);
        interacterHouse("bgHouseFive", bgHouseFive, bgHouseFiveSel);

        if (selectedHouse == 3)
        {
            startButton.SetActive(true);
        }



    }


    private void interacterHouse(string name, GameObject go, GameObject sgo)
    {
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.tag == name)
            {
                go.SetActive(true);
            }
            if (Input.GetMouseButtonDown(0))
            {
                //print(hit.collider.name);
                if (hit.collider.tag == name)
                {

                    //    isClicked = true;
                    go.SetActive(false);
                    if (selectedHouse < 3)
                    {
                        sgo.SetActive(true);
                        selectedHouse++;
                    }

                    //if (sgo.activeSelf && selectedHouse > 0)
                    //{
                    //    Debug.Log("hi");
                    //    sgo.SetActive(false);
                    //    selectedHouse--;
                    //}
                   
                    Debug.Log(name);
                }
            }
        }
        else //if (isClicked == false)
        {
            go.SetActive(false);
        }
    }

    public void beginButton()
    {
        SceneManager.LoadScene("TETRIS_two", LoadSceneMode.Single);
    }

   
}
