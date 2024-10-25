using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    [SerializeField]
    AudioSource sfxBola;

    private void OnCollisionEnter(Collision other)
    {
        sfxBola.Play();
    }
}
