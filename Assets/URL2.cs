using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
 
public class URL2 : MonoBehaviour
{
    public void onClick()
    {
        string url_;
        url_ = String.Format("https://line.me/R/ti/p/@639uwexy");
        Application.OpenURL(url_);
    }
}
