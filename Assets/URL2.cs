using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.InteropServices;
public class URL2 : MonoBehaviour
{
    [DllImport("__Internal")] private static extern void OpenNewWindow(string url);
    public void onClick()
    {
        string url_;
        url_ = String.Format("https://line.me/R/ti/p/@639uwexy");
        OpenNewWindow(url_);
    }
}
