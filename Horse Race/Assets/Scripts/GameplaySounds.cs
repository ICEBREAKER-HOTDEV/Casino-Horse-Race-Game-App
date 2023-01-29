using UnityEngine;

public class GameplaySounds : MonoBehaviour
{
    AudioSource horsesRunning;
    AudioSource crowdNoise;
    void Start()
    {
        horsesRunning = GetComponent<AudioSource>();
        crowdNoise = GetComponent<AudioSource>();

        horsesRunning.Play(0);
        crowdNoise.Play(0);   
    }
}
