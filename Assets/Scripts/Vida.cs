using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour
{
	public int vida = 3;
	public int vidaMax = 5;
	public bool mortal = true;
	public float tiempoInmortal = 1.5f; //Medida de tiempo
	float cuandoMeVuelvoMortal = 0f; //Medida de tiempo

	void Start(){
	}




	void Update(){
		if (!mortal && Time.time > cuandoMeVuelvoMortal) {
			mortal = true;
		}
	}

	void OnCollisionStay2D(Collision2D conQuienHeChocado){
		if (conQuienHeChocado.gameObject.CompareTag ("Hueso")) {
			if (mortal){
				--vida;
				mortal = false;
				cuandoMeVuelvoMortal = Time.time + tiempoInmortal;
				if (vida <= 0) {
					Destroy (gameObject);
				}
			}
		}
	}
   
}
