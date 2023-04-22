using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class loadscene : MonoBehaviour
{
    
   public  void Loadscene()
    {
        SceneManager.LoadScene(0);
    }

    public void Exit()
    {
        Application.Quit();
        //Debug.Log("exit");
    }
   
}
