using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Labirin : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Awake");
    }

    private void OnEnable()
    {
        Debug.Log("On Enable");
    }

    private void Start()
    {
        Debug.Log("Start");
    }

    private void Update()
    {
        Debug.Log("Update");
    }

    private void LateUpdate()
    {
        Debug.Log("Late Update");
    }

    private void OnDisable()
    {
        Debug.Log("On Disable");
    }

    private void OnDestroy()
    {
        Debug.Log("On Destroy");
    }

    private void OnApplicationQuit()
    {
        Debug.Log("On Application Quit");
    }
}
