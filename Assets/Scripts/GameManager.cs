using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int currentLevelIndex;
    public static GameManager singleton;


    void Awake()
    {
        if (singleton == null)
        {
            singleton = this;
        }

        else if (singleton != null)
        {
            Destroy(gameObject);
            DontDestroyOnLoad(gameObject);
        }

        PlayerPrefs.SetInt("CurrentLevelIndex", 0);
    }

    // Start is called before the first frame update
    void Start()
    {
        currentLevelIndex = PlayerPrefs.GetInt("CurrentLevelIndex");
    }

    // Update is called once per frame
    void Update()
    {
       
    }

   
}