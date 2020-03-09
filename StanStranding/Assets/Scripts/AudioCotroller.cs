using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioCotroller : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip calm;
    public AudioClip tense;
    private AudioSource Audio;
    private void Start()
    {
        Audio = gameObject.GetComponent<AudioSource>();
    }
    public void ChangeToCalm()
    {
        Audio.clip = calm;
        Audio.Play();
    }
    public void ChangeToTense()
    {
        Audio.clip = tense;
        Audio.Play();
    }
}
