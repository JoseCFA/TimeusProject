using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PuntosScript : MonoBehaviour {

	// Use this for initialization

	public static int currentPuntos;
	public static Text texto;
	public static int puntosAux=0;

	void Awake () {
	
		texto = GetComponent<Text> ();
		texto.text = currentPuntos.ToString();
	}
	
	// Update is called once per frame
	void Update () {
	

	}

	public static void setPuntos(int points){

		puntosAux += points;

		string aux = puntosAux.ToString ();

		texto.text = aux;

	}
}
