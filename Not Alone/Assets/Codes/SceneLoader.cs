using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void LoadChapter1()
    {
        SceneManager.LoadScene("Chapter 1");
    }

    public void LoadChapter1Game()
    {
        SceneManager.LoadScene("Chapter 1 Game");
    }
}
