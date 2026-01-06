using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyDamage : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Le joueur est mort !");

            MenuManager manager = FindObjectOfType<MenuManager>();

            if (manager != null)
            {
                manager.LoseGame();
            }
        }
    }
}