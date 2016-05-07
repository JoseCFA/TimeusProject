using UnityEngine;
using System.Collections;

public class ContinueButtonClass : MonoBehaviour {

    public GameObject panel;
    public GameObject pauseButton;

    public void ContinuarPartida()
    {
        panel.SendMessage("DesactivarPanel", SendMessageOptions.RequireReceiver);
        pauseButton.SendMessage("ActivarPauseButton", SendMessageOptions.RequireReceiver);
    }


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
