using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
	public float cdDisparo = 1.5f;

	public GameObject pelota;
	public Transform puntoOrigenPelota;

	public float potencia = 50f;
    // Start is called before the first frame update
    void Start()
    {
		//cdDisparo = 0f;
    }

    // Update is called once per frame
    void Update()
    {
		//cdDisparo -= Time.deltaTime;

		if (Input.GetKeyDown (KeyCode.Space)) //&& cdDisparo == 0f)
		{
			GameObject pelotaNueva;
			Rigidbody2D rbpelota;
			pelotaNueva = Instantiate (pelota, puntoOrigenPelota.position, puntoOrigenPelota.rotation);
			rbpelota = pelotaNueva.GetComponent<Rigidbody2D>();
			rbpelota.AddForce(pelotaNueva.transform.up * potencia);
			//cdDisparo = 1.5f;

		}
    }


}
