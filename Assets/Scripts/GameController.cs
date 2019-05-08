using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    
    public GameObject pausa;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pausa()
    {
        Time.timeScale = 0f;
        pausa.SetActive(true);
        
    }

    public void Continuar()
    {
        Time.timeScale = 1f;
        pausa.SetActive(false);
    }

    public void VolverAEmpezar()
    {
        SceneManager.LoadScene("Escenario 1");
    }
}
