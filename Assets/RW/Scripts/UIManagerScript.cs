using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour
{
    public string RocketMouse;
    public void StartGame()
    {
        SceneManager.LoadScene("RocketMouse");
    }
}