using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement
public class play : MonoBehaviour
{
  
  
      public void PlayButton()  
     {
       sceneManager.LoadScane(1)

     }
     
     public void QuitButton()
     {
       Application.Quit()
     
     }
