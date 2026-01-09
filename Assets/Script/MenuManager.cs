using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject winPanel;
    public GameObject losePanel;
    public GameObject startPanel;
    public static bool isRestarting = false;

    private void Start()
    {
        if (isRestarting == true)
        {
            StartGame(); 
            isRestarting = false;
        }
        else
        {
            Time.timeScale = 0f;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            FinishGame(true);
        }
    }

    public void FinishGame(bool win)
    {
        if (win)
        {
            Debug.Log("Gagné !");
            winPanel.SetActive(true);
        }else
        {
            Debug.Log("Perdu !");
            losePanel.SetActive(true);
        }

        FindObjectOfType<PlayerInventory>().ShowInventory();

        Time.timeScale = 0f;
    }

    public void StartGame()
    {
        Time.timeScale = 1f;
        startPanel.SetActive(false);
        FindObjectOfType<PlayerInventory>().ShowInventory();
    }

    public void RestartLevel()
    {
        isRestarting = true;

        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void QuitGame()
    {
        Debug.Log("Fermeture du jeu...");
        Application.Quit();

        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }

    public void ReturnToMainMenu()
    {
        isRestarting = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
