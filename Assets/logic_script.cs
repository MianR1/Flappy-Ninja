using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logic_script : MonoBehaviour
{
    public float score;
    public Text scoretext;
    public GameObject gameoverscreen;

    [ContextMenu("increase")] // lets you call the function to test in unity
    public void addScore(){
        score += 0.5f;
        scoretext.text = score.ToString();
    }

    public void restartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver(){
        gameoverscreen.SetActive(true);
    }
}