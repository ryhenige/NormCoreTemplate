using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    public Text selected;
    private string room;

    public void SetRoom(string _room)
    {
        room = _room;
        selected.text = _room ;
    }

    public void Connect()
    {
        if (room != null)
        {
            CrossSceneVars.server = room;
            SceneManager.LoadScene("Main");
        }
    }

}