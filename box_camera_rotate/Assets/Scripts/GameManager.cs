using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {


    // Use this for initialization

	// HOLA CARAJOO

    // Use this for initialization Polla

    public static GameManager instance;
    public GameObject Enemigo;

	GameObject aux;
	Vector3 guardarPosicion;
	Transform posicion;
	Quaternion guardarRotacion;

    public static GameManager Instance
    {
        get { return instance; }
    }

    void Awake()
    {
        //Asigna esta instancia al campo instance
        if (instance == null)
            instance = this;
        else
            Destroy(this);  //Garantiza que sólo haya una instancia de esta clase
    }

  

}
