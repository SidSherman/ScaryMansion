using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MainMenuUIController : MonoBehaviour
{
    [SerializeField] private Button startButton;
    [SerializeField] private Button SettingButton;
    [SerializeField] private Button PlayerSelectorButton;
    [SerializeField] private Button ExitButton;

    // Start is called before the first frame update
    void Start()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;
        startButton = root.Q<Button>("NewGameButton");
        SettingButton = root.Q<Button>("SettingsButton");
        ExitButton = root.Q<Button>("ExitButton");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
