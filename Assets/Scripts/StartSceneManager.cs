using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneManager : MonoBehaviour {
    public void Start () {
        Debug.Log (SceneManager.GetActiveScene ().name);
        SceneManager.LoadScene ("Menu");
    }
}
