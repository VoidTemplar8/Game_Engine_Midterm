using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Back_To_Menu : MonoBehaviour
{
    public void changeScenes(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}