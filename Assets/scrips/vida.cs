using UnityEngine;
using UnityEngine.SceneManagement;

public class vida : MonoBehaviour
{
    public int lives;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            DamagePlayer(5);
        }
    }


    public void DamagePlayer(int damage)
    {

        lives = lives - damage;
        if (lives <= 0)
        {

            SceneManager.LoadScene("Nivel1");

        }
    }

}
