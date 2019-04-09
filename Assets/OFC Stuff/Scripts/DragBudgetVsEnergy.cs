using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragBudgetVsEnergy : MonoBehaviour {

    Vector3 initialPosition;
    public GameObject placement; //the placement of the puzzle piece
    float dragDistance = 9.1f; //distance to drag mouse
    float zPosSolar;
    private Vector3 objPos;
    private GameObject puzzleCreator;

    private void Awake()
    {
        puzzleCreator = GameObject.Find("PuzzleCreatorScript");
    }

    // Use this for initialization
    void Start()
    {
        initialPosition = gameObject.transform.position;
        

        //dragDistance = Vector3.Distance(transform.position, Camera.main.transform.position);
        //Debug.Log(dragDistance);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, dragDistance);
        objPos = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = objPos;
    }

   

    void OnMouseUp()
    {
        //Find the closest Vector3 of the grid, if it returns (0,0,0) -> nothing is close

        Vector3 closest = puzzleCreator.GetComponent<CreatePuzzle>().GetNearestPointOnGrid(transform.position);
       
        Debug.Log(closest);

        
        if ( closest == new Vector3(0,0,0))
        {
            transform.position = initialPosition;          
        }
        else {
            transform.position = closest;
        }
    }

    
}
