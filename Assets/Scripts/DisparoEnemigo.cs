using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoEnemigo : MonoBehaviour
{

	public GameObject hueso;
	public Transform puntoOrigenHueso;

	public float potencia = 50f;
    public bool disparando;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

	void OnTriggerEnter2D (Collider2D other)
	{
		Debug.Log("Tocado");
        if (other.gameObject.CompareTag("Player"))
        {
            GameObject huesoNuevo;
            Rigidbody2D rbHueso;
            huesoNuevo = Instantiate(hueso, puntoOrigenHueso.position, puntoOrigenHueso.rotation);
            rbHueso = huesoNuevo.GetComponent<Rigidbody2D>();
            rbHueso.AddForce(huesoNuevo.transform.up * -potencia);
   
        }

	}

}
