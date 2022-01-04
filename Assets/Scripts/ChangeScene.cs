using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    private bool madeConnection = false;


    public Text roomName;
    public Text selected;
    private string room;

    private void Update()
    {
        //update room
        if (madeConnection)
        {
            if (NetworkManager.instance.room.connected && roomName.text != NetworkManager.instance.room.name)
            {
                roomName.text = NetworkManager.instance.room.name;
            }
        }
    }

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