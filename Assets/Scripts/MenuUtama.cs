using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUtama : MonoBehaviour
{
    public void Mainkan()
    {
        // Ketika klik tombol mainkan, scene Labirin akan diload
        SceneManager.LoadScene("Labirin");
    }

    public void Keluar()
    {
        // Ketika klik tombol keluar, aplikasi game akan ditutup
        Application.Quit();
    }
}
