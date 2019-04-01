using UnityEngine;
using System.Collections;

public class DestroyByTime : MonoBehaviour
{
    public float lifetime;
    private AudioSource audio;
    void Start()
    {
        audio = GetComponent<AudioSource>();
        audio.Play();
        Destroy(gameObject, lifetime);

    }
}