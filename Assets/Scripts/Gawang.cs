using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gawang : MonoBehaviour
{
    // Function ini akan dipanggil ketika ada object yang mulai menembus gawang
    private void OnTriggerEnter(Collider other)
    {
        // Ketika ada object yang menembus gawang, scene MenuGameOver akan diload
        SceneManager.LoadScene("MenuGameOver");
    }
}
