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

    void Start()
    {
    }

    void Update()
    {
        // Mendapatkan nilai rotasi sekarang
        // rotasi sekarang dirotasi di sumbu x +1 dengan kecepetan rotasi yang telah ditentukan
        rotasiSekarang = rotasiSekarang + new Vector3(1, 0, 0) * kecepatanRotasi * Time.deltaTime;
        // Mengubah rotasi dari component transform labirin dengan nilai variable rotasi sekarang
        // Nilai vector rotasi perlu dikorvensi ke sudut menggunakan Quaternion.Euler
        transformLabirin.rotation = Quaternion.Euler(rotasiSekarang);
    }

    public void TekanKiri()
    {
        Debug.Log("Kiri");
    }

    public void TekanKanan()
    {
        Debug.Log("Kanan");
    }
}
