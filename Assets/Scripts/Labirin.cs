using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Labirin : MonoBehaviour
{
    // Membuat variable nama dengan tipe string, dengan nilai awal "Agate"
    [SerializeField]
    string nama = "Agate";
    // Membuat variable kecepatan dengan tipe float, dengan nilai awal "10.5"
    [SerializeField]
    float kecepatan = 10.5f;
    // Membuat variable pemain menang dengan tipe bool, dengan nilai awal "false"
    [SerializeField]
    bool pemainMenang = false;
    // Membuat variable posisi 2D dengan tipe Vector2, dengan nilai awal "(x: 0, y:0)"
    [SerializeField]
    Vector2 posisi2D = new Vector3(0, 0);
    // Membuat variable posisi 3D dengan tipe Vector3, dengan nilai awal "(x: 0, y:0, z:0)"
    [SerializeField]
    Vector3 posisi3D = new Vector3(0, 0, 0);

    // Membuat variable kecepatan dengan tipe integer, dengan nilai awal "100"
    int score = 100;

    void Start()
    {
        // Memunculkan log dengan nilai variable nama yaitu Agate
        Debug.Log(nama);
    }

    void Update()
    {

    }
}
