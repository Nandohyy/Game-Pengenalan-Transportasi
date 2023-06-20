using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audiomobil : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource lagu;
    public void mulai()
    {
        lagu.Play();
    }

    // Update is called once per frame
    public void stop()
    {
        lagu.Stop();
    }
}
