using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaChaman : MonoBehaviour
{
	public float vidaInicial = 2f;
	float vidaActual;

    // Start is called before the first frame update
    void Start()
    {
		vidaActual = vidaInicial;
    }

	// Update is called once per frame
    void Update()
    {
        
    }

	public void QuitaVida(float cantidad){
		vidaActual = vidaActual - cantidad;
		if (vidaActual <=0){
			Muerte();
		}
	}

	void Muerte()
    {
		Destroy (gameObject);
	}
}
