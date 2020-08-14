using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
 

public class ListSceneController : MonoBehaviour
{
    // Start is called before the first frame update    public GameObject Dialog = null;
    public GameObject Dialog = null;
    void Start(){

        if(Dialog != null)
        {
            GameObject.Find ("Dialog").SetActive (false);
        }
    }

   

    // Update is called once per frame
    void Update()
    {
        
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
        SceneManager.LoadScene("Input");
    }
    public void onButtonCancel () 
    {
        GameObject.Find ("Dialog").SetActive (false);
    }
     
    public void OnClickBackButton()
    {
        SceneManager.LoadScene("top");
    }
}
