using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class LoginService : MonoBehaviour
{
    // 
    public InputField phone;
    public InputField pwd;

    public Button loginBtn; 
    public Button regBtn;
    public Text errorMsg;


    public void Login() {
        errorMsg.text = "手机号密码登陆成功";
        SceneManager.LoadScene("main");
    }
}
