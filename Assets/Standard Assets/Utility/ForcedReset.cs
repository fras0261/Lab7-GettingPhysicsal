using System;
using UnityEngine;
<<<<<<< HEAD
using UnityEngine.SceneManagement;
=======
>>>>>>> 860761ec8dfa20c58b2713e85442b2aaf7e13a15
using UnityStandardAssets.CrossPlatformInput;

[RequireComponent(typeof (GUITexture))]
public class ForcedReset : MonoBehaviour
{
    private void Update()
    {
        // if we have forced a reset ...
        if (CrossPlatformInputManager.GetButtonDown("ResetObject"))
        {
            //... reload the scene
<<<<<<< HEAD
            SceneManager.LoadScene(SceneManager.GetSceneAt(0).path);
=======
            Application.LoadLevelAsync(Application.loadedLevelName);
>>>>>>> 860761ec8dfa20c58b2713e85442b2aaf7e13a15
        }
    }
}
