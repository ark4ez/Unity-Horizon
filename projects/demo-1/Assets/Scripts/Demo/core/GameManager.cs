using UnityEngine;

namespace Demo.core
{
    ///<summary>
    /// ゲームの状態を示す
    /// </summary>>
    public enum GameState
    {
        Default,
        Error,
    }

    /// <summary>
    /// ゲームの進行関連
    /// </summary>
    public class GameManager : MonoBehaviour
    {
        private GameState State { get; set; }

        private void Start()
        {
            State = GameState.Default;
            Debug.Log("Game manager is start");
            DontDestroyOnLoad(gameObject);
        }

        private void FixedUpdate()
        {
            switch (State)
            {
                case GameState.Default:
                    break;
                case GameState.Error:
                    break;
                default:
                    break;
            }
        }

        private void OnDestroy()
        {
            Debug.Log("Game manager is destroy");
        }
    }
}