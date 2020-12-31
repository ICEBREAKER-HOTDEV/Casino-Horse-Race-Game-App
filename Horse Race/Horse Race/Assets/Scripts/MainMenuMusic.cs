using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenuMusic : MonoBehaviour
{
    private static MainMenuMusic instance = null;

    public static MainMenuMusic Instance
    {
        get { return instance; }
    }

    void Start()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
            instance = this;
    }

    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Gameplay_Stadium" || SceneManager.GetActiveScene().name == "Gameplay_Desert")
            Destroy(this.gameObject);
        else
            DontDestroyOnLoad(this.gameObject);
    }
}
