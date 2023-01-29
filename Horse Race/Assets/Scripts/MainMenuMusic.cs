using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuMusic : MonoBehaviour
{
    AudioSource mainMenuMusic;
    GameObject mainCamera;
    void Awake()
    {
        mainCamera = GameObject.Find("Main Camera");
        
        mainMenuMusic = GetComponent<AudioSource>();
        mainMenuMusic.Play(0);

        DontDestroyOnLoad(mainMenuMusic);
    }

    void Update() 
    {
        if (SceneManager.GetActiveScene().name == "Gameplay_Stadium" ||
            SceneManager.GetActiveScene().name == "Gameplay_Desert") {
                mainMenuMusic.GetComponent<AudioSource>().Stop();
                Destroy(mainCamera);
            }
    }
}
