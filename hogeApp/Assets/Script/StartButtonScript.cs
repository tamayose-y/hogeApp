using UnityEngine;
using UnityEngine.SceneManagement;
 
public class StartButtonScript : MonoBehaviour {
 
    public void OnClickInputButton()
    {
        SceneManager.LoadScene("list");
    }
 
}
