using UnityEngine;
using UnityEngine.SceneManagement;

public class Dano : MonoBehaviour
{
    public int damage;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        vida vida1  = collision.gameObject.GetComponent<vida>();

        if (vida1 == null)
        {

        }
        else
        {

            vida1.DamagePlayer(damage);

        }

    }
    
}
