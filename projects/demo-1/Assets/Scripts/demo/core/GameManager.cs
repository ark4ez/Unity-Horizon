using System;
using UnityEngine;

/*
 * ゲームの中心となるパッケージ
 */
namespace demo.core
{
    // ゲームの状態を示す
    public enum GameState
    {
        Default,
        Error,
    }

    /*
     * ゲームの進行関連
     */
    public class GameManager : MonoBehaviour
    {
        private string _debugTag;

        private GameState State { get; set; }

        private void Start()
        {
            _debugTag = "[" + GetType().FullName + "] : ";
            State = GameState.Default;
            Debug.Log(_debugTag + "Game start");
            DontDestroyOnLoad(gameObject);
        }

        private void FixedUpdate()
        {
            switch (State)
            {
                case GameState.Default:
                    // Debug.Log(_debugTag + "");
                    break;
                case GameState.Error:
                    // Debug.Log("Error");
                    break;
                default:
                    break;
            }
        }
    }
}