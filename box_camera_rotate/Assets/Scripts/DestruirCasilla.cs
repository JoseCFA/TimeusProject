using UnityEngine;
using System.Collections;

public class DestruirCasilla : MonoBehaviour {

    // Use this for initialization

    //CasillasClass casilla;

    
	void Start () {
	
       
        

	}
	
	// Update is called once per frame
	void Update () {


	}

    void OnMouseDown()
    {


        if (Input.GetMouseButtonDown(0))
        {
            Destroy(this); 


        }


    }
}
