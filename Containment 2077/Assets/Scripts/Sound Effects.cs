using UnityEngine;

public class SoundEffects : MonoBehaviour
{
    public AudioSource src;
    public AudioClip sfx1, sfx2, sfx3;
    public void phoneButton()
    {
        src.clip = sfx1;
        src.Play();
    }
}
