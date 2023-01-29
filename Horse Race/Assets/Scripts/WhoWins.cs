using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WhoWins : MonoBehaviour
{
    public Collider2D finishLine;
    [SerializeField] private GameObject endGameHUD;
    [SerializeField] private GameObject pauseMenuUI; 
    public Text winner;

    private void OnTriggerEnter2D(Collider2D other)
    {
        endGameHUD.SetActive(true);

        if (other.gameObject.name == "blackHorse")
            winner.text = "SAHBATUR   WINS";
        else if (other.gameObject.name == "whiteHorse")
            winner.text = "OYMAPINAR   WINS";
        else if (other.gameObject.name == "greyHorse")
            winner.text = "BOLD PILOT   WINS";
        else
            winner.text = "GULBATUR   WINS";

        finishLine.gameObject.SetActive(false);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void Update() 
    {
        if (pauseMenuUI.activeSelf == true) {
            endGameHUD.SetActive(false);
            Cursor.visible = true;
        }
    }
}


