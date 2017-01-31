using UnityEngine;
using System.Collections;

public class FadeIn : MonoBehaviour {
    public float delay;
    public float fadeInTime;

    private Renderer image;

    private float timer;
    private bool fadeStarted;
    private bool faded;
	
    void Start()
    {
        image = GetComponent<Renderer>();
        Color c = image.material.color;
        c.a = 0;
        image.material.color = c;
        timer = delay;
        faded = false;
        fadeStarted = false;
    }
    
	void Update () {
        if (!faded)
        {
            if (!fadeStarted)
            {
                timer -= Time.deltaTime;
                if (timer <= 0)
                {
                    timer = 0;
                    fadeStarted = true;
                }
            }
            else
            {
                timer += Time.deltaTime;
                Color c = image.material.color;
                c.a = timer / fadeInTime;
                if (c.a >= 1)
                {
                    c.a = 1;
                    faded = true;
                }
                image.material.color = c;
            }
        }
	}
}
