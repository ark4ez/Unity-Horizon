using UnityEngine;

/*
 * ゲームプレイヤーに関するパッケージ（必ずしもゲーム内における操作対象のゲームキャラに関するものではない）
 */
namespace demo.player
{
    public class PlayerInput : MonoBehaviour
    {
        private string _debugTag;

        private void Start()
        {
            _debugTag = "[" + GetType().FullName + "] : ";
            DontDestroyOnLoad(gameObject);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                Debug.Log(_debugTag + "Get key 'W'");
            }

            if (Input.GetKey(KeyCode.A))
            {
                Debug.Log(_debugTag + "Get key 'A'");
            }
        }
    }
}