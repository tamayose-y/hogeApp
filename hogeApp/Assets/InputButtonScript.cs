using UnityEngine;
using UnityEngine.SceneManagement;
 
public class InputButtonScript : MonoBehaviour {
 
    public void OnClickInputButton()
    {
        SceneManager.LoadScene("list");
    }
 
}
