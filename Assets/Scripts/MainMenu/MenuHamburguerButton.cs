using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MenuHamburguerButton : MonoBehaviour
{

    [SerializeField] private Sprite menuClosedImage;   // Image for the closed menu state
    [SerializeField] private Sprite menuOpenImage;     // Image for the open menu state
    [SerializeField] private Image buttonImage;

    [SerializeField] private GameObject gameMenuPanel; // Reference to the menu panel
    [SerializeField] private GameObject leftSideButtonsPanel; // Reference to the menu panel
    [SerializeField] private GameObject rightSideButtonsPanel; // Reference to the menu panel


    private bool isMenuOpen = false;

    private void Start()
    {
        // Get the Image component attached to this GameObject
        buttonImage = GetComponent<Image>();

        // Set the initial image to the closed menu state
        buttonImage.sprite = menuClosedImage;

        gameMenuPanel.SetActive(false);


        leftSideButtonsPanel = GameObject.Find("Buttons_Left_Side");
        rightSideButtonsPanel = GameObject.Find("Buttons_Right_Side");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ToggleMenu();
        }
    }

    public void ToggleMenu()
    {
        isMenuOpen = !isMenuOpen;
        gameMenuPanel.SetActive(isMenuOpen);
        leftSideButtonsPanel.SetActive(!isMenuOpen);
        rightSideButtonsPanel.SetActive(!isMenuOpen);

        buttonImage.sprite = isMenuOpen ? menuOpenImage : menuClosedImage;

        if (isMenuOpen)
        {
            Time.timeScale = 0f; // Pause the game
        }
        else
        {
            Time.timeScale = 1f; // Resume the game
        }
    }
}
