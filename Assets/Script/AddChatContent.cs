using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;
using Text = UnityEngine.UI.Text;

public class AddChatContent : MonoBehaviour
{
    public GameObject textPrefab; // Text物件的預製體
    public Transform parentTransform; // 用來放置Text物件的父物體
    public InputField inputField; // 連接InputField
    public List<Transform> messages = new List<Transform>();



    // Start is called before the first frame update
    void Start()
    {
        if (inputField != null)
        {
            inputField.onEndEdit.AddListener(OnInputEnd);
        }
    }
    
        void OnInputEnd(string text)
    {
        Debug.Log("輸入的訊息: " + text);

        GameObject newText = Instantiate(textPrefab); // 生成Text物件

        Debug.Log(newText);

        newText.GetComponent<Text>().text = text; // 設置Text物件的文本

        inputField.text = "";
        inputField.ActivateInputField();


    }




    // Update is called once per frame
    void Update()
    {

    }
}
