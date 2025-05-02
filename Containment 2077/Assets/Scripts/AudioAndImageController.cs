using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AudioAndImageController : MonoBehaviour
{
    public GameObject imageToShow; // The image to display
    public AudioSource audioSource; // The audio source
    public float delayBeforeAudio = 2f; // Delay in seconds before playing audio
    public float delayAfterAudio = 0.5f; // Delay after audio before showing image

    void Start()
    {
        // Start the process
        StartCoroutine(PlayAudioAndShowImage());
    }

    private IEnumerator PlayAudioAndShowImage()
    {
        // Wait before playing the audio
        yield return new WaitForSeconds(delayBeforeAudio);

        // Play the audio
        if (audioSource != null)
        {
            audioSource.Play();
        }

        // Wait for the audio to finish + additional delay
        if (audioSource != null)
        {
            yield return new WaitForSeconds(audioSource.clip.length + delayAfterAudio);
        }

        // Show the image
        if (imageToShow != null)
        {
            imageToShow.SetActive(true);
        }
    }
}
