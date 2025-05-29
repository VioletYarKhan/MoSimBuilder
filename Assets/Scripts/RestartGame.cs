using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    void Update()
    {
        /*
        for (int i = 0; i <= 19; i++)
        {
            if (Input.GetKeyDown("joystick button " + i))
            {
                Debug.Log("Pressed: joystick button " + i);
            }
        }*/
        if (Input.GetKeyDown(KeyCode.JoystickButton7))
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}