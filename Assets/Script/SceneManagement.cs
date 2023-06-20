using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{

	public string EnterScene;
	public string EscapeScene;
	public bool isEscapeForQuit = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	if (Input.GetKeyUp(KeyCode.Return))
	    {
	    Debug.Log("Name Scene: " + EnterScene);
	    SceneManager.LoadScene(EnterScene);
	    }

        if (Input.GetKeyUp(KeyCode.Escape))
	        {
	            if (isEscapeForQuit)
	            {
	                Application.Quit();
	            }
	            else
	            {
	                Debug.Log("Name Scene: " + EscapeScene);
	                SceneManager.LoadScene(EscapeScene);
	            }
	        }

    }
}