using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoEsqueletos : MonoBehaviour
{
	public float anchuraX;
	public float anchuraY;
	private Vector2 destino;
	public int velocidad;
	bool movDcha = true;
	bool movAbajo = true;
	bool movAbajo2 = true;
	bool movIzq = true;
    // Start is called before the first frame update
    void Start()
    {
		//destino.y = (anchuraY + transform.position.y);
		//destino.x = transform.position.x;
		destino.x = (anchuraX + transform.position.x); // Empezamos movienddo hacia la derecha
		destino.y = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
		if((Vector2)transform.position != destino)
		{
			transform.position = Vector2.MoveTowards(transform.position, destino, velocidad * Time.deltaTime);
		}
		else if (movDcha)
		{
			Debug.Log("Movimiento abajo");
			movDcha = false;

			destino.y = destino.y - anchuraY; // Movimiento abajo
			movAbajo = true;
		}
		else if (movAbajo)
		{
			Debug.Log("Movimiento izquierda");
			movAbajo = false;
			destino.x = destino.x - anchuraX; // Movimiento hacia izquierda
			movIzq = true;
		}
		else if (movIzq)
		{
			Debug.Log("Movimiento abajo");
			movIzq = false;
			destino.y = destino.y - anchuraY;//Movimiento abajo
			movAbajo2 = true;
		}
		else if (movAbajo2)
		{
			Debug.Log("Movimiento derecha");
			movAbajo2 = false;
			destino.x = destino.x + anchuraX;//Movimiento derecha
			movDcha = true;
		}


    }
}
