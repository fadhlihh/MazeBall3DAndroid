using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gawang : MonoBehaviour
{
    // Function ini akan dipanggil ketika ada object yang mulai menembus gawang
    private void OnTriggerEnter(Collider other)
    {
        // Ketika ada object yang menembus gawang akan dimunculkan log Kamu Menang
        Debug.Log("Kamu Menang!");
    }
}
