using UnityEngine;
using Normal.Realtime;

public class NetworkManager : MonoBehaviour
{
    public static NetworkManager instance;
    private Realtime _realtime;
    public Room room;
    private bool isConnected = false;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            _realtime = GetComponent<Realtime>();
        }
        else if (instance != this)
        {
            Debug.Log("Instance already exists, destroying object!");
            Destroy(this);
        }
    }

    private void Start()
    {
        if (!isConnected)
        {
            room = new Room();
            isConnected = true;
        }
    }

    public void Connect(string _room)
    {
       instance._realtime.Connect(_room);
    }

    // instanced realtime public var
    public Realtime realtime => instance._realtime;

    public class Room
    {
        public bool connected =>  instance._realtime.room.connected;
        public int clientId => instance._realtime.room.clientID;
        public string name => instance._realtime.room.name;

    }






    // Update is called once per frame




}
