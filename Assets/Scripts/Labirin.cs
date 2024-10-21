using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Labirin : MonoBehaviour
{
    // Membuat variable untuk direferensikan ke object
    [SerializeField]
    GameObject labirin;

    void Start()
    {
        // Memunculkan nama object yang dimasukkan ke dalam variable labirin
        Debug.Log(labirin.name);
        // Memunculkan status active/non-active object yang dimasukkan ke dalam variable labirin
        Debug.Log(labirin.activeInHierarchy);

        // Memunculkan nama object yang dimasukkan ke dalam variable labirin menjadi Maze
        labirin.name = "Maze";
        // Mengubah status object yang dimasukkan ke dalam variable labirin menjadi aktif
        labirin.SetActive(true);
    }
}
