using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLoader : MonoBehaviour
{
    [Header("This script loads a scene which contains a camera rig. It can be any player, google cardboard, Oculus VR etc, etc")]
    [Space(20)]
    [Tooltip("The buildIndex of the player scene")]
    [SerializeField]
    private int sceneToLoad;

    //Automatically loads in a player scene if there is not already one loaded
    private void Start()
    {
        if (SceneManager.sceneCount <= 1)
            SceneManager.LoadScene(sceneToLoad, LoadSceneMode.Additive);
    }
}
