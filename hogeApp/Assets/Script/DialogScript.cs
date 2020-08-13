using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
 
public class DialogScript : MonoBehaviour {
    
    
    public GameObject Dialog = null;

    void Start(){

        if(Dialog != null)
        {
            GameObject.Find ("Dialog").SetActive (false);
        }
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
