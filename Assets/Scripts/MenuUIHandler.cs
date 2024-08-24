using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    public TMP_InputField tmpInputField;

    public void StartNew()
    {
        GameManager.Instance.playerName = tmpInputField.text;

        SceneManager.LoadScene(1);
    }
}
