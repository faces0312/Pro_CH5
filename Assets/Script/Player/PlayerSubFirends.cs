using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerSubFirends : MonoBehaviour
{
    public GameObject subFirends1;
    public GameObject subFirends2;
    public GameObject subFirends3;
    public GameObject subFirends4;

    private void Start()
    {
        UpdateSubFirends();
    }

    public void UpdateSubFirends()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        if(currentSceneIndex == 0)
        {
            if (Data.Instance.gameData.subfirend1On == true)
                Instantiate(subFirends1, new Vector3(-1, 2.5f, 0), Quaternion.identity);
            if (Data.Instance.gameData.subfirend2On == true)
                Instantiate(subFirends2, new Vector3(1, 2.5f, 0), Quaternion.identity);
            if (Data.Instance.gameData.subfirend3On == true)
                Instantiate(subFirends3, new Vector3(-1, -1, 0), Quaternion.identity);
            if (Data.Instance.gameData.subfirend4On == true)
                Instantiate(subFirends4, new Vector3(1, -1, 0), Quaternion.identity);
        }
        else
        {
            if (Data.Instance.gameData.subfirend1On == true)
                Instantiate(subFirends1, new Vector3(-1, -3.5f, 0), Quaternion.identity);
            if (Data.Instance.gameData.subfirend2On == true)
                Instantiate(subFirends2, new Vector3(1, -3.5f, 0), Quaternion.identity);
            if (Data.Instance.gameData.subfirend3On == true)
                Instantiate(subFirends3, new Vector3(-2, -3.5f, 0), Quaternion.identity);
            if (Data.Instance.gameData.subfirend4On == true)
                Instantiate(subFirends4, new Vector3(2, -3.5f, 0), Quaternion.identity);
        }
        
    }
}
