using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundMusic : MonoBehaviour
{
    private static backgroundMusic instance = null;

    void Awake()
    {
        // Prevent multiple instances of this object
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Ensure the object is not destroyed when switching scenes
        }
        else
        {
            Destroy(gameObject); // Destroy the new object if one already exists
        }
    }
}
