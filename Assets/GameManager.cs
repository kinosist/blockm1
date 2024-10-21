using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private GameObject text;
    private GameObject restartButton;

    // Start is called before the first frame update
    void Start()
    {
        text = GameObject.Find("Text");
        restartButton = GameObject.Find("RestartButton");

        // �{�^�����\��
        restartButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // �Q�[���I�[�o�[����
    public void GameOver()
    {
        text.GetComponent<Text>().text = "Game Over";

        // �{�^����\��
        restartButton.SetActive(true);
    }

    // ���X�^�[�g����
    public void Restart()
    {
        // ���݂̃V�[�����ēǂݍ���
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
