using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public void DesertLevel()
    {
        SceneManager.LoadScene("Gameplay_Desert");
    }

    public void StadiumLevel()
    {
        SceneManager.LoadScene("Gameplay_Stadium");
    }
}
