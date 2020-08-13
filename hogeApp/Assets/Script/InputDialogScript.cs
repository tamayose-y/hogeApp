using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
 
public class InputDialogScript : MonoBehaviour {
    
    
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
        SceneManager.LoadScene("Input");
    }
    public void onButtonCancel () 
    {
        GameObject.Find ("Dialog").SetActive (false);
    }
 
}