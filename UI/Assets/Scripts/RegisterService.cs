using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class RegisterService : MonoBehaviour
{
    // reg
    public InputField phone;
    public InputField code;
    public InputField pwd;

    public Button regBtn;
    public Button loginBtn;
    public Button sendBtn;
    public Text errorMsg;
    
    public void Register() {
        errorMsg.text = "手机号，验证码错误";

    }

    public void SendCode(){
         errorMsg.text = "短信已发送，请查收";

    }

}
