using TMPro;
using UnityEngine;

public class Text : MonoBehaviour {
    public TMP_Text st;

    public void Start () {
        st.text = "123";
    }

    public void UpdateText () {

        st.text = UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name;

    }

}
