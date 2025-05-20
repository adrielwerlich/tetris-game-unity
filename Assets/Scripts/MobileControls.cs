using UnityEngine;

public class MobileControls : MonoBehaviour
{
    private Board board; // Reference to the Board object

    private void Start()
    {
        // Automatically find the Board object in the scene
        if (board == null)
        {
            board = FindObjectOfType<Board>();

            if (board == null)
            {
                throw new System.Exception("Board object not found in the scene.");
            }
        }
    }



    public void OnPressSpace()
    {
        if (board != null && board.activePiece != null)
        {
            Debug.Log("Space pressed - Hard Drop");
            board.activePiece.ClearBoardAndUpdateLockTime(); // Clear the board and update lock time
            board.activePiece.HardDrop(); // Call HardDrop on the active piece
            board.activePiece.HandleMovementAndStep();
        }
    }

    public void OnPressQ()
    {
        if (board != null && board.activePiece != null)
        {
            board.activePiece.qPressed = true; // Rotate the active piece left
        }
    }

    public void OnPressE()
    {
        if (board != null && board.activePiece != null)
        {
            board.activePiece.ePressed = true; // Rotate the active piece right
        }
    }

    public void OnPressA()
    {
        if (board != null && board.activePiece != null)
        {
            board.activePiece.aPressed = true; // Move the active piece left
        }
    }

    public void OnPressD()
    {
        if (board != null && board.activePiece != null)
        {
            board.activePiece.dPressed = true; // Move the active piece right
        }
    }

    public void OnPressS()
    {
        if (board != null && board.activePiece != null)
        {
            board.activePiece.SoftDrop(); // Soft drop the active piece
            board.activePiece.StepAndSetActivePieceInBoard();
        }
    }


}
