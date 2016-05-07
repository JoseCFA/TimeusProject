using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemigoScript : MonoBehaviour {

    // Use this for initialization

	public int tocado=0;
	public int tocadoRed=0;
	public int tocadoGreen=0;
	public Sprite [] sprites;
	public Sprite sprite1;
	public Sprite sprite2;
	public Sprite padre1;
	public Sprite padre2;
	public Sprite padre3;
	Text sumador;
	private Vector3 auxPos;
	private Quaternion qr;
	GameObject go;
	GameObject HolaText;
	private Transform tr;
	public GameObject texto;
	public GameObject puntos;

    void Start () {
		tocado = 0;
		tocadoRed= 0;
		tocadoGreen=0;

		sumador = gameObject.AddComponent<Text>();
		sumador.text += "hola";
		sumador.color = Color.red;



	}
	
	// Update is called once per frame
	void Update () {



        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hitInfo = new RaycastHit();
			Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);
			//Making the raycast
			if (hitInfo.collider != null && hitInfo.collider.gameObject== this.gameObject) //Linea hecha por © CCGLP 
			{
         
				if(this.tocado==0 && hitInfo.collider.gameObject.GetComponent<SpriteRenderer>().sprite == padre1){

                //Destroy(hitInfo.collider.gameObject);
				hitInfo.collider.gameObject.GetComponentInParent<SpriteRenderer>().sprite= sprites[0];
				hitInfo.collider.gameObject.GetComponentInParent<Transform>().localScale= transform.localScale/1.5f;
				print("He cambiado de color");
			

				this.tocado++;

				}
				else if(this.tocado == 1){

					hitInfo.collider.gameObject.GetComponentInParent<SpriteRenderer>().sprite = sprites[1];
					hitInfo.collider.gameObject.GetComponentInParent<Transform>().localScale=transform.localScale/1.75f;


					this.tocado++;

				}
				else if(this.tocado > 1){

					auxPos = hitInfo.collider.gameObject.transform.position;
					qr = hitInfo.collider.gameObject.transform.rotation;
					print ("LlegueALaPosicion"+auxPos);

					GameObject myText = Instantiate<GameObject>(texto);
					myText.GetComponent<AtacarScript>().setTexto ("+10", auxPos,qr);
					//((GameObject)(Instantiate(puntos))).GetComponent<PuntosScript> ().setPuntos (10);


					Destroy(hitInfo.collider.gameObject);
					Destroy(hitInfo.transform.gameObject);

				}

				if(this.tocadoRed==0 && hitInfo.collider.gameObject.GetComponent<SpriteRenderer>().sprite == padre2){

					//Destroy(hitInfo.collider.gameObject);
					hitInfo.collider.gameObject.GetComponentInParent<SpriteRenderer>().sprite= sprites[2];
					hitInfo.collider.gameObject.GetComponentInParent<Transform>().localScale= transform.localScale/1.5f;
					print("He cambiado de color");


					this.tocadoRed++;

				}
				else if(this.tocadoRed == 1){

					hitInfo.collider.gameObject.GetComponentInParent<SpriteRenderer>().sprite = sprites[3];
					hitInfo.collider.gameObject.GetComponentInParent<Transform>().localScale=transform.localScale/1.75f;


					this.tocadoRed++;

				}
				else if(this.tocadoRed > 1){

					auxPos = hitInfo.collider.gameObject.transform.position;
					GameObject myText = Instantiate<GameObject>(texto);
					myText.GetComponent<AtacarScript>().setTexto ("-10", auxPos,qr);

					Destroy(hitInfo.collider.gameObject);
					Destroy(hitInfo.transform.gameObject);

				}


				if(this.tocadoGreen==0 && hitInfo.collider.gameObject.GetComponent<SpriteRenderer>().sprite == padre3){

					hitInfo.collider.gameObject.GetComponentInParent<SpriteRenderer>().sprite= sprites[4];
					hitInfo.collider.gameObject.GetComponentInParent<Transform>().localScale= transform.localScale/1.5f;
					print("He cambiado de color");


					this.tocadoGreen++;

				}
				else if(this.tocadoGreen == 1){

					hitInfo.collider.gameObject.GetComponentInParent<SpriteRenderer>().sprite = sprites[5];
					hitInfo.collider.gameObject.GetComponentInParent<Transform>().localScale=transform.localScale/1.75f;


					this.tocadoGreen++;

				}
				else if(this.tocadoGreen > 1){
					
					auxPos = hitInfo.collider.gameObject.transform.position;
					GameObject myText = Instantiate<GameObject>(texto);
					myText.GetComponent<AtacarScript>().setTexto ("+10", auxPos,qr);


					Destroy(hitInfo.collider.gameObject);
					Destroy(hitInfo.transform.gameObject);

				}

            }
				

        }

    }

	public Vector3 posObj(){


		return auxPos;
	}



}
