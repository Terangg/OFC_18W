using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragBudgetVsEnergy : MonoBehaviour {

    Vector3 initialPosition;
    public GameObject placement; //the placement of the puzzle piece
    float dragDistance = 9.1f; //distance to drag mouse
    float zPosSolar;
    //float zPosPlacement;


    // Use this for initialization
    void Start()
    {
        initialPosition = gameObject.transform.position;
        //zPosPlacement = placement.transform.eulerAngles.y;
        //dragDistance = Vector3.Distance(transform.position, Camera.main.transform.position);
        //Debug.Log(dragDistance);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDrag()
    {
        Debug.Log("drag");
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, dragDistance);
        Vector3 objPos = Camera.main.ScreenToWorldPoint(mousePosition);

        transform.position = objPos;
    }

    void OnMouseUp()
    {
        Debug.Log("mouse up");

        float distance = Vector3.Distance(transform.position, placement.transform.position); //distance between placement and solar
        //zPosSolar = this.transform.eulerAngles.z; //y rotation of the solar object
        Debug.Log(distance);
        if (distance < 8)
        {

            transform.position = new Vector3(placement.transform.position.x, transform.position.y, transform.position.z);
            }
        else { transform.position = initialPosition; }
    }
}
