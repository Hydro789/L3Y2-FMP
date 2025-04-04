using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public TMP_Text currentLevel;

    // Update is called once per frame
    void Update()
    {
        currentLevel.text = SceneManager.GetActiveScene().name;
    }

    public void NextLevel()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void PreviousLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
