using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class blkScn : MonoBehaviour
{

	Ray ray;
    RaycastHit hit;

    private float moveSpeed = 12.2f;

    public GameObject brdBtn;

    public Transform mainTrans;
	public Transform house_1;
	public Transform house_2;
	public Transform house_3;
	public Transform house_4;
	public Transform house_5;

	public GameObject infoBox_1;
	public GameObject infoBox_2;
	public GameObject infoBox_3;
	public GameObject infoBox_4;
	public GameObject infoBox_5;

	private bool isBird = true;
    // Start is called before the first frame update
    void Start()
    {
        infoBox_1.SetActive(false);
        infoBox_2.SetActive(false);
        infoBox_3.SetActive(false);
        infoBox_4.SetActive(false);
        infoBox_5.SetActive(false);
        brdBtn.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    	ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    	houseSelector("HOUSE1", house_1, infoBox_1);
    	houseSelector("HOUSE2", house_2, infoBox_2);
    	houseSelector("HOUSE3", house_3, infoBox_3);
    	houseSelector("HOUSE4", house_4, infoBox_4);
    	houseSelector("HOUSE5", house_5, infoBox_5);

        
    }

    private void houseSelector(string name, Transform target, GameObject infoBox) {
    	if (Physics.Raycast (ray, out hit) ) {
    		//!! COMPUTER BUILD !!//
    		if (hit.collider.tag == name && Camera.main.transform.position != target.position && isBird ) {
    			infoBox.SetActive(true);
    		} else {
    			infoBox.SetActive(false);
    		}
    		//!! COMPUTER BUILD !!//

    		if (Input.GetMouseButtonDown (0) && isBird) {
				if (hit.collider.tag == name ) {
					Debug.Log(hit.collider.tag);
					Camera.main.transform.position = target.position;
					Camera.main.transform.rotation = target.rotation;
					isBird = false;
					brdBtn.SetActive(true);
				}
			}
    	}

    }

    public void mainView() {
    	Camera.main.transform.position = mainTrans.position;
		Camera.main.transform.rotation = mainTrans.rotation;
		isBird = true;
		brdBtn.SetActive(false);
    }

    public void infoBox1() {
    	if (!infoBox_1.activeSelf) {
    		infoBox_1.SetActive(true);
    	} else {
    		infoBox_1.SetActive(false);
    	}
    }

    public void infoBox2() {
    	if (!infoBox_2.activeSelf) {
    		infoBox_2.SetActive(true);
    	} else {
    		infoBox_2.SetActive(false);
    	}
    }

    public void infoBox3() {
    	if (!infoBox_3.activeSelf) {
    		infoBox_3.SetActive(true);
    	} else {
    		infoBox_3.SetActive(false);
    	}
    }

    public void infoBox4() {
    	if (!infoBox_4.activeSelf) {
    		infoBox_4.SetActive(true);
    	} else {
    		infoBox_4.SetActive(false);
    	}
    }

    public void infoBox5() {
    	if (!infoBox_5.activeSelf) {
    		infoBox_5.SetActive(true);
    	} else {
    		infoBox_5.SetActive(false);
    	}
    }
}
