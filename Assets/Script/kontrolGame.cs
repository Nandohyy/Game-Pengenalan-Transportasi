using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class kontrolGame : MonoBehaviour
{
    // Start is called before the first frame update
    public void KembaliSampleScene(){
        SceneManager.LoadScene ("SampleScene");
    }
    public void transportasiDarat(){
        SceneManager.LoadScene ("DaratScene");
    }
    public void transportasiLaut(){
        SceneManager.LoadScene ("LautScene");
    }
    public void transportasiUdara(){
        SceneManager.LoadScene ("UdaraScene");
    }
}
