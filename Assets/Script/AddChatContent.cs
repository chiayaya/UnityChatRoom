using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;
using Text = UnityEngine.UI.Text;

public class AddChatContent : MonoBehaviour
{
    public GameObject textPrefab; // Text���󪺹w�s��
    public Transform parentTransform; // �Ψө�mText���󪺤�����
    public InputField inputField; // �s��InputField
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
        Debug.Log("��J���T��: " + text);

        GameObject newText = Instantiate(textPrefab); // �ͦ�Text����

        Debug.Log(newText);

        newText.GetComponent<Text>().text = text; // �]�mText���󪺤奻

        inputField.text = "";
        inputField.ActivateInputField();


    }




    // Update is called once per frame
    void Update()
    {

    }
}
