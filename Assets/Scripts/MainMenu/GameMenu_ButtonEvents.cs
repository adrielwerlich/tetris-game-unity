using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMenu_ButtonEvents : MonoBehaviour
{
    private MenuHamburguerButton menuHamburguerButton;
    private Board board;

    private void Start()
    {
        menuHamburguerButton = GameObject.Find("HamburguerMenuButton").GetComponent<MenuHamburguerButton>();
        board = GameObject.Find("Board").GetComponent<Board>();
    }

    public void CloseMenuAndPlay()
    {
        menuHamburguerButton.ToggleMenu();
    }

    public void RestartGame()
    {
        board.GameOver();
        board.SpawnPiece();
        CloseMenuAndPlay();
    }
}
