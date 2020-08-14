using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class InputScriptController : MonoBehaviour
{

    public GameObject Dialog = null;

    // Start is called before the first frame update
    void Start()
    {
        if(Dialog != null)
        {
            GameObject.Find ("Dialog").SetActive (false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickBackButton()
    {
        SceneManager.LoadScene("list");
    }
 
    public void OnClickInputButton()
    {
        SceneManager.LoadScene("list");
    }


    void OnClickCheckButton()
    {
       checkDialog();
    }


    public void checkDialog()
    {
        if(Dialog != null)
        {
            Dialog.SetActive(true);
        }
    }

    public void onButtonOk () 
    {
        GameObject.Find ("Dialog").SetActive (false);
    }
    public void onButtonCancel () 
    {
        GameObject.Find ("Dialog").SetActive (false);
    }
}
