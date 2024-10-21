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
        // Memanggil function MunculkanLog(), 
        // untuk memunculkan log dengan nilai variable nama yaitu Agate
        MunculkanNama();

        // Memanggil function TambahAngka(angka1: 5, angka2: 3), 
        // untuk memunculkan log dengan nilai variable hasil tambah 5 + 3 = 8
        TambahAngka(5, 3);
    }

    void Update()
    {

    }

    // Membuat function untuk memunculkan log dengan nilai variable nama
    void MunculkanNama()
    {
        // Memunculkan log dengan nilai variable nama yaitu Agate
        Debug.Log(nama);
    }

    // Membuat function untuk menambahkan angka
    void TambahAngka(int angka1, int angka2)
    {
        // Membuat variable hasil, dengan nilai nya adalah hasil tambah angka1 dan angka2
        int hasil = angka1 + angka2;
        // Memunculkan log dengan nilai variable hasil
        Debug.Log(hasil);
    }
}
