using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Labirin : MonoBehaviour
{
    // Membuat variable untuk direferensikan ke transform
    [SerializeField]
    Transform transformLabirin;
    [SerializeField]
    float kecepatanRotasi;

    Vector3 rotasiSekarang = new Vector3(0, 0, 0);
    Vector3 arahRotasi = new Vector3(0, 0, 0);

    void Update()
    {
        // Mendapatkan nilai rotasi sekarang
        // rotasi sekarang dirotasi dengan arah rotasi sesuai variable arahRotasi
        // dengan kecepatan sesuai variable kecepatanRotasi
        rotasiSekarang = rotasiSekarang + arahRotasi * kecepatanRotasi * Time.deltaTime;
        // Mengubah rotasi dari component transform labirin dengan nilai variable rotasi sekarang
        // Nilai vector rotasi perlu dikorvensi ke sudut menggunakan Quaternion.Euler
        transformLabirin.rotation = Quaternion.Euler(rotasiSekarang);

    }

    public void TekanAtas()
    {
        // Menentukan arah rotasi ke atas
        arahRotasi = new Vector3(1, 0, 0);
    }

    public void TekanBawah()
    {
        // Menentukan arah rotasi ke bawah
        arahRotasi = new Vector3(-1, 0, 0);
    }

    public void TekanKiri()
    {
        // Menentukan arah rotasi ke kiri
        arahRotasi = new Vector3(0, 0, 1);
    }

    public void TekanKanan()
    {
        // Menentukan arah rotasi ke kanan
        arahRotasi = new Vector3(0, 0, -1);
    }

    public void LepasTombol()
    {
        // Menentukan arah rotasi nol (tidak berputar)
        arahRotasi = new Vector3(0, 0, 0);
    }
}
