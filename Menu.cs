using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
   

    // Update is called once per frame
   
    public void Jugar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Controles()
    {
        SceneManager.LoadScene("Controles");
    }

    //public void Menu(string nombreMenu)
    
    //{
      //  SceneManager.LoadScene("Menu");
    //}

    public void Salir()
    {
        Application.Quit();
    }

}
