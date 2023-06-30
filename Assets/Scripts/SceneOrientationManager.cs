using UnityEngine;

public class SceneOrientationManager : MonoBehaviour {
    void Start () {
        string sceneName = UnityEngine.SceneManagement.SceneManager.GetActiveScene().name;

        if (sceneName == "Menu" || sceneName == "Gallery") {
            SetPortraitOrientation ();
        } else {
            SetAutoRotation ();
        }
    }

    void SetPortraitOrientation () {
        Screen.orientation = ScreenOrientation.Portrait;
    }

    void SetAutoRotation () {
        Screen.orientation = ScreenOrientation.AutoRotation;
    }
}