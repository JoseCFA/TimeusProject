using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class AtacarScript : MonoBehaviour {
	/// <summary>
	/// Clase de efecto de texto cuando el jugador realiza un ataque
	/// </summary>
	/// 
	public float timer=1;
	public float speed;
	private float aumentarY;
	public float destroyTime;
	private Vector3 tr;
	private Quaternion qr;
	private TextMesh texto;

	//GetComponents respectivos
	void Awake	 () {

		texto= GetComponent<TextMesh>();
		tr= GetComponent<Transform>().position;
		qr = GetComponent<Transform> ().rotation;
	
	}

	public void setTexto(string aux, Vector3 auxPos,Quaternion qr){

		texto.text = aux;
		tr = auxPos;
		this.qr = qr;
		PuntosScript.setPuntos (int.Parse (aux));
	}
	
	//Se juega con el color segun el tiempo del objeto dentro de la escena
	//La posicion varia segun el tiempo y una variable auxiliar para aumentar la velocidad
	//Cuando el timer es menor que 0 el objeto se destruyo

	void Update () {

		timer -= Time.deltaTime;
		aumentarY+=Time.deltaTime*speed;
		texto.color = new Color(0,0,0,timer);
		texto.transform.rotation = qr;
		texto.transform.position= new Vector3(tr.x,tr.y+aumentarY,tr.z);

		if(timer <=0){

			Destroy(this.gameObject);
		}

	}
		
}
