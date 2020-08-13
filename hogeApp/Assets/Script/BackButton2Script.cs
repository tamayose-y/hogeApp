using UnityEngine;
using UnityEngine.SceneManagement;
 
public class BackButton2Script : MonoBehaviour {
 
    public void OnClickBackButton()
    {
        SceneManager.LoadScene("list");
    }
 
}
