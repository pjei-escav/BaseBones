using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

	Rigidbody2D player;
	Animator animaPlayer;

	public float velocidad = 4f;


    // Start is called before the first frame update
    void Start()
    {
		player = GetComponent<Rigidbody2D>();
		animaPlayer = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKey (KeyCode.LeftArrow))
		{
			player.AddForce(Vector2.left * velocidad);
		}
        
		if (Input.GetKey (KeyCode.RightArrow))
		{
			player.AddForce(Vector2.right * velocidad);
		}

    }
}
