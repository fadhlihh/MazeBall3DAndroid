using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Labirin : MonoBehaviour
{
    // Membuat variable untuk direferensikan ke transform
    [SerializeField]
    Transform transformLabirin;

    void Start()
    {
        // Memunculkan posisi object dari component transform labirin
        Debug.Log(transformLabirin.position);
        // Memunculkan rotasi object dari component transform labirin
        Debug.Log(transformLabirin.rotation);
        // Memunculkan skala object dari component transform labirin
        Debug.Log(transformLabirin.localScale);

        // Menentukan nilai posisi baru menggunakan variable tipe vector
        Vector3 posisiBaru = new Vector3(10, 0, 0);
        // Mengubah posisi dari component transform labirin di titik posisi baru
        transformLabirin.position = posisiBaru;

        // Menentukan nilai rotasi baru menggunakan variable tipe vector
        Vector3 rotasiBaru = new Vector3(90, 0, 0);
        // Mengubah rotasi dari component transform labirin dengan nilai variable rotasi baru
        // Nilai vector rotasi perlu dikorvensi ke sudut menggunakan Quaternion.Euler
        transformLabirin.rotation = Quaternion.Euler(rotasiBaru);

        // Menentukan nilai rotasi baru menggunakan variable tipe vector
        Vector3 skalaBaru = new Vector3(2, 2, 2);
        // Mengubah skala dari component transform labirin dengan nilai variable skala baru
        transformLabirin.localScale = skalaBaru;
    }
}
