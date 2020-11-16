using UnityEngine;
using System.Collections;
using UnityEngine.UI;  ////ここを追加////

public class ScoreText : MonoBehaviour {
    // Use this for initialization
    void Start () {
        this.GetComponent<Text>().text = "点数";
    }

    // Update is called once per frame
    void Update () {
        this.GetComponent<Text>().text = "点数";
    }
}