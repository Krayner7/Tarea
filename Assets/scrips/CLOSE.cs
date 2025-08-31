using UnityEngine;
using UnityEngine.SceneManagement;

public class CLOSE : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            Application.Quit();

        }

        if (Input.GetKeyDown(KeyCode.R))
        {

            SceneManager.LoadScene("Nivel1");

        }
    }
}
