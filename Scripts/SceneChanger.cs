using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{

        public void GotoMainScene()
        {
            
            SceneManager.LoadScene("Main");
        
          }

        public void GotoMenuScene()
        {
            SceneManager.LoadScene("Menu");
        }
        public void GotoDeadScene()
        {
            SceneManager.LoadScene("Dead");
        }


}
