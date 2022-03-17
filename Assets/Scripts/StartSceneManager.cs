using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//シーンを変えるときに必要なおまじない



public class StartSceneManager : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetKeyDown("up") == true)
       // {
            //SceneManager.LoadScene("Main");
        //}
    }

    public void Go1()
    {
        SceneManager.LoadScene("1_Stage1");
    }
    public void Go2()
    {
        SceneManager.LoadScene("2_Stage1");
    }
    public void Go3()
    {
        SceneManager.LoadScene("3_Stage");
    }

    public void HowToPlay()
    {
        SceneManager.LoadScene("HowToPlay");
    }

}