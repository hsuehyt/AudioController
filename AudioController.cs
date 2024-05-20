using UnityEngine;

public class AudioController : MonoBehaviour
{
    private AudioSource audioSource;
    private bool isPaused;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        isPaused = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isPaused)
            {
                audioSource.Play();
                isPaused = false;
            }
            else
            {
                audioSource.Pause();
                isPaused = true;
            }
        }
    }
}
