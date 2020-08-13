using UnityEngine;
using UnityEngine.SceneManagement;
 
public class BackButtonScript : MonoBehaviour {
 
    public void OnClickBackButton()
    {
        SceneManager.LoadScene("top");
    }
 
}
