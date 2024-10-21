using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private GameObject text;
    private GameObject restartButton;
    private GameObject[] blocks;    // ブロックの配列

    // Start is called before the first frame update
    void Start()
    {
        text = GameObject.Find("Text");
        restartButton = GameObject.Find("RestartButton");

        // ボタンを非表示
        restartButton.SetActive(false);

        // "Block"タグのオブジェクトを全て取得
        blocks = GameObject.FindGameObjectsWithTag("Block");
    }

    // Update is called once per frame
    void Update()
    {
        // "Block"タグのオブジェクトを全て取得
        blocks = GameObject.FindGameObjectsWithTag("Block");
        // ブロックが全て消えたらゲームクリア
        if (blocks.Length == 0)
        {
            GameClear();
        }
    }

    // ゲームオーバー処理
    public void GameOver()
    {
        text.GetComponent<Text>().text = "Game Over";

        // ボタンを表示
        restartButton.SetActive(true);
    }

    // リスタート処理
    public void Restart()
    {
        // 現在のシーンを再読み込み
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // ゲームクリア処理
    public void GameClear()
    {
        text.GetComponent<Text>().text = "Game Clear!";
    }
}
