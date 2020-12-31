using UnityEngine.SceneManagement;
using UnityEngine;

public class ButtonSounds : MonoBehaviour
{
    public AudioSource buttonClick;

    public void PlayButtonSound()
    {
        buttonClick.Play();
    }

    void Update()
    {
        DontDestroyOnLoad(buttonClick.gameObject);
    }
}