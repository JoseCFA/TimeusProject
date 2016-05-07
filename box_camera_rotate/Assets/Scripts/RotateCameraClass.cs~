using UnityEngine;
using System.Collections;

public class RotateCameraClass : MonoBehaviour {

	// public variables

	/// <summary>
	/// El cubo alrededor del cual se rota
	/// </summary>
	public Transform target;

	/// <summary>
	/// The rotation quantity.
	/// </summary>
	const float ROTATION_QUANTITY = 90.0f;


	public float speedRotation = 10;

	// working variables

	/// <summary>
	/// transform caching
	/// </summary>
	Transform tr;

	/// <summary>
	/// The type of the rotation.
	/// </summary>
	public enum RotationType { none, left, right, up, down };
	public RotationType rotationType;

	/// <summary>
	/// Rotacion acumulada mientras se rota
	/// </summary>
	float accumulatedRotation;

	// Use this for initialization
	void Start () 
	{
		tr = transform;
		rotationType = RotationType.none;
	}
	
	// Update is called once per frame
	void Update () 
	{
		//Sólo si no se está rotando en este momento
		if(rotationType != RotationType.none)
		{
			//Cantidad a rotar
			float quantityRotation = Time.deltaTime * speedRotation;
			//Cantidad acumulada
			accumulatedRotation += quantityRotation;

			//¿Nos hemos pasado de 90?
			if(accumulatedRotation > ROTATION_QUANTITY)
			{
				//Descontamos quantityRotation
				accumulatedRotation -= quantityRotation;
				//Calculamos lo que falta para 90
				quantityRotation = ROTATION_QUANTITY - accumulatedRotation;
				//Rotamos
				Rotate(quantityRotation);
				//El próximo Update ya no se rota
				rotationType = RotationType.none;
			}
			else
			{
				//Rotamos
				Rotate(quantityRotation);
			}


		}
	}

	/// <summary>
	/// Rotate the specified quantityRotation.
	/// </summary>
	/// <param name="quantityRotation">Quantity rotation.</param>
	void Rotate(float quantityRotation)
	{
		//Según el tipo de rotación rotamos alrededor del target y el eje adecuado la cantidad calculada
		if(rotationType == RotationType.left)
			tr.RotateAround(target.position, tr.up, -quantityRotation);
		else if(rotationType == RotationType.right)
			tr.RotateAround(target.position, tr.up, quantityRotation);
		else if(rotationType == RotationType.up)
			tr.RotateAround(target.position, tr.right, quantityRotation);
		else if(rotationType == RotationType.down)
			tr.RotateAround(target.position, tr.right, -quantityRotation);

	}

	/// <summary>
	/// Rotate the specified towards.
	/// El parámetro towards lo pasa el botón
	/// </summary>
	/// <param name="towards">Towards.</param>
	public void SetRotataionType(string towards)
	{
		//Sólo si no se está rotando en este momento
		if(rotationType == RotationType.none)
		{
			if(towards == "left")
				rotationType = RotationType.left;
			else if(towards == "right")
				rotationType = RotationType.right;
			else if(towards == "up")
				rotationType = RotationType.up;
			else if(towards == "down")
				rotationType = RotationType.down;

			accumulatedRotation = 0;
		}
	}
	
}
