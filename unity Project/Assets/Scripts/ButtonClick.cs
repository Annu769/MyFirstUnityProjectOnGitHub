using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonClick : MonoBehaviour
{
    public Button button;
    public string Nextscene;
    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(ButtonOnclick);
    }
    private void ButtonOnclick()
    {
        Debug.Log("Button clicked");
        SceneManager.LoadScene(Nextscene);
    }
    
}
