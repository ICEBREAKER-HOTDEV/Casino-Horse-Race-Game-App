using UnityEngine;

public class CursorChange : MonoBehaviour
{
    public Texture2D cursorArrow;
    public Texture2D cursorHand;

    public Vector2 onButtonCursorHotSpot;
    public Vector2 normalCursorHotSpot;
    void Start()
    {
        Cursor.SetCursor(cursorArrow, Vector2.zero, CursorMode.ForceSoftware);
    }

    public void OnMouseEnter() 
    {
        Cursor.SetCursor(cursorHand, onButtonCursorHotSpot, CursorMode.ForceSoftware);    
    }    

    public void OnMouseExit()
    {
        Cursor.SetCursor(cursorArrow, normalCursorHotSpot, CursorMode.ForceSoftware);
    }
}
