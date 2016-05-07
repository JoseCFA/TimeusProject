using UnityEngine;
using System.Collections;

public class QuitButtonClass : MonoBehaviour {

    public void SalirPartida()
    {
        Debug.Log("salir");
        Application.LoadLevel("Menu");
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
