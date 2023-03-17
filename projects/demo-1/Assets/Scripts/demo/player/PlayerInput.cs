using UnityEngine;

namespace demo.player
{
    // public interface IPlayerInputResolver
    // {
    //     void MoveUp();
    //     void MoveDown();
    //     void MoveLeft();
    //     void MoveRight();
    //     
    // }

    public class PlayerInput : MonoBehaviour
    {
        private void Start()
        {
            DontDestroyOnLoad(gameObject);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
            }
        }
    }
}