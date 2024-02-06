using TMPro;
using UnityEngine;

public class NameInputController : MonoBehaviour
{
    void Start()
    {
        GetComponent<TMP_InputField>().text = PlayerPrefs.GetString("currentUsername", "");
    }

}
