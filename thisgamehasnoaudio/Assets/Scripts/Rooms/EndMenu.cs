using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    public void PlayAgain(){
        SceneManager.LoadScene(1);
    }
}
