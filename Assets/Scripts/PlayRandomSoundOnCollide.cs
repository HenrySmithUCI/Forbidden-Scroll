using UnityEngine;
using System.Collections;

public class PlayRandomSoundOnCollide : MonoBehaviour {

    public AudioClip[] clips;
    public GameObject[] others;

    private AudioSource source;

    private void Start()
    {
        source = GetComponent<AudioSource>();
    }

    public void playSound()
    {
        if (!source.isPlaying)
        {
            source.clip = clips[Random.Range(0, clips.Length)];
            source.Play();
        }
    }

    private void OnMouseDown()
    {
        playSound();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        foreach(GameObject go in others)
        {
            if(collision.gameObject == go)
            {
                playSound();
                break;
            }
        }
    }
}
