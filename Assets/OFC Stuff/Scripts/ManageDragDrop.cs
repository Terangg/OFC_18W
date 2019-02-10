using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageDragDrop : MonoBehaviour {

    Vector3 initialPosition;
    public GameObject placement; //the placement of the puzzle piece
    float dragDistance = 13; //distance to drag mouse
    float yPosSolar;
    float yPosPlacement;
    

	// Use this for initialization
	void Start () {
        initialPosition = gameObject.transform.position;
        yPosPlacement = placement.transform.eulerAngles.y;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, dragDistance);
        Vector3 objPos = Camera.main.ScreenToWorldPoint(mousePosition);

        transform.position = objPos;
    }

    void OnMouseUp()
    {     
            
        float distance = Vector3.Distance(transform.position, placement.transform.position); //distance between placement and solar
        yPosSolar = this.transform.eulerAngles.y; //y rotation of the solar object

        if (distance < 0.5)
        {
            Debug.Log(distance);
            Debug.Log("this tag" + this.tag);
            Debug.Log("other tag" + placement.tag);
            if (this.gameObject.CompareTag(placement.tag)
                && yPosSolar < (yPosPlacement + 30)
                && yPosSolar > (yPosPlacement - 30)) 
            { transform.position = placement.transform.position; }
            else { transform.position = initialPosition; }
        }
        else { transform.position = initialPosition; }
        }
    
}
