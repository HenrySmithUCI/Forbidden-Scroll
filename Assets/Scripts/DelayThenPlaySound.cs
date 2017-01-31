using UnityEngine;
using System.Collections;

public class DelayThenPlaySound : MonoBehaviour {

    public float delay;
    public AudioClip clip;

    private float timer;
    private bool played;
    private AudioSource source;

    // Use this for initialization
    void Start () {
        source = GetComponent<AudioSource>();
        timer = delay;
        played = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (!played)
        {
            timer -= Time.deltaTime;
            if(timer <= 0)
            {
                source.clip = clip;
                source.Play();
                played = true;
            }
        }
	}
}
