using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject dl;
    public GameObject zc;
    void Start()
    {
        zc.SetActive(false);
        dl.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void get_dl()
    {
        zc.SetActive (false);
        dl.SetActive (true);
    }
    public void get_zc()
    {
        zc.SetActive(true);
        dl.SetActive (false);
    }
}
