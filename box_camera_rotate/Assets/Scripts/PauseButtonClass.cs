using UnityEngine;
using System.Collections;

public class PauseButtonClass : MonoBehaviour {

    public GameObject panel;

    public void ActivarPauseButton()
    {
        this.gameObject.SetActive(true);
    }

    void PausarPartida()
    {
        panel.SendMessage("ActivarPanel", SendMessageOptions.RequireReceiver);
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
