using UnityEngine.SceneManagement;
using UnityEngine;


public class PauseMenuButtons : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenuUI;      //Buradaki [SerializeField] komutu private değişkenleri inspectorda public ve görünür yapmak için kullanılır.
    private bool isPaused;
    
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            isPaused = !isPaused;

        if (isPaused) {
            ActivateMenu();
            Cursor.visible = true;
        }
        else {
            DeactivateMenu();
            Cursor.visible = false;
        }
    }

    void ActivateMenu()
    {
        Time.timeScale = 0f;             //Bu kod zaman akışını sıfırlar, yani oyunu dondurur
        //AudioListener.pause = true;     //Bu da oyunun seslerini dondurur
        pauseMenuUI.SetActive(true);
    }

    void DeactivateMenu()
    {
        Time.timeScale = 1f;             //Bu da zaman akışını devam ettirir, yani oyun devam eder.
        //AudioListener.pause = false;    //Oyunun sesleri çalmaya devam eder.
        pauseMenuUI.SetActive(false);
    }
}
