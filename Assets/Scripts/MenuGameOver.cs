using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuGameOver : MonoBehaviour
{
    public void Ulangi()
    {
        // Ketika klik tombol ulangi, scene Labirin akan diload
        SceneManager.LoadScene("Labirin");
    }

    public void MenuUtama()
    {
        // Ketika klik tombol menu utama, scene MenuUtama akan diload
        SceneManager.LoadScene("MenuUtama");
    }
}
